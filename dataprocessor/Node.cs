
using System;
using System.Linq;

namespace dataprocessor
{
    public sealed partial class Node
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
                case 11:
                    return typeof(Node<,,,,,,,,,,>).MakeGenericType(parameters);
                case 12:
                    return typeof(Node<,,,,,,,,,,,>).MakeGenericType(parameters);
                case 13:
                    return typeof(Node<,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 14:
                    return typeof(Node<,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 15:
                    return typeof(Node<,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 16:
                    return typeof(Node<,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 17:
                    return typeof(Node<,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 18:
                    return typeof(Node<,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 19:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 20:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 21:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 22:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 23:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 24:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 25:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 26:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 27:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 28:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 29:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 30:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 31:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 32:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 33:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 34:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 35:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 36:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 37:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 38:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 39:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 40:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 41:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 42:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 43:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 44:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 45:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 46:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 47:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 48:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 49:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 50:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 51:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 52:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 53:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 54:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 55:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 56:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 57:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 58:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 59:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 60:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 61:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 62:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 63:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
                case 64:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>).MakeGenericType(parameters);
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
                case 11:
                    return typeof(Node<,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 12:
                    return typeof(Node<,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 13:
                    return typeof(Node<,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 14:
                    return typeof(Node<,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 15:
                    return typeof(Node<,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 16:
                    return typeof(Node<,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 17:
                    return typeof(Node<,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 18:
                    return typeof(Node<,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 19:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 20:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 21:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 22:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 23:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 24:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 25:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 26:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 27:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 28:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 29:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 30:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 31:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 32:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 33:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 34:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 35:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 36:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 37:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 38:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 39:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 40:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 41:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 42:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 43:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 44:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 45:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 46:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 47:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 48:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 49:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 50:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 51:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 52:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 53:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 54:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 55:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 56:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 57:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 58:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 59:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 60:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 61:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 62:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 63:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                case 64:
                    return typeof(Node<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>.Action).MakeGenericType(parameters);
                default:
                    throw new ArgumentException(nameof(parameters));
            }
        }

        public static object GetNodeFor(Type[] parameters)
        {
            if (parameters == null)
                throw new ArgumentNullException(nameof(parameters));

            var type = GetTypeFor(parameters);
            var actionType = GetActionTypeFor(parameters);

            var obj = type.GetConstructor(new Type[0]).Invoke(new object[0]);
            return obj;
        }
    }

    public sealed partial class Node<T1, T2>
    {
        public delegate void Action(T1 p1, T2 p2);

        private const ulong _completionMask = 3ul;
        private ulong _filled;
        private Action _action;
        private T1 _1;
        private T2 _2;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }
    }

    public sealed partial class Node<T1, T2, T3>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3);

        private const ulong _completionMask = 7ul;
        private ulong _filled;
        private Action _action;
        private T1 _1;
        private T2 _2;
        private T3 _3;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4);

        private const ulong _completionMask = 15ul;
        private ulong _filled;
        private Action _action;
        private T1 _1;
        private T2 _2;
        private T3 _3;
        private T4 _4;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5);

        private const ulong _completionMask = 31ul;
        private ulong _filled;
        private Action _action;
        private T1 _1;
        private T2 _2;
        private T3 _3;
        private T4 _4;
        private T5 _5;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6);

        private const ulong _completionMask = 63ul;
        private ulong _filled;
        private Action _action;
        private T1 _1;
        private T2 _2;
        private T3 _3;
        private T4 _4;
        private T5 _5;
        private T6 _6;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7);

        private const ulong _completionMask = 127ul;
        private ulong _filled;
        private Action _action;
        private T1 _1;
        private T2 _2;
        private T3 _3;
        private T4 _4;
        private T5 _5;
        private T6 _6;
        private T7 _7;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8);

        private const ulong _completionMask = 255ul;
        private ulong _filled;
        private Action _action;
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
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9);

        private const ulong _completionMask = 511ul;
        private ulong _filled;
        private Action _action;
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
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10);

        private const ulong _completionMask = 1023ul;
        private ulong _filled;
        private Action _action;
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
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11);

        private const ulong _completionMask = 2047ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12);

        private const ulong _completionMask = 4095ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13);

        private const ulong _completionMask = 8191ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14);

        private const ulong _completionMask = 16383ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15);

        private const ulong _completionMask = 32767ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16);

        private const ulong _completionMask = 65535ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17);

        private const ulong _completionMask = 131071ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18);

        private const ulong _completionMask = 262143ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19);

        private const ulong _completionMask = 524287ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20);

        private const ulong _completionMask = 1048575ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21);

        private const ulong _completionMask = 2097151ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22);

        private const ulong _completionMask = 4194303ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23);

        private const ulong _completionMask = 8388607ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24);

        private const ulong _completionMask = 16777215ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25);

        private const ulong _completionMask = 33554431ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26);

        private const ulong _completionMask = 67108863ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27);

        private const ulong _completionMask = 134217727ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28);

        private const ulong _completionMask = 268435455ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29);

        private const ulong _completionMask = 536870911ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30);

        private const ulong _completionMask = 1073741823ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31);

        private const ulong _completionMask = 2147483647ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32);

        private const ulong _completionMask = 4294967295ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33);

        private const ulong _completionMask = 8589934591ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34);

        private const ulong _completionMask = 17179869183ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35);

        private const ulong _completionMask = 34359738367ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36);

        private const ulong _completionMask = 68719476735ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37);

        private const ulong _completionMask = 137438953471ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38);

        private const ulong _completionMask = 274877906943ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39);

        private const ulong _completionMask = 549755813887ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40);

        private const ulong _completionMask = 1099511627775ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41);

        private const ulong _completionMask = 2199023255551ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42);

        private const ulong _completionMask = 4398046511103ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;
        private T42 _42;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }

        public void Set42(T42 p42)
        {
            _42 = p42;
            MaybeCallAndReset(2199023255552ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43);

        private const ulong _completionMask = 8796093022207ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;
        private T42 _42;
        private T43 _43;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }

        public void Set42(T42 p42)
        {
            _42 = p42;
            MaybeCallAndReset(2199023255552ul);
        }

        public void Set43(T43 p43)
        {
            _43 = p43;
            MaybeCallAndReset(4398046511104ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44);

        private const ulong _completionMask = 17592186044415ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;
        private T42 _42;
        private T43 _43;
        private T44 _44;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }

        public void Set42(T42 p42)
        {
            _42 = p42;
            MaybeCallAndReset(2199023255552ul);
        }

        public void Set43(T43 p43)
        {
            _43 = p43;
            MaybeCallAndReset(4398046511104ul);
        }

        public void Set44(T44 p44)
        {
            _44 = p44;
            MaybeCallAndReset(8796093022208ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45);

        private const ulong _completionMask = 35184372088831ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;
        private T42 _42;
        private T43 _43;
        private T44 _44;
        private T45 _45;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44, _45);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }

        public void Set42(T42 p42)
        {
            _42 = p42;
            MaybeCallAndReset(2199023255552ul);
        }

        public void Set43(T43 p43)
        {
            _43 = p43;
            MaybeCallAndReset(4398046511104ul);
        }

        public void Set44(T44 p44)
        {
            _44 = p44;
            MaybeCallAndReset(8796093022208ul);
        }

        public void Set45(T45 p45)
        {
            _45 = p45;
            MaybeCallAndReset(17592186044416ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46);

        private const ulong _completionMask = 70368744177663ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;
        private T42 _42;
        private T43 _43;
        private T44 _44;
        private T45 _45;
        private T46 _46;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }

        public void Set42(T42 p42)
        {
            _42 = p42;
            MaybeCallAndReset(2199023255552ul);
        }

        public void Set43(T43 p43)
        {
            _43 = p43;
            MaybeCallAndReset(4398046511104ul);
        }

        public void Set44(T44 p44)
        {
            _44 = p44;
            MaybeCallAndReset(8796093022208ul);
        }

        public void Set45(T45 p45)
        {
            _45 = p45;
            MaybeCallAndReset(17592186044416ul);
        }

        public void Set46(T46 p46)
        {
            _46 = p46;
            MaybeCallAndReset(35184372088832ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47);

        private const ulong _completionMask = 140737488355327ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;
        private T42 _42;
        private T43 _43;
        private T44 _44;
        private T45 _45;
        private T46 _46;
        private T47 _47;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }

        public void Set42(T42 p42)
        {
            _42 = p42;
            MaybeCallAndReset(2199023255552ul);
        }

        public void Set43(T43 p43)
        {
            _43 = p43;
            MaybeCallAndReset(4398046511104ul);
        }

        public void Set44(T44 p44)
        {
            _44 = p44;
            MaybeCallAndReset(8796093022208ul);
        }

        public void Set45(T45 p45)
        {
            _45 = p45;
            MaybeCallAndReset(17592186044416ul);
        }

        public void Set46(T46 p46)
        {
            _46 = p46;
            MaybeCallAndReset(35184372088832ul);
        }

        public void Set47(T47 p47)
        {
            _47 = p47;
            MaybeCallAndReset(70368744177664ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48);

        private const ulong _completionMask = 281474976710655ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;
        private T42 _42;
        private T43 _43;
        private T44 _44;
        private T45 _45;
        private T46 _46;
        private T47 _47;
        private T48 _48;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }

        public void Set42(T42 p42)
        {
            _42 = p42;
            MaybeCallAndReset(2199023255552ul);
        }

        public void Set43(T43 p43)
        {
            _43 = p43;
            MaybeCallAndReset(4398046511104ul);
        }

        public void Set44(T44 p44)
        {
            _44 = p44;
            MaybeCallAndReset(8796093022208ul);
        }

        public void Set45(T45 p45)
        {
            _45 = p45;
            MaybeCallAndReset(17592186044416ul);
        }

        public void Set46(T46 p46)
        {
            _46 = p46;
            MaybeCallAndReset(35184372088832ul);
        }

        public void Set47(T47 p47)
        {
            _47 = p47;
            MaybeCallAndReset(70368744177664ul);
        }

        public void Set48(T48 p48)
        {
            _48 = p48;
            MaybeCallAndReset(140737488355328ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49);

        private const ulong _completionMask = 562949953421311ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;
        private T42 _42;
        private T43 _43;
        private T44 _44;
        private T45 _45;
        private T46 _46;
        private T47 _47;
        private T48 _48;
        private T49 _49;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48, _49);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }

        public void Set42(T42 p42)
        {
            _42 = p42;
            MaybeCallAndReset(2199023255552ul);
        }

        public void Set43(T43 p43)
        {
            _43 = p43;
            MaybeCallAndReset(4398046511104ul);
        }

        public void Set44(T44 p44)
        {
            _44 = p44;
            MaybeCallAndReset(8796093022208ul);
        }

        public void Set45(T45 p45)
        {
            _45 = p45;
            MaybeCallAndReset(17592186044416ul);
        }

        public void Set46(T46 p46)
        {
            _46 = p46;
            MaybeCallAndReset(35184372088832ul);
        }

        public void Set47(T47 p47)
        {
            _47 = p47;
            MaybeCallAndReset(70368744177664ul);
        }

        public void Set48(T48 p48)
        {
            _48 = p48;
            MaybeCallAndReset(140737488355328ul);
        }

        public void Set49(T49 p49)
        {
            _49 = p49;
            MaybeCallAndReset(281474976710656ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50);

        private const ulong _completionMask = 1125899906842623ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;
        private T42 _42;
        private T43 _43;
        private T44 _44;
        private T45 _45;
        private T46 _46;
        private T47 _47;
        private T48 _48;
        private T49 _49;
        private T50 _50;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48, _49, _50);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }

        public void Set42(T42 p42)
        {
            _42 = p42;
            MaybeCallAndReset(2199023255552ul);
        }

        public void Set43(T43 p43)
        {
            _43 = p43;
            MaybeCallAndReset(4398046511104ul);
        }

        public void Set44(T44 p44)
        {
            _44 = p44;
            MaybeCallAndReset(8796093022208ul);
        }

        public void Set45(T45 p45)
        {
            _45 = p45;
            MaybeCallAndReset(17592186044416ul);
        }

        public void Set46(T46 p46)
        {
            _46 = p46;
            MaybeCallAndReset(35184372088832ul);
        }

        public void Set47(T47 p47)
        {
            _47 = p47;
            MaybeCallAndReset(70368744177664ul);
        }

        public void Set48(T48 p48)
        {
            _48 = p48;
            MaybeCallAndReset(140737488355328ul);
        }

        public void Set49(T49 p49)
        {
            _49 = p49;
            MaybeCallAndReset(281474976710656ul);
        }

        public void Set50(T50 p50)
        {
            _50 = p50;
            MaybeCallAndReset(562949953421312ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51);

        private const ulong _completionMask = 2251799813685247ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;
        private T42 _42;
        private T43 _43;
        private T44 _44;
        private T45 _45;
        private T46 _46;
        private T47 _47;
        private T48 _48;
        private T49 _49;
        private T50 _50;
        private T51 _51;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48, _49, _50, _51);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }

        public void Set42(T42 p42)
        {
            _42 = p42;
            MaybeCallAndReset(2199023255552ul);
        }

        public void Set43(T43 p43)
        {
            _43 = p43;
            MaybeCallAndReset(4398046511104ul);
        }

        public void Set44(T44 p44)
        {
            _44 = p44;
            MaybeCallAndReset(8796093022208ul);
        }

        public void Set45(T45 p45)
        {
            _45 = p45;
            MaybeCallAndReset(17592186044416ul);
        }

        public void Set46(T46 p46)
        {
            _46 = p46;
            MaybeCallAndReset(35184372088832ul);
        }

        public void Set47(T47 p47)
        {
            _47 = p47;
            MaybeCallAndReset(70368744177664ul);
        }

        public void Set48(T48 p48)
        {
            _48 = p48;
            MaybeCallAndReset(140737488355328ul);
        }

        public void Set49(T49 p49)
        {
            _49 = p49;
            MaybeCallAndReset(281474976710656ul);
        }

        public void Set50(T50 p50)
        {
            _50 = p50;
            MaybeCallAndReset(562949953421312ul);
        }

        public void Set51(T51 p51)
        {
            _51 = p51;
            MaybeCallAndReset(1125899906842624ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52);

        private const ulong _completionMask = 4503599627370495ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;
        private T42 _42;
        private T43 _43;
        private T44 _44;
        private T45 _45;
        private T46 _46;
        private T47 _47;
        private T48 _48;
        private T49 _49;
        private T50 _50;
        private T51 _51;
        private T52 _52;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48, _49, _50, _51, _52);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }

        public void Set42(T42 p42)
        {
            _42 = p42;
            MaybeCallAndReset(2199023255552ul);
        }

        public void Set43(T43 p43)
        {
            _43 = p43;
            MaybeCallAndReset(4398046511104ul);
        }

        public void Set44(T44 p44)
        {
            _44 = p44;
            MaybeCallAndReset(8796093022208ul);
        }

        public void Set45(T45 p45)
        {
            _45 = p45;
            MaybeCallAndReset(17592186044416ul);
        }

        public void Set46(T46 p46)
        {
            _46 = p46;
            MaybeCallAndReset(35184372088832ul);
        }

        public void Set47(T47 p47)
        {
            _47 = p47;
            MaybeCallAndReset(70368744177664ul);
        }

        public void Set48(T48 p48)
        {
            _48 = p48;
            MaybeCallAndReset(140737488355328ul);
        }

        public void Set49(T49 p49)
        {
            _49 = p49;
            MaybeCallAndReset(281474976710656ul);
        }

        public void Set50(T50 p50)
        {
            _50 = p50;
            MaybeCallAndReset(562949953421312ul);
        }

        public void Set51(T51 p51)
        {
            _51 = p51;
            MaybeCallAndReset(1125899906842624ul);
        }

        public void Set52(T52 p52)
        {
            _52 = p52;
            MaybeCallAndReset(2251799813685248ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53);

        private const ulong _completionMask = 9007199254740991ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;
        private T42 _42;
        private T43 _43;
        private T44 _44;
        private T45 _45;
        private T46 _46;
        private T47 _47;
        private T48 _48;
        private T49 _49;
        private T50 _50;
        private T51 _51;
        private T52 _52;
        private T53 _53;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48, _49, _50, _51, _52, _53);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }

        public void Set42(T42 p42)
        {
            _42 = p42;
            MaybeCallAndReset(2199023255552ul);
        }

        public void Set43(T43 p43)
        {
            _43 = p43;
            MaybeCallAndReset(4398046511104ul);
        }

        public void Set44(T44 p44)
        {
            _44 = p44;
            MaybeCallAndReset(8796093022208ul);
        }

        public void Set45(T45 p45)
        {
            _45 = p45;
            MaybeCallAndReset(17592186044416ul);
        }

        public void Set46(T46 p46)
        {
            _46 = p46;
            MaybeCallAndReset(35184372088832ul);
        }

        public void Set47(T47 p47)
        {
            _47 = p47;
            MaybeCallAndReset(70368744177664ul);
        }

        public void Set48(T48 p48)
        {
            _48 = p48;
            MaybeCallAndReset(140737488355328ul);
        }

        public void Set49(T49 p49)
        {
            _49 = p49;
            MaybeCallAndReset(281474976710656ul);
        }

        public void Set50(T50 p50)
        {
            _50 = p50;
            MaybeCallAndReset(562949953421312ul);
        }

        public void Set51(T51 p51)
        {
            _51 = p51;
            MaybeCallAndReset(1125899906842624ul);
        }

        public void Set52(T52 p52)
        {
            _52 = p52;
            MaybeCallAndReset(2251799813685248ul);
        }

        public void Set53(T53 p53)
        {
            _53 = p53;
            MaybeCallAndReset(4503599627370496ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53, T54 p54);

        private const ulong _completionMask = 18014398509481983ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;
        private T42 _42;
        private T43 _43;
        private T44 _44;
        private T45 _45;
        private T46 _46;
        private T47 _47;
        private T48 _48;
        private T49 _49;
        private T50 _50;
        private T51 _51;
        private T52 _52;
        private T53 _53;
        private T54 _54;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48, _49, _50, _51, _52, _53, _54);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }

        public void Set42(T42 p42)
        {
            _42 = p42;
            MaybeCallAndReset(2199023255552ul);
        }

        public void Set43(T43 p43)
        {
            _43 = p43;
            MaybeCallAndReset(4398046511104ul);
        }

        public void Set44(T44 p44)
        {
            _44 = p44;
            MaybeCallAndReset(8796093022208ul);
        }

        public void Set45(T45 p45)
        {
            _45 = p45;
            MaybeCallAndReset(17592186044416ul);
        }

        public void Set46(T46 p46)
        {
            _46 = p46;
            MaybeCallAndReset(35184372088832ul);
        }

        public void Set47(T47 p47)
        {
            _47 = p47;
            MaybeCallAndReset(70368744177664ul);
        }

        public void Set48(T48 p48)
        {
            _48 = p48;
            MaybeCallAndReset(140737488355328ul);
        }

        public void Set49(T49 p49)
        {
            _49 = p49;
            MaybeCallAndReset(281474976710656ul);
        }

        public void Set50(T50 p50)
        {
            _50 = p50;
            MaybeCallAndReset(562949953421312ul);
        }

        public void Set51(T51 p51)
        {
            _51 = p51;
            MaybeCallAndReset(1125899906842624ul);
        }

        public void Set52(T52 p52)
        {
            _52 = p52;
            MaybeCallAndReset(2251799813685248ul);
        }

        public void Set53(T53 p53)
        {
            _53 = p53;
            MaybeCallAndReset(4503599627370496ul);
        }

        public void Set54(T54 p54)
        {
            _54 = p54;
            MaybeCallAndReset(9007199254740992ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53, T54 p54, T55 p55);

        private const ulong _completionMask = 36028797018963967ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;
        private T42 _42;
        private T43 _43;
        private T44 _44;
        private T45 _45;
        private T46 _46;
        private T47 _47;
        private T48 _48;
        private T49 _49;
        private T50 _50;
        private T51 _51;
        private T52 _52;
        private T53 _53;
        private T54 _54;
        private T55 _55;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48, _49, _50, _51, _52, _53, _54, _55);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }

        public void Set42(T42 p42)
        {
            _42 = p42;
            MaybeCallAndReset(2199023255552ul);
        }

        public void Set43(T43 p43)
        {
            _43 = p43;
            MaybeCallAndReset(4398046511104ul);
        }

        public void Set44(T44 p44)
        {
            _44 = p44;
            MaybeCallAndReset(8796093022208ul);
        }

        public void Set45(T45 p45)
        {
            _45 = p45;
            MaybeCallAndReset(17592186044416ul);
        }

        public void Set46(T46 p46)
        {
            _46 = p46;
            MaybeCallAndReset(35184372088832ul);
        }

        public void Set47(T47 p47)
        {
            _47 = p47;
            MaybeCallAndReset(70368744177664ul);
        }

        public void Set48(T48 p48)
        {
            _48 = p48;
            MaybeCallAndReset(140737488355328ul);
        }

        public void Set49(T49 p49)
        {
            _49 = p49;
            MaybeCallAndReset(281474976710656ul);
        }

        public void Set50(T50 p50)
        {
            _50 = p50;
            MaybeCallAndReset(562949953421312ul);
        }

        public void Set51(T51 p51)
        {
            _51 = p51;
            MaybeCallAndReset(1125899906842624ul);
        }

        public void Set52(T52 p52)
        {
            _52 = p52;
            MaybeCallAndReset(2251799813685248ul);
        }

        public void Set53(T53 p53)
        {
            _53 = p53;
            MaybeCallAndReset(4503599627370496ul);
        }

        public void Set54(T54 p54)
        {
            _54 = p54;
            MaybeCallAndReset(9007199254740992ul);
        }

        public void Set55(T55 p55)
        {
            _55 = p55;
            MaybeCallAndReset(18014398509481984ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53, T54 p54, T55 p55, T56 p56);

        private const ulong _completionMask = 72057594037927935ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;
        private T42 _42;
        private T43 _43;
        private T44 _44;
        private T45 _45;
        private T46 _46;
        private T47 _47;
        private T48 _48;
        private T49 _49;
        private T50 _50;
        private T51 _51;
        private T52 _52;
        private T53 _53;
        private T54 _54;
        private T55 _55;
        private T56 _56;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48, _49, _50, _51, _52, _53, _54, _55, _56);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }

        public void Set42(T42 p42)
        {
            _42 = p42;
            MaybeCallAndReset(2199023255552ul);
        }

        public void Set43(T43 p43)
        {
            _43 = p43;
            MaybeCallAndReset(4398046511104ul);
        }

        public void Set44(T44 p44)
        {
            _44 = p44;
            MaybeCallAndReset(8796093022208ul);
        }

        public void Set45(T45 p45)
        {
            _45 = p45;
            MaybeCallAndReset(17592186044416ul);
        }

        public void Set46(T46 p46)
        {
            _46 = p46;
            MaybeCallAndReset(35184372088832ul);
        }

        public void Set47(T47 p47)
        {
            _47 = p47;
            MaybeCallAndReset(70368744177664ul);
        }

        public void Set48(T48 p48)
        {
            _48 = p48;
            MaybeCallAndReset(140737488355328ul);
        }

        public void Set49(T49 p49)
        {
            _49 = p49;
            MaybeCallAndReset(281474976710656ul);
        }

        public void Set50(T50 p50)
        {
            _50 = p50;
            MaybeCallAndReset(562949953421312ul);
        }

        public void Set51(T51 p51)
        {
            _51 = p51;
            MaybeCallAndReset(1125899906842624ul);
        }

        public void Set52(T52 p52)
        {
            _52 = p52;
            MaybeCallAndReset(2251799813685248ul);
        }

        public void Set53(T53 p53)
        {
            _53 = p53;
            MaybeCallAndReset(4503599627370496ul);
        }

        public void Set54(T54 p54)
        {
            _54 = p54;
            MaybeCallAndReset(9007199254740992ul);
        }

        public void Set55(T55 p55)
        {
            _55 = p55;
            MaybeCallAndReset(18014398509481984ul);
        }

        public void Set56(T56 p56)
        {
            _56 = p56;
            MaybeCallAndReset(36028797018963968ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53, T54 p54, T55 p55, T56 p56, T57 p57);

        private const ulong _completionMask = 144115188075855871ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;
        private T42 _42;
        private T43 _43;
        private T44 _44;
        private T45 _45;
        private T46 _46;
        private T47 _47;
        private T48 _48;
        private T49 _49;
        private T50 _50;
        private T51 _51;
        private T52 _52;
        private T53 _53;
        private T54 _54;
        private T55 _55;
        private T56 _56;
        private T57 _57;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48, _49, _50, _51, _52, _53, _54, _55, _56, _57);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }

        public void Set42(T42 p42)
        {
            _42 = p42;
            MaybeCallAndReset(2199023255552ul);
        }

        public void Set43(T43 p43)
        {
            _43 = p43;
            MaybeCallAndReset(4398046511104ul);
        }

        public void Set44(T44 p44)
        {
            _44 = p44;
            MaybeCallAndReset(8796093022208ul);
        }

        public void Set45(T45 p45)
        {
            _45 = p45;
            MaybeCallAndReset(17592186044416ul);
        }

        public void Set46(T46 p46)
        {
            _46 = p46;
            MaybeCallAndReset(35184372088832ul);
        }

        public void Set47(T47 p47)
        {
            _47 = p47;
            MaybeCallAndReset(70368744177664ul);
        }

        public void Set48(T48 p48)
        {
            _48 = p48;
            MaybeCallAndReset(140737488355328ul);
        }

        public void Set49(T49 p49)
        {
            _49 = p49;
            MaybeCallAndReset(281474976710656ul);
        }

        public void Set50(T50 p50)
        {
            _50 = p50;
            MaybeCallAndReset(562949953421312ul);
        }

        public void Set51(T51 p51)
        {
            _51 = p51;
            MaybeCallAndReset(1125899906842624ul);
        }

        public void Set52(T52 p52)
        {
            _52 = p52;
            MaybeCallAndReset(2251799813685248ul);
        }

        public void Set53(T53 p53)
        {
            _53 = p53;
            MaybeCallAndReset(4503599627370496ul);
        }

        public void Set54(T54 p54)
        {
            _54 = p54;
            MaybeCallAndReset(9007199254740992ul);
        }

        public void Set55(T55 p55)
        {
            _55 = p55;
            MaybeCallAndReset(18014398509481984ul);
        }

        public void Set56(T56 p56)
        {
            _56 = p56;
            MaybeCallAndReset(36028797018963968ul);
        }

        public void Set57(T57 p57)
        {
            _57 = p57;
            MaybeCallAndReset(72057594037927936ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53, T54 p54, T55 p55, T56 p56, T57 p57, T58 p58);

        private const ulong _completionMask = 288230376151711743ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;
        private T42 _42;
        private T43 _43;
        private T44 _44;
        private T45 _45;
        private T46 _46;
        private T47 _47;
        private T48 _48;
        private T49 _49;
        private T50 _50;
        private T51 _51;
        private T52 _52;
        private T53 _53;
        private T54 _54;
        private T55 _55;
        private T56 _56;
        private T57 _57;
        private T58 _58;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48, _49, _50, _51, _52, _53, _54, _55, _56, _57, _58);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }

        public void Set42(T42 p42)
        {
            _42 = p42;
            MaybeCallAndReset(2199023255552ul);
        }

        public void Set43(T43 p43)
        {
            _43 = p43;
            MaybeCallAndReset(4398046511104ul);
        }

        public void Set44(T44 p44)
        {
            _44 = p44;
            MaybeCallAndReset(8796093022208ul);
        }

        public void Set45(T45 p45)
        {
            _45 = p45;
            MaybeCallAndReset(17592186044416ul);
        }

        public void Set46(T46 p46)
        {
            _46 = p46;
            MaybeCallAndReset(35184372088832ul);
        }

        public void Set47(T47 p47)
        {
            _47 = p47;
            MaybeCallAndReset(70368744177664ul);
        }

        public void Set48(T48 p48)
        {
            _48 = p48;
            MaybeCallAndReset(140737488355328ul);
        }

        public void Set49(T49 p49)
        {
            _49 = p49;
            MaybeCallAndReset(281474976710656ul);
        }

        public void Set50(T50 p50)
        {
            _50 = p50;
            MaybeCallAndReset(562949953421312ul);
        }

        public void Set51(T51 p51)
        {
            _51 = p51;
            MaybeCallAndReset(1125899906842624ul);
        }

        public void Set52(T52 p52)
        {
            _52 = p52;
            MaybeCallAndReset(2251799813685248ul);
        }

        public void Set53(T53 p53)
        {
            _53 = p53;
            MaybeCallAndReset(4503599627370496ul);
        }

        public void Set54(T54 p54)
        {
            _54 = p54;
            MaybeCallAndReset(9007199254740992ul);
        }

        public void Set55(T55 p55)
        {
            _55 = p55;
            MaybeCallAndReset(18014398509481984ul);
        }

        public void Set56(T56 p56)
        {
            _56 = p56;
            MaybeCallAndReset(36028797018963968ul);
        }

        public void Set57(T57 p57)
        {
            _57 = p57;
            MaybeCallAndReset(72057594037927936ul);
        }

        public void Set58(T58 p58)
        {
            _58 = p58;
            MaybeCallAndReset(144115188075855872ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53, T54 p54, T55 p55, T56 p56, T57 p57, T58 p58, T59 p59);

        private const ulong _completionMask = 576460752303423487ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;
        private T42 _42;
        private T43 _43;
        private T44 _44;
        private T45 _45;
        private T46 _46;
        private T47 _47;
        private T48 _48;
        private T49 _49;
        private T50 _50;
        private T51 _51;
        private T52 _52;
        private T53 _53;
        private T54 _54;
        private T55 _55;
        private T56 _56;
        private T57 _57;
        private T58 _58;
        private T59 _59;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48, _49, _50, _51, _52, _53, _54, _55, _56, _57, _58, _59);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }

        public void Set42(T42 p42)
        {
            _42 = p42;
            MaybeCallAndReset(2199023255552ul);
        }

        public void Set43(T43 p43)
        {
            _43 = p43;
            MaybeCallAndReset(4398046511104ul);
        }

        public void Set44(T44 p44)
        {
            _44 = p44;
            MaybeCallAndReset(8796093022208ul);
        }

        public void Set45(T45 p45)
        {
            _45 = p45;
            MaybeCallAndReset(17592186044416ul);
        }

        public void Set46(T46 p46)
        {
            _46 = p46;
            MaybeCallAndReset(35184372088832ul);
        }

        public void Set47(T47 p47)
        {
            _47 = p47;
            MaybeCallAndReset(70368744177664ul);
        }

        public void Set48(T48 p48)
        {
            _48 = p48;
            MaybeCallAndReset(140737488355328ul);
        }

        public void Set49(T49 p49)
        {
            _49 = p49;
            MaybeCallAndReset(281474976710656ul);
        }

        public void Set50(T50 p50)
        {
            _50 = p50;
            MaybeCallAndReset(562949953421312ul);
        }

        public void Set51(T51 p51)
        {
            _51 = p51;
            MaybeCallAndReset(1125899906842624ul);
        }

        public void Set52(T52 p52)
        {
            _52 = p52;
            MaybeCallAndReset(2251799813685248ul);
        }

        public void Set53(T53 p53)
        {
            _53 = p53;
            MaybeCallAndReset(4503599627370496ul);
        }

        public void Set54(T54 p54)
        {
            _54 = p54;
            MaybeCallAndReset(9007199254740992ul);
        }

        public void Set55(T55 p55)
        {
            _55 = p55;
            MaybeCallAndReset(18014398509481984ul);
        }

        public void Set56(T56 p56)
        {
            _56 = p56;
            MaybeCallAndReset(36028797018963968ul);
        }

        public void Set57(T57 p57)
        {
            _57 = p57;
            MaybeCallAndReset(72057594037927936ul);
        }

        public void Set58(T58 p58)
        {
            _58 = p58;
            MaybeCallAndReset(144115188075855872ul);
        }

        public void Set59(T59 p59)
        {
            _59 = p59;
            MaybeCallAndReset(288230376151711744ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53, T54 p54, T55 p55, T56 p56, T57 p57, T58 p58, T59 p59, T60 p60);

        private const ulong _completionMask = 1152921504606846975ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;
        private T42 _42;
        private T43 _43;
        private T44 _44;
        private T45 _45;
        private T46 _46;
        private T47 _47;
        private T48 _48;
        private T49 _49;
        private T50 _50;
        private T51 _51;
        private T52 _52;
        private T53 _53;
        private T54 _54;
        private T55 _55;
        private T56 _56;
        private T57 _57;
        private T58 _58;
        private T59 _59;
        private T60 _60;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48, _49, _50, _51, _52, _53, _54, _55, _56, _57, _58, _59, _60);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }

        public void Set42(T42 p42)
        {
            _42 = p42;
            MaybeCallAndReset(2199023255552ul);
        }

        public void Set43(T43 p43)
        {
            _43 = p43;
            MaybeCallAndReset(4398046511104ul);
        }

        public void Set44(T44 p44)
        {
            _44 = p44;
            MaybeCallAndReset(8796093022208ul);
        }

        public void Set45(T45 p45)
        {
            _45 = p45;
            MaybeCallAndReset(17592186044416ul);
        }

        public void Set46(T46 p46)
        {
            _46 = p46;
            MaybeCallAndReset(35184372088832ul);
        }

        public void Set47(T47 p47)
        {
            _47 = p47;
            MaybeCallAndReset(70368744177664ul);
        }

        public void Set48(T48 p48)
        {
            _48 = p48;
            MaybeCallAndReset(140737488355328ul);
        }

        public void Set49(T49 p49)
        {
            _49 = p49;
            MaybeCallAndReset(281474976710656ul);
        }

        public void Set50(T50 p50)
        {
            _50 = p50;
            MaybeCallAndReset(562949953421312ul);
        }

        public void Set51(T51 p51)
        {
            _51 = p51;
            MaybeCallAndReset(1125899906842624ul);
        }

        public void Set52(T52 p52)
        {
            _52 = p52;
            MaybeCallAndReset(2251799813685248ul);
        }

        public void Set53(T53 p53)
        {
            _53 = p53;
            MaybeCallAndReset(4503599627370496ul);
        }

        public void Set54(T54 p54)
        {
            _54 = p54;
            MaybeCallAndReset(9007199254740992ul);
        }

        public void Set55(T55 p55)
        {
            _55 = p55;
            MaybeCallAndReset(18014398509481984ul);
        }

        public void Set56(T56 p56)
        {
            _56 = p56;
            MaybeCallAndReset(36028797018963968ul);
        }

        public void Set57(T57 p57)
        {
            _57 = p57;
            MaybeCallAndReset(72057594037927936ul);
        }

        public void Set58(T58 p58)
        {
            _58 = p58;
            MaybeCallAndReset(144115188075855872ul);
        }

        public void Set59(T59 p59)
        {
            _59 = p59;
            MaybeCallAndReset(288230376151711744ul);
        }

        public void Set60(T60 p60)
        {
            _60 = p60;
            MaybeCallAndReset(576460752303423488ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53, T54 p54, T55 p55, T56 p56, T57 p57, T58 p58, T59 p59, T60 p60, T61 p61);

        private const ulong _completionMask = 2305843009213693951ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;
        private T42 _42;
        private T43 _43;
        private T44 _44;
        private T45 _45;
        private T46 _46;
        private T47 _47;
        private T48 _48;
        private T49 _49;
        private T50 _50;
        private T51 _51;
        private T52 _52;
        private T53 _53;
        private T54 _54;
        private T55 _55;
        private T56 _56;
        private T57 _57;
        private T58 _58;
        private T59 _59;
        private T60 _60;
        private T61 _61;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48, _49, _50, _51, _52, _53, _54, _55, _56, _57, _58, _59, _60, _61);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }

        public void Set42(T42 p42)
        {
            _42 = p42;
            MaybeCallAndReset(2199023255552ul);
        }

        public void Set43(T43 p43)
        {
            _43 = p43;
            MaybeCallAndReset(4398046511104ul);
        }

        public void Set44(T44 p44)
        {
            _44 = p44;
            MaybeCallAndReset(8796093022208ul);
        }

        public void Set45(T45 p45)
        {
            _45 = p45;
            MaybeCallAndReset(17592186044416ul);
        }

        public void Set46(T46 p46)
        {
            _46 = p46;
            MaybeCallAndReset(35184372088832ul);
        }

        public void Set47(T47 p47)
        {
            _47 = p47;
            MaybeCallAndReset(70368744177664ul);
        }

        public void Set48(T48 p48)
        {
            _48 = p48;
            MaybeCallAndReset(140737488355328ul);
        }

        public void Set49(T49 p49)
        {
            _49 = p49;
            MaybeCallAndReset(281474976710656ul);
        }

        public void Set50(T50 p50)
        {
            _50 = p50;
            MaybeCallAndReset(562949953421312ul);
        }

        public void Set51(T51 p51)
        {
            _51 = p51;
            MaybeCallAndReset(1125899906842624ul);
        }

        public void Set52(T52 p52)
        {
            _52 = p52;
            MaybeCallAndReset(2251799813685248ul);
        }

        public void Set53(T53 p53)
        {
            _53 = p53;
            MaybeCallAndReset(4503599627370496ul);
        }

        public void Set54(T54 p54)
        {
            _54 = p54;
            MaybeCallAndReset(9007199254740992ul);
        }

        public void Set55(T55 p55)
        {
            _55 = p55;
            MaybeCallAndReset(18014398509481984ul);
        }

        public void Set56(T56 p56)
        {
            _56 = p56;
            MaybeCallAndReset(36028797018963968ul);
        }

        public void Set57(T57 p57)
        {
            _57 = p57;
            MaybeCallAndReset(72057594037927936ul);
        }

        public void Set58(T58 p58)
        {
            _58 = p58;
            MaybeCallAndReset(144115188075855872ul);
        }

        public void Set59(T59 p59)
        {
            _59 = p59;
            MaybeCallAndReset(288230376151711744ul);
        }

        public void Set60(T60 p60)
        {
            _60 = p60;
            MaybeCallAndReset(576460752303423488ul);
        }

        public void Set61(T61 p61)
        {
            _61 = p61;
            MaybeCallAndReset(1152921504606846976ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53, T54 p54, T55 p55, T56 p56, T57 p57, T58 p58, T59 p59, T60 p60, T61 p61, T62 p62);

        private const ulong _completionMask = 4611686018427387903ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;
        private T42 _42;
        private T43 _43;
        private T44 _44;
        private T45 _45;
        private T46 _46;
        private T47 _47;
        private T48 _48;
        private T49 _49;
        private T50 _50;
        private T51 _51;
        private T52 _52;
        private T53 _53;
        private T54 _54;
        private T55 _55;
        private T56 _56;
        private T57 _57;
        private T58 _58;
        private T59 _59;
        private T60 _60;
        private T61 _61;
        private T62 _62;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48, _49, _50, _51, _52, _53, _54, _55, _56, _57, _58, _59, _60, _61, _62);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }

        public void Set42(T42 p42)
        {
            _42 = p42;
            MaybeCallAndReset(2199023255552ul);
        }

        public void Set43(T43 p43)
        {
            _43 = p43;
            MaybeCallAndReset(4398046511104ul);
        }

        public void Set44(T44 p44)
        {
            _44 = p44;
            MaybeCallAndReset(8796093022208ul);
        }

        public void Set45(T45 p45)
        {
            _45 = p45;
            MaybeCallAndReset(17592186044416ul);
        }

        public void Set46(T46 p46)
        {
            _46 = p46;
            MaybeCallAndReset(35184372088832ul);
        }

        public void Set47(T47 p47)
        {
            _47 = p47;
            MaybeCallAndReset(70368744177664ul);
        }

        public void Set48(T48 p48)
        {
            _48 = p48;
            MaybeCallAndReset(140737488355328ul);
        }

        public void Set49(T49 p49)
        {
            _49 = p49;
            MaybeCallAndReset(281474976710656ul);
        }

        public void Set50(T50 p50)
        {
            _50 = p50;
            MaybeCallAndReset(562949953421312ul);
        }

        public void Set51(T51 p51)
        {
            _51 = p51;
            MaybeCallAndReset(1125899906842624ul);
        }

        public void Set52(T52 p52)
        {
            _52 = p52;
            MaybeCallAndReset(2251799813685248ul);
        }

        public void Set53(T53 p53)
        {
            _53 = p53;
            MaybeCallAndReset(4503599627370496ul);
        }

        public void Set54(T54 p54)
        {
            _54 = p54;
            MaybeCallAndReset(9007199254740992ul);
        }

        public void Set55(T55 p55)
        {
            _55 = p55;
            MaybeCallAndReset(18014398509481984ul);
        }

        public void Set56(T56 p56)
        {
            _56 = p56;
            MaybeCallAndReset(36028797018963968ul);
        }

        public void Set57(T57 p57)
        {
            _57 = p57;
            MaybeCallAndReset(72057594037927936ul);
        }

        public void Set58(T58 p58)
        {
            _58 = p58;
            MaybeCallAndReset(144115188075855872ul);
        }

        public void Set59(T59 p59)
        {
            _59 = p59;
            MaybeCallAndReset(288230376151711744ul);
        }

        public void Set60(T60 p60)
        {
            _60 = p60;
            MaybeCallAndReset(576460752303423488ul);
        }

        public void Set61(T61 p61)
        {
            _61 = p61;
            MaybeCallAndReset(1152921504606846976ul);
        }

        public void Set62(T62 p62)
        {
            _62 = p62;
            MaybeCallAndReset(2305843009213693952ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53, T54 p54, T55 p55, T56 p56, T57 p57, T58 p58, T59 p59, T60 p60, T61 p61, T62 p62, T63 p63);

        private const ulong _completionMask = 9223372036854775807ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;
        private T42 _42;
        private T43 _43;
        private T44 _44;
        private T45 _45;
        private T46 _46;
        private T47 _47;
        private T48 _48;
        private T49 _49;
        private T50 _50;
        private T51 _51;
        private T52 _52;
        private T53 _53;
        private T54 _54;
        private T55 _55;
        private T56 _56;
        private T57 _57;
        private T58 _58;
        private T59 _59;
        private T60 _60;
        private T61 _61;
        private T62 _62;
        private T63 _63;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48, _49, _50, _51, _52, _53, _54, _55, _56, _57, _58, _59, _60, _61, _62, _63);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }

        public void Set42(T42 p42)
        {
            _42 = p42;
            MaybeCallAndReset(2199023255552ul);
        }

        public void Set43(T43 p43)
        {
            _43 = p43;
            MaybeCallAndReset(4398046511104ul);
        }

        public void Set44(T44 p44)
        {
            _44 = p44;
            MaybeCallAndReset(8796093022208ul);
        }

        public void Set45(T45 p45)
        {
            _45 = p45;
            MaybeCallAndReset(17592186044416ul);
        }

        public void Set46(T46 p46)
        {
            _46 = p46;
            MaybeCallAndReset(35184372088832ul);
        }

        public void Set47(T47 p47)
        {
            _47 = p47;
            MaybeCallAndReset(70368744177664ul);
        }

        public void Set48(T48 p48)
        {
            _48 = p48;
            MaybeCallAndReset(140737488355328ul);
        }

        public void Set49(T49 p49)
        {
            _49 = p49;
            MaybeCallAndReset(281474976710656ul);
        }

        public void Set50(T50 p50)
        {
            _50 = p50;
            MaybeCallAndReset(562949953421312ul);
        }

        public void Set51(T51 p51)
        {
            _51 = p51;
            MaybeCallAndReset(1125899906842624ul);
        }

        public void Set52(T52 p52)
        {
            _52 = p52;
            MaybeCallAndReset(2251799813685248ul);
        }

        public void Set53(T53 p53)
        {
            _53 = p53;
            MaybeCallAndReset(4503599627370496ul);
        }

        public void Set54(T54 p54)
        {
            _54 = p54;
            MaybeCallAndReset(9007199254740992ul);
        }

        public void Set55(T55 p55)
        {
            _55 = p55;
            MaybeCallAndReset(18014398509481984ul);
        }

        public void Set56(T56 p56)
        {
            _56 = p56;
            MaybeCallAndReset(36028797018963968ul);
        }

        public void Set57(T57 p57)
        {
            _57 = p57;
            MaybeCallAndReset(72057594037927936ul);
        }

        public void Set58(T58 p58)
        {
            _58 = p58;
            MaybeCallAndReset(144115188075855872ul);
        }

        public void Set59(T59 p59)
        {
            _59 = p59;
            MaybeCallAndReset(288230376151711744ul);
        }

        public void Set60(T60 p60)
        {
            _60 = p60;
            MaybeCallAndReset(576460752303423488ul);
        }

        public void Set61(T61 p61)
        {
            _61 = p61;
            MaybeCallAndReset(1152921504606846976ul);
        }

        public void Set62(T62 p62)
        {
            _62 = p62;
            MaybeCallAndReset(2305843009213693952ul);
        }

        public void Set63(T63 p63)
        {
            _63 = p63;
            MaybeCallAndReset(4611686018427387904ul);
        }
    }

    public sealed partial class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63, T64>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53, T54 p54, T55 p55, T56 p56, T57 p57, T58 p58, T59 p59, T60 p60, T61 p61, T62 p62, T63 p63, T64 p64);

        private const ulong _completionMask = 18446744073709551615ul;
        private ulong _filled;
        private Action _action;
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
        private T11 _11;
        private T12 _12;
        private T13 _13;
        private T14 _14;
        private T15 _15;
        private T16 _16;
        private T17 _17;
        private T18 _18;
        private T19 _19;
        private T20 _20;
        private T21 _21;
        private T22 _22;
        private T23 _23;
        private T24 _24;
        private T25 _25;
        private T26 _26;
        private T27 _27;
        private T28 _28;
        private T29 _29;
        private T30 _30;
        private T31 _31;
        private T32 _32;
        private T33 _33;
        private T34 _34;
        private T35 _35;
        private T36 _36;
        private T37 _37;
        private T38 _38;
        private T39 _39;
        private T40 _40;
        private T41 _41;
        private T42 _42;
        private T43 _43;
        private T44 _44;
        private T45 _45;
        private T46 _46;
        private T47 _47;
        private T48 _48;
        private T49 _49;
        private T50 _50;
        private T51 _51;
        private T52 _52;
        private T53 _53;
        private T54 _54;
        private T55 _55;
        private T56 _56;
        private T57 _57;
        private T58 _58;
        private T59 _59;
        private T60 _60;
        private T61 _61;
        private T62 _62;
        private T63 _63;
        private T64 _64;

        public Node(Action action)
        {
            SetAction(action);
        }

        public Node()
        {
        }

        public void SetAction(Action action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            _action = action;
        }

        private void MaybeCallAndReset(ulong value)
        {
            if (_action == null)
                throw new InvalidOperationException();

            var old = _filled;
            _filled |= value;

            if (old != _completionMask && _filled == _completionMask)
            {
                _filled = 0;
                _action(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23, _24, _25, _26, _27, _28, _29, _30, _31, _32, _33, _34, _35, _36, _37, _38, _39, _40, _41, _42, _43, _44, _45, _46, _47, _48, _49, _50, _51, _52, _53, _54, _55, _56, _57, _58, _59, _60, _61, _62, _63, _64);
            }
        }

        public void Set1(T1 p1)
        {
            _1 = p1;
            MaybeCallAndReset(1ul);
        }

        public void Set2(T2 p2)
        {
            _2 = p2;
            MaybeCallAndReset(2ul);
        }

        public void Set3(T3 p3)
        {
            _3 = p3;
            MaybeCallAndReset(4ul);
        }

        public void Set4(T4 p4)
        {
            _4 = p4;
            MaybeCallAndReset(8ul);
        }

        public void Set5(T5 p5)
        {
            _5 = p5;
            MaybeCallAndReset(16ul);
        }

        public void Set6(T6 p6)
        {
            _6 = p6;
            MaybeCallAndReset(32ul);
        }

        public void Set7(T7 p7)
        {
            _7 = p7;
            MaybeCallAndReset(64ul);
        }

        public void Set8(T8 p8)
        {
            _8 = p8;
            MaybeCallAndReset(128ul);
        }

        public void Set9(T9 p9)
        {
            _9 = p9;
            MaybeCallAndReset(256ul);
        }

        public void Set10(T10 p10)
        {
            _10 = p10;
            MaybeCallAndReset(512ul);
        }

        public void Set11(T11 p11)
        {
            _11 = p11;
            MaybeCallAndReset(1024ul);
        }

        public void Set12(T12 p12)
        {
            _12 = p12;
            MaybeCallAndReset(2048ul);
        }

        public void Set13(T13 p13)
        {
            _13 = p13;
            MaybeCallAndReset(4096ul);
        }

        public void Set14(T14 p14)
        {
            _14 = p14;
            MaybeCallAndReset(8192ul);
        }

        public void Set15(T15 p15)
        {
            _15 = p15;
            MaybeCallAndReset(16384ul);
        }

        public void Set16(T16 p16)
        {
            _16 = p16;
            MaybeCallAndReset(32768ul);
        }

        public void Set17(T17 p17)
        {
            _17 = p17;
            MaybeCallAndReset(65536ul);
        }

        public void Set18(T18 p18)
        {
            _18 = p18;
            MaybeCallAndReset(131072ul);
        }

        public void Set19(T19 p19)
        {
            _19 = p19;
            MaybeCallAndReset(262144ul);
        }

        public void Set20(T20 p20)
        {
            _20 = p20;
            MaybeCallAndReset(524288ul);
        }

        public void Set21(T21 p21)
        {
            _21 = p21;
            MaybeCallAndReset(1048576ul);
        }

        public void Set22(T22 p22)
        {
            _22 = p22;
            MaybeCallAndReset(2097152ul);
        }

        public void Set23(T23 p23)
        {
            _23 = p23;
            MaybeCallAndReset(4194304ul);
        }

        public void Set24(T24 p24)
        {
            _24 = p24;
            MaybeCallAndReset(8388608ul);
        }

        public void Set25(T25 p25)
        {
            _25 = p25;
            MaybeCallAndReset(16777216ul);
        }

        public void Set26(T26 p26)
        {
            _26 = p26;
            MaybeCallAndReset(33554432ul);
        }

        public void Set27(T27 p27)
        {
            _27 = p27;
            MaybeCallAndReset(67108864ul);
        }

        public void Set28(T28 p28)
        {
            _28 = p28;
            MaybeCallAndReset(134217728ul);
        }

        public void Set29(T29 p29)
        {
            _29 = p29;
            MaybeCallAndReset(268435456ul);
        }

        public void Set30(T30 p30)
        {
            _30 = p30;
            MaybeCallAndReset(536870912ul);
        }

        public void Set31(T31 p31)
        {
            _31 = p31;
            MaybeCallAndReset(1073741824ul);
        }

        public void Set32(T32 p32)
        {
            _32 = p32;
            MaybeCallAndReset(2147483648ul);
        }

        public void Set33(T33 p33)
        {
            _33 = p33;
            MaybeCallAndReset(4294967296ul);
        }

        public void Set34(T34 p34)
        {
            _34 = p34;
            MaybeCallAndReset(8589934592ul);
        }

        public void Set35(T35 p35)
        {
            _35 = p35;
            MaybeCallAndReset(17179869184ul);
        }

        public void Set36(T36 p36)
        {
            _36 = p36;
            MaybeCallAndReset(34359738368ul);
        }

        public void Set37(T37 p37)
        {
            _37 = p37;
            MaybeCallAndReset(68719476736ul);
        }

        public void Set38(T38 p38)
        {
            _38 = p38;
            MaybeCallAndReset(137438953472ul);
        }

        public void Set39(T39 p39)
        {
            _39 = p39;
            MaybeCallAndReset(274877906944ul);
        }

        public void Set40(T40 p40)
        {
            _40 = p40;
            MaybeCallAndReset(549755813888ul);
        }

        public void Set41(T41 p41)
        {
            _41 = p41;
            MaybeCallAndReset(1099511627776ul);
        }

        public void Set42(T42 p42)
        {
            _42 = p42;
            MaybeCallAndReset(2199023255552ul);
        }

        public void Set43(T43 p43)
        {
            _43 = p43;
            MaybeCallAndReset(4398046511104ul);
        }

        public void Set44(T44 p44)
        {
            _44 = p44;
            MaybeCallAndReset(8796093022208ul);
        }

        public void Set45(T45 p45)
        {
            _45 = p45;
            MaybeCallAndReset(17592186044416ul);
        }

        public void Set46(T46 p46)
        {
            _46 = p46;
            MaybeCallAndReset(35184372088832ul);
        }

        public void Set47(T47 p47)
        {
            _47 = p47;
            MaybeCallAndReset(70368744177664ul);
        }

        public void Set48(T48 p48)
        {
            _48 = p48;
            MaybeCallAndReset(140737488355328ul);
        }

        public void Set49(T49 p49)
        {
            _49 = p49;
            MaybeCallAndReset(281474976710656ul);
        }

        public void Set50(T50 p50)
        {
            _50 = p50;
            MaybeCallAndReset(562949953421312ul);
        }

        public void Set51(T51 p51)
        {
            _51 = p51;
            MaybeCallAndReset(1125899906842624ul);
        }

        public void Set52(T52 p52)
        {
            _52 = p52;
            MaybeCallAndReset(2251799813685248ul);
        }

        public void Set53(T53 p53)
        {
            _53 = p53;
            MaybeCallAndReset(4503599627370496ul);
        }

        public void Set54(T54 p54)
        {
            _54 = p54;
            MaybeCallAndReset(9007199254740992ul);
        }

        public void Set55(T55 p55)
        {
            _55 = p55;
            MaybeCallAndReset(18014398509481984ul);
        }

        public void Set56(T56 p56)
        {
            _56 = p56;
            MaybeCallAndReset(36028797018963968ul);
        }

        public void Set57(T57 p57)
        {
            _57 = p57;
            MaybeCallAndReset(72057594037927936ul);
        }

        public void Set58(T58 p58)
        {
            _58 = p58;
            MaybeCallAndReset(144115188075855872ul);
        }

        public void Set59(T59 p59)
        {
            _59 = p59;
            MaybeCallAndReset(288230376151711744ul);
        }

        public void Set60(T60 p60)
        {
            _60 = p60;
            MaybeCallAndReset(576460752303423488ul);
        }

        public void Set61(T61 p61)
        {
            _61 = p61;
            MaybeCallAndReset(1152921504606846976ul);
        }

        public void Set62(T62 p62)
        {
            _62 = p62;
            MaybeCallAndReset(2305843009213693952ul);
        }

        public void Set63(T63 p63)
        {
            _63 = p63;
            MaybeCallAndReset(4611686018427387904ul);
        }

        public void Set64(T64 p64)
        {
            _64 = p64;
            MaybeCallAndReset(9223372036854775808ul);
        }
    }
}