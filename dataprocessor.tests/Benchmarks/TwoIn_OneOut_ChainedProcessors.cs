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
    public class TwoIn_OneOut_ChainedProcessors
    {
        [Test]
        public void Benchmark()
        {
            Environment.CurrentDirectory = TestContext.CurrentContext.TestDirectory;
            var r = BenchmarkRunner.Run<TwoIn_OneOut_ChainedProcessors>();
            Assert.IsEmpty(r.ValidationErrors);
        }

        [Params(1)]
        public int RunLength;

        Tuple<Writer<int>, Writer<int>> _optimal;
        Tuple<Writer<int>, Writer<int>> _naive;
        Tuple<Writer<int>, Writer<int>> _draft1;
        Tuple<Writer<int>, Writer<int>> _draft2;

        [GlobalSetup]
        public void GlobalSetup()
        {
            _naive = Setup(new NaiveDataProcessor());
            _draft1 = Setup(new Draft1DataProcessor());
            _draft2 = Setup(new DataProcessorBuilder());

            var n = new Node<int, int>((a, b) => DoNothing(Add(a, b)));
            _optimal = Tuple.Create<Writer<int>, Writer<int>>(
                new ActionWriter<int>(a => n.Set1(Plus1(a))),
                new ActionWriter<int>(b => n.Set2(Plus2(b))));
        }

        [Benchmark(Baseline = true)]
        public void Optimal() => Run(_optimal, RunLength);
        [Benchmark]
        public void Naive() => Run(_naive, RunLength);
        [Benchmark]
        public void Draft1() => Run(_draft1, RunLength);
        [Benchmark]
        public void Draft2() => Run(_draft2, RunLength);

        static Tuple<Writer<int>, Writer<int>> Setup(IDataProcessorBuilder b)
        {
            var w1 = b.AddInput<int>("in1");
            var w2 = b.AddInput<int>("in2");
            b.AddProcessor<int, int>("in1", "tmp1", Plus1);
            b.AddProcessor<int, int>("in2", "tmp2", Plus2);
            b.AddProcessor<int, int, int>("tmp1", "tmp2", "out", Add);
            b.AddListener<int>("out", DoNothing);
            b.Build();

            return Tuple.Create(w1, w2);
        }

        static void Run(Tuple<Writer<int>, Writer<int>> w, int runLength)
        {
            while (runLength-- > 0)
            {
                w.Item1.Send(runLength);
                w.Item2.Send(runLength);
            }
        }

        static int Plus1(int i) => i + 1;
        static int Plus2(int i) => i + 2;
        static int Add(int i, int j) => i + j;
        static void DoNothing(int _) { }
    }
}
