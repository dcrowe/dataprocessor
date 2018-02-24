using System;

namespace dataprocessor
{

    public interface IDataProcessor : IDisposable 
    {
        void Close();
    }
}
