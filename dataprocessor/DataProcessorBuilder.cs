using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace dataprocessor
{
    public class DataProcessorBuilder : IDataProcessorBuilder, IDataProcessor
    {
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

        private class WriterInfo
        {
            public WriterInfo(NameType description, WriterBase writer)
            {
                Description = description;
                Writer = writer;
                Parameter = Expression.Parameter(description.Type, description.Name);
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
            void Close();
        }

        private class W<T> : Writer<T>, WriterBase
        {
            public virtual Type ActionType => typeof(Action<T>);
            public virtual void Close() => base.SetAction(null);

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

        public Writer<T> AddInput<T>(string name)
        {
            if (_state != 0)
                throw new InvalidOperationException();
            if (name == null)
                throw new ArgumentException();

            var n = GetName(NameType.From<T>(name));

            if (n.Writer != null)
                throw new InvalidOperationException();

            var w = new W<T>();
            var wi = new WriterInfo(n.Description, w);
            _writers.Add(wi);
            n.Writer = wi;

            return w;
        }

        public void AddListener(IEnumerable<string> nameIn, LambdaExpression onRceiveAction)
        {
            if (_state != 0)
                throw new Exception();
            if (onRceiveAction == null)
                throw new ArgumentException();
            if (nameIn == null)
                throw new ArgumentException();

            var nin = nameIn.ToArray();

            if (nin.Length != onRceiveAction.Parameters.Count())
                throw new Exception();
            if (nin.Length == 0)
                throw new ArgumentException();

            var ns = Enumerable.Range(0, nin.Length)
                               .Select(ix => new NameType(nin[ix], onRceiveAction.Parameters[ix].Type))
                               .Select(GetName)
                               .ToArray();

            var ni = new NodeInfo(onRceiveAction, ns, null);
            _nodes.Add(ni);

            foreach (var n in ns)
                n.Outputs.Add(ni);
        }

        public void AddProcessor(IEnumerable<string> nameIn, string nameOut, LambdaExpression processor)
        {
            if (_state != 0)
                throw new Exception();
            if (nameOut == null)
                throw new ArgumentException();
            if (nameIn == null)
                throw new ArgumentException();
            if (processor == null)
                throw new ArgumentException();
            if (processor.ReturnType == typeof(void))
                throw new ArgumentException();

            var nin = nameIn.ToArray();

            if (nin.Length != processor.Parameters.Count())
                throw new Exception();
            if (nin.Length == 0)
                throw new ArgumentException();

            var nout = GetName(new NameType(nameOut, processor.ReturnType));

            // check that no parameters have multipl inputs
            if (nout.Writer != null)
                throw new InvalidOperationException();
            if (nout.Input != null)
                throw new InvalidOperationException();

            var ns = Enumerable.Range(0, nin.Length)
                               .Select(ix => new NameType(nin[ix], processor.Parameters[ix].Type))
                               .Select(GetName)
                               .ToArray();

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

            return this;
        }

        public IEnumerable<NameType> GetDefinedInputs()
        {
            if (_state != 0)
                throw new Exception();
            return _names.Values.Select(l => l.Description);
        }

        void IDataProcessor.Close()
        {
            _state = 2;

            foreach (var w in _writers)
                w.Writer.Close();
        }

        void IDisposable.Dispose() { ((IDataProcessor)this).Close(); }

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

            // check that all parameters are satisfiable
            //if (name.Input == null && name.Writer == null)
            //    throw new InvalidOperationException($"Parameter '{name.Description.Name}' does not have an input.");

            // first time through, we want to find nodes that need splitting and fix 'em what for
            for (var ix = 0; ix < queue.Count; ix++)
            {
                var o = queue[ix];

                // do we need to split???
                var needsSplit = DetermineTransitiveWritersFor(o).Count() > 1;

                if (needsSplit)
                {
                    // 1. create "node" to track state
                    LambdaExpression expr;
                    string nodeName;
                    var types = o.Inputs.Select(i => i.Description.Type).ToArray();
                    var delegateType = Node.GetActionTypeFor(types);

                    if (o.Output == null)
                    {
                        nodeName = string.Join(",", o.Inputs.Select(i => i.Description.Name));
                        expr = o.Expr;
                    }
                    else
                    {
                        nodeName = o.Output.Description.Name;

                        var writerType = typeof(W<>).MakeGenericType(new[] { o.Output.Description.Type });
                        var writer = (WriterBase)Activator.CreateInstance(writerType);
                        o.Output.Input = null;
                        o.Output.Writer = new WriterInfo(o.Output.Description, writer);
                        _writers.Add(o.Output.Writer);

                        expr = Expression.Lambda(
                            delegateType,
                            Expression.Call(
                                Expression.Constant(writer),
                                "Send",
                                null,
                                o.Expr.Body),
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
                        var p = Expression.Parameter(i.Description.Type, i.Description.Name);
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
                    var v = Expression.Variable(o.Output.Description.Type, o.Output.Description.Name);
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

        private IEnumerable<NameInfo> SortDependenciesFirst(IEnumerable<NameInfo> names)
        {
            var todo = names.ToList();
            var trunks = new Queue<NameInfo>(todo.Where(n => !n.Outputs.Any(o => o.Output != null)));
            var reverseResult = new List<NameInfo>(todo.Count);
            var seen = new HashSet<NameInfo>(todo);

            while (trunks.Any())
            {
                var ni = trunks.Dequeue();

                if (!seen.Add(ni))
                    reverseResult.Remove(ni);

                reverseResult.Add(ni);

                if (ni.Input != null)
                    foreach (var dep in ni.Input.Inputs)
                        trunks.Enqueue(dep);
            }

            var missed = todo.Except(seen).FirstOrDefault();
            if (missed != null)
                throw new InvalidOperationException($"Parameter '{missed.Description.Name}' does not have an input.");

            reverseResult.Reverse();

            Console.Out.WriteLine("SortDependenciesFirst : " + string.Join(", ", reverseResult.Select(n => n.Description.Name)));

            return reverseResult;
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

            Console.Out.WriteLine("SortDependenciesFirst : " + string.Join(", ", reverseResult));

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
                Console.Out.WriteLine(
                    "After: {0} => {1}",
                    string.Join(", ", name),
                    expr.GetDebugString());
            }
            catch { }
#endif
            return expr;
        }
    }
}
