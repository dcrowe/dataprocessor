using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using NUnit.Framework;
using dataprocessor;

namespace dataprocessor.tests.benchmarks
{
    [ShortRunJob, MemoryDiagnoser, Category("Benchmarks"), Explicit]
    public class OneIn_OneOut_SimpleProcessor
    {
        [Test]
        public void Benchmark()
        {
            Environment.CurrentDirectory = TestContext.CurrentContext.TestDirectory;
            var r = BenchmarkRunner.Run<OneIn_OneOut_SimpleProcessor>();
            Assert.IsEmpty(r.ValidationErrors);
        }

        [Params(100)]
        public int RunLength;

        IWriter<int> _naive;
        IWriter<int> _draft1;
        IWriter<int> _draft2;
        Action<int> _preferredCurrentTechnique;

        [GlobalSetup]
        public void GlobalSetup()
        {
            _naive = Setup(new NaiveDataProcessor());
            _draft1 = Setup(new Draft1DataProcessor());
            _draft2 = Setup(new Draft2DataProcessor());

            var p = Expression.Parameter(typeof(int), "p");
            _preferredCurrentTechnique = Expression
                .Lambda<Action<int>>(
                    Expression.Invoke(
                        Expression.Constant((Action<int>)DoNothing),
                        p),
                    p)
                .Compile();
        }

        [Benchmark(Baseline = true)]
        public void Optimal()
        {
            var runLength = RunLength;
            while (runLength-- > 0)
            {
                DoNothing(Plus1(runLength));
            }
        }

        [Benchmark]
        public void PreferredTechinque()
        {
            var runLength = RunLength;
            while (runLength-- > 0)
            {
                _preferredCurrentTechnique(runLength);
            }
        }

        [Benchmark]
        public void Naive() => Run(_naive, RunLength);

        [Benchmark]
        public void Draft1() => Run(_draft1, RunLength);

        [Benchmark]
        public void Draft2() => Run(_draft2, RunLength);

        static IWriter<int> Setup(IDataProcessorBuilder b)
        {
            var w = b.AddInput<int>("in");
            b.AddProcessor<int, int>("in", "out", Plus1);
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
        static void DoNothing(int _)
        {

        }
    }
}
