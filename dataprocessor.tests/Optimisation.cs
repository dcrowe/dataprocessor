using System;
using System.Linq.Expressions;
using dataprocessor;
using NUnit.Framework;

namespace dataprocessor.tests
{
    public class Optimisation
    {
        [Test]
        public void InlineLambdas_Single()
        {
            var p = Expression.Parameter(typeof(int), "p");
            var a = Expression.Parameter(typeof(int), "a");

            var input = Expression.Lambda(
                Expression.Invoke(
                    Expression.Lambda(Expression.Add(a, a), a),
                    p),
                p);
            var actual = InlineLambdaInvocations.Visit(input);

            var expected = Expression.Lambda(Expression.Add(p, p), p);

            Console.Out.WriteLine("In: " + input.GetDebugString());
            Console.Out.WriteLine("Out: " + actual.GetDebugString());

            Assert.AreEqual(expected.GetDebugString(), actual.GetDebugString());
        }

        [Test]
        public void InlineLambdas_Double()
        {
            var p = Expression.Parameter(typeof(int), "p");
            var a = Expression.Parameter(typeof(int), "a");
            var b = Expression.Parameter(typeof(int), "b");

            var input = Expression.Lambda(
                Expression.Invoke(
                    Expression.Lambda(
                        Expression.Invoke(
                            Expression.Lambda(Expression.Add(b, b), b),
                            a),
                        a),
                    p),
                p);
            var actual = InlineLambdaInvocations.Visit(input);

            var expected = Expression.Lambda(Expression.Add(p, p), p);

            Console.Out.WriteLine("In: " + input.GetDebugString());
            Console.Out.WriteLine("Out: " + actual.GetDebugString());

            Assert.AreEqual(expected.GetDebugString(), actual.GetDebugString());
        }

        [Test]
        public void InlineLambdas_Five()
        {
            var p = Expression.Parameter(typeof(int), "p");
            var a = Expression.Parameter(typeof(int), "a");
            var b = Expression.Parameter(typeof(int), "b");
            var c = Expression.Parameter(typeof(int), "c");
            var d = Expression.Parameter(typeof(int), "d");
            var e = Expression.Parameter(typeof(int), "e");

            var input = Expression.Lambda(
                Expression.Invoke(
                    Expression.Lambda(
                        Expression.Invoke(
                            Expression.Lambda(
                                Expression.Invoke(
                                    Expression.Lambda(
                                        Expression.Invoke(
                                            Expression.Lambda(
                                                Expression.Invoke(
                                                    Expression.Lambda(Expression.Add(e, e), e),
                                                    d),
                                                d),
                                            c),
                                        c),
                                    b),
                                b),
                            a),
                        a),
                    p),
                p);
            var actual = InlineLambdaInvocations.Visit(input);

            var expected = Expression.Lambda(Expression.Add(p, p), p);

            Console.Out.WriteLine("In: " + input.GetDebugString());
            Console.Out.WriteLine("Out: " + actual.GetDebugString());

            Assert.AreEqual(expected.GetDebugString(), actual.GetDebugString());
        }
    }
}
