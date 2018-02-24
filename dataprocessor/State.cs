
using System;

namespace dataprocessor
{
    internal sealed partial class State
    {
        public static Type GetTypeFor(Type[] parameters)
        {
            if (parameters == null)
                throw new ArgumentNullException(nameof(parameters));

            switch (parameters.Length)
            {
                case 2:
                    return typeof(State<,>).MakeGenericType(parameters);
                case 3:
                    return typeof(State<,,>).MakeGenericType(parameters);
                case 4:
                    return typeof(State<,,,>).MakeGenericType(parameters);
                case 5:
                    return typeof(State<,,,,>).MakeGenericType(parameters);
                case 6:
                    return typeof(State<,,,,,>).MakeGenericType(parameters);
                default:
                    throw new ArgumentException(nameof(parameters));
            }
        }

        public static object GetStateFor(Type[] parameters)
        {
            var type = GetTypeFor(parameters);
            var obj = type.GetConstructor(new Type[0]).Invoke(new object[0]);
            return obj;
        }
    }

    internal sealed partial class State<T1, T2>
    {
        public delegate void Action(T1 p1, T2 p2);

        private const ulong _completionMask = 3ul;
        private ulong _filled;

        public T1 P1 { get; private set; }

        public bool Set1(T1 p1)
        {
            P1 = p1;
            _filled |= 1ul;
            return IsFilled;
        }

        public T2 P2 { get; private set; }

        public bool Set2(T2 p2)
        {
            P2 = p2;
            _filled |= 2ul;
            return IsFilled;
        }

/*
        public bool SetN<T>(ushort index, T value)
        {
            bool result;

            switch(index)
            {
                case 1:
                    if (typeof(T) != typeof(T1))
                        throw new ArgumentException("Incorrect type for index", nameof(index));
                    result = Set1((T1)value);
                    break;
                case 2:
                    if (typeof(T) != typeof(T2))
                        throw new ArgumentException("Incorrect type for index", nameof(index));
                    result = Set2((T2)value);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(index));
            }

            return result;
        }
*/

        public bool IsFilled 
        {
            get { return _filled == _completionMask; }
        }

        public void Reset() 
        {
            _filled = 0;
        }

        public void ApplyTo(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            action(P1, P2);
        }
    }

    internal sealed partial class State<T1, T2, T3>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3);

        private const ulong _completionMask = 7ul;
        private ulong _filled;

        public T1 P1 { get; private set; }

        public bool Set1(T1 p1)
        {
            P1 = p1;
            _filled |= 1ul;
            return IsFilled;
        }

        public T2 P2 { get; private set; }

        public bool Set2(T2 p2)
        {
            P2 = p2;
            _filled |= 2ul;
            return IsFilled;
        }

        public T3 P3 { get; private set; }

        public bool Set3(T3 p3)
        {
            P3 = p3;
            _filled |= 4ul;
            return IsFilled;
        }

/*
        public bool SetN<T>(ushort index, T value)
        {
            bool result;

            switch(index)
            {
                case 1:
                    if (typeof(T) != typeof(T1))
                        throw new ArgumentException("Incorrect type for index", nameof(index));
                    result = Set1((T1)value);
                    break;
                case 2:
                    if (typeof(T) != typeof(T2))
                        throw new ArgumentException("Incorrect type for index", nameof(index));
                    result = Set2((T2)value);
                    break;
                case 3:
                    if (typeof(T) != typeof(T3))
                        throw new ArgumentException("Incorrect type for index", nameof(index));
                    result = Set3((T3)value);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(index));
            }

            return result;
        }
*/

        public bool IsFilled 
        {
            get { return _filled == _completionMask; }
        }

        public void Reset() 
        {
            _filled = 0;
        }

        public void ApplyTo(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            action(P1, P2, P3);
        }
    }

    internal sealed partial class State<T1, T2, T3, T4>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4);

        private const ulong _completionMask = 15ul;
        private ulong _filled;

        public T1 P1 { get; private set; }

        public bool Set1(T1 p1)
        {
            P1 = p1;
            _filled |= 1ul;
            return IsFilled;
        }

        public T2 P2 { get; private set; }

        public bool Set2(T2 p2)
        {
            P2 = p2;
            _filled |= 2ul;
            return IsFilled;
        }

        public T3 P3 { get; private set; }

        public bool Set3(T3 p3)
        {
            P3 = p3;
            _filled |= 4ul;
            return IsFilled;
        }

        public T4 P4 { get; private set; }

        public bool Set4(T4 p4)
        {
            P4 = p4;
            _filled |= 8ul;
            return IsFilled;
        }

/*
        public bool SetN<T>(ushort index, T value)
        {
            bool result;

            switch(index)
            {
                case 1:
                    if (typeof(T) != typeof(T1))
                        throw new ArgumentException("Incorrect type for index", nameof(index));
                    result = Set1((T1)value);
                    break;
                case 2:
                    if (typeof(T) != typeof(T2))
                        throw new ArgumentException("Incorrect type for index", nameof(index));
                    result = Set2((T2)value);
                    break;
                case 3:
                    if (typeof(T) != typeof(T3))
                        throw new ArgumentException("Incorrect type for index", nameof(index));
                    result = Set3((T3)value);
                    break;
                case 4:
                    if (typeof(T) != typeof(T4))
                        throw new ArgumentException("Incorrect type for index", nameof(index));
                    result = Set4((T4)value);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(index));
            }

            return result;
        }
*/

        public bool IsFilled 
        {
            get { return _filled == _completionMask; }
        }

        public void Reset() 
        {
            _filled = 0;
        }

        public void ApplyTo(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            action(P1, P2, P3, P4);
        }
    }

    internal sealed partial class State<T1, T2, T3, T4, T5>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5);

        private const ulong _completionMask = 31ul;
        private ulong _filled;

        public T1 P1 { get; private set; }

        public bool Set1(T1 p1)
        {
            P1 = p1;
            _filled |= 1ul;
            return IsFilled;
        }

        public T2 P2 { get; private set; }

        public bool Set2(T2 p2)
        {
            P2 = p2;
            _filled |= 2ul;
            return IsFilled;
        }

        public T3 P3 { get; private set; }

        public bool Set3(T3 p3)
        {
            P3 = p3;
            _filled |= 4ul;
            return IsFilled;
        }

        public T4 P4 { get; private set; }

        public bool Set4(T4 p4)
        {
            P4 = p4;
            _filled |= 8ul;
            return IsFilled;
        }

        public T5 P5 { get; private set; }

        public bool Set5(T5 p5)
        {
            P5 = p5;
            _filled |= 16ul;
            return IsFilled;
        }

/*
        public bool SetN<T>(ushort index, T value)
        {
            bool result;

            switch(index)
            {
                case 1:
                    if (typeof(T) != typeof(T1))
                        throw new ArgumentException("Incorrect type for index", nameof(index));
                    result = Set1((T1)value);
                    break;
                case 2:
                    if (typeof(T) != typeof(T2))
                        throw new ArgumentException("Incorrect type for index", nameof(index));
                    result = Set2((T2)value);
                    break;
                case 3:
                    if (typeof(T) != typeof(T3))
                        throw new ArgumentException("Incorrect type for index", nameof(index));
                    result = Set3((T3)value);
                    break;
                case 4:
                    if (typeof(T) != typeof(T4))
                        throw new ArgumentException("Incorrect type for index", nameof(index));
                    result = Set4((T4)value);
                    break;
                case 5:
                    if (typeof(T) != typeof(T5))
                        throw new ArgumentException("Incorrect type for index", nameof(index));
                    result = Set5((T5)value);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(index));
            }

            return result;
        }
*/

        public bool IsFilled 
        {
            get { return _filled == _completionMask; }
        }

        public void Reset() 
        {
            _filled = 0;
        }

        public void ApplyTo(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            action(P1, P2, P3, P4, P5);
        }
    }

    internal sealed partial class State<T1, T2, T3, T4, T5, T6>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6);

        private const ulong _completionMask = 63ul;
        private ulong _filled;

        public T1 P1 { get; private set; }

        public bool Set1(T1 p1)
        {
            P1 = p1;
            _filled |= 1ul;
            return IsFilled;
        }

        public T2 P2 { get; private set; }

        public bool Set2(T2 p2)
        {
            P2 = p2;
            _filled |= 2ul;
            return IsFilled;
        }

        public T3 P3 { get; private set; }

        public bool Set3(T3 p3)
        {
            P3 = p3;
            _filled |= 4ul;
            return IsFilled;
        }

        public T4 P4 { get; private set; }

        public bool Set4(T4 p4)
        {
            P4 = p4;
            _filled |= 8ul;
            return IsFilled;
        }

        public T5 P5 { get; private set; }

        public bool Set5(T5 p5)
        {
            P5 = p5;
            _filled |= 16ul;
            return IsFilled;
        }

        public T6 P6 { get; private set; }

        public bool Set6(T6 p6)
        {
            P6 = p6;
            _filled |= 32ul;
            return IsFilled;
        }

/*
        public bool SetN<T>(ushort index, T value)
        {
            bool result;

            switch(index)
            {
                case 1:
                    if (typeof(T) != typeof(T1))
                        throw new ArgumentException("Incorrect type for index", nameof(index));
                    result = Set1((T1)value);
                    break;
                case 2:
                    if (typeof(T) != typeof(T2))
                        throw new ArgumentException("Incorrect type for index", nameof(index));
                    result = Set2((T2)value);
                    break;
                case 3:
                    if (typeof(T) != typeof(T3))
                        throw new ArgumentException("Incorrect type for index", nameof(index));
                    result = Set3((T3)value);
                    break;
                case 4:
                    if (typeof(T) != typeof(T4))
                        throw new ArgumentException("Incorrect type for index", nameof(index));
                    result = Set4((T4)value);
                    break;
                case 5:
                    if (typeof(T) != typeof(T5))
                        throw new ArgumentException("Incorrect type for index", nameof(index));
                    result = Set5((T5)value);
                    break;
                case 6:
                    if (typeof(T) != typeof(T6))
                        throw new ArgumentException("Incorrect type for index", nameof(index));
                    result = Set6((T6)value);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(index));
            }

            return result;
        }
*/

        public bool IsFilled 
        {
            get { return _filled == _completionMask; }
        }

        public void Reset() 
        {
            _filled = 0;
        }

        public void ApplyTo(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            action(P1, P2, P3, P4, P5, P6);
        }
    }
}