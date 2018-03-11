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

        public static LambdaExpression EnsureReturnTypeIsVoid(this LambdaExpression expr)
        {
            if (expr == null)
                throw new System.ArgumentNullException(nameof(expr));
            if (expr.ReturnType == typeof(void))
                return expr;

            var bodyExpr = expr.Body as BlockExpression;
            var body = bodyExpr != null
                ? Expression.Block(typeof(void), bodyExpr?.Expressions)
                : Expression.Block(typeof(void), expr.Body);

            expr = Expression.Lambda(body, expr.Parameters);

            return expr;
        }

        public static void AssertNoPrivateMethods(this LambdaExpression expr)
        {
            new ThrowOnPrivateMethods().Visit(expr);
        }
    }
}