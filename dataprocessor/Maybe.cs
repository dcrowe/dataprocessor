using System;

namespace dataprocessor
{
    public struct Maybe<T>
    {
        public static Maybe<T> Nothing => new Maybe<T>();
        public static Maybe<T> Just(T value) => new Maybe<T>(value);
        public static implicit operator Maybe<T>(T value) => new Maybe<T>(value);

        private Maybe(T value)
        {
            IsPresent = true;
            Value = value;
        }

        public readonly bool IsPresent;
        public readonly T Value;
    }

    public static class Maybe
    {
        public static bool IsMaybe(this Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));
            return type.IsConstructedGenericType
                && type.GetGenericTypeDefinition() == typeof(Maybe<>);
        }

        public static Type ToMaybe(this Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));
            return typeof(Maybe<>).MakeGenericType(type);
        }
    }
}
