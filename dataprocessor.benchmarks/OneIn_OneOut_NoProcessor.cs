using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using NUnit.Framework;
using dataprocessor;
using dataprocessor.Old;
using dataprocessor.benchmarks.Utilities;

namespace dataprocessor.benchmarks
{
    [ShortRunJob, MemoryDiagnoser, Category("Benchmarks")]
    public class OneIn_OneOut_NoProcessor
    {
        [Test]
        public void Benchmark() 
        {
            Environment.CurrentDirectory = TestContext.CurrentContext.TestDirectory;
            var r = BenchmarkRunner.Run<OneIn_OneOut_NoProcessor>();
            Assert.IsEmpty(r.ValidationErrors);
        }

        [Params(1000)]
        public int RunLength;

        Writer<int> _naive;
        Writer<int> _draft2;
        Writer<int> _optimal;

        [Benchmark(Baseline = true)]
        public void Optimal() => Run(_optimal, RunLength);
        [Benchmark]
        public void Naive() => Run(_naive, RunLength);
        [Benchmark]
        public void Draft2() => Run(_draft2, RunLength);

        [GlobalSetup]
        public void GlobalSetup()
        {
            _naive = Setup(new NaiveDataProcessor());
            _draft2 = Setup(new DataProcessorBuilder());

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

        static void DoNothing(int _) { }
    }
}
