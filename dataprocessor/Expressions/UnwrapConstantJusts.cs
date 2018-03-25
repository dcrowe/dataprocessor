using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace dataprocessor.Expressions
{
    public class UnwrapConstantJusts : ExpressionVisitor
    {
        private readonly List<ParameterExpression> _candidates 
            = new List<ParameterExpression>();
        private readonly Dictionary<ParameterExpression, ParameterExpression> _replacements
            = new Dictionary<ParameterExpression, ParameterExpression>();

        protected override Expression VisitBlock(BlockExpression node)
        {
            if (node.Variables.Count == 0 && node.Expressions.Count == 1)
                return node.Expressions[0];

            _candidates.AddRange(node.Variables);

            var exprs = node.Expressions
                            .Select(Visit)
                            .ToList();

            var vars = node.Variables
                           .Select(VisitParameter)
                           .Cast<ParameterExpression>()
                           .ToList();

            var block = Expression.Block(vars, exprs);

            _candidates.RemoveAll(node.Variables.Contains);
            vars.ForEach(v => _replacements.Remove(v));

            return block;
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            if (_replacements.TryGetValue(node, out ParameterExpression replacement))
                return replacement;
            return node;
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            var orig = node.Expression as ParameterExpression;
            if (orig != null && _replacements.TryGetValue(
                orig,
                out ParameterExpression replacement))
            {
                if (node.Member.Name == nameof(Maybe<int>.Value))
                    return replacement;
                if (node.Member.Name == nameof(Maybe<int>.IsPresent))
                    return Expression.Constant(true);
            }

            return base.VisitMember(node);
        }

		protected override Expression VisitBinary(BinaryExpression node)
        {
            if (node.NodeType == ExpressionType.Assign
                && node.Right.Type.IsMaybe())
            {
                var varLeft = node.Left as ParameterExpression;
                var isVarOnLeft = varLeft != null && _candidates.Contains(varLeft);

                var right = (Visit(node.Right));
                var callRight = right as MethodCallExpression;
                var isAlwaysJust = callRight != null && callRight.Method.IsJustMethod();

                // From: Maybe<T> v = Maybe<T>.Just(expr);
                // To: T v = expr;
                if (isAlwaysJust && isVarOnLeft)
                {
                    var v = Expression.Variable(varLeft.Type.FromMaybe(), varLeft.Name);
                    _replacements.Add(varLeft, v);

                    var e = Expression.Assign(v, Visit(callRight.Arguments[0]));
                    return e;
                }

                var constRight = right as ConstantExpression;
                var isConstantJust = constRight != null
                        && (bool)constRight.Value.GetType()
                       .GetField(nameof(Maybe<int>.IsPresent))
                       .GetValue(constRight.Value);

                // From: Maybe<T> v = Constant of Maybe<T>.Just(expr);
                // To: T v = expr;
                if (isConstantJust && isVarOnLeft)
                {
                    var v = Expression.Variable(varLeft.Type.FromMaybe(), varLeft.Name);
                    _replacements.Add(varLeft, v);

                    var value = constRight.Value.GetType()
                                          .GetField(nameof(Maybe<int>.Value))
                                          .GetValue(constRight.Value);
                    var e = Expression.Assign(v, Expression.Constant(value, v.Type));
                    return e;
                }
            }

            if (node.NodeType == ExpressionType.And || node.NodeType == ExpressionType.AndAlso)
            {
                var left = base.Visit(node.Left);

                // From: True && ...
                // To: ...
                var constLeft = left as ConstantExpression;
                if (constLeft != null && Equals(constLeft.Value, true))
                    return Visit(node.Right);

                // From: ... && True
                // To: ...
                var constRight = Visit(node.Right) as ConstantExpression;
                if (constRight != null && Equals(constRight.Value, true))
                    return left;
            }

            return base.VisitBinary(node);
		}

		protected override Expression VisitConditional(ConditionalExpression node)
		{
            var testConst = Visit(node.Test) as ConstantExpression;

            if (testConst != null)
            {
                var testVal = (bool)testConst.Value;
                var result = testVal ? node.IfTrue : node.IfFalse;
                return Visit(result);
            }

            _candidates.Clear();
            return base.VisitConditional(node);
		}

		protected override Expression VisitTry(TryExpression node)
		{
            _candidates.Clear();
            return base.VisitTry(node);
		}
	}
}
