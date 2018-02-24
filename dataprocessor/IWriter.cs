namespace dataprocessor
{
    public interface IWriter
    {
        void Set<T>(T value);
    }

    public interface IWriter<T>
    {
        void Set(T value);
    }
}
