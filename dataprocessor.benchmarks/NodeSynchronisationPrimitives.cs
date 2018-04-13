using System;
using System.Collections.Generic;
using System.Threading;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;

namespace dataprocessor.benchmarks
{
    [MemoryDiagnoser, ShortRunJob]
    public class NodeSynchronisationPrimitives
    {
        [Params(100)]
        public int RunLength = 10000;

        readonly object _obj = new object();
        volatile int _count;

        void PostTriggerAction(int a, object b)
        {
            _count++;
        }

        readonly List<Thread> _threads = new List<Thread>();
        Node<int, object> _unlocked;
        Locked1Node<int, object> _locked1;
        Locked2Node<int, object> _locked2;
        SemaphoreSlimNode<int, object> _semaphoreSlim;
        SpinLockNode<int, object> _spinLock;

        [GlobalSetup]
        [NUnit.Framework.SetUp]
        public void GlobalSetup()
        {
            _count = 0;
            _unlocked = new Node<int, object>(PostTriggerAction);
            _locked1 = new Locked1Node<int, object>(PostTriggerAction);
            _locked2 = new Locked2Node<int, object>(PostTriggerAction);
            _semaphoreSlim = new SemaphoreSlimNode<int, object>(PostTriggerAction);
            _spinLock = new SpinLockNode<int, object>(PostTriggerAction);
        }

        [IterationCleanup]
        [NUnit.Framework.TearDown]
        public void TearDown()
        {
            foreach (var t in _threads)
                t.Abort();
            _threads.Clear();
        }

        void Run(Action a)
        {
            var t = new Thread(() =>
            {
                while (true)
                    a();
            });

            t.IsBackground = true;
            t.Start();
            _threads.Add(t);
        }

        [Benchmark]
        [NUnit.Framework.Test]
        public void Unlocked() 
        {
            _count = 0;
            while (_count < RunLength)
            {
                _unlocked.Set1(1);
                _unlocked.Set2(_obj);
            }
            _count = 0;
            using (Timer.Step("Run"))
            while (_count < RunLength) 
            {
                _unlocked.Set1(1);
                _unlocked.Set2(_obj);
            }
        }

        [Benchmark(Baseline = true)]
        [NUnit.Framework.Test]
        public void Locked1()
        {
            Run(() => _locked1.Set1(1));
            Run(() => _locked1.Set2(_obj));

            _count = 0;
            while (_count < RunLength) { }
            _count = 0;
            using (Timer.Step("Run"))
                while (_count < RunLength) { }
        }

        [Benchmark]
        [NUnit.Framework.Test]
        public void Locked2()
        {
            Run(() => _locked2.Set1(1));
            Run(() => _locked2.Set2(_obj));

            _count = 0;
            while (_count < RunLength) { }
            _count = 0;
            using (Timer.Step("Run"))
                while (_count < RunLength) { }
        }

        //[Benchmark]
        [NUnit.Framework.Test]
        public void SemaphoreSlim()
        {
            Run(() => _semaphoreSlim.Set1(1));
            Run(() => _semaphoreSlim.Set2(_obj));

            _count = 0;
            while (_count < RunLength) { }
            _count = 0;
            using (Timer.Step("Run"))
                while (_count < RunLength) { }
        }

        [Benchmark]
        [NUnit.Framework.Test]
        public void SpinLock()
        {
            Run(() => _spinLock.Set1(1));
            Run(() => _spinLock.Set2(_obj));

            _count = 0;
            while (_count < RunLength) { }
            _count = 0;
            using (Timer.Step("Run"))
                while (_count < RunLength) { }
        }

        class Locked1Node<T1, T2>
        {
            readonly object _l = new object();
            readonly Action<T1, T2> _a;
            T1 _1;
            T2 _2;
            ulong _f;

            public Locked1Node(Action<T1, T2> a) { _a = a; }
            public void Set1(T1 v1) { _1 = v1; MaybeCallAndReset(1); }
            public void Set2(T2 v2) { _2 = v2; MaybeCallAndReset(2); }

            void MaybeCallAndReset(ulong value)
            {
                lock(_l)
                {
                    var old = _f;
                    _f |= value;

                    if (old != 3 && _f == 3)
                    {
                        _f = 0;

                        var tmp1 = _1;
                        var tmp2 = _2;
                        _a(_1, _2);
                    }
                }
            }
        }

        class Locked2Node<T1, T2>
        {
            readonly object _l = new object();
            readonly Action<T1, T2> _a;
            T1 _1;
            T2 _2;
            ulong _f;

            public Locked2Node(Action<T1, T2> a) { _a = a; }
            public void Set1(T1 v1) { _1 = v1; MaybeCallAndReset(1); }
            public void Set2(T2 v2) { _2 = v2; MaybeCallAndReset(2); }

            void MaybeCallAndReset(ulong value)
            {
                bool held = false;

                try
                {
                    Monitor.Enter(_l, ref held);

                    var old = _f;
                    _f |= value;

                    if (old != 3 && _f == 3)
                    {
                        _f = 0;
                        var tmp1 = _1;
                        var tmp2 = _2;

                        Monitor.Exit(_l);
                        held = false;

                        _a(tmp1, tmp2);
                    }
                }
                finally
                {
                    if (held)
                        Monitor.Exit(_l);
                }
            }
        }

        class SemaphoreSlimNode<T1, T2>
        {
            readonly SemaphoreSlim _l = new SemaphoreSlim(1);
            readonly Action<T1, T2> _a;
            T1 _1;
            T2 _2;
            ulong _f;

            public SemaphoreSlimNode(Action<T1, T2> a) { _a = a; }
            public void Set1(T1 v1) { _1 = v1; MaybeCallAndReset(1); }
            public void Set2(T2 v2) { _2 = v2; MaybeCallAndReset(2); }

            void MaybeCallAndReset(ulong value)
            {
                try
                {
                    _l.Wait();

                    var old = _f;
                    _f |= value;

                    if (old != 3 && _f == 3)
                    {
                        _f = 0;
                        _a(_1, _2);
                    }
                }
                finally
                {
                    _l.Release();
                }
            }
        }

        class SpinLockNode<T1, T2>
        {
            readonly Action<T1, T2> _a;
            SpinLock _l = new SpinLock(false);
            T1 _1;
            T2 _2;
            ulong _f;

            public SpinLockNode(Action<T1, T2> a) { _a = a; }
            public void Set1(T1 v1) { _1 = v1; MaybeCallAndReset(1); }
            public void Set2(T2 v2) { _2 = v2; MaybeCallAndReset(2); }

            void MaybeCallAndReset(ulong value)
            {
                bool held = false;
                try
                {
                    _l.Enter(ref held);

                    var old = _f;
                    _f |= value;

                    if (old != 3 && _f == 3)
                    {
                        _f = 0;
                        var tmp1 = _1;
                        var tmp2 = _2;

                        _l.Exit();
                        held = false;

                        _a(tmp1, tmp2);
                    }
                }
                finally
                {
                    if (held) _l.Exit();
                }
            }
        }
    }
}
