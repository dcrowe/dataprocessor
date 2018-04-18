using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace dataprocessor.Old
{
    internal class NaiveDataProcessor : IDataProcessorBuilder, IDataProcessor
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

        private class W<T> : Writer<T>
        {
            private readonly Listener _listener;
            readonly NaiveDataProcessor _dp;

            public W(NaiveDataProcessor dp, Listener listener)
            {
                _dp = dp;
                _listener = listener;
                SetAction(v =>
                {
                    if (_dp._state == 0)
                        throw new InvalidOperationException();
                    if (_dp._state == 2)
                        throw new InvalidOperationException();
                    listener.Call(v);
                });
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

        public Writer<T> AddInput<T>(string name)
        {
            if (_state != 0)
                throw new InvalidOperationException();
            if (name == null)
                throw new ArgumentException();
            
            var l = GetListener(NameType.From<T>(name));
            l.AssertFirstWriter();

            return new W<T>(this, l);
        }

        public void AddListener(LambdaExpression onRceiveAction, params NameType[] nameIn)
        {
            if (_state != 0)
                throw new InvalidOperationException();
            if (onRceiveAction == null)
                throw new ArgumentNullException();
            if (nameIn == null)
                throw new ArgumentNullException();
            if (nameIn.Length != onRceiveAction.Parameters.Count() || nameIn.Length == 0)
                throw new ArgumentException();

            var func = onRceiveAction.Compile();
            Action<object[]> resultAction = vs => func.DynamicInvoke(vs);
            var state = new ProcessorState(nameIn.Length, resultAction);

            for (var ix = 0; ix < nameIn.Length; ix++)
            {
                var ix2 = ix;
                var l = GetListener(nameIn[ix]);
                l.AddRecipient<object>(v =>
                {
                    state.Received(ix2, v);
                });
            }
        }

        private Listener GetListener(NameType desc)
        {
            if (!desc.IsValid)
                throw new ArgumentException();

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
                throw new InvalidOperationException();
            _state = 1;
            return this;
        }

        public IEnumerable<NameType> GetAllNames()
        {
            if (_state != 0)
                throw new InvalidOperationException();
            return _listeners.Values.Select(l => l.Description);
        }

        public NameType GetName(string name)
        {
            if (_state != 0)
                throw new InvalidOperationException();
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            Listener l;
            if (_listeners.TryGetValue(name, out l))
                return l.Description;

            return NameType.Empty;
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

            var resultListener = GetListener(nameOut);
            var parameters = processor.Parameters;

            var maybeType = typeof(Maybe<>).MakeGenericType(nameOut.Type);
            var body = processor.Body;

            if (processor.ReturnType != maybeType && processor.ReturnType != nameOut.Type)
                throw new ArgumentException();

            resultListener.AssertFirstWriter();

            var isMaybe = processor.ReturnType == maybeType;
            if (isMaybe)
            {
                var v = Expression.Variable(maybeType, nameOut.Name);
                var resultAction = Expression.Lambda(
                    Expression.Block(
                        new[] { v },
                        Expression.Assign(v, processor.Body),
                        Expression.IfThen(
                            Expression.Field(v, "IsPresent"),
                            Expression.Call(
                                Expression.Constant(resultListener),
                                "Call",
                                null,
                                Expression.Convert(
                                    Expression.Field(processor.Body, "Value"), 
                                    typeof(object))))),
                    parameters);

                AddListener(resultAction, nameIn); 
            }
            else
            {
                var resultAction = Expression.Lambda(
                    Expression.Call(
                        Expression.Constant(resultListener),
                        "Call",
                        null,
                        Expression.Convert(
                            processor.Body,
                            typeof(object))),
                    parameters);

                AddListener(resultAction, nameIn);   
            }
        }

        void IDataProcessor.Close() { _state = 2; }

        void IDisposable.Dispose() { _state = 2; }
    }
}
