using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace dataprocessor
{
    public interface IDataProcessorBuilder
    {
        Writer<T> AddInput<T>(string name);

        void AddProcessor(LambdaExpression processor, NameType nameOut, params NameType[] nameIn);

        void AddListener(LambdaExpression onRceiveAction, params NameType[] nameIn);

        IEnumerable<NameType> GetDefinedInputs();

        IDataProcessor Build();
    }

    public class Writer<T> : IClosable
    {
        private Action<T> _action;

        protected void SetAction(Action<T> action)
        {
            _action = action;
        }

        public void Send(T value)
        {
            if (_action == null)
                throw new InvalidOperationException();
            _action(value);
        }

        public void Close() => SetAction(null);
    }

    public interface IDataProcessor : IDisposable
    {
        void Close();
    }

    public interface IClosable 
    {
        void Close();
    }
}
