
using System;
using System.Threading;

namespace dataprocessor
{
    public sealed class Node
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

    public sealed class Node<T1, T2>
    {
        public delegate void Action(T1 p1, T2 p2);

        private const ulong _completionMask = 3ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2);
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

    public sealed class Node<T1, T2, T3>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3);

        private const ulong _completionMask = 7ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3);
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

    public sealed class Node<T1, T2, T3, T4>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4);

        private const ulong _completionMask = 15ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4);
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

    public sealed class Node<T1, T2, T3, T4, T5>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5);

        private const ulong _completionMask = 31ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6);

        private const ulong _completionMask = 63ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7);

        private const ulong _completionMask = 127ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8);

        private const ulong _completionMask = 255ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9);

        private const ulong _completionMask = 511ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10);

        private const ulong _completionMask = 1023ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11);

        private const ulong _completionMask = 2047ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12);

        private const ulong _completionMask = 4095ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13);

        private const ulong _completionMask = 8191ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14);

        private const ulong _completionMask = 16383ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15);

        private const ulong _completionMask = 32767ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16);

        private const ulong _completionMask = 65535ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17);

        private const ulong _completionMask = 131071ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18);

        private const ulong _completionMask = 262143ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19);

        private const ulong _completionMask = 524287ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20);

        private const ulong _completionMask = 1048575ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21);

        private const ulong _completionMask = 2097151ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22);

        private const ulong _completionMask = 4194303ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23);

        private const ulong _completionMask = 8388607ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24);

        private const ulong _completionMask = 16777215ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25);

        private const ulong _completionMask = 33554431ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26);

        private const ulong _completionMask = 67108863ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27);

        private const ulong _completionMask = 134217727ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28);

        private const ulong _completionMask = 268435455ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29);

        private const ulong _completionMask = 536870911ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30);

        private const ulong _completionMask = 1073741823ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31);

        private const ulong _completionMask = 2147483647ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32);

        private const ulong _completionMask = 4294967295ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33);

        private const ulong _completionMask = 8589934591ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34);

        private const ulong _completionMask = 17179869183ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35);

        private const ulong _completionMask = 34359738367ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36);

        private const ulong _completionMask = 68719476735ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37);

        private const ulong _completionMask = 137438953471ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38);

        private const ulong _completionMask = 274877906943ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39);

        private const ulong _completionMask = 549755813887ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40);

        private const ulong _completionMask = 1099511627775ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41);

        private const ulong _completionMask = 2199023255551ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42);

        private const ulong _completionMask = 4398046511103ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     
            var t42 = default(T42);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                        t42 = _42;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41, t42);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43);

        private const ulong _completionMask = 8796093022207ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     
            var t42 = default(T42);     
            var t43 = default(T43);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                        t42 = _42;
                        t43 = _43;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41, t42, t43);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44);

        private const ulong _completionMask = 17592186044415ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     
            var t42 = default(T42);     
            var t43 = default(T43);     
            var t44 = default(T44);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                        t42 = _42;
                        t43 = _43;
                        t44 = _44;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41, t42, t43, t44);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45);

        private const ulong _completionMask = 35184372088831ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     
            var t42 = default(T42);     
            var t43 = default(T43);     
            var t44 = default(T44);     
            var t45 = default(T45);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                        t42 = _42;
                        t43 = _43;
                        t44 = _44;
                        t45 = _45;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41, t42, t43, t44, t45);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46);

        private const ulong _completionMask = 70368744177663ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     
            var t42 = default(T42);     
            var t43 = default(T43);     
            var t44 = default(T44);     
            var t45 = default(T45);     
            var t46 = default(T46);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                        t42 = _42;
                        t43 = _43;
                        t44 = _44;
                        t45 = _45;
                        t46 = _46;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41, t42, t43, t44, t45, t46);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47);

        private const ulong _completionMask = 140737488355327ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     
            var t42 = default(T42);     
            var t43 = default(T43);     
            var t44 = default(T44);     
            var t45 = default(T45);     
            var t46 = default(T46);     
            var t47 = default(T47);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                        t42 = _42;
                        t43 = _43;
                        t44 = _44;
                        t45 = _45;
                        t46 = _46;
                        t47 = _47;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41, t42, t43, t44, t45, t46, t47);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48);

        private const ulong _completionMask = 281474976710655ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     
            var t42 = default(T42);     
            var t43 = default(T43);     
            var t44 = default(T44);     
            var t45 = default(T45);     
            var t46 = default(T46);     
            var t47 = default(T47);     
            var t48 = default(T48);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                        t42 = _42;
                        t43 = _43;
                        t44 = _44;
                        t45 = _45;
                        t46 = _46;
                        t47 = _47;
                        t48 = _48;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41, t42, t43, t44, t45, t46, t47, t48);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49);

        private const ulong _completionMask = 562949953421311ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     
            var t42 = default(T42);     
            var t43 = default(T43);     
            var t44 = default(T44);     
            var t45 = default(T45);     
            var t46 = default(T46);     
            var t47 = default(T47);     
            var t48 = default(T48);     
            var t49 = default(T49);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                        t42 = _42;
                        t43 = _43;
                        t44 = _44;
                        t45 = _45;
                        t46 = _46;
                        t47 = _47;
                        t48 = _48;
                        t49 = _49;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41, t42, t43, t44, t45, t46, t47, t48, t49);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50);

        private const ulong _completionMask = 1125899906842623ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     
            var t42 = default(T42);     
            var t43 = default(T43);     
            var t44 = default(T44);     
            var t45 = default(T45);     
            var t46 = default(T46);     
            var t47 = default(T47);     
            var t48 = default(T48);     
            var t49 = default(T49);     
            var t50 = default(T50);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                        t42 = _42;
                        t43 = _43;
                        t44 = _44;
                        t45 = _45;
                        t46 = _46;
                        t47 = _47;
                        t48 = _48;
                        t49 = _49;
                        t50 = _50;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41, t42, t43, t44, t45, t46, t47, t48, t49, t50);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51);

        private const ulong _completionMask = 2251799813685247ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     
            var t42 = default(T42);     
            var t43 = default(T43);     
            var t44 = default(T44);     
            var t45 = default(T45);     
            var t46 = default(T46);     
            var t47 = default(T47);     
            var t48 = default(T48);     
            var t49 = default(T49);     
            var t50 = default(T50);     
            var t51 = default(T51);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                        t42 = _42;
                        t43 = _43;
                        t44 = _44;
                        t45 = _45;
                        t46 = _46;
                        t47 = _47;
                        t48 = _48;
                        t49 = _49;
                        t50 = _50;
                        t51 = _51;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41, t42, t43, t44, t45, t46, t47, t48, t49, t50, t51);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52);

        private const ulong _completionMask = 4503599627370495ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     
            var t42 = default(T42);     
            var t43 = default(T43);     
            var t44 = default(T44);     
            var t45 = default(T45);     
            var t46 = default(T46);     
            var t47 = default(T47);     
            var t48 = default(T48);     
            var t49 = default(T49);     
            var t50 = default(T50);     
            var t51 = default(T51);     
            var t52 = default(T52);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                        t42 = _42;
                        t43 = _43;
                        t44 = _44;
                        t45 = _45;
                        t46 = _46;
                        t47 = _47;
                        t48 = _48;
                        t49 = _49;
                        t50 = _50;
                        t51 = _51;
                        t52 = _52;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41, t42, t43, t44, t45, t46, t47, t48, t49, t50, t51, t52);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53);

        private const ulong _completionMask = 9007199254740991ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     
            var t42 = default(T42);     
            var t43 = default(T43);     
            var t44 = default(T44);     
            var t45 = default(T45);     
            var t46 = default(T46);     
            var t47 = default(T47);     
            var t48 = default(T48);     
            var t49 = default(T49);     
            var t50 = default(T50);     
            var t51 = default(T51);     
            var t52 = default(T52);     
            var t53 = default(T53);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                        t42 = _42;
                        t43 = _43;
                        t44 = _44;
                        t45 = _45;
                        t46 = _46;
                        t47 = _47;
                        t48 = _48;
                        t49 = _49;
                        t50 = _50;
                        t51 = _51;
                        t52 = _52;
                        t53 = _53;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41, t42, t43, t44, t45, t46, t47, t48, t49, t50, t51, t52, t53);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53, T54 p54);

        private const ulong _completionMask = 18014398509481983ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     
            var t42 = default(T42);     
            var t43 = default(T43);     
            var t44 = default(T44);     
            var t45 = default(T45);     
            var t46 = default(T46);     
            var t47 = default(T47);     
            var t48 = default(T48);     
            var t49 = default(T49);     
            var t50 = default(T50);     
            var t51 = default(T51);     
            var t52 = default(T52);     
            var t53 = default(T53);     
            var t54 = default(T54);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                        t42 = _42;
                        t43 = _43;
                        t44 = _44;
                        t45 = _45;
                        t46 = _46;
                        t47 = _47;
                        t48 = _48;
                        t49 = _49;
                        t50 = _50;
                        t51 = _51;
                        t52 = _52;
                        t53 = _53;
                        t54 = _54;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41, t42, t43, t44, t45, t46, t47, t48, t49, t50, t51, t52, t53, t54);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53, T54 p54, T55 p55);

        private const ulong _completionMask = 36028797018963967ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     
            var t42 = default(T42);     
            var t43 = default(T43);     
            var t44 = default(T44);     
            var t45 = default(T45);     
            var t46 = default(T46);     
            var t47 = default(T47);     
            var t48 = default(T48);     
            var t49 = default(T49);     
            var t50 = default(T50);     
            var t51 = default(T51);     
            var t52 = default(T52);     
            var t53 = default(T53);     
            var t54 = default(T54);     
            var t55 = default(T55);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                        t42 = _42;
                        t43 = _43;
                        t44 = _44;
                        t45 = _45;
                        t46 = _46;
                        t47 = _47;
                        t48 = _48;
                        t49 = _49;
                        t50 = _50;
                        t51 = _51;
                        t52 = _52;
                        t53 = _53;
                        t54 = _54;
                        t55 = _55;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41, t42, t43, t44, t45, t46, t47, t48, t49, t50, t51, t52, t53, t54, t55);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53, T54 p54, T55 p55, T56 p56);

        private const ulong _completionMask = 72057594037927935ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     
            var t42 = default(T42);     
            var t43 = default(T43);     
            var t44 = default(T44);     
            var t45 = default(T45);     
            var t46 = default(T46);     
            var t47 = default(T47);     
            var t48 = default(T48);     
            var t49 = default(T49);     
            var t50 = default(T50);     
            var t51 = default(T51);     
            var t52 = default(T52);     
            var t53 = default(T53);     
            var t54 = default(T54);     
            var t55 = default(T55);     
            var t56 = default(T56);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                        t42 = _42;
                        t43 = _43;
                        t44 = _44;
                        t45 = _45;
                        t46 = _46;
                        t47 = _47;
                        t48 = _48;
                        t49 = _49;
                        t50 = _50;
                        t51 = _51;
                        t52 = _52;
                        t53 = _53;
                        t54 = _54;
                        t55 = _55;
                        t56 = _56;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41, t42, t43, t44, t45, t46, t47, t48, t49, t50, t51, t52, t53, t54, t55, t56);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53, T54 p54, T55 p55, T56 p56, T57 p57);

        private const ulong _completionMask = 144115188075855871ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     
            var t42 = default(T42);     
            var t43 = default(T43);     
            var t44 = default(T44);     
            var t45 = default(T45);     
            var t46 = default(T46);     
            var t47 = default(T47);     
            var t48 = default(T48);     
            var t49 = default(T49);     
            var t50 = default(T50);     
            var t51 = default(T51);     
            var t52 = default(T52);     
            var t53 = default(T53);     
            var t54 = default(T54);     
            var t55 = default(T55);     
            var t56 = default(T56);     
            var t57 = default(T57);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                        t42 = _42;
                        t43 = _43;
                        t44 = _44;
                        t45 = _45;
                        t46 = _46;
                        t47 = _47;
                        t48 = _48;
                        t49 = _49;
                        t50 = _50;
                        t51 = _51;
                        t52 = _52;
                        t53 = _53;
                        t54 = _54;
                        t55 = _55;
                        t56 = _56;
                        t57 = _57;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41, t42, t43, t44, t45, t46, t47, t48, t49, t50, t51, t52, t53, t54, t55, t56, t57);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53, T54 p54, T55 p55, T56 p56, T57 p57, T58 p58);

        private const ulong _completionMask = 288230376151711743ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     
            var t42 = default(T42);     
            var t43 = default(T43);     
            var t44 = default(T44);     
            var t45 = default(T45);     
            var t46 = default(T46);     
            var t47 = default(T47);     
            var t48 = default(T48);     
            var t49 = default(T49);     
            var t50 = default(T50);     
            var t51 = default(T51);     
            var t52 = default(T52);     
            var t53 = default(T53);     
            var t54 = default(T54);     
            var t55 = default(T55);     
            var t56 = default(T56);     
            var t57 = default(T57);     
            var t58 = default(T58);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                        t42 = _42;
                        t43 = _43;
                        t44 = _44;
                        t45 = _45;
                        t46 = _46;
                        t47 = _47;
                        t48 = _48;
                        t49 = _49;
                        t50 = _50;
                        t51 = _51;
                        t52 = _52;
                        t53 = _53;
                        t54 = _54;
                        t55 = _55;
                        t56 = _56;
                        t57 = _57;
                        t58 = _58;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41, t42, t43, t44, t45, t46, t47, t48, t49, t50, t51, t52, t53, t54, t55, t56, t57, t58);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53, T54 p54, T55 p55, T56 p56, T57 p57, T58 p58, T59 p59);

        private const ulong _completionMask = 576460752303423487ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     
            var t42 = default(T42);     
            var t43 = default(T43);     
            var t44 = default(T44);     
            var t45 = default(T45);     
            var t46 = default(T46);     
            var t47 = default(T47);     
            var t48 = default(T48);     
            var t49 = default(T49);     
            var t50 = default(T50);     
            var t51 = default(T51);     
            var t52 = default(T52);     
            var t53 = default(T53);     
            var t54 = default(T54);     
            var t55 = default(T55);     
            var t56 = default(T56);     
            var t57 = default(T57);     
            var t58 = default(T58);     
            var t59 = default(T59);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                        t42 = _42;
                        t43 = _43;
                        t44 = _44;
                        t45 = _45;
                        t46 = _46;
                        t47 = _47;
                        t48 = _48;
                        t49 = _49;
                        t50 = _50;
                        t51 = _51;
                        t52 = _52;
                        t53 = _53;
                        t54 = _54;
                        t55 = _55;
                        t56 = _56;
                        t57 = _57;
                        t58 = _58;
                        t59 = _59;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41, t42, t43, t44, t45, t46, t47, t48, t49, t50, t51, t52, t53, t54, t55, t56, t57, t58, t59);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53, T54 p54, T55 p55, T56 p56, T57 p57, T58 p58, T59 p59, T60 p60);

        private const ulong _completionMask = 1152921504606846975ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     
            var t42 = default(T42);     
            var t43 = default(T43);     
            var t44 = default(T44);     
            var t45 = default(T45);     
            var t46 = default(T46);     
            var t47 = default(T47);     
            var t48 = default(T48);     
            var t49 = default(T49);     
            var t50 = default(T50);     
            var t51 = default(T51);     
            var t52 = default(T52);     
            var t53 = default(T53);     
            var t54 = default(T54);     
            var t55 = default(T55);     
            var t56 = default(T56);     
            var t57 = default(T57);     
            var t58 = default(T58);     
            var t59 = default(T59);     
            var t60 = default(T60);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                        t42 = _42;
                        t43 = _43;
                        t44 = _44;
                        t45 = _45;
                        t46 = _46;
                        t47 = _47;
                        t48 = _48;
                        t49 = _49;
                        t50 = _50;
                        t51 = _51;
                        t52 = _52;
                        t53 = _53;
                        t54 = _54;
                        t55 = _55;
                        t56 = _56;
                        t57 = _57;
                        t58 = _58;
                        t59 = _59;
                        t60 = _60;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41, t42, t43, t44, t45, t46, t47, t48, t49, t50, t51, t52, t53, t54, t55, t56, t57, t58, t59, t60);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53, T54 p54, T55 p55, T56 p56, T57 p57, T58 p58, T59 p59, T60 p60, T61 p61);

        private const ulong _completionMask = 2305843009213693951ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     
            var t42 = default(T42);     
            var t43 = default(T43);     
            var t44 = default(T44);     
            var t45 = default(T45);     
            var t46 = default(T46);     
            var t47 = default(T47);     
            var t48 = default(T48);     
            var t49 = default(T49);     
            var t50 = default(T50);     
            var t51 = default(T51);     
            var t52 = default(T52);     
            var t53 = default(T53);     
            var t54 = default(T54);     
            var t55 = default(T55);     
            var t56 = default(T56);     
            var t57 = default(T57);     
            var t58 = default(T58);     
            var t59 = default(T59);     
            var t60 = default(T60);     
            var t61 = default(T61);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                        t42 = _42;
                        t43 = _43;
                        t44 = _44;
                        t45 = _45;
                        t46 = _46;
                        t47 = _47;
                        t48 = _48;
                        t49 = _49;
                        t50 = _50;
                        t51 = _51;
                        t52 = _52;
                        t53 = _53;
                        t54 = _54;
                        t55 = _55;
                        t56 = _56;
                        t57 = _57;
                        t58 = _58;
                        t59 = _59;
                        t60 = _60;
                        t61 = _61;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41, t42, t43, t44, t45, t46, t47, t48, t49, t50, t51, t52, t53, t54, t55, t56, t57, t58, t59, t60, t61);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53, T54 p54, T55 p55, T56 p56, T57 p57, T58 p58, T59 p59, T60 p60, T61 p61, T62 p62);

        private const ulong _completionMask = 4611686018427387903ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     
            var t42 = default(T42);     
            var t43 = default(T43);     
            var t44 = default(T44);     
            var t45 = default(T45);     
            var t46 = default(T46);     
            var t47 = default(T47);     
            var t48 = default(T48);     
            var t49 = default(T49);     
            var t50 = default(T50);     
            var t51 = default(T51);     
            var t52 = default(T52);     
            var t53 = default(T53);     
            var t54 = default(T54);     
            var t55 = default(T55);     
            var t56 = default(T56);     
            var t57 = default(T57);     
            var t58 = default(T58);     
            var t59 = default(T59);     
            var t60 = default(T60);     
            var t61 = default(T61);     
            var t62 = default(T62);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                        t42 = _42;
                        t43 = _43;
                        t44 = _44;
                        t45 = _45;
                        t46 = _46;
                        t47 = _47;
                        t48 = _48;
                        t49 = _49;
                        t50 = _50;
                        t51 = _51;
                        t52 = _52;
                        t53 = _53;
                        t54 = _54;
                        t55 = _55;
                        t56 = _56;
                        t57 = _57;
                        t58 = _58;
                        t59 = _59;
                        t60 = _60;
                        t61 = _61;
                        t62 = _62;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41, t42, t43, t44, t45, t46, t47, t48, t49, t50, t51, t52, t53, t54, t55, t56, t57, t58, t59, t60, t61, t62);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53, T54 p54, T55 p55, T56 p56, T57 p57, T58 p58, T59 p59, T60 p60, T61 p61, T62 p62, T63 p63);

        private const ulong _completionMask = 9223372036854775807ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     
            var t42 = default(T42);     
            var t43 = default(T43);     
            var t44 = default(T44);     
            var t45 = default(T45);     
            var t46 = default(T46);     
            var t47 = default(T47);     
            var t48 = default(T48);     
            var t49 = default(T49);     
            var t50 = default(T50);     
            var t51 = default(T51);     
            var t52 = default(T52);     
            var t53 = default(T53);     
            var t54 = default(T54);     
            var t55 = default(T55);     
            var t56 = default(T56);     
            var t57 = default(T57);     
            var t58 = default(T58);     
            var t59 = default(T59);     
            var t60 = default(T60);     
            var t61 = default(T61);     
            var t62 = default(T62);     
            var t63 = default(T63);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                        t42 = _42;
                        t43 = _43;
                        t44 = _44;
                        t45 = _45;
                        t46 = _46;
                        t47 = _47;
                        t48 = _48;
                        t49 = _49;
                        t50 = _50;
                        t51 = _51;
                        t52 = _52;
                        t53 = _53;
                        t54 = _54;
                        t55 = _55;
                        t56 = _56;
                        t57 = _57;
                        t58 = _58;
                        t59 = _59;
                        t60 = _60;
                        t61 = _61;
                        t62 = _62;
                        t63 = _63;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41, t42, t43, t44, t45, t46, t47, t48, t49, t50, t51, t52, t53, t54, t55, t56, t57, t58, t59, t60, t61, t62, t63);
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

    public sealed class Node<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63, T64>
    {
        public delegate void Action(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12, T13 p13, T14 p14, T15 p15, T16 p16, T17 p17, T18 p18, T19 p19, T20 p20, T21 p21, T22 p22, T23 p23, T24 p24, T25 p25, T26 p26, T27 p27, T28 p28, T29 p29, T30 p30, T31 p31, T32 p32, T33 p33, T34 p34, T35 p35, T36 p36, T37 p37, T38 p38, T39 p39, T40 p40, T41 p41, T42 p42, T43 p43, T44 p44, T45 p45, T46 p46, T47 p47, T48 p48, T49 p49, T50 p50, T51 p51, T52 p52, T53 p53, T54 p54, T55 p55, T56 p56, T57 p57, T58 p58, T59 p59, T60 p60, T61 p61, T62 p62, T63 p63, T64 p64);

        private const ulong _completionMask = 18446744073709551615ul;
#pragma warning disable RECS0092 // Convert field to readonly
        private SpinLock _lock = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
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

            var held = false;
            var shouldCall = false;
            var t1 = default(T1);     
            var t2 = default(T2);     
            var t3 = default(T3);     
            var t4 = default(T4);     
            var t5 = default(T5);     
            var t6 = default(T6);     
            var t7 = default(T7);     
            var t8 = default(T8);     
            var t9 = default(T9);     
            var t10 = default(T10);     
            var t11 = default(T11);     
            var t12 = default(T12);     
            var t13 = default(T13);     
            var t14 = default(T14);     
            var t15 = default(T15);     
            var t16 = default(T16);     
            var t17 = default(T17);     
            var t18 = default(T18);     
            var t19 = default(T19);     
            var t20 = default(T20);     
            var t21 = default(T21);     
            var t22 = default(T22);     
            var t23 = default(T23);     
            var t24 = default(T24);     
            var t25 = default(T25);     
            var t26 = default(T26);     
            var t27 = default(T27);     
            var t28 = default(T28);     
            var t29 = default(T29);     
            var t30 = default(T30);     
            var t31 = default(T31);     
            var t32 = default(T32);     
            var t33 = default(T33);     
            var t34 = default(T34);     
            var t35 = default(T35);     
            var t36 = default(T36);     
            var t37 = default(T37);     
            var t38 = default(T38);     
            var t39 = default(T39);     
            var t40 = default(T40);     
            var t41 = default(T41);     
            var t42 = default(T42);     
            var t43 = default(T43);     
            var t44 = default(T44);     
            var t45 = default(T45);     
            var t46 = default(T46);     
            var t47 = default(T47);     
            var t48 = default(T48);     
            var t49 = default(T49);     
            var t50 = default(T50);     
            var t51 = default(T51);     
            var t52 = default(T52);     
            var t53 = default(T53);     
            var t54 = default(T54);     
            var t55 = default(T55);     
            var t56 = default(T56);     
            var t57 = default(T57);     
            var t58 = default(T58);     
            var t59 = default(T59);     
            var t60 = default(T60);     
            var t61 = default(T61);     
            var t62 = default(T62);     
            var t63 = default(T63);     
            var t64 = default(T64);     

            try
            {
                _lock.Enter(ref held);

                _filled |= value;

                if (_filled == _completionMask)
                {
                    _filled = 0;

                    shouldCall = true;
                        t1 = _1;
                        t2 = _2;
                        t3 = _3;
                        t4 = _4;
                        t5 = _5;
                        t6 = _6;
                        t7 = _7;
                        t8 = _8;
                        t9 = _9;
                        t10 = _10;
                        t11 = _11;
                        t12 = _12;
                        t13 = _13;
                        t14 = _14;
                        t15 = _15;
                        t16 = _16;
                        t17 = _17;
                        t18 = _18;
                        t19 = _19;
                        t20 = _20;
                        t21 = _21;
                        t22 = _22;
                        t23 = _23;
                        t24 = _24;
                        t25 = _25;
                        t26 = _26;
                        t27 = _27;
                        t28 = _28;
                        t29 = _29;
                        t30 = _30;
                        t31 = _31;
                        t32 = _32;
                        t33 = _33;
                        t34 = _34;
                        t35 = _35;
                        t36 = _36;
                        t37 = _37;
                        t38 = _38;
                        t39 = _39;
                        t40 = _40;
                        t41 = _41;
                        t42 = _42;
                        t43 = _43;
                        t44 = _44;
                        t45 = _45;
                        t46 = _46;
                        t47 = _47;
                        t48 = _48;
                        t49 = _49;
                        t50 = _50;
                        t51 = _51;
                        t52 = _52;
                        t53 = _53;
                        t54 = _54;
                        t55 = _55;
                        t56 = _56;
                        t57 = _57;
                        t58 = _58;
                        t59 = _59;
                        t60 = _60;
                        t61 = _61;
                        t62 = _62;
                        t63 = _63;
                        t64 = _64;
                    }
            }
            finally
            {
                if (held)
                    _lock.Exit(false);
            }

            if (shouldCall)
                _action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32, t33, t34, t35, t36, t37, t38, t39, t40, t41, t42, t43, t44, t45, t46, t47, t48, t49, t50, t51, t52, t53, t54, t55, t56, t57, t58, t59, t60, t61, t62, t63, t64);
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