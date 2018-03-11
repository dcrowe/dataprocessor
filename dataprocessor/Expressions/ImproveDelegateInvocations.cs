using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace dataprocessor.Expressions
{
    public class ImproveDelegateInvocations : ExpressionVisitor
    {
        public static T Apply<T>(T expr) where T : Expression
        {
            var expr2 = new ImproveDelegateInvocations().VisitAndConvert(expr, nameof(Apply));
            return expr2;
        }

        protected override Expression VisitInvocation(InvocationExpression node)
        {
            var expr = node.Expression as ConstantExpression;
            var dele = expr?.Value as Delegate;

            if (dele != null)
            {
                var methodInfo = dele.GetType().GetMethod("Invoke");
                if (methodInfo == null)
                    return base.VisitInvocation(node);

                var ps = methodInfo.GetParameters();

                if (ps.Any(p => p.IsOut || p.IsRetval || p.IsLcid))
                    return base.VisitInvocation(node);

                var ps2 = ps.Select(p => Expression.Parameter(p.ParameterType, p.Name))
                            .ToList();

                var invocationList = dele.GetInvocationList();

                var args = node.Arguments.Select(Visit);
                
                if (invocationList.Length == 1)
                {
                    var i = invocationList.Single();
                    var call = i.Target != null
                            ? Expression.Call(Expression.Constant(i.Target), i.Method, args)
                            : Expression.Call(i.Method, args);
                    return call;;
                }
                else 
                {
                    var vars = new List<ParameterExpression>();
                    var assigns = new List<Expression>();

                    foreach(var a in args)
                    {
                        var v = Expression.Variable(a.Type);
                        vars.Add(v);
                        assigns.Add(Expression.Assign(v, a));
                    }

                    foreach(var i in invocationList)
                    {
                        var call = i.Target != null
                                ? Expression.Call(Expression.Constant(i.Target), i.Method, vars)
                                : Expression.Call(i.Method, vars);
                        assigns.Add(call);
                    }

                    var block = Expression.Block(
                        methodInfo.ReturnType,
                        vars, 
                        assigns);
                    return block;
                }
            }

            return base.VisitInvocation(node);
        }
    }
}
