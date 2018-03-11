using System;
using System.Reflection;
using System.Linq.Expressions;

namespace dataprocessor.Expressions
{
    internal class ThrowOnPrivateMethods : ExpressionVisitor
    {
		protected override Expression VisitConstant(ConstantExpression node)
		{
            var del = node.Value as Delegate;
            if (del != null)
            {
                foreach (var l in del.GetInvocationList())
                    Check(l.GetMethodInfo());
            }

            return base.VisitConstant(node);
		}

		protected override Expression VisitMethodCall(MethodCallExpression node)
		{
            Check(node.Method);
            return base.VisitMethodCall(node);
		}

        void Check(MethodInfo m)
        {
            if (!m.IsPublic)
                throw new MethodAccessException($"Call to non-public method {m} will fail.");
        }
	}
}