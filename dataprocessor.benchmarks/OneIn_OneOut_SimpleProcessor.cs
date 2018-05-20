using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using dataprocessor.Compilers;
using dataprocessor.benchmarks.Utilities;

namespace dataprocessor.benchmarks
{
    [MemoryDiagnoser]
    public class OneIn_OneOut_SimpleProcessor
    {
        [Params(100)]
        public int RunLength;
  
        Writer<int> _actual;
        Writer<int> _optimal;

        [GlobalSetup]
        public void GlobalSetup()
        {
            _actual = Setup(new DataProcessorBuilder(new MethodBuilderCompiler()));
            _optimal = new ActionWriter<int>(i => DoNothing(Plus1(i)));
        }

        [Benchmark(Baseline = true)]
        public void Optimal() => Run(_optimal, RunLength);
        [Benchmark]
        public void Actual() => Run(_actual, RunLength);

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

        public static int Plus1(int i) => i + 1;
        public static void DoNothing(int _) { }
    }
}
