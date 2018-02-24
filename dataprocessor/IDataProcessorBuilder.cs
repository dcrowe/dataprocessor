using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace dataprocessor
{
    public interface IDataProcessorBuilder
    {
        IWriter<T> AddInput<T>(string name);

        void AddProcessor(IEnumerable<string> nameIn, string nameOut, LambdaExpression processor);

        void AddListener(IEnumerable<string> nameIn, LambdaExpression onRceiveAction);

        IEnumerable<NameType> GetDefinedInputs();

        IDataProcessor Build();
    }

    public interface IWriter<T>
    {
        void Send(T value);
    }

    public interface IDataProcessor : IDisposable
    {
        void Close();
    }
}
