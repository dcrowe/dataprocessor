using System;

namespace dataprocessor
{
    public struct NameType
    {
        public NameType(string name, Type type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; }
        public Type Type { get; }

        public static NameType From<T>(string name)
        {
            return new NameType(name, typeof(T));
        }

        public static NameType Unique<T>() 
        {
            return new NameType(new Guid().ToString(), typeof(T));
        }
    }
}
