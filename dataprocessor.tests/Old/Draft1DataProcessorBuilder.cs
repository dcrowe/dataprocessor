﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace dataprocessor
{
    public class Draft1DataProcessor : IDataProcessorBuilder, IDataProcessor
    {
        private class Listener
        {
            public Listener(NameType desc) { Description = desc; }

            public NameType Description { get; }

            public readonly List<LambdaExpression> Recipients = new List<LambdaExpression>();
            private bool hasWriter = false;

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

        private interface WriterBase 
        {
            void Compile();
        }

        private class W<T> : Writer<T>, WriterBase
        {
            private readonly Listener _listener;
            readonly Draft1DataProcessor _dp;
            private Action<T> _action;

            public W(Draft1DataProcessor dp, Listener listener)
            {
                _dp = dp;
                _listener = listener;
            }

            public virtual void Compile()
            {
                var p = Expression.Parameter(typeof(T), _listener.Description.Name + "_listener");
                var expr = Expression.Lambda<Action<T>>(
                    Expression.Block(
                        _listener.Recipients.Select(
                            r => Expression.Invoke(r, p))),
                    p);

#if DEBUG
                try
                {
                    Console.Out.WriteLine(
                        "{0} => {1}",
                        string.Join(", ", _listener.Description.Name),
                        expr.GetDebugString());
                }
                catch(Exception) {}
#endif

                _action = expr.Compile();
                SetAction(_action);
            }
        }

        private class State
        {
            private readonly int _count;
            private readonly Action<object[]> _action;
            private object[] _state;
            private bool[] _filled;
            private int _remaining;

            public State(int count, Action<object[]> action)
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
        private readonly List<WriterBase> _writers = new List<WriterBase>();

        public Writer<T> AddInput<T>(string name)
        {
            if (_state != 0)
                throw new InvalidOperationException();
            if (name == null)
                throw new ArgumentException();

            var l = GetListener(NameType.From<T>(name));
            l.AssertFirstWriter();

            var w = new W<T>(this, l);
            _writers.Add(w);

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

            var func = onRceiveAction.Compile();
            Action<object[]> resultAction = vs => func.DynamicInvoke(vs);
            var state = new State(nameIn.Length, resultAction);

            for (var ix = 0; ix < nameIn.Length; ix++)
            {
                var ix2 = ix;
                var l = GetListener(nameIn[ix]);

                var p = Expression.Parameter(l.Description.Type, l.Description.Name);
                var expr = Expression.Lambda(
                    Expression.Call(
                        Expression.Constant(state),
                        "Received",
                        null,
                        Expression.Constant(ix2),
                        Expression.Convert(p, typeof(object))),
                    p);
                l.AddRecipient(expr);
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

        public void AddProcessor(LambdaExpression processor, NameType nameOut, params NameType[] nameIn)
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
                            Expression.Constant(nameOut.Name)),
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

            AddListener(expr, nameIn);
        }

        void IDataProcessor.Close() { _state = 2; }

        void IDisposable.Dispose() { _state = 2; }
    }
}
