using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace dataprocessor
{
    public class Draft2DataProcessor : IDataProcessorBuilder, IDataProcessor
    {
        private class Listener
        {
            public Listener(NameType desc) { Description = desc; }

            public NameType Description { get; }

            public readonly List<LambdaExpression> Recipients = new List<LambdaExpression>();
            private bool hasWriter;

            public void AddRecipient(LambdaExpression action)
            {
                Recipients.Add(action);
            }

            public void AssertFirstWriter()
            {
                if (hasWriter)
                    throw new InvalidOperationException();
                hasWriter = true;
            }
        }

        private abstract class WriterBase
        {
            public abstract void Compile();   
        }

        private class Writer<T> : WriterBase, IWriter<T>
        {
            private readonly Draft2DataProcessor _dp;
            private readonly Listener _listener;
            private Action<T> _action;

            public Writer(Draft2DataProcessor dp, Listener listener)
            {
                _dp = dp;
                _listener = listener;
            }

            public override void Compile()
            {
                var p = Expression.Parameter(typeof(T), _listener.Description.Name + "_listener");

                var expr = Expression.Lambda<Action<T>>(
                    Expression.Block(
                        _listener.Recipients.Select(
                            r => Expression.Invoke(r, p))),
                    p);
                
                //expr = InlineLambdaInvocations.Visit(expr);
                //expr = RemoveRedundantCasts.Visit(expr);

#if DEBUG
                try
                {
                    Console.Out.WriteLine(
                        "{0} => {1}",
                        string.Join(", ", _listener.Description.Name),
                        expr.GetDebugString());
                }
                catch {}
#endif

                _action = expr.Compile();
            }

            public void Send(T value)
            {
                if (_dp._state == 0)
                    throw new InvalidOperationException();
                if (_dp._state == 2)
                    return;

                _action(value);
            }
        }

        private int _state = 0;
        private readonly Dictionary<string, Listener> _listeners = new Dictionary<string, Listener>();
        private readonly List<WriterBase> _writers = new List<WriterBase>();

        public IWriter<T> AddInput<T>(string name)
        {
            if (_state != 0)
                throw new InvalidOperationException();
            if (name == null)
                throw new ArgumentException();

            var l = GetListener(NameType.From<T>(name));
            l.AssertFirstWriter();

            var w = new Writer<T>(this, l);
            _writers.Add(w);

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

            if (nin.Length > 1)
            {
                var stateParameterTypes = onRceiveAction.Parameters.Select(p => p.Type).ToArray();
                var state = State.GetStateFor(stateParameterTypes);

                for (var ix = 0; ix < nin.Length; ix++)
                {
                    var ix2 = ix + 1;
                    var l = GetListener(new NameType(nin[ix], onRceiveAction.Parameters[ix].Type));

                    var s = Expression.Constant(state);
                    var fs = Enumerable
                        .Range(1, nin.Length)
                        .Select(i => Expression.Property(s, "P" + i))
                        .ToArray();
                    var p = Expression.Parameter(l.Description.Type, l.Description.Name);

                    var expr = Expression.Lambda(
                        Expression.IfThen(
                            Expression.Call(s, "Set" + ix2, null, p),
                            Expression.Block(
                                Expression.Call(s, "Reset", null),
                                Expression.Invoke(onRceiveAction, fs))),
                        p);
                    l.AddRecipient(expr);
                }
            }
            else
            {
                var l = GetListener(new NameType(nin[0], onRceiveAction.Parameters[0].Type));
                l.AddRecipient(onRceiveAction);
            }
        }

        private Listener GetListener(NameType desc)
        {
            Listener listener;

            if (!_listeners.TryGetValue(desc.Name, out listener))
            {
                listener = new Listener(desc);
                _listeners.Add(desc.Name, listener);
            }
            else if (listener.Description.Type != desc.Type)
            {
                throw new InvalidOperationException();
            }

            return listener;
        }

        public IDataProcessor Build()
        {
            if (_state != 0)
                throw new Exception();
            _state = 1;

            foreach (var w in _writers)
                w.Compile();

            return this;
        }

        public IEnumerable<NameType> GetDefinedInputs()
        {
            if (_state != 0)
                throw new Exception();
            return _listeners.Values.Select(l => l.Description);
        }

        public void AddProcessor(IEnumerable<string> nameIn, string nameOut, LambdaExpression processor)
        {
            if (_state != 0)
                throw new Exception();

            var getW = Expression
                .Lambda<Func<WriterBase>>(
                    Expression.Convert(
                        Expression.Call(
                            Expression.Constant(this),
                            "AddInput",
                            new[] { processor.ReturnType },
                            Expression.Constant(nameOut)),
                        typeof(WriterBase)))
                .Compile();
            
            var w = getW();

            var parameters = processor.Parameters;
            var ww = Expression.Constant(w);

            var expr = Expression.Lambda(
                Expression.Call(
                    ww,
                    "Send",
                    null,
                    processor.Body),
                parameters);

            AddListener(nameIn, expr);
        }

        void IDataProcessor.Close() { _state = 2; }

        void IDisposable.Dispose() { _state = 2; }
    }
}
