using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace dataprocessor
{
    public class DataProcessorBuilder : IDataProcessorBuilder
    {
        [System.Diagnostics.DebuggerDisplay("Name: {Description}")]
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

            public override string ToString()
            {
                return string.Format(
                    "({0}) => {1}",
                    string.Join(", ", Inputs.Select(i => i.Description.Name)),
                    Output?.Description.Name ?? "-");
            }
        }

        [System.Diagnostics.DebuggerDisplay("Writer: {Description}")]
        private class WriterInfo
        {
            public WriterInfo(NameType description, WriterBase writer)
            {
                Description = description;
                Writer = writer;
                Parameter = description.AsParameter();
            }

            public readonly NameType Description;
            public readonly WriterBase Writer;

            public readonly ParameterExpression Parameter;
            public readonly List<ParameterExpression> Variables = new List<ParameterExpression>();
            public readonly List<Expression> Expressions = new List<Expression>();

            public ParameterExpression GetPFor(NameInfo name)
            {
                if (name.Description.Name == Parameter.Name)
                    return Parameter;
                return Variables.First(p => p.Name == name.Description.Name);
            }
        }

        private interface WriterBase
        {
            Type ActionType { get; }
            void SetAction(Delegate action);
        }

        private class Writer<T> : dataprocessor.Writer<T>, WriterBase
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

        private int _state;
        private readonly Dictionary<string, NameInfo> _names = new Dictionary<string, NameInfo>();
        private readonly List<WriterInfo> _writers = new List<WriterInfo>();
        private readonly List<NodeInfo> _nodes = new List<NodeInfo>();

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
            var wi = new WriterInfo(n.Description, w);
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
            if (processor == null)
                throw new ArgumentException();
            if (processor.ReturnType == typeof(void))
                throw new ArgumentException();
            if (nameIn.Length != processor.Parameters.Count())
                throw new Exception();
            if (nameIn.Length == 0)
                throw new ArgumentException();

            var nout = GetName(nameOut);

            // check that no parameters have multipl inputs
            if (nout.Writer != null)
                throw new InvalidOperationException();
            if (nout.Input != null)
                throw new InvalidOperationException();

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

            CompileToIntermediate();
            CompileToFinal();

            var cs = _writers.Select(w => (IClosable)w.Writer).ToArray();
            return new DataProcessor(cs);
        }

        public IEnumerable<NameType> GetDefinedInputs()
        {
            if (_state != 0)
                throw new Exception();
            return _names.Values.Select(l => l.Description);
        }

        private NameInfo GetName(NameType desc)
        {
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

                // do we need to split???
                var needsSplit = DetermineTransitiveWritersFor(o).Count() > 1;

                if (needsSplit)
                {
                    var nodeName = o.Output?.Description.Name
                                   ?? string.Join(",", o.Inputs.Select(i => i.Description.Name));
                    Log($"Splitting: {nodeName}");

                    // 1. create "node" to track state
                    LambdaExpression expr = o.Expr;
                    var types = o.Inputs.Select(i => i.Description.Type).ToArray();
                    var delegateType = Node.GetActionTypeFor(types);

                    if (o.Output != null)
                    {
                        var writerType = typeof(Writer<>).MakeGenericType(new[] { o.Output.Description.Type });
                        var writer = (WriterBase)Activator.CreateInstance(writerType);
                        o.Output.Input = null;
                        o.Output.Writer = new WriterInfo(o.Output.Description, writer);
                        _writers.Add(o.Output.Writer);

                        var v = o.Output.Description.AsVariable();
                        expr = Expression.Lambda(
                            delegateType,
                            Expression.Block(
                                new[] { v },
                                Expression.Assign(v, o.Expr.Body),
                                Expression.Call(
                                    Expression.Constant(writer),
                                    "Send",
                                    null,
                                    v)),
                            o.Expr.Parameters);
                    }

                    expr = expr.EnsureReturnTypeIsVoid();
                    var action = OptimiseAndLog(nodeName, expr).Compile();
                    var node = Node.GetNodeFor(types, action);

                    var inputIx = 0;
                    foreach (var i in o.Inputs)
                    {
                        // 2. remove from each of its inputs
                        i.Outputs.Remove(o);

                        // 3. add the new "split" nodes instead
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
                        queue.Insert(ix + inputIx, nodeInfo);
                    }

                    // 4. remove the old unsplit node
                    queue.RemoveAt(ix);
                    o = queue[ix];
                    DetermineTransitiveWritersFor(o);
                }

                // after any splitting, we can get on with the good stuff
                var w = o.TransitiveWriters.SingleOrDefault();

                if (w == null)
                    continue;

                if (o.Output == null)
                {
                    var ps = o.Inputs.Select(w.GetPFor);
                    var e = Expression.Invoke(o.Expr, ps);
                    w.Expressions.Add(e);
                }
                else
                {
                    var v = o.Output.Description.AsVariable();
                    var ps = o.Inputs.Select(w.GetPFor);
                    var e = Expression.Assign(v, Expression.Invoke(o.Expr, ps));
                    w.Variables.Add(v);
                    w.Expressions.Add(e);
                }
            }
        }

        private void CompileToFinal()
        {
            foreach (var w in _writers)
            {
                var expr = Expression.Lambda(
                    w.Writer.ActionType,
                    Expression.Block(
                        w.Variables,
                        w.Expressions),
                    w.Parameter);

                expr = expr.EnsureReturnTypeIsVoid();
                expr = OptimiseAndLog(w.Description.Name, expr);

                var action = expr.Compile();
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
            //expr = RemoveRedundantCasts.Visit(expr);

#if DEBUG
            try
            {
                Log($"OptimiseAndLog: {name} => {expr.GetDebugString()}");
            }
#pragma warning disable RECS0022 // A catch clause that catches System.Exception and has an empty body
            catch { }
#pragma warning restore RECS0022 // A catch clause that catches System.Exception and has an empty body
#endif
            return expr;
        }

        private static void Log(string value)
        {
            Console.WriteLine(value);
        }
    }
}
