using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using dataprocessor.Compilers;
using dataprocessor.Expressions;

namespace dataprocessor
{
    public class DataProcessorBuilder : IDataProcessorBuilder
    {
        [DebuggerDisplay("Name: {Description}")]
        private class NameInfo
        {
            public NameInfo(NameType desc) { Description = desc; }

            public readonly NameType Description;
            public WriterInfo Writer;
            public NodeInfo Input;
            public readonly List<NodeInfo> Outputs = new List<NodeInfo>();
        }

        private class NodeInfo
        {
            public NodeInfo(LambdaExpression expr, NameInfo[] inputs, NameInfo output)
            {
                Expr = expr;
                Inputs = inputs;
                Output = output;
            }

            public readonly NameInfo[] Inputs;
            public readonly NameInfo Output;
            public readonly LambdaExpression Expr;

            public HashSet<WriterInfo> TransitiveWriters;

            public string Name => Output?.Description.Name
                                  ?? string.Join(",", Inputs.Select(i => i.Description.Name));

            public override string ToString()
            {
                return string.Format(
                    "({0}) => {1}",
                    string.Join(", ", Inputs.Select(i => i.Description.Name)),
                    Output?.Description.Name ?? "-");
            }
        }

        [DebuggerDisplay("Writer: {Description}")]
        private class WriterInfo
        {
            public WriterInfo(string name, ICanSetAction writer, 
                              params ParameterExpression[] parameters)
            {
                Name = name;
                Writer = writer;
                Parameters = parameters;
            }

            public readonly string Name;
            public readonly ICanSetAction Writer;

            public readonly ParameterExpression[] Parameters;
            public readonly List<ParameterExpression> Variables = new List<ParameterExpression>();
            public readonly List<Expression> Expressions = new List<Expression>();

            public Expression GetPFor(NameInfo name)
            {
                Expression pp = Parameters.FirstOrDefault(p => p.Name == name.Description.Name);
                if (pp != null)
                    return pp;

                var v = Variables.First(p => p.Name == name.Description.Name);
                return Expression.Field(v, "Value");
            }

            public Expression GetIsPresentFor(NameInfo name)
            {
                Expression pp = Parameters.FirstOrDefault(p => p.Name == name.Description.Name);
                if (pp != null)
                    return Expression.Constant(true);

                var v = Variables.First(p => p.Name == name.Description.Name);
                return Expression.Field(v, "IsPresent");
            }
        }

        private interface ICanSetAction
        {
            Type ActionType { get; }
            void SetAction(Delegate action);
        }

        private class Writer<T> : dataprocessor.Writer<T>, ICanSetAction
        {
            public virtual Type ActionType => typeof(Action<T>);

            public virtual void SetAction(Delegate action)
            {
                if (action == null)
                    throw new ArgumentNullException(nameof(action));

                var a = (Action<T>)action;
                base.SetAction(a);
            }
        }

        private class NodeSetAction : ICanSetAction
        {
            private readonly object _node;
            private readonly Type _actionType;

            public NodeSetAction(object node, Type actionType)
            {
                _node = node;
                _actionType = actionType;
            }

            public Type ActionType => _actionType;

            public void SetAction(Delegate action)
            {
                var meth = _node.GetType().GetMethod("SetAction");
                meth.Invoke(_node, new[] { action });
            }
        }

        private int _state;
        private readonly Dictionary<string, NameInfo> _names = new Dictionary<string, NameInfo>();
        private readonly List<WriterInfo> _writers = new List<WriterInfo>();
        private readonly List<NodeInfo> _nodes = new List<NodeInfo>();
        private readonly ICompiler _compiler;

        public DataProcessorBuilder() : this(new DynamicMethodCompiler())
        {
        }

        public DataProcessorBuilder(ICompiler compiler)
        {
            if (compiler == null)
                throw new ArgumentNullException(nameof(compiler));
            _compiler = compiler;
        }

        public dataprocessor.Writer<T> AddInput<T>(string name)
        {
            if (_state != 0)
                throw new InvalidOperationException();
            if (name == null)
                throw new ArgumentException();

            var n = GetName(NameType.From<T>(name));

            if (n.Writer != null)
                throw new InvalidOperationException();

            var w = new Writer<T>();
            var wi = new WriterInfo(n.Description.Name, w, n.Description.AsParameter());
            _writers.Add(wi);
            n.Writer = wi;

            return w;
        }

        public void AddListener(LambdaExpression onRceiveAction, params NameType[] nameIn)
        {
            if (_state != 0)
                throw new Exception();
            if (onRceiveAction == null)
                throw new ArgumentException();
            if (nameIn == null)
                throw new ArgumentException();
            if (nameIn.Length != onRceiveAction.Parameters.Count())
                throw new Exception();
            if (nameIn.Length == 0)
                throw new ArgumentException();

            var ns = nameIn.Select(GetName).ToArray();
            var ni = new NodeInfo(onRceiveAction, ns, null);
            _nodes.Add(ni);

            foreach (var n in ns)
                n.Outputs.Add(ni);
        }

        public void AddProcessor(LambdaExpression processor, NameType nameOut, params NameType[] nameIn)
        {
            if (_state != 0)
                throw new Exception();
            if (nameIn == null)
                throw new ArgumentException();
            if (!nameOut.IsValid)
                throw new ArgumentException();
            if (processor == null)
                throw new ArgumentException();
            if (processor.ReturnType == typeof(void))
                throw new ArgumentException();
            if (nameIn.Length != processor.Parameters.Count())
                throw new Exception();
            if (nameIn.Length == 0)
                throw new ArgumentException();

            var maybeType = nameOut.Type.ToMaybe();
            if (processor.ReturnType != nameOut.Type && processor.ReturnType != maybeType)
                throw new ArgumentException();
            
            var nout = GetName(nameOut);

            // check that no parameters have multiple inputs
            if (nout.Writer != null)
                throw new InvalidOperationException();
            if (nout.Input != null)
                throw new InvalidOperationException();

            // lift return type to Maybe<> if required
            if (processor.ReturnType != maybeType)
            {
                processor = Expression.Lambda(
                    Expression.Call(
                        maybeType,
                        "Just",
                        null,
                        processor.Body),
                    processor.Parameters);
            }

            var ns = nameIn.Select(GetName).ToArray();
            var ni = new NodeInfo(processor, ns, nout);
            _nodes.Add(ni);

            nout.Input = ni;
            foreach (var n in ns)
                n.Outputs.Add(ni);
        }

        public IDataProcessor Build()
        {
            if (_state != 0)
                throw new Exception();
            _state = 1;

            using (Timer.Step("DataProcessorBuilder.Build"))
            {
                CompileToIntermediate();
                CompileToFinal();

                var cs = _writers.Select(w => w.Writer).OfType<IClosable>().ToArray();
                return new DataProcessor(cs);
            }
        }

        public IEnumerable<NameType> GetDefinedInputs()
        {
            if (_state != 0)
                throw new Exception();
            return _names.Values.Select(l => l.Description);
        }

        private NameInfo GetName(NameType desc)
        {
            if (!desc.IsValid)
                throw new ArgumentException();

            if (!_names.TryGetValue(desc.Name, out NameInfo name))
            {
                name = new NameInfo(desc);
                _names.Add(desc.Name, name);
            }
            else if (name.Description.Type != desc.Type)
            {
                throw new InvalidOperationException();
            }

            return name;
        }

        private void CompileToIntermediate()
        {
            var queue = SortDependenciesFirst(_nodes).ToList();

            // first time through, we want to find nodes that need splitting and fix 'em what for
            for (var ix = 0; ix < queue.Count; ix++)
            {
                var o = queue[ix];

                var needsSplit = DetermineTransitiveWritersFor(o).Count() > 1;

                if (needsSplit)
                {
                    var newNodes = SplitNode(o);

                    // update the queue
                    queue.RemoveAt(ix);
                    queue.InsertRange(ix, newNodes);

                    // reprime the current node
                    o = queue[ix];
                    DetermineTransitiveWritersFor(o);
                }

                var w = o.TransitiveWriters.SingleOrDefault();

                // no source writer, then nothing to do
                if (w == null)
                    continue;

                // attach the node's expressions to the writer
                if (o.Output == null)
                {
                    var ps = o.Inputs.Select(w.GetPFor);
                    var ifs = o.Inputs
                               .Select(w.GetIsPresentFor)
                               .Aggregate(Expression.AndAlso);
                    var e = Expression.IfThen(
                        ifs,
                        Expression.Invoke(o.Expr, ps));
                    w.Expressions.Add(e);
                }
                else
                {
                    var v = o.Output.Description.AsMaybeVariable();
                    var ps = o.Inputs.Select(w.GetPFor);
                    var ifs = o.Inputs
                               .Select(w.GetIsPresentFor)
                               .Aggregate(Expression.AndAlso);
                    var e = Expression.IfThen(
                        ifs,
                        Expression.Assign(v, Expression.Invoke(o.Expr, ps)));
                    w.Variables.Add(v);
                    w.Expressions.Add(e);
                }
            }
        }

        private IEnumerable<NodeInfo> SplitNode(NodeInfo o)
        {
            var nodeName = o.Name;
            Log($"Splitting: {nodeName}");

            // create "node" to hold state
            var types = o.Inputs.Select(i => i.Description.Type).ToArray();
            var delegateType = Node.GetActionTypeFor(types);
            var node = Node.GetNodeFor(types);

            var writer = new NodeSetAction(node, delegateType);
            var info = new WriterInfo(nodeName, writer, o.Expr.Parameters.ToArray());
            _writers.Add(info);

            var expr = o.Expr.Body;

            // modify action to return output to the tree
            if (o.Output != null)
            {
                o.Output.Input = null;
                o.Output.Writer = info;

                var v = o.Output.Description.AsMaybeVariable();
                info.Variables.Add(v);
                expr = Expression.Assign(v, o.Expr.Body);
            }

            info.Expressions.Add(expr);

            var results = new List<NodeInfo>();
            var inputIx = 0;
            foreach (var i in o.Inputs)
            {
                // remove old node from each of its inputs
                i.Outputs.Remove(o);

                // add the new "split" nodes instead
                inputIx++;
                var p = i.Description.AsParameter();
                var splitExpr = Expression.Lambda(
                    Expression.Call(
                        Expression.Constant(node),
                        "Set" + inputIx,
                        null,
                        p),
                    p);

                var nodeInfo = new NodeInfo(
                    splitExpr,
                    new[] { i },
                    null);

                i.Outputs.Add(nodeInfo);
                results.Add(nodeInfo);
            }

            return results;
        }

        private void CompileToFinal()
        {
            foreach (var w in _writers)
            {
                w.Expressions.Add(Expression.Empty());

                var expr = Expression.Lambda(
                    w.Writer.ActionType,
                    Expression.Block(
                        typeof(void),
                        w.Variables,
                        w.Expressions),
                    w.Parameters);

                expr = expr.EnsureReturnTypeIsVoid();
                expr = OptimiseAndLog(w.Name, expr);

                var action = _compiler.Compile(w.Name, expr);
                w.Writer.SetAction(action);
            }
        }

        private ICollection<WriterInfo> DetermineTransitiveWritersFor(NodeInfo n)
        {
            if (n.TransitiveWriters != null)
                return n.TransitiveWriters;

            var ws = new HashSet<WriterInfo>();

            foreach (var i in n.Inputs)
            {
                if (i.Input != null)
                {
                    foreach (var w in DetermineTransitiveWritersFor(i.Input))
                        ws.Add(w);
                }
                if (i.Writer != null)
                {
                    ws.Add(i.Writer);
                }
            }

            n.TransitiveWriters = ws;
            return ws;
        }

        private IEnumerable<NodeInfo> SortDependenciesFirst(IEnumerable<NodeInfo> nodes)
        {
            var todo = nodes.ToList();
            var trunks = new Queue<NodeInfo>(todo.Where(n => n.Output == null));
            var reverseResult = new List<NodeInfo>(todo.Count);
            var seen = new HashSet<NodeInfo>(todo);

            while (trunks.Any())
            {
                var ni = trunks.Dequeue();

                if (!seen.Add(ni))
                    reverseResult.Remove(ni);

                reverseResult.Add(ni);

                foreach (var dep in ni.Inputs)
                    if (dep.Input != null)
                        trunks.Enqueue(dep.Input);
            }

            var missed = todo.Except(seen).FirstOrDefault();
            if (missed != null)
                throw new InvalidOperationException($"Processor '{missed}' cannot be satisfied.");

            reverseResult.Reverse();

            Log($"SortDependenciesFirst: {string.Join(", ", reverseResult)}");
            return reverseResult;
        }

        private static TLambda OptimiseAndLog<TLambda>(string name, TLambda expr)
            where TLambda : LambdaExpression
        {
            expr = InlineLambdaInvocations.Visit(expr);
            expr = ImproveDelegateInvocations.Apply(expr);
            expr = new UnwrapConstantJusts().VisitAndConvert(expr, name);

            try
            {
                Log($"OptimiseAndLog: {name} => {expr.GetDebugString()}");
            }
            catch 
            {
                Log($"OptimiseAndLog: {name} => eeeek.");
            }

            return expr;
        }

        private static void Log(string value)
        {
#if DEBUG
            Console.WriteLine(value);
#endif
        }
    }
}
