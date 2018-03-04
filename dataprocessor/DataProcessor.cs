using System;

namespace dataprocessor
{
    public sealed class DataProcessor : IDataProcessor
    {
        private IClosable[] _writers;

        public DataProcessor(IClosable[] writers)
        {
            _writers = writers;
        }

        void IDataProcessor.Close()
        {
            foreach (var w in _writers)
                w.Close();
        }

        void IDisposable.Dispose() { ((IDataProcessor)this).Close(); }
    }
}