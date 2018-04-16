using System;
using System.Diagnostics;
using System.Linq.Expressions;
using dataprocessor.Expressions;

namespace dataprocessor
{
    internal static class Logger
    {
        [Conditional("DEBUG")]
        public static void WriteLine(string value)
        {
            Console.WriteLine(value);
        }

        [Conditional("DEBUG")]
        public static void WriteLine(string name, LambdaExpression expr)
        {
            try
            {
                WriteLine($"OptimiseAndLog: {name} => {expr.GetDebugString()}");
            }
            catch
            {
                WriteLine($"OptimiseAndLog: {name} => eeeek.");
            }
        }
    }
}
