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
            var ws = _writers;
            _writers = null;

            if (ws != null)
                foreach (var w in ws)
                    w.Close();
        }

        void IDisposable.Dispose() => ((IDataProcessor)this).Close();
    }
}