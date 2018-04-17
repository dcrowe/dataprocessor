
using System;
using System.Linq;
using NUnit.Framework;
using dataprocessor;

namespace dataprocessor.tests
{
    public class AddProcessorOverloadTests
    {
        private const string I = "i";
        private DataProcessorBuilder _b;
        private Writer<int> _i;
        private int _actual;

        [SetUp]
        public void Setup()
        {
            _actual = 0;
            _b = new DataProcessorBuilder();
            _i = _b.AddInput<int>(I);
            _b.AddListener<int>("o", o => _actual = o);
        }

        [Test]
        public void AddProcessor1()
        {
            _b.AddProcessor<int, int>(I, "o", (p1) => Sum(p1));
            RunAndAssert(1);
        }

        [Test]
        public void AddProcessorMaybe1()
        {
            _b.AddProcessorint, int>(I, "o", (p1) => Maybe<int>.Just(Sum(p1)));
            RunAndAssert(1);
        }

        [Test]
        public void AddProcessorExpression1()
        {
            _b.AddProcessorExpression<int, int>(I, "o", (p1) => Sum(p1));
            RunAndAssert(1);
        }

        [Test]
        public void AddProcessorExpressionMaybe1()
        {
            _b.AddProcessorExpression<int, int>(I, "o", (p1) => Maybe<int>.Just(Sum(p1)));
            RunAndAssert(1);
        }

        [Test]
        public void AddProcessor2()
        {
            _b.AddProcessor<int, int, int>(I, I, "o", (p1, p2) => Sum(p1, p2));
            RunAndAssert(2);
        }

        [Test]
        public void AddProcessorMaybe2()
        {
            _b.AddProcessorint, int, int>(I, I, "o", (p1, p2) => Maybe<int>.Just(Sum(p1, p2)));
            RunAndAssert(2);
        }

        [Test]
        public void AddProcessorExpression2()
        {
            _b.AddProcessorExpression<int, int, int>(I, I, "o", (p1, p2) => Sum(p1, p2));
            RunAndAssert(2);
        }

        [Test]
        public void AddProcessorExpressionMaybe2()
        {
            _b.AddProcessorExpression<int, int, int>(I, I, "o", (p1, p2) => Maybe<int>.Just(Sum(p1, p2)));
            RunAndAssert(2);
        }

        [Test]
        public void AddProcessor3()
        {
            _b.AddProcessor<int, int, int, int>(I, I, I, "o", (p1, p2, p3) => Sum(p1, p2, p3));
            RunAndAssert(3);
        }

        [Test]
        public void AddProcessorMaybe3()
        {
            _b.AddProcessorint, int, int, int>(I, I, I, "o", (p1, p2, p3) => Maybe<int>.Just(Sum(p1, p2, p3)));
            RunAndAssert(3);
        }

        [Test]
        public void AddProcessorExpression3()
        {
            _b.AddProcessorExpression<int, int, int, int>(I, I, I, "o", (p1, p2, p3) => Sum(p1, p2, p3));
            RunAndAssert(3);
        }

        [Test]
        public void AddProcessorExpressionMaybe3()
        {
            _b.AddProcessorExpression<int, int, int, int>(I, I, I, "o", (p1, p2, p3) => Maybe<int>.Just(Sum(p1, p2, p3)));
            RunAndAssert(3);
        }

        [Test]
        public void AddProcessor4()
        {
            _b.AddProcessor<int, int, int, int, int>(I, I, I, I, "o", (p1, p2, p3, p4) => Sum(p1, p2, p3, p4));
            RunAndAssert(4);
        }

        [Test]
        public void AddProcessorMaybe4()
        {
            _b.AddProcessorint, int, int, int, int>(I, I, I, I, "o", (p1, p2, p3, p4) => Maybe<int>.Just(Sum(p1, p2, p3, p4)));
            RunAndAssert(4);
        }

        [Test]
        public void AddProcessorExpression4()
        {
            _b.AddProcessorExpression<int, int, int, int, int>(I, I, I, I, "o", (p1, p2, p3, p4) => Sum(p1, p2, p3, p4));
            RunAndAssert(4);
        }

        [Test]
        public void AddProcessorExpressionMaybe4()
        {
            _b.AddProcessorExpression<int, int, int, int, int>(I, I, I, I, "o", (p1, p2, p3, p4) => Maybe<int>.Just(Sum(p1, p2, p3, p4)));
            RunAndAssert(4);
        }

        [Test]
        public void AddProcessor5()
        {
            _b.AddProcessor<int, int, int, int, int, int>(I, I, I, I, I, "o", (p1, p2, p3, p4, p5) => Sum(p1, p2, p3, p4, p5));
            RunAndAssert(5);
        }

        [Test]
        public void AddProcessorMaybe5()
        {
            _b.AddProcessorint, int, int, int, int, int>(I, I, I, I, I, "o", (p1, p2, p3, p4, p5) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5)));
            RunAndAssert(5);
        }

        [Test]
        public void AddProcessorExpression5()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int>(I, I, I, I, I, "o", (p1, p2, p3, p4, p5) => Sum(p1, p2, p3, p4, p5));
            RunAndAssert(5);
        }

        [Test]
        public void AddProcessorExpressionMaybe5()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int>(I, I, I, I, I, "o", (p1, p2, p3, p4, p5) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5)));
            RunAndAssert(5);
        }

        [Test]
        public void AddProcessor6()
        {
            _b.AddProcessor<int, int, int, int, int, int, int>(I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6) => Sum(p1, p2, p3, p4, p5, p6));
            RunAndAssert(6);
        }

        [Test]
        public void AddProcessorMaybe6()
        {
            _b.AddProcessorint, int, int, int, int, int, int>(I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6)));
            RunAndAssert(6);
        }

        [Test]
        public void AddProcessorExpression6()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int>(I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6) => Sum(p1, p2, p3, p4, p5, p6));
            RunAndAssert(6);
        }

        [Test]
        public void AddProcessorExpressionMaybe6()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int>(I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6)));
            RunAndAssert(6);
        }

        [Test]
        public void AddProcessor7()
        {
            _b.AddProcessor<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7) => Sum(p1, p2, p3, p4, p5, p6, p7));
            RunAndAssert(7);
        }

        [Test]
        public void AddProcessorMaybe7()
        {
            _b.AddProcessorint, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7)));
            RunAndAssert(7);
        }

        [Test]
        public void AddProcessorExpression7()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7) => Sum(p1, p2, p3, p4, p5, p6, p7));
            RunAndAssert(7);
        }

        [Test]
        public void AddProcessorExpressionMaybe7()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7)));
            RunAndAssert(7);
        }

        private int Sum(params int[] parms) => parms.Sum();

        private void RunAndAssert(int i)
        {
            var d = _b.Build();
            _i.Send(1);
            Assert.AreEqual(i, _actual);
        }
    }
}
