using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using dataprocessor.Collation;
using dataprocessor.Compilers;
using dataprocessor.Expressions;

namespace dataprocessor
{
    public class DataProcessorBuilder : IDataProcessorBuilder
    {
        private int _state;
        private readonly Dictionary<string, NameInfo> _names = new Dictionary<string, NameInfo>();
        private readonly List<WriterInfo> _writers = new List<WriterInfo>();
        private readonly List<ProcessorInfo> _nodes = new List<ProcessorInfo>();
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

        public Writer<T> AddInput<T>(string name)
        {
            if (_state != 0)
                throw new InvalidOperationException();
            if (name == null)
                throw new ArgumentException();

            var n = Get(NameType.From<T>(name));

            if (n.SourceWriter != null)
                throw new InvalidOperationException();

            var w = new WriterSetAction<T>();
            var wi = new WriterInfo(name, w, n);
            _writers.Add(wi);
            n.SourceWriter = wi;

            return w;
        }

        public void AddListener(LambdaExpression listener, params NameType[] nameIn)
        {
            if (_state != 0)
                throw new InvalidOperationException();
            if (listener == null)
                throw new ArgumentNullException();
            if (nameIn == null)
                throw new ArgumentNullException();
            if (nameIn.Length != listener.Parameters.Count())
                throw new ArgumentException();
            if (nameIn.Length == 0)
                throw new ArgumentException();

            var ns = nameIn.Select(Get).ToArray();
            var ni = new ProcessorInfo(listener, ns, null);
            _nodes.Add(ni);

            foreach (var n in ns)
                n.Consumers.Add(ni);
        }

        public void AddProcessor(LambdaExpression processor, NameType nameOut, params NameType[] nameIn)
        {
            if (_state != 0)
                throw new InvalidOperationException();
            if (nameIn == null)
                throw new ArgumentNullException();
            if (!nameOut.IsValid)
                throw new ArgumentException();
            if (processor == null)
                throw new ArgumentNullException();
            if (processor.ReturnType == typeof(void))
                throw new ArgumentException();
            if (nameIn.Length != processor.Parameters.Count())
                throw new ArgumentException();
            if (nameIn.Length == 0)
                throw new ArgumentException();

            var maybeType = nameOut.Type.ToMaybe();
            if (processor.ReturnType != nameOut.Type && processor.ReturnType != maybeType)
                throw new ArgumentException();

            var nout = Get(nameOut);

            // check that no parameters have multiple inputs
            if (nout.SourceWriter != null)
                throw new InvalidOperationException();
            if (nout.SourceProcessor != null)
                throw new InvalidOperationException();

            var ns = nameIn.Select(Get).ToArray();
            var ni = new ProcessorInfo(processor, ns, nout);
            _nodes.Add(ni);

            nout.SourceProcessor = ni;
            foreach (var n in ns)
                n.Consumers.Add(ni);
        }

        public IDataProcessor Build()
        {
            if (_state != 0)
                throw new InvalidOperationException();
            _state = 1;

            using (Timer.Step("DataProcessorBuilder.Build"))
            {
                // flatten tree into list where dependants come later
                var queue = ProcessorInfo.SortDependenciesFirst(_nodes);

                // loop through processors, adding them to their source writers
                for (var ix = 0; ix < queue.Count; ix++)
                {
                    var o = queue[ix];

                    var needsSplit = o.GetSourceWriters().Count() > 1;

                    // if the processor needs data from multiple writers,
                    // then insert an intermediate node to store the state
                    if (needsSplit)
                    {
                        var newNodes = o.Split(out WriterInfo newWriter);
                        _writers.Add(newWriter);

                        // update the queue
                        queue.RemoveAt(ix);
                        queue.InsertRange(ix, newNodes);

                        // reprime the current node
                        o = queue[ix];
                    }

                    var w = o.GetSourceWriters().SingleOrDefault();

                    // no source writer, then nothing to do
                    if (w == null)
                        continue;

                    // add it to the writer
                    w.Append(o);
                }

                // loop through the writers, compiling each one
                foreach (var w in _writers)
                {
                    var expr = w.GetFinalLambda();
                    Logger.WriteLine(w.Name, expr);

                    var action = _compiler.Compile(w.Name, expr);
                    w.Writer.SetAction(action);
                }

                // return the data processor
                var cs = _writers.Select(w => w.Writer)
                                 .OfType<IClosable>()
                                 .ToArray();
                return new DataProcessor(cs);
            }
        }

        public IEnumerable<NameType> GetAllNames()
        {
            if (_state != 0)
                throw new InvalidOperationException();
            return _names.Values.Select(l => l.Description);
        }

        public NameType GetName(string name)
        {
            if (_state != 0)
                throw new InvalidOperationException();
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            if (_names.TryGetValue(name, out NameInfo ni))
                return ni.Description;

            return NameType.Empty;
        }

        private NameInfo Get(NameType desc)
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
    }
}