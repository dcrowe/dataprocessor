using System;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace dataprocessor.Expressions
{
    public class InlineLambdaInvocations : ExpressionVisitor
    {
        public static T Visit<T>(T expr) where T : Expression
        {
            var expr2 = new InlineLambdaInvocations().VisitAndConvert(expr, nameof(Visit));
            return expr2;
        }

        private readonly Dictionary<ParameterExpression, Expression>
            _replacements = new Dictionary<ParameterExpression, Expression>();

        protected override Expression VisitInvocation(InvocationExpression node)
        {
            var expr = node.Expression as LambdaExpression;

            if (expr != null)
            {
                // recursively remove any inlining from this inner lambda
                expr = Visit(expr);

                // save parameters for inline replacement
                for (var ix = 0; ix < node.Arguments.Count; ix++)
                    _replacements.Add(expr.Parameters[ix], node.Arguments[ix]);
                
                return base.Visit(expr.Body);
            }

            return base.VisitInvocation(node);
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            Expression expr = null;
            if (_replacements.TryGetValue(node, out expr))
                return expr;
            
            return node;
        }
    }
}
