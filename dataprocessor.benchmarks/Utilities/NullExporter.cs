using System.Collections.Generic;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Reports;

namespace dataprocessor.benchmarks.Utilities
{
    internal class NullExporter : IExporter
    {
        public string Name => "NullExporter";

        public IEnumerable<string> ExportToFiles(Summary summary, ILogger consoleLogger)
        {
            return new string[0];
        }

        public void ExportToLog(Summary summary, ILogger logger)
        {
        }
    }
}