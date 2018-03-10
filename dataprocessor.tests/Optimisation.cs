using System;
using System.Linq.Expressions;
using dataprocessor;
using NUnit.Framework;

using System.IO;
using System.Reflection;
using System.Reflection.Emit;

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

        [Test]
        public void ImproveDelegateInvocation_Static_Single()
        {
            var expected = Expression.Lambda<Func<int>>(Expression.Call(
                typeof(Optimisation),
                "StaticDelegate",
                null,
                Expression.Constant(1)));
            AssertAreEqual(StaticDelegate, expected);
        }

        [Test]
        public void ImproveDelegateInvocation_Mixed_Double()
        {
            MultiDelegate = null;
            MultiDelegate += StaticDelegate;
            MultiDelegate += InstanceDelegate;

            var v = Expression.Variable(typeof(int));
            var expected = Expression.Lambda<Func<int>>(
                Expression.Block(
                    new[] { v },
                    Expression.Assign(v, Expression.Constant(1)),
                    Expression.Call(typeof(Optimisation), "StaticDelegate", null, v),
                    Expression.Call(Expression.Constant(this), "InstanceDelegate", null, v)));

            AssertAreEqual(MultiDelegate, expected);
        }

        private static void AssertAreEqual(Func<int, int> func, Expression<Func<int>> expected)
        {
            var orig = Expression.Lambda<Func<int>>(
                Expression.Invoke(
                    Expression.Constant(func, typeof(Func<int, int>)),
                    Expression.Constant(1)));

            var actual = ImproveDelegateInvocations.Apply(orig);
            Console.Out.WriteLine(actual.GetDebugString());
            Assert.AreEqual(expected.GetDebugString(), actual.GetDebugString());
        }

        private static int StaticDelegate(int i) => i + 1;
        private int InstanceDelegate(int i) => i + 2;
        private event Func<int, int> MultiDelegate;
    }
}
