namespace dataprocessor
{
    internal class DataProcessor : IDataProcessor
    {
        private WriterBase[] writerBase;

        public DataProcessor(WriterBase[] writerBase)
        {
            this.writerBase = writerBase;
        }
    }
}