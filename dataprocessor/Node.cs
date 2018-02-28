
using System;
using System.Linq;

namespace dataprocessor
{
    internal sealed partial class Node
    {
        public static Type GetTypeFor(Type[] parameters)
        {
            if (parameters == null)
                throw new ArgumentNullException(nameof(parameters));

            switch (parameters.Length)
            {
                case 2:
                    return typeof(Node<,>).MakeGenericType(parameters);
                case 3:
                    return typeof(Node<,,>).MakeGenericType(parameters);
                case 4:
                    return typeof(Node<,,,>).MakeGenericType(parameters);
                case 5:
                    return typeof(Node<,,,,>).MakeGenericType(parameters);
                case 6:
                    return typeof(Node<,,,,,>).MakeGenericType(parameters);
                case 7:
                    return typeof(Node<,,,,,,>).MakeGenericType(parameters);
                case 8:
                    return typeof(Node<,,,,,,,>).MakeGenericType(parameters);
                case 9:
                    return typeof(Node<,,,,,,,,>).MakeGenericType(parameters);
                case 10:
                    return typeof(Node<,,,,,,,,,>).MakeGenericType(parameters);
                default:
                    throw new ArgumentException(nameof(parameters));
            }
        }

        public static Type GetActionTypeFor(Type[] parameters)
        {
            if (parameters == null)
                throw new ArgumentNullException(nameof(parameters));

            switch (parameters.Length)
            {
                case 2:
                    return typeof(Node<,>.Action).MakeGenericType(parameters);
                case 3:
                    return typeof(Node<,,>.Action).MakeGenericType(parameters);
                case 4:
                    return typeof(Node<,,,>.Action).MakeGenericType(parameters);
                case 5:
                    return typeof(Node<,,,,>.Action).MakeGenericType(parameters);
                case 6:
                    return typeof(Node<,,,,,>.Action).MakeGenericType(parameters);
                case 7:
                    return typeof(Node<,,,,,,>.Action).MakeGenericType(parameters);
                case 8:
                    return typeof(Node<,,,,,,,>.Action).MakeGenericType(parameters);
                case 9:
                    return typeof(Node<,,,,,,,,>.Action).MakeGenericType(parameters);
                case 10:
                    return typeof(Node<,,,,,,,,,>.Action).MakeGenericType(parameters);
                default:
                    throw new ArgumentException(nameof(parameters));
            }
        }

        public static object GetNodeFor(Type[] parameters, Delegate action)
        {
            if (parameters == null)
                throw new ArgumentNullException(nameof(parameters));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            var type = GetTypeFor(parameters);
            var actionType = GetActionTypeFor(parameters);

            var actionAction = action
                .GetInvocationList()
                .Select(d => Delegate.CreateDelegate(actionType, d.Target, d.Method))
                .Aggregate(Delegate.Combine);

            var obj = type.GetConstructor(new [] { actionType }).Invoke(new object[] { actionAction });
            return obj;
        }
    }

    internal sealed partial class Node<T1, T2>
    {
        public delegate void Action(T1 p1, T2 p2);

        private const ulong _completionMask = 3ul;
        private ulong _filled;
        private readonly Action _action;
        private T1 _1;
        private T2 _2;

        public Node(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private bool IsFilled => _filled == _completionMask;
        private void Reset() => _filled = 0;

        public void Set1(T1 p1)
        {
            var wasFilled = IsFilled;
            _1 = p1;
            _filled |= 1ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2);
                Reset();
            }
        }

        public void Set2(T2 p2)
        {
            var wasFilled = IsFilled;
            _2 = p2;
            _filled |= 2ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2);
                Reset();
            }
        }
    }

    internal sealed partial class Node<T1, T2, T3>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3);

        private const ulong _completionMask = 7ul;
        private ulong _filled;
        private readonly Action _action;
        private T1 _1;
        private T2 _2;
        private T3 _3;

        public Node(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private bool IsFilled => _filled == _completionMask;
        private void Reset() => _filled = 0;

        public void Set1(T1 p1)
        {
            var wasFilled = IsFilled;
            _1 = p1;
            _filled |= 1ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3);
                Reset();
            }
        }

        public void Set2(T2 p2)
        {
            var wasFilled = IsFilled;
            _2 = p2;
            _filled |= 2ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3);
                Reset();
            }
        }

        public void Set3(T3 p3)
        {
            var wasFilled = IsFilled;
            _3 = p3;
            _filled |= 4ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3);
                Reset();
            }
        }
    }

    internal sealed partial class Node<T1, T2, T3, T4>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4);

        private const ulong _completionMask = 15ul;
        private ulong _filled;
        private readonly Action _action;
        private T1 _1;
        private T2 _2;
        private T3 _3;
        private T4 _4;

        public Node(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private bool IsFilled => _filled == _completionMask;
        private void Reset() => _filled = 0;

        public void Set1(T1 p1)
        {
            var wasFilled = IsFilled;
            _1 = p1;
            _filled |= 1ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4);
                Reset();
            }
        }

        public void Set2(T2 p2)
        {
            var wasFilled = IsFilled;
            _2 = p2;
            _filled |= 2ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4);
                Reset();
            }
        }

        public void Set3(T3 p3)
        {
            var wasFilled = IsFilled;
            _3 = p3;
            _filled |= 4ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4);
                Reset();
            }
        }

        public void Set4(T4 p4)
        {
            var wasFilled = IsFilled;
            _4 = p4;
            _filled |= 8ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4);
                Reset();
            }
        }
    }

    internal sealed partial class Node<T1, T2, T3, T4, T5>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5);

        private const ulong _completionMask = 31ul;
        private ulong _filled;
        private readonly Action _action;
        private T1 _1;
        private T2 _2;
        private T3 _3;
        private T4 _4;
        private T5 _5;

        public Node(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private bool IsFilled => _filled == _completionMask;
        private void Reset() => _filled = 0;

        public void Set1(T1 p1)
        {
            var wasFilled = IsFilled;
            _1 = p1;
            _filled |= 1ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5);
                Reset();
            }
        }

        public void Set2(T2 p2)
        {
            var wasFilled = IsFilled;
            _2 = p2;
            _filled |= 2ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5);
                Reset();
            }
        }

        public void Set3(T3 p3)
        {
            var wasFilled = IsFilled;
            _3 = p3;
            _filled |= 4ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5);
                Reset();
            }
        }

        public void Set4(T4 p4)
        {
            var wasFilled = IsFilled;
            _4 = p4;
            _filled |= 8ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5);
                Reset();
            }
        }

        public void Set5(T5 p5)
        {
            var wasFilled = IsFilled;
            _5 = p5;
            _filled |= 16ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5);
                Reset();
            }
        }
    }

    internal sealed partial class Node<T1, T2, T3, T4, T5, T6>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6);

        private const ulong _completionMask = 63ul;
        private ulong _filled;
        private readonly Action _action;
        private T1 _1;
        private T2 _2;
        private T3 _3;
        private T4 _4;
        private T5 _5;
        private T6 _6;

        public Node(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private bool IsFilled => _filled == _completionMask;
        private void Reset() => _filled = 0;

        public void Set1(T1 p1)
        {
            var wasFilled = IsFilled;
            _1 = p1;
            _filled |= 1ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6);
                Reset();
            }
        }

        public void Set2(T2 p2)
        {
            var wasFilled = IsFilled;
            _2 = p2;
            _filled |= 2ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6);
                Reset();
            }
        }

        public void Set3(T3 p3)
        {
            var wasFilled = IsFilled;
            _3 = p3;
            _filled |= 4ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6);
                Reset();
            }
        }

        public void Set4(T4 p4)
        {
            var wasFilled = IsFilled;
            _4 = p4;
            _filled |= 8ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6);
                Reset();
            }
        }

        public void Set5(T5 p5)
        {
            var wasFilled = IsFilled;
            _5 = p5;
            _filled |= 16ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6);
                Reset();
            }
        }

        public void Set6(T6 p6)
        {
            var wasFilled = IsFilled;
            _6 = p6;
            _filled |= 32ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6);
                Reset();
            }
        }
    }

    internal sealed partial class Node<T1, T2, T3, T4, T5, T6, T7>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7);

        private const ulong _completionMask = 127ul;
        private ulong _filled;
        private readonly Action _action;
        private T1 _1;
        private T2 _2;
        private T3 _3;
        private T4 _4;
        private T5 _5;
        private T6 _6;
        private T7 _7;

        public Node(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private bool IsFilled => _filled == _completionMask;
        private void Reset() => _filled = 0;

        public void Set1(T1 p1)
        {
            var wasFilled = IsFilled;
            _1 = p1;
            _filled |= 1ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7);
                Reset();
            }
        }

        public void Set2(T2 p2)
        {
            var wasFilled = IsFilled;
            _2 = p2;
            _filled |= 2ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7);
                Reset();
            }
        }

        public void Set3(T3 p3)
        {
            var wasFilled = IsFilled;
            _3 = p3;
            _filled |= 4ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7);
                Reset();
            }
        }

        public void Set4(T4 p4)
        {
            var wasFilled = IsFilled;
            _4 = p4;
            _filled |= 8ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7);
                Reset();
            }
        }

        public void Set5(T5 p5)
        {
            var wasFilled = IsFilled;
            _5 = p5;
            _filled |= 16ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7);
                Reset();
            }
        }

        public void Set6(T6 p6)
        {
            var wasFilled = IsFilled;
            _6 = p6;
            _filled |= 32ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7);
                Reset();
            }
        }

        public void Set7(T7 p7)
        {
            var wasFilled = IsFilled;
            _7 = p7;
            _filled |= 64ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7);
                Reset();
            }
        }
    }

    internal sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8);

        private const ulong _completionMask = 255ul;
        private ulong _filled;
        private readonly Action _action;
        private T1 _1;
        private T2 _2;
        private T3 _3;
        private T4 _4;
        private T5 _5;
        private T6 _6;
        private T7 _7;
        private T8 _8;

        public Node(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private bool IsFilled => _filled == _completionMask;
        private void Reset() => _filled = 0;

        public void Set1(T1 p1)
        {
            var wasFilled = IsFilled;
            _1 = p1;
            _filled |= 1ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8);
                Reset();
            }
        }

        public void Set2(T2 p2)
        {
            var wasFilled = IsFilled;
            _2 = p2;
            _filled |= 2ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8);
                Reset();
            }
        }

        public void Set3(T3 p3)
        {
            var wasFilled = IsFilled;
            _3 = p3;
            _filled |= 4ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8);
                Reset();
            }
        }

        public void Set4(T4 p4)
        {
            var wasFilled = IsFilled;
            _4 = p4;
            _filled |= 8ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8);
                Reset();
            }
        }

        public void Set5(T5 p5)
        {
            var wasFilled = IsFilled;
            _5 = p5;
            _filled |= 16ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8);
                Reset();
            }
        }

        public void Set6(T6 p6)
        {
            var wasFilled = IsFilled;
            _6 = p6;
            _filled |= 32ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8);
                Reset();
            }
        }

        public void Set7(T7 p7)
        {
            var wasFilled = IsFilled;
            _7 = p7;
            _filled |= 64ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8);
                Reset();
            }
        }

        public void Set8(T8 p8)
        {
            var wasFilled = IsFilled;
            _8 = p8;
            _filled |= 128ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8);
                Reset();
            }
        }
    }

    internal sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9);

        private const ulong _completionMask = 511ul;
        private ulong _filled;
        private readonly Action _action;
        private T1 _1;
        private T2 _2;
        private T3 _3;
        private T4 _4;
        private T5 _5;
        private T6 _6;
        private T7 _7;
        private T8 _8;
        private T9 _9;

        public Node(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private bool IsFilled => _filled == _completionMask;
        private void Reset() => _filled = 0;

        public void Set1(T1 p1)
        {
            var wasFilled = IsFilled;
            _1 = p1;
            _filled |= 1ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9);
                Reset();
            }
        }

        public void Set2(T2 p2)
        {
            var wasFilled = IsFilled;
            _2 = p2;
            _filled |= 2ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9);
                Reset();
            }
        }

        public void Set3(T3 p3)
        {
            var wasFilled = IsFilled;
            _3 = p3;
            _filled |= 4ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9);
                Reset();
            }
        }

        public void Set4(T4 p4)
        {
            var wasFilled = IsFilled;
            _4 = p4;
            _filled |= 8ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9);
                Reset();
            }
        }

        public void Set5(T5 p5)
        {
            var wasFilled = IsFilled;
            _5 = p5;
            _filled |= 16ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9);
                Reset();
            }
        }

        public void Set6(T6 p6)
        {
            var wasFilled = IsFilled;
            _6 = p6;
            _filled |= 32ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9);
                Reset();
            }
        }

        public void Set7(T7 p7)
        {
            var wasFilled = IsFilled;
            _7 = p7;
            _filled |= 64ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9);
                Reset();
            }
        }

        public void Set8(T8 p8)
        {
            var wasFilled = IsFilled;
            _8 = p8;
            _filled |= 128ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9);
                Reset();
            }
        }

        public void Set9(T9 p9)
        {
            var wasFilled = IsFilled;
            _9 = p9;
            _filled |= 256ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9);
                Reset();
            }
        }
    }

    internal sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10);

        private const ulong _completionMask = 1023ul;
        private ulong _filled;
        private readonly Action _action;
        private T1 _1;
        private T2 _2;
        private T3 _3;
        private T4 _4;
        private T5 _5;
        private T6 _6;
        private T7 _7;
        private T8 _8;
        private T9 _9;
        private T10 _10;

        public Node(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private bool IsFilled => _filled == _completionMask;
        private void Reset() => _filled = 0;

        public void Set1(T1 p1)
        {
            var wasFilled = IsFilled;
            _1 = p1;
            _filled |= 1ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10);
                Reset();
            }
        }

        public void Set2(T2 p2)
        {
            var wasFilled = IsFilled;
            _2 = p2;
            _filled |= 2ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10);
                Reset();
            }
        }

        public void Set3(T3 p3)
        {
            var wasFilled = IsFilled;
            _3 = p3;
            _filled |= 4ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10);
                Reset();
            }
        }

        public void Set4(T4 p4)
        {
            var wasFilled = IsFilled;
            _4 = p4;
            _filled |= 8ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10);
                Reset();
            }
        }

        public void Set5(T5 p5)
        {
            var wasFilled = IsFilled;
            _5 = p5;
            _filled |= 16ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10);
                Reset();
            }
        }

        public void Set6(T6 p6)
        {
            var wasFilled = IsFilled;
            _6 = p6;
            _filled |= 32ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10);
                Reset();
            }
        }

        public void Set7(T7 p7)
        {
            var wasFilled = IsFilled;
            _7 = p7;
            _filled |= 64ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10);
                Reset();
            }
        }

        public void Set8(T8 p8)
        {
            var wasFilled = IsFilled;
            _8 = p8;
            _filled |= 128ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10);
                Reset();
            }
        }

        public void Set9(T9 p9)
        {
            var wasFilled = IsFilled;
            _9 = p9;
            _filled |= 256ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10);
                Reset();
            }
        }

        public void Set10(T10 p10)
        {
            var wasFilled = IsFilled;
            _10 = p10;
            _filled |= 512ul;

            if (!wasFilled && IsFilled)
            {
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10);
                Reset();
            }
        }
    }
}