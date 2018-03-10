using System;
using BenchmarkDotNet.Running;

namespace dataprocessor.benchmarks
{
    class Program
    {
        public static void Main(string[] args)
        {
            var switcher = new BenchmarkSwitcher(new[]
            {
                typeof(TwoIn_OneOut_ChainedProcessors),
                typeof(OneIn_OneOut_ChainedProcessors),
                typeof(OneIn_OneOut_NoProcessor),
                typeof(OneIn_OneOut_SimpleProcessor)
            });
            switcher.Run(args);
        }
    }
}
