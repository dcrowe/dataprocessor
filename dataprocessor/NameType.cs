using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace dataprocessor
{
    [DebuggerDisplay("{Name} : {Type}")]
    public struct NameType
    {
        public NameType(string name, Type type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; }
        public Type Type { get; }
        public bool IsValid => !string.IsNullOrEmpty(Name) && Type != null;

        public static NameType Empty => new NameType();
        public static NameType From<T>(string name) => new NameType(name, typeof(T));
    }
}
