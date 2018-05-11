using System.Diagnostics;
using System.Linq.Expressions;
using dataprocessor.Expressions;

namespace dataprocessor
{
    internal static class Log
    {
        internal static readonly TraceSource Src = new TraceSource("dataprocessor");

        public static bool IsVerbose => Src.Switch.ShouldTrace(TraceEventType.Verbose);
        public static bool IsInfo => Src.Switch.ShouldTrace(TraceEventType.Information);
        public static bool IsWarn => Src.Switch.ShouldTrace(TraceEventType.Warning);
        public static bool IsError => Src.Switch.ShouldTrace(TraceEventType.Error);

        public static void Verbose(string message)
        {
            Src.TraceEvent(TraceEventType.Verbose, 0, message);
        }

        public static void Info(string message)
        {
            Src.TraceEvent(TraceEventType.Information, 0, message);
        }

        public static void Warn(string message)
        {
            Src.TraceEvent(TraceEventType.Warning, 0, message);
        }

        public static void Error(string message)
        {
            Src.TraceEvent(TraceEventType.Error, 0, message);
        }

        public static void Verbose(string message, Expression expr)
        {
            if (!IsVerbose)
                return;

            try
            {
                Verbose($"{message} - {expr.GetDebugString()}");
            }
            catch
            {
                Verbose($"{message} - Error getting Expression string.");
            }
        }
    }
}