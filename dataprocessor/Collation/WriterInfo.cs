using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using dataprocessor.Expressions;

namespace dataprocessor.Collation
{
    [DebuggerDisplay("Writer: {Description}")]
    public class WriterInfo
    {
        public WriterInfo(string name,
                          ICanSetAction writer,
                          params NameInfo[] parameters)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));
            if (parameters == null)
                throw new ArgumentNullException(nameof(parameters));
            Name = name;
            Writer = writer;
            _parameters = parameters
                .Select(ni => ni.Description)
                .Select(p => Expression.Parameter(p.Type, p.Name))
                .ToArray();
        }

        public readonly string Name;
        public readonly ICanSetAction Writer;

        private readonly ParameterExpression[] _parameters;
        private readonly List<ParameterExpression> _variables = new List<ParameterExpression>();
        private readonly List<Expression> _expressions = new List<Expression>();

        public void Append(ProcessorInfo o)
        {
            if (o == null)
                throw new ArgumentNullException(nameof(o));
            
            var ps = o.Inputs.Select(ParameterFor);
            var ifs = IsPresentFor(o.Inputs);
            var isMaybe = ifs != null;

            Expression e = Expression.Invoke(o.Expr, ps);

            // apply some performance improvements
            e = ImproveDelegateInvocations.Apply(e);
            e = InlineLambdaInvocations.Visit(e);

            if (o.Output != null)
            {
                var t = o.Expr.Body.Type;

                // does the result type need to be lifted from T to Maybe<T>?
                var needsLift = isMaybe && !o.Expr.Type.IsMaybe();

                if (needsLift)
                {
                    t = t.ToMaybe();
                    e = Expression.Call(t, "Just", null, e);
                }

                var v = Expression.Variable(t, o.Output.Description.Name);
                e = Expression.Assign(v, e);
                _variables.Add(v);
            }

            if (ifs != null)
                e = Expression.IfThen(ifs, e);
                
            _expressions.Add(e);
        }

        public LambdaExpression GetFinalLambda()
        {
            if (!_expressions.Any())
                _expressions.Add(Expression.Empty());

            var expr = Expression.Lambda(
                Writer.ActionType,
                Expression.Block(
                    typeof(void),
                    _variables,
                    _expressions),
                _parameters);
            
            return expr;
        }

        private Expression ParameterFor(NameInfo name)
        {
            var pp = _parameters.FirstOrDefault(p => p.Name == name.Description.Name);
            if (pp != null)
                return pp;

            var v = _variables.First(p => p.Name == name.Description.Name);
            if (v.Type.IsMaybe())
                return Expression.Field(v, "Value");

            return v;
        }

        private Expression IsPresentFor(NameInfo[] names)
        {
            var vs = _variables
                .Where(v => names.Any(ni => ni.Description.Name == v.Name))
                .Where(v => v.Type.IsMaybe())
                .ToList();

            if (!vs.Any())
                return null;

            var e = vs
                .Select(v => (Expression)Expression.Field(v, nameof(Maybe<int>.IsPresent)))
                .Aggregate(Expression.AndAlso);
            return e;
        }
    }
}
