using System;
using System.Linq.Expressions;
using System.Reflection;

namespace dataprocessor.Expressions
{
    public static class ExpressionExtensions
    {
        private const BindingFlags PrivateStatic
            = BindingFlags.GetProperty | BindingFlags.NonPublic | BindingFlags.Instance;
        private static readonly PropertyInfo _debugViewProperty = typeof(Expression)
            .GetProperty("DebugView", PrivateStatic);

        public static string GetDebugString(this Expression expr)
        {
            var dv = (string)_debugViewProperty.GetValue(expr);
            return dv;
        }

        public static void AssertNoPrivateMethods(this LambdaExpression expr)
        {
            new ThrowOnPrivateMethods().Visit(expr);
        }
    }
}