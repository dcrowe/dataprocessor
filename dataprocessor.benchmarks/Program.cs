using System;
using BenchmarkDotNet.Running;

namespace dataprocessor.benchmarks
{
    class Program
    {
        public static void Main(string[] args)
        {
            var types = Benchmarks.FindBenchmarks();
            var switcher = new BenchmarkSwitcher(types);
            switcher.Run(args);
        }
    }
}
