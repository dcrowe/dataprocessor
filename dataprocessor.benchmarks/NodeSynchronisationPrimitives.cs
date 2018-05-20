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
		[Params(1000)]
		public int RunLength = 10000;

		[Params(true, false)]
		public bool IsSynchronous;

		readonly object _obj = new object();
		volatile int _count;
		int _bob = 0;

		readonly List<Thread> _threads = new List<Thread>();
		INode2<int, int> _unlocked;
		INode2<int, int> _lock;
		INode2<int, int> _monitor;
		INode2<int, int> _semaphoreSlim;
		INode2<int, int> _spinLock;

		[GlobalSetup]
		[NUnit.Framework.SetUp]
		public void GlobalSetup()
		{
			_count = 0;
			_unlocked = new Node<int, int>(PostTriggerAction);
			_lock = new LockNode<int, int>(PostTriggerAction);
			_monitor = new MonitorNode<int, int>(PostTriggerAction);
			_semaphoreSlim = new SemaphoreSlimNode<int, int>(PostTriggerAction);
			_spinLock = new SpinLockNode<int, int>(PostTriggerAction);
		}

		[IterationCleanup]
		public void TearDown()
		{
			foreach (var t in _threads)
				t.Abort();
			_threads.Clear();
		}

		void PostTriggerAction(int a, int b)
		{
			if (IsSynchronous)
				_count++;
			else
			    Interlocked.Increment(ref _count);

            // need to do "something" to prevent the results being optimised away
			_bob = a + b;
		}

		void Run(INode2<int, int> node)
		{
			_count = 0;

			if (IsSynchronous)
			{
				var i = 0;
				while (_count < RunLength)
				{
					node.Set1(i++);
					node.Set2(i++);
				}
			}
			else
			{
				var t = new Thread(() =>
				{
					try
					{
						var i = 0;
						while (true)
						{
							node.Set1(i++);
                            Thread.Yield();
						}
					}
					catch (ThreadAbortException)
					{
					}
					catch (Exception ex)
					{
						Console.Out.WriteLine("Exception in Run() : " + ex);
					}
				});
				t.Start();
				_threads.Add(t);

				var j = 0;
				while (_count < RunLength)
				{
					node.Set2(j++);
					Thread.Yield();
				}
			}
		}

		//[Benchmark]
		public void Unlocked() => Run(_unlocked);

		//[Benchmark(Baseline = true)]
		public void Lock() => Run(_lock);

		//[Benchmark]
		public void Monitor() => Run(_monitor);

		//[Benchmark]
		public void SemaphoreSlim() => Run(_semaphoreSlim);

		//[Benchmark]
		public void SpinLock() => Run(_spinLock);

		public interface INode2<T1, T2> 
		{
			void Set1(T1 v);
			void Set2(T2 v);
		}

        public class Node<T1, T2> : INode2<T1, T2>
        {
            readonly Action<T1, T2> _a;
            T1 _1;
            T2 _2;
            ulong _f;

            public Node(Action<T1, T2> a) { _a = a; }
            public void Set1(T1 v1) { _1 = v1; MaybeCallAndReset(1); }
            public void Set2(T2 v2) { _2 = v2; MaybeCallAndReset(2); }

            void MaybeCallAndReset(ulong value)
            {
                T1 tmp1 = default(T1);
                T2 tmp2 = default(T2);
                bool call = false;

                _f |= value;

                if (_f == 3)
                {
                    _f = 0;

                    tmp1 = _1;
                    tmp2 = _2;
                    call = true;
                }

                if (call)
                    _a(tmp1, tmp2);
            }
        }

		class LockNode<T1, T2> : INode2<T1, T2>
        {
            readonly object _l = new object();
            readonly Action<T1, T2> _a;
            T1 _1;
            T2 _2;
            ulong _f;

            public LockNode(Action<T1, T2> a) { _a = a; }
            public void Set1(T1 v1) { _1 = v1; MaybeCallAndReset(1); }
            public void Set2(T2 v2) { _2 = v2; MaybeCallAndReset(2); }

            void MaybeCallAndReset(ulong value)
            {
				T1 tmp1 = default(T1);
				T2 tmp2 = default(T2);
				bool call = false;

                lock(_l)
				{
					_f |= value;

					if (_f == 3)
                    {
                        _f = 0;

                        tmp1 = _1;
                        tmp2 = _2;
						call = true;
                    }
                }

				if (call)
                    _a(tmp1, tmp2);
            }
        }

		class MonitorNode<T1, T2> : INode2<T1, T2>
        {
            readonly object _l = new object();
            readonly Action<T1, T2> _a;
            T1 _1;
            T2 _2;
            ulong _f;

            public MonitorNode(Action<T1, T2> a) { _a = a; }
            public void Set1(T1 v1) { _1 = v1; MaybeCallAndReset(1); }
            public void Set2(T2 v2) { _2 = v2; MaybeCallAndReset(2); }

            void MaybeCallAndReset(ulong value)
			{
                T1 tmp1 = default(T1);
                T2 tmp2 = default(T2);
                bool call = false;

                bool held = false;

                try
                {
					System.Threading.Monitor.Enter(_l, ref held);

                    _f |= value;

                    if (_f == 3)
                    {
						_f = 0;

                        tmp1 = _1;
                        tmp2 = _2;
                        call = true;
                    }
                }
                finally
                {
                    if (held)
						System.Threading.Monitor.Exit(_l);
                }

				if (call)
                    _a(tmp1, tmp2);
            }
        }

		class SemaphoreSlimNode<T1, T2> : INode2<T1, T2>
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
                T1 tmp1 = default(T1);
                T2 tmp2 = default(T2);
                bool call = false;

                try
                {
                    _l.Wait();

                    _f |= value;

                    if (_f == 3)
                    {
						_f = 0;

                        tmp1 = _1;
                        tmp2 = _2;
                        call = true;
                    }
                }
                finally
                {
                    _l.Release();
				}

                if (call)
                    _a(tmp1, tmp2);
            }
        }

		class SpinLockNode<T1, T2> : INode2<T1, T2>
        {
            readonly Action<T1, T2> _a;
#pragma warning disable RECS0092 // Convert field to readonly
			SpinLock _l = new SpinLock(false);
#pragma warning restore RECS0092 // Convert field to readonly
			T1 _1;
            T2 _2;
            ulong _f;

            public SpinLockNode(Action<T1, T2> a) { _a = a; }
            public void Set1(T1 v1) { _1 = v1; MaybeCallAndReset(1); }
            public void Set2(T2 v2) { _2 = v2; MaybeCallAndReset(2); }

            void MaybeCallAndReset(ulong value)
			{
                T1 tmp1 = default(T1);
                T2 tmp2 = default(T2);
                bool call = false;

                bool held = false;
                try
                {
                    _l.Enter(ref held);

                    _f |= value;

                    if (_f == 3)
                    {
						_f = 0;

                        tmp1 = _1;
                        tmp2 = _2;
                        call = true;
                    }
                }
                finally
                {
					if (held)
						_l.Exit(false);
				}

                if (call)
                    _a(tmp1, tmp2);
            }
        }
    }
}
