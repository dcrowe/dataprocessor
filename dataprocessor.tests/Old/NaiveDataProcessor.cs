using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace dataprocessor
{
    public class NaiveDataProcessor : IDataProcessorBuilder, IDataProcessor
    {
        private class Listener
        {
            public Listener(NameType desc) { Description = desc; }

            public NameType Description { get; }

            private List<Action<object>> _recipients = new List<Action<object>>();
            private bool hasWriter = false;

            public void Call(object value)
            {
                foreach (var r in _recipients)
                    r(value);
            }

            public void AddRecipient<T>(Action<T> action)
            {
                _recipients.Add(v => action((T)v));
            }

            public void AssertFirstWriter()
            {
                if (hasWriter)
                    throw new InvalidOperationException();
                hasWriter = true;
            }
        }

        private class Writer<T> : IWriter<T>
        {
            private readonly Listener _listener;
            readonly NaiveDataProcessor _dp;

            public Writer(NaiveDataProcessor dp, Listener listener)
            {
                _dp = dp;
                _listener = listener;
                SetAction(v => listener.Call(v));
            }
        }

        private class ProcessorState
        {
            private readonly int _count;
            private readonly Action<object[]> _action;
            private object[] _state;
            private bool[] _filled;
            private int _remaining;

            public ProcessorState(int count, Action<object[]> action)
            {
                _count = count;
                _action = action;
                Reset();
            }

            void Reset()
            {
                _state = new object[_count];
                _filled = new bool[_count];
                _remaining = _count;
            }

            public void Received(int ix, object value)
            {
                var wasFilled = _filled[ix];

                _state[ix] = value;
                _filled[ix] = true;

                if (!wasFilled)
                {
                    _remaining--;
                    if (_remaining == 0)
                    {
                        _action(_state);
                        Reset();
                    }
                }
            }
        }

        private int _state = 0;
        private readonly Dictionary<string, Listener> _listeners = new Dictionary<string, Listener>();

        public IWriter<T> AddInput<T>(string name)
        {
            if (_state != 0)
                throw new InvalidOperationException();
            if (name == null)
                throw new ArgumentException();


            var l = GetListener(NameType.From<T>(name));
            l.AssertFirstWriter();

            return new Writer<T>(this, l);
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

            var func = onRceiveAction.Compile();
            Action<object[]> resultAction = vs => func.DynamicInvoke(vs);
            var state = new ProcessorState(nin.Length, resultAction);

            for (var ix = 0; ix < nin.Length; ix++)
            {
                var ix2 = ix;
                var l = GetListener(new NameType(nin[ix], onRceiveAction.Parameters[ix].Type));
                l.AddRecipient<object>(v =>
                {
                    state.Received(ix2, v);
                });
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

            var func = processor.Compile();
            var resultListener = GetListener(new NameType(nameOut, processor.ReturnType));
            var parameters = processor.Parameters;

            var resultAction = Expression.Lambda(
                Expression.Call(
                    Expression.Constant(resultListener),
                    "Call",
                    null,
                    Expression.Convert(
                        processor.Body,
                        typeof(object))),
                parameters);
            
            AddListener(nameIn, resultAction);
        }

        void IDataProcessor.Close() { _state = 2; }

        void IDisposable.Dispose() { _state = 2; }
    }
}
