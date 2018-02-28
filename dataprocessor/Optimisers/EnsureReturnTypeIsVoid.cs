using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;

namespace dataprocessor
{
    public static class ExpressionExtensions
    {
        public static LambdaExpression EnsureReturnTypeIsVoid(this LambdaExpression expr)
        {
            Contract.Requires(expr != null);
            Contract.Ensures(Contract.Result<LambdaExpression>() != null);
            Contract.Ensures(Contract.Result<LambdaExpression>().ReturnType == typeof(void));

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
    }
}
