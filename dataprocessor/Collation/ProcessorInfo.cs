using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;

namespace dataprocessor.Collation
{
    [DebuggerDisplay("Processor: {DebugDescription}")]
    public class ProcessorInfo
    {
        private HashSet<WriterInfo> _transitiveWriters;

        public ProcessorInfo(LambdaExpression expr, NameInfo[] inputs, NameInfo output)
        {
            if (expr == null)
                throw new ArgumentNullException(nameof(expr));
            if (inputs == null)
                throw new ArgumentNullException(nameof(inputs));
            Expr = expr;
            Inputs = inputs;
            Output = output;
        }

        public NameInfo[] Inputs { get; }
        public NameInfo Output { get; }
        public LambdaExpression Expr { get; }

        public string Name => Output?.Description.Name
                              ?? string.Join(",", Inputs.Select(i => i.Description.Name));

        internal string DebugDescription => string.Format(
            "({0}) => {1}",
            string.Join(", ", Inputs.Select(i => i.Description.Name)),
            Output?.Description.Name ?? "-");

        public ICollection<WriterInfo> GetSourceWriters()
        {
            if (_transitiveWriters != null)
                return _transitiveWriters;

            var ws = new HashSet<WriterInfo>();

            foreach (var i in Inputs)
            {
                if (i.SourceProcessor != null)
                {
                    foreach (var w in i.SourceProcessor.GetSourceWriters())
                        ws.Add(w);
                }
                if (i.SourceWriter != null)
                {
                    ws.Add(i.SourceWriter);
                }
            }

            _transitiveWriters = ws;
            return ws;
        }

        public static List<ProcessorInfo> SortDependenciesFirst(IEnumerable<ProcessorInfo> nodes)
        {
            if (nodes == null)
                throw new ArgumentNullException(nameof(nodes));
            
            var todo = nodes.ToList();
            var trunks = new Queue<ProcessorInfo>(todo.Where(n =>
                 n.Output == null || !n.Output.Consumers.Any()));
            var reverseResult = new List<ProcessorInfo>(todo.Count);
            var seen = new HashSet<ProcessorInfo>(todo);

            while (trunks.Any())
            {
                var ni = trunks.Dequeue();

                if (!seen.Add(ni))
                    reverseResult.Remove(ni);

                reverseResult.Add(ni);

                foreach (var dep in ni.Inputs)
                    if (dep.SourceProcessor != null)
                        trunks.Enqueue(dep.SourceProcessor);
            }

            var missed = todo.Except(reverseResult).FirstOrDefault();
            if (missed != null)
                throw new InvalidOperationException($"Processor '{missed.Name}' cannot be satisfied.");

            reverseResult.Reverse();

            if (Log.IsVerbose)
                Log.Verbose($"In Dependency Order: {string.Join(", ", reverseResult)}");
            
            return reverseResult;
        }

        public IEnumerable<ProcessorInfo> Split(out WriterInfo info)
        {
            Log.Verbose($"Splitting: {Name}");

            // create node to hold state
            var types = Inputs.Select(i => i.Description.Type).ToArray();
            var delegateType = Node.GetActionTypeFor(types);
            var node = Node.GetNodeFor(types);

            var writer = new NodeSetAction(node, delegateType);
            info = new WriterInfo(Name, writer, Inputs);

            // modify action to return output to the tree
            if (Output != null)
            {
                Output.SourceProcessor = null;
                Output.SourceWriter = info;
            }

            info.Append(this);

            var results = new List<ProcessorInfo>();
            foreach (var i in Inputs)
            {
                // remove old node from each of its inputs
                i.Consumers.Remove(this);

                // add the new "split" nodes instead
                var p = Expression.Parameter(
                    i.Description.Type,
                    i.Description.Name);
                var e = Expression.Lambda(
                    Expression.Call(
                        Expression.Constant(node),
                        "Set" + (results.Count + 1),
                        null,
                        p),
                    p);

                var nodeInfo = new ProcessorInfo(e, new[] { i }, null);
                i.Consumers.Add(nodeInfo);
                results.Add(nodeInfo);
            }

            return results;
        }
    }
}