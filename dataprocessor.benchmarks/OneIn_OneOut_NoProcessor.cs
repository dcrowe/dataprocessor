using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using dataprocessor.Compilers;
using dataprocessor.Old;
using dataprocessor.benchmarks.Utilities;

namespace dataprocessor.benchmarks
{
    [MemoryDiagnoser]
    public class OneIn_OneOut_NoProcessor
    {
        [Params(100)]
        public int RunLength;

        Writer<int> _naive;
        Writer<int> _actual;
        Writer<int> _optimal;

        [Benchmark(Baseline = true)]
        public void Optimal() => Run(_optimal, RunLength);
        [Benchmark]
        public void Naive() => Run(_naive, RunLength);
        [Benchmark]
        public void Actual() => Run(_actual, RunLength);

        [GlobalSetup]
        public void GlobalSetup()
        {
            _naive = Setup(new NaiveDataProcessor());
            _actual = Setup(new DataProcessorBuilder(new MethodBuilderCompiler()));
            _optimal = new ActionWriter<int>(b => DoNothing(b));
        }

        static Writer<int> Setup(IDataProcessorBuilder b)
        {
            b.AddListener<int>("b", DoNothing);
            var w = b.AddInput<int>("b");
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

        public static void DoNothing(int _) { }
    }
}
