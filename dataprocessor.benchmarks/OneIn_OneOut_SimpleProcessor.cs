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

        Writer<int> _naive;
        Writer<int> _draft2;
        Writer<int> _optimal;

        [GlobalSetup]
        public void GlobalSetup()
        {
            _naive = Setup(new NaiveDataProcessor());
            _draft2 = Setup(new DataProcessorBuilder());
            _optimal = new ActionWriter<int>(i => DoNothing(Plus1(i)));
        }

        [Benchmark(Baseline = true)]
        public void Optimal() => Run(_optimal, RunLength);
        [Benchmark]
        public void Naive() => Run(_naive, RunLength);
        [Benchmark]
        public void Draft2() => Run(_draft2, RunLength);

        static Writer<int> Setup(IDataProcessorBuilder b)
        {
            var w = b.AddInput<int>("in");
            b.AddProcessor<int, int>("in", "out", Plus1);
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

        static int Plus1(int i) => i + 1;
        static void DoNothing(int _) { }
    }
}
