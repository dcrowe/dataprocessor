using System;
using System.Linq.Expressions;
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

        Action<int> _optimal;
        Action<int> _naive;
        Action<int> _draft1;
        Action<int> _draft2;
        Action<int> _preferredCurrentTechnique;

        [GlobalSetup]
        public void GlobalSetup()
        {
            _naive = Setup(new NaiveDataProcessor()).Send;
            _draft1 = Setup(new Draft1DataProcessor()).Send;
            _draft2 = Setup(new Draft2DataProcessor()).Send;

            var p = Expression.Parameter(typeof(int), "p");
            var expr1 = Expression.Lambda<Action<int>>(
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
            var expr2 = Expression.Lambda<Action<int>>(
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
            _preferredCurrentTechnique = new ActionWriter<int>(expr2.Compile()).Send;

            _optimal = i =>
            {
                var tmp1 = Plus1(i);
                var tmp2 = Plus2(i);
                DoNothing(tmp1 + tmp2);
            };
        }

        [Benchmark]
        public void Optimal() => Run(_optimal, RunLength);

        [Benchmark(Baseline = true)]
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
            b.AddProcessor<int, int>("in", "tmp1", Plus1);
            b.AddProcessor<int, int>("in", "tmp2", Plus2);
            b.AddProcessor<int, int, int>("tmp1", "tmp2", "out", Add);
            b.AddListener<int>("out", DoNothing);

            b.Build();

            return w;
        }

        static void Run(Action<int> w, int runLength)
        {
            while (runLength-- > 0)
            {
                w(runLength);
            }
        }

        static int Plus1(int i) => i + 1;
        static int Plus2(int i) => i + 2;
        static int Add(int i, int j) => i + j;
        static void DoNothing(int _) { }
    }
}
