using System;
using System.Reflection;
using System.Linq.Expressions;

namespace dataprocessor
{
    public struct Maybe<T>
    {
        public static Maybe<T> Nothing => new Maybe<T>();
        public static Maybe<T> Just(T value) => new Maybe<T>(value);
        public static implicit operator Maybe<T>(T value) => Just(value);

        private Maybe(T value)
        {
            IsPresent = true;
            Value = value;
        }

        public readonly bool IsPresent;
        public readonly T Value;
    }

    public static class MaybeHelpers 
    {
        static readonly MethodInfo _justMethod = typeof(Maybe<int>).GetMethod("Just");
        static readonly MethodInfo _implicitJustMethod = typeof(Maybe<int>).GetMethod("op_Implicit");

        public static bool IsMaybe(this Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Maybe<>);
        }

        public static Type ToMaybe(this Type type)
        {
            return typeof(Maybe<>).MakeGenericType(type);
        }

        public static Type FromMaybe(this Type type)
        {
            return type.GetGenericArguments()[0];
        }

        public static bool IsJustMethod(this MethodInfo mi)
        {
            if (mi.IsGenericMethod)
                mi = mi.GetGenericMethodDefinition();
            var result =  mi == _justMethod || mi == _implicitJustMethod;
            return result;
        }
    }
}
