using System.Linq.Expressions;

namespace dataprocessor
{
    public class RemoveRedundantCasts : ExpressionVisitor
    {
        public static T Visit<T>(T expr) where T : Expression
        {
            var expr2 = new RemoveRedundantCasts().VisitAndConvert(expr, nameof(Visit));
            return expr2;
        }

        protected override Expression VisitUnary(UnaryExpression node)
        {
            if (node.NodeType == ExpressionType.Convert
                && node.Operand.NodeType == ExpressionType.Convert)
            {
                var inner = (UnaryExpression)node.Operand;
                return Visit(Expression.Convert(inner.Operand, node.Type));
            }

            if (node.NodeType == ExpressionType.Convert
                && node.Type == node.Operand.Type)
            {
                return Visit(node.Operand);
            }

            return base.VisitUnary(node);
        }
    }
}
