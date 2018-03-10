using System;
using System.Linq;
using System.Reflection;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using dataprocessor.benchmarks.Utilities;
using NUnit.Framework;

namespace dataprocessor.benchmarks
{
    public class Benchmarks
    {
        [Test]
        public void Run([ValueSource(nameof(FindBenchmarks))]Type type)
        {
            Environment.CurrentDirectory = TestContext.CurrentContext.TestDirectory;

            var c = ManualConfig
                .CreateEmpty()
                .With(Job.ShortRun)
                .With(MemoryDiagnoser.Default)
                .With(new NullExporter())
                .With(DefaultColumnProviders.Instance)
                .With(new QuietLogger(new ConsoleLogger()));

            var r = BenchmarkRunner.Run(type, c);
            Assert.IsEmpty(r.ValidationErrors);
        }

        public static Type[] FindBenchmarks()
        {
            var bms = from t in Assembly.GetExecutingAssembly().ExportedTypes
                      where t.GetMethods().Any(m => m.IsDefined(typeof(BenchmarkAttribute)))
                      orderby t.FullName
                      select t;

            return bms.ToArray();
        }
    }
}
