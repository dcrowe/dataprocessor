using System;
using System.Linq;
using BenchmarkDotNet.Loggers;

namespace dataprocessor.benchmarks.Utilities
{
    public class QuietLogger : ILogger
    {
        const string beginResultsSection = "// * Summary *";
        readonly ILogger _logger;
        bool inResults;

        public QuietLogger(ILogger logger)
        {
            _logger = logger;
        }

        public void Write(LogKind logKind, string text)
        {
            if (Filter(logKind, text))
                _logger.Write(logKind, text);
        }

        public void WriteLine()
        {
            if (inResults)
                _logger.WriteLine();
        }

        public void WriteLine(LogKind logKind, string text)
        {
            if (Filter(logKind, text))
                _logger.WriteLine(logKind, text);
        }

        private bool Filter(LogKind logKind, string text)
        {
            if (logKind == LogKind.Header && text == beginResultsSection)
                inResults = true;

            if (inResults)
                return logKind != LogKind.Hint;
            else
                return logKind == LogKind.Error;
        }
    }
}