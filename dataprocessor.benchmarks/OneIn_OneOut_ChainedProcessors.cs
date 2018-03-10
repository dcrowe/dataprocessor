using System;
using System.Linq.Expressions;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using NUnit.Framework;
using dataprocessor.Old;
using dataprocessor.benchmarks.Utilities;

namespace dataprocessor.benchmarks
{
    [MemoryDiagnoser]
    public class OneIn_OneOut_ChainedProcessors
    {
        [Params(100)]
        public int RunLength;

        Writer<int> _optimal;
        Writer<int> _naive;
        Writer<int> _actual;
        Writer<int> _preferredCurrentTechnique;

        [GlobalSetup]
        public void GlobalSetup()
        {
            _naive = Setup(new NaiveDataProcessor());
            _actual = Setup(new DataProcessorBuilder());

            var p = Expression.Parameter(typeof(int), "p");
            var expr = Expression.Lambda<Action<int>>(
                Expression.Call(
                    typeof(OneIn_OneOut_ChainedProcessors),
                    "DoNothing",
                    null,
                    Expression.Add(
                        Expression.Call(
                            typeof(OneIn_OneOut_ChainedProcessors),
                            "Plus1",
                            null,
                            p),
                        Expression.Call(
                            typeof(OneIn_OneOut_ChainedProcessors),
                            "Plus2",
                            null,
                            p))),
                p);
            _preferredCurrentTechnique = new ActionWriter<int>(expr.Compile());

            _optimal = new ActionWriter<int>(i =>
            {
                var tmp1 = Plus1(i);
                var tmp2 = Plus2(i);
                DoNothing(tmp1 + tmp2);
            });
        }

        [Benchmark]
        public void Optimal() => Run(_optimal, RunLength);

        [Benchmark(Baseline = true)]
        public void PreferredTechinque() => Run(_preferredCurrentTechnique, RunLength);

        [Benchmark]
        public void Naive() => Run(_naive, RunLength);

        [Benchmark]
        public void Actual() => Run(_actual, RunLength);

        static Writer<int> Setup(IDataProcessorBuilder b)
        {
            var w = b.AddInput<int>("in");
            b.AddProcessor<int, int>("in", "tmp1", Plus1);
            b.AddProcessor<int, int>("in", "tmp2", Plus2);
            b.AddProcessor<int, int, int>("tmp1", "tmp2", "out", Add);
            b.AddListener<int>("out", DoNothing);
            b.Build();

            return w;
        }

        static void Run(Writer<int> w, int runLength)
        {
            while (runLength-- > 0)
            {
                w.Send(runLength);
            }
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        static int Plus1(int i) => i + 1;
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        static int Plus2(int i) => i + 2;
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        static int Add(int i, int j) => i + j;
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        static void DoNothing(int _) { }
    }
}
