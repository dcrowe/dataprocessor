using System;
using System.Linq.Expressions;

namespace dataprocessor
{
    [System.Diagnostics.DebuggerDisplay("{Name} : {Type}")]
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

        public static NameType From<T>(string name) => new NameType(name, typeof(T));

        internal ParameterExpression AsParameter() => Expression.Parameter(Type, Name);
        internal ParameterExpression AsVariable() => Expression.Variable(Type, Name);
    }
}
