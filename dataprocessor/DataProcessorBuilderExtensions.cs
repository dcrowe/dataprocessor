using System;
using System.Linq.Expressions;

namespace dataprocessor
{
    public static partial class DataProcessorBuilderExtensions
    {
        private static readonly System.Reflection.PropertyInfo _debugViewProperty =
                                          typeof(Expression).GetProperty(
                                              "DebugView",
                                              System.Reflection.BindingFlags.GetProperty |
                                              System.Reflection.BindingFlags.NonPublic |
                                              System.Reflection.BindingFlags.Instance);

        public static string GetDebugString(this Expression expr)
        {
            var dv = (string)_debugViewProperty.GetValue(expr);
            return dv;
        }
    }
}
