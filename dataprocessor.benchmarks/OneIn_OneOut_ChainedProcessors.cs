using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using dataprocessor.Compilers;
using dataprocessor.benchmarks.Utilities;

namespace dataprocessor.benchmarks
{
    [MemoryDiagnoser]
    public class OneIn_OneOut_ChainedProcessors
    {
        [Params(100)]
        public int RunLength;

        Writer<int> _optimal;
        Writer<int> _actualDynamicMethod;
        Writer<int> _actual;

        [GlobalSetup]
        public void GlobalSetup()
        {
            _actualDynamicMethod = Setup(new DataProcessorBuilder());
            _actual = Setup(new DataProcessorBuilder(new MethodBuilderCompiler()));
            
            _optimal = new ActionWriter<int>(i =>
            {
                var tmp1 = Plus1(i);
                var tmp2 = Plus2(i);
                DoNothing(tmp1 + tmp2);
            });
        }

        [Benchmark(Baseline = true)]
        public void Optimal() => Run(_optimal, RunLength);

        [Benchmark]
        public void ActualDynamicMethod() => Run(_actualDynamicMethod, RunLength);

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

        public static int Plus1(int i) => i + 1;
        public static int Plus2(int i) => i + 2;
        public static int Add(int i, int j) => i + j;
        public static void DoNothing(int _) { }
    }
}
