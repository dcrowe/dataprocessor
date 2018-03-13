
using System;
using System.Linq;
using NUnit.Framework;
using dataprocessor;

namespace dataprocessor.tests
{
    public class AddListenerOverloadTests
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
        }

        [Test]
        public void AddListener1()
        {
            _b.AddListener<int>(I, (p1) => Sum(p1));
            RunAndAssert(1);
        }

        [Test]
        public void AddListenerExpression1()
        {
            _b.AddListenerExpression<int>(I, (p1) => Sum(p1));
            RunAndAssert(1);
        }

        [Test]
        public void AddListener2()
        {
            _b.AddListener<int, int>(I, I, (p1, p2) => Sum(p1, p2));
            RunAndAssert(2);
        }

        [Test]
        public void AddListenerExpression2()
        {
            _b.AddListenerExpression<int, int>(I, I, (p1, p2) => Sum(p1, p2));
            RunAndAssert(2);
        }

        [Test]
        public void AddListener3()
        {
            _b.AddListener<int, int, int>(I, I, I, (p1, p2, p3) => Sum(p1, p2, p3));
            RunAndAssert(3);
        }

        [Test]
        public void AddListenerExpression3()
        {
            _b.AddListenerExpression<int, int, int>(I, I, I, (p1, p2, p3) => Sum(p1, p2, p3));
            RunAndAssert(3);
        }

        [Test]
        public void AddListener4()
        {
            _b.AddListener<int, int, int, int>(I, I, I, I, (p1, p2, p3, p4) => Sum(p1, p2, p3, p4));
            RunAndAssert(4);
        }

        [Test]
        public void AddListenerExpression4()
        {
            _b.AddListenerExpression<int, int, int, int>(I, I, I, I, (p1, p2, p3, p4) => Sum(p1, p2, p3, p4));
            RunAndAssert(4);
        }

        [Test]
        public void AddListener5()
        {
            _b.AddListener<int, int, int, int, int>(I, I, I, I, I, (p1, p2, p3, p4, p5) => Sum(p1, p2, p3, p4, p5));
            RunAndAssert(5);
        }

        [Test]
        public void AddListenerExpression5()
        {
            _b.AddListenerExpression<int, int, int, int, int>(I, I, I, I, I, (p1, p2, p3, p4, p5) => Sum(p1, p2, p3, p4, p5));
            RunAndAssert(5);
        }

        [Test]
        public void AddListener6()
        {
            _b.AddListener<int, int, int, int, int, int>(I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6) => Sum(p1, p2, p3, p4, p5, p6));
            RunAndAssert(6);
        }

        [Test]
        public void AddListenerExpression6()
        {
            _b.AddListenerExpression<int, int, int, int, int, int>(I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6) => Sum(p1, p2, p3, p4, p5, p6));
            RunAndAssert(6);
        }

        [Test]
        public void AddListener7()
        {
            _b.AddListener<int, int, int, int, int, int, int>(I, I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6, p7) => Sum(p1, p2, p3, p4, p5, p6, p7));
            RunAndAssert(7);
        }

        [Test]
        public void AddListenerExpression7()
        {
            _b.AddListenerExpression<int, int, int, int, int, int, int>(I, I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6, p7) => Sum(p1, p2, p3, p4, p5, p6, p7));
            RunAndAssert(7);
        }

        private int Sum(params int[] parms) => _actual = parms.Sum();

        private void RunAndAssert(int i)
        {
            var d = _b.Build();
            _i.Send(1);
            Assert.AreEqual(i, _actual);
        }
    }
}
