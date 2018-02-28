using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using NUnit.Framework;
using dataprocessor;
using dataprocessor.tests.Utilities;

namespace dataprocessor.tests.benchmarks
{
    [ShortRunJob, MemoryDiagnoser, Category("Benchmarks"), Explicit]
    public class OneIn_OneOut_ChainedProcessors
    {
        [Test]
        public void Benchmark()
        {
            Environment.CurrentDirectory = TestContext.CurrentContext.TestDirectory;
            var r = BenchmarkRunner.Run<OneIn_OneOut_ChainedProcessors>();
            Assert.IsEmpty(r.ValidationErrors);
        }

        [Params(100)]
        public int RunLength;

        IWriter<int> _naive;
        IWriter<int> _draft1;
        IWriter<int> _draft2;
        IWriter<int> _preferredCurrentTechnique;

        [GlobalSetup]
        public void GlobalSetup()
        {
            _naive = Setup(new NaiveDataProcessor());
            _draft1 = Setup(new Draft1DataProcessor());
            _draft2 = Setup(new Draft2DataProcessor());

            var p = Expression.Parameter(typeof(int), "p");
            var expr = Expression.Lambda<Action<int>>(
                Expression.Invoke(
                    Expression.Constant((Action<int>)DoNothing),
                    Expression.Add(
                        Expression.Invoke(
                            Expression.Constant((Func<int, int>)Plus1),
                            p),
                        Expression.Invoke(
                            Expression.Constant((Func<int, int>)Plus2),
                            p))),
                p);
            _preferredCurrentTechnique = new ActionWriter<int>(expr.Compile());
        }

        [Benchmark(Baseline = true)]
        public void Optimal()
        {
            var runLength = RunLength;
            while (runLength-- > 0)
            {
                var tmp1 = Plus1(runLength);
                var tmp2 = Plus2(runLength);
                DoNothing(tmp1 + tmp2);
            }
        }

        [Benchmark]
        public void PreferredTechinque() => Run(_preferredCurrentTechnique, RunLength);

        [Benchmark]
        public void Naive() => Run(_naive, RunLength);

        [Benchmark]
        public void Draft1() => Run(_draft1, RunLength);

        [Benchmark]
        public void Draft2() => Run(_draft2, RunLength);

        static IWriter<int> Setup(IDataProcessorBuilder b)
        {
            var w = b.AddInput<int>("in");
            b.AddProcessor<int, int>("in", "tmp1", (int i) => Plus1(i));
            b.AddProcessor<int, int>("in", "tmp2", (int i) => Plus2(i));
            b.AddProcessor(new[] { "tmp1", "tmp2" }, "out",
                           (Expression<Func<int, int, int>>)((int tmp1, int tmp2) => tmp1 + tmp2));
            b.AddListener<int>("out", DoNothing);

            b.Build();

            return w;
        }

        static void Run(IWriter<int> w, int runLength)
        {
            while (runLength-- > 0)
            {
                w.Send(runLength);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        static int Plus1(int i)
        {
            return i + 1;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        static int Plus2(int i)
        {
            return i + 1;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        static void DoNothing(int _)
        {

        }
    }
}
