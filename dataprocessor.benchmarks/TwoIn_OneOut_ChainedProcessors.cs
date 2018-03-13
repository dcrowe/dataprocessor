using System;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using dataprocessor.Old;
using dataprocessor.benchmarks.Utilities;
using dataprocessor.Compilers;

namespace dataprocessor.benchmarks
{
    [MemoryDiagnoser]
    public class TwoIn_OneOut_ChainedProcessors
    {
        [Params(100)]
        public int RunLength;

        Tuple<Writer<int>, Writer<int>> _optimal;
        Tuple<Writer<int>, Writer<int>> _naive;
        Tuple<Writer<int>, Writer<int>> _actual;

        [GlobalSetup]
        public void GlobalSetup()
        {
            _naive = Setup(new NaiveDataProcessor());
            _actual = Setup(new DataProcessorBuilder(new MethodBuilderCompiler()));

            var n = new Node<int, int>((a, b) => DoNothing(a + b));
            _optimal = Tuple.Create<Writer<int>, Writer<int>>(
                new ActionWriter<int>(a => n.Set1(a + 1)),
                new ActionWriter<int>(b => n.Set2(b + 2)));
        }

        [Benchmark(Baseline = true)]
        public void Optimal() => Run(_optimal, RunLength);
        [Benchmark]
        public void Naive() => Run(_naive, RunLength);
        [Benchmark]
        public void Actual() => Run(_actual, RunLength);

        static Tuple<Writer<int>, Writer<int>> Setup(IDataProcessorBuilder b)
        {
            var w1 = b.AddInput<int>("in1");
            var w2 = b.AddInput<int>("in2");
            b.AddProcessorExpression<int, int>("in1", "tmp1", i => i + 1);
            b.AddProcessorExpression<int, int>("in2", "tmp2", i => i + 2);
            b.AddProcessorExpression<int, int, int>("tmp1", "tmp2", "out", (i, j) => i + j);
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

        public static void DoNothing(int _) { }
    }
}
