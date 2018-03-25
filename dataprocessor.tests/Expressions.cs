using System;
using System.Linq.Expressions;
using dataprocessor.Expressions;
using NUnit.Framework;


namespace dataprocessor.tests
{
    public class Expressions
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
            AreEqual(expected, actual);
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
            AreEqual(expected, actual);
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
            AreEqual(expected, actual);
        }

        private static void AreEqual(Expression expected, Expression actual)
        {
            Console.Out.WriteLine("Actual: " + actual.GetDebugString());
            Assert.AreEqual(expected.GetDebugString(), actual.GetDebugString());
        }

        [Test]
        public void ImproveDelegateInvocation_Static_Single()
        {
            var expected = Expression.Lambda<Func<int>>(Expression.Call(
                typeof(Expressions),
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
                    Expression.Call(typeof(Expressions), "StaticDelegate", null, v),
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

        [Test]
        public void UnwrapJusts_Constants()
        {
            var v = Expression.Variable(typeof(Maybe<int>), "v");
            var e = Expression.Block(
                new[] { v },
                Expression.Assign(v, Expression.Constant(Maybe<int>.Just(1))),
                Expression.Field(v, "Value"));

            var vv = Expression.Variable(typeof(int), "v");
            var expected = Expression.Block(
                new[] { vv },
                Expression.Assign(vv, Expression.Constant(1)),
                vv);

            var actual = new UnwrapConstantJusts().VisitAndConvert(e, "");
            AreEqual(expected, actual);
        }

        [Test]
        public void UnwrapJusts_CallsToJust()
        {
            var v = Expression.Variable(typeof(Maybe<int>), "v");
            var e = Expression.Block(
                new[] { v },
                Expression.Assign(v, Expression.Call(
                    typeof(Maybe<int>),
                    "Just",
                    null,
                    Expression.Constant(1))),
                Expression.Field(v, "Value"));

            var vv = Expression.Variable(typeof(int), "v");
            var expected = Expression.Block(
                new[] { vv },
                Expression.Assign(vv, Expression.Constant(1)),
                vv);

            var actual = new UnwrapConstantJusts().VisitAndConvert(e, "");
            AreEqual(expected, actual);
        }

        [Test]
        public void UnwrapJusts_ReduceIfs()
        {
            var v = Expression.Variable(typeof(int), "v");
            var e = Expression.Block(
                new[] { v },
                Expression.IfThen(
                    Expression.And(
                        Expression.Constant(true),
                        Expression.Constant(true)),
                    Expression.Assign(v, Expression.Constant(1))));

            var expected = Expression.Block(
                new[] { v },
                Expression.Assign(v, Expression.Constant(1)));

            var actual = new UnwrapConstantJusts().Visit(e);
            AreEqual(expected, actual);
        }

        [Test]
        public void UnwrapJusts_DontReduceIncompleteIfs()
        {
            var b = Expression.Variable(typeof(bool), "b");
            var v = Expression.Variable(typeof(Maybe<int>), "v");
            var e = Expression.Block(
                new[] { v },
                Expression.IfThen(
                    b,
                    Expression.Assign(v, Expression.Constant(Maybe<int>.Just(1)))),
                Expression.Field(v, "Value"));

            var vv = Expression.Variable(typeof(int), "v");
            var expected = e;

            var actual = new UnwrapConstantJusts().VisitAndConvert(e, "");
            AreEqual(expected, actual);
        }

        [Test]
        public void UnwrapJusts_DontReduceIncompleteIfs_2()
        {
            var b = Expression.Variable(typeof(bool), "b");
            var v1 = Expression.Variable(typeof(Maybe<int>), "v1");
            var v2 = Expression.Variable(typeof(Maybe<int>), "v2");
            var e = Expression.Block(
                new[] { v1, v2 },
                Expression.IfThen(
                    b,
                    Expression.Assign(v1, Expression.Constant(Maybe<int>.Just(1)))),
                Expression.IfThen(
                    Expression.Field(v1, "IsPresent"),
                    Expression.Assign(v2, v1)),
                Expression.Field(v2, "Value"));

            var vv = Expression.Variable(typeof(int), "v");
            var expected = e;

            Console.Out.WriteLine("Expected: " + e.GetDebugString());
            var actual = new UnwrapConstantJusts().VisitAndConvert(e, "");
            AreEqual(expected, actual);
        }
    }
}
