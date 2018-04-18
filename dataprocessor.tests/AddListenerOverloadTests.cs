
using System;
using System.Linq;
using System.Linq.Expressions;
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
        public void AddListener1_ArgChecks()
        {
            Action<int> func = (p1) => Sum(p1);
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int>(null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int>(I, null));
        }

        [Test]
        public void AddListener1()
        {
            _b.AddListener<int>(I, (p1) => Sum(p1));
            RunAndAssert(1);
        }

        [Test]
        public void AddListenerExpression1_ArgChecks()
        {
            Expression<Action<int>> func = (p1) => Sum(p1);
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int>(null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int>(I, null));
        }

        [Test]
        public void AddListenerExpression1()
        {
            _b.AddListenerExpression<int>(I, (p1) => Sum(p1));
            RunAndAssert(1);
        }

        [Test]
        public void AddListener2_ArgChecks()
        {
            Action<int, int> func = (p1, p2) => Sum(p1, p2);
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int>(null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int>(I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int>(I, I, null));
        }

        [Test]
        public void AddListener2()
        {
            _b.AddListener<int, int>(I, I, (p1, p2) => Sum(p1, p2));
            RunAndAssert(2);
        }

        [Test]
        public void AddListenerExpression2_ArgChecks()
        {
            Expression<Action<int, int>> func = (p1, p2) => Sum(p1, p2);
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int>(null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int>(I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int>(I, I, null));
        }

        [Test]
        public void AddListenerExpression2()
        {
            _b.AddListenerExpression<int, int>(I, I, (p1, p2) => Sum(p1, p2));
            RunAndAssert(2);
        }

        [Test]
        public void AddListener3_ArgChecks()
        {
            Action<int, int, int> func = (p1, p2, p3) => Sum(p1, p2, p3);
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int>(null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int>(I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int>(I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int>(I, I, I, null));
        }

        [Test]
        public void AddListener3()
        {
            _b.AddListener<int, int, int>(I, I, I, (p1, p2, p3) => Sum(p1, p2, p3));
            RunAndAssert(3);
        }

        [Test]
        public void AddListenerExpression3_ArgChecks()
        {
            Expression<Action<int, int, int>> func = (p1, p2, p3) => Sum(p1, p2, p3);
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int>(null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int>(I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int>(I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int>(I, I, I, null));
        }

        [Test]
        public void AddListenerExpression3()
        {
            _b.AddListenerExpression<int, int, int>(I, I, I, (p1, p2, p3) => Sum(p1, p2, p3));
            RunAndAssert(3);
        }

        [Test]
        public void AddListener4_ArgChecks()
        {
            Action<int, int, int, int> func = (p1, p2, p3, p4) => Sum(p1, p2, p3, p4);
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int>(null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int>(I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int>(I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int>(I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int>(I, I, I, I, null));
        }

        [Test]
        public void AddListener4()
        {
            _b.AddListener<int, int, int, int>(I, I, I, I, (p1, p2, p3, p4) => Sum(p1, p2, p3, p4));
            RunAndAssert(4);
        }

        [Test]
        public void AddListenerExpression4_ArgChecks()
        {
            Expression<Action<int, int, int, int>> func = (p1, p2, p3, p4) => Sum(p1, p2, p3, p4);
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int>(null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int>(I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int>(I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int>(I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int>(I, I, I, I, null));
        }

        [Test]
        public void AddListenerExpression4()
        {
            _b.AddListenerExpression<int, int, int, int>(I, I, I, I, (p1, p2, p3, p4) => Sum(p1, p2, p3, p4));
            RunAndAssert(4);
        }

        [Test]
        public void AddListener5_ArgChecks()
        {
            Action<int, int, int, int, int> func = (p1, p2, p3, p4, p5) => Sum(p1, p2, p3, p4, p5);
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int>(null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int>(I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int>(I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int>(I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int>(I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int>(I, I, I, I, I, null));
        }

        [Test]
        public void AddListener5()
        {
            _b.AddListener<int, int, int, int, int>(I, I, I, I, I, (p1, p2, p3, p4, p5) => Sum(p1, p2, p3, p4, p5));
            RunAndAssert(5);
        }

        [Test]
        public void AddListenerExpression5_ArgChecks()
        {
            Expression<Action<int, int, int, int, int>> func = (p1, p2, p3, p4, p5) => Sum(p1, p2, p3, p4, p5);
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int>(null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int>(I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int>(I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int>(I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int>(I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int>(I, I, I, I, I, null));
        }

        [Test]
        public void AddListenerExpression5()
        {
            _b.AddListenerExpression<int, int, int, int, int>(I, I, I, I, I, (p1, p2, p3, p4, p5) => Sum(p1, p2, p3, p4, p5));
            RunAndAssert(5);
        }

        [Test]
        public void AddListener6_ArgChecks()
        {
            Action<int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6) => Sum(p1, p2, p3, p4, p5, p6);
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int>(null, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int>(I, null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int>(I, I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int>(I, I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int>(I, I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int>(I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int>(I, I, I, I, I, I, null));
        }

        [Test]
        public void AddListener6()
        {
            _b.AddListener<int, int, int, int, int, int>(I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6) => Sum(p1, p2, p3, p4, p5, p6));
            RunAndAssert(6);
        }

        [Test]
        public void AddListenerExpression6_ArgChecks()
        {
            Expression<Action<int, int, int, int, int, int>> func = (p1, p2, p3, p4, p5, p6) => Sum(p1, p2, p3, p4, p5, p6);
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int>(null, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int>(I, null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int>(I, I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int>(I, I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int>(I, I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int>(I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int>(I, I, I, I, I, I, null));
        }

        [Test]
        public void AddListenerExpression6()
        {
            _b.AddListenerExpression<int, int, int, int, int, int>(I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6) => Sum(p1, p2, p3, p4, p5, p6));
            RunAndAssert(6);
        }

        [Test]
        public void AddListener7_ArgChecks()
        {
            Action<int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7) => Sum(p1, p2, p3, p4, p5, p6, p7);
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int>(null, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int>(I, null, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int>(I, I, null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int>(I, I, I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int>(I, I, I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int>(I, I, I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int>(I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null));
        }

        [Test]
        public void AddListener7()
        {
            _b.AddListener<int, int, int, int, int, int, int>(I, I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6, p7) => Sum(p1, p2, p3, p4, p5, p6, p7));
            RunAndAssert(7);
        }

        [Test]
        public void AddListenerExpression7_ArgChecks()
        {
            Expression<Action<int, int, int, int, int, int, int>> func = (p1, p2, p3, p4, p5, p6, p7) => Sum(p1, p2, p3, p4, p5, p6, p7);
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int>(null, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int>(I, null, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int>(I, I, null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int>(I, I, I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int>(I, I, I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int>(I, I, I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int>(I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null));
        }

        [Test]
        public void AddListenerExpression7()
        {
            _b.AddListenerExpression<int, int, int, int, int, int, int>(I, I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6, p7) => Sum(p1, p2, p3, p4, p5, p6, p7));
            RunAndAssert(7);
        }

        [Test]
        public void AddListener8_ArgChecks()
        {
            Action<int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8) => Sum(p1, p2, p3, p4, p5, p6, p7, p8);
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null));
        }

        [Test]
        public void AddListener8()
        {
            _b.AddListener<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6, p7, p8) => Sum(p1, p2, p3, p4, p5, p6, p7, p8));
            RunAndAssert(8);
        }

        [Test]
        public void AddListenerExpression8_ArgChecks()
        {
            Expression<Action<int, int, int, int, int, int, int, int>> func = (p1, p2, p3, p4, p5, p6, p7, p8) => Sum(p1, p2, p3, p4, p5, p6, p7, p8);
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null));
        }

        [Test]
        public void AddListenerExpression8()
        {
            _b.AddListenerExpression<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6, p7, p8) => Sum(p1, p2, p3, p4, p5, p6, p7, p8));
            RunAndAssert(8);
        }

        [Test]
        public void AddListener9_ArgChecks()
        {
            Action<int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9);
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null));
        }

        [Test]
        public void AddListener9()
        {
            _b.AddListener<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6, p7, p8, p9) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9));
            RunAndAssert(9);
        }

        [Test]
        public void AddListenerExpression9_ArgChecks()
        {
            Expression<Action<int, int, int, int, int, int, int, int, int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9);
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null));
        }

        [Test]
        public void AddListenerExpression9()
        {
            _b.AddListenerExpression<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6, p7, p8, p9) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9));
            RunAndAssert(9);
        }

        [Test]
        public void AddListener10_ArgChecks()
        {
            Action<int, int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null));
        }

        [Test]
        public void AddListener10()
        {
            _b.AddListener<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10));
            RunAndAssert(10);
        }

        [Test]
        public void AddListenerExpression10_ArgChecks()
        {
            Expression<Action<int, int, int, int, int, int, int, int, int, int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null));
        }

        [Test]
        public void AddListenerExpression10()
        {
            _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10));
            RunAndAssert(10);
        }

        [Test]
        public void AddListener11_ArgChecks()
        {
            Action<int, int, int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null));
        }

        [Test]
        public void AddListener11()
        {
            _b.AddListener<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11));
            RunAndAssert(11);
        }

        [Test]
        public void AddListenerExpression11_ArgChecks()
        {
            Expression<Action<int, int, int, int, int, int, int, int, int, int, int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null));
        }

        [Test]
        public void AddListenerExpression11()
        {
            _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11));
            RunAndAssert(11);
        }

        [Test]
        public void AddListener12_ArgChecks()
        {
            Action<int, int, int, int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null));
        }

        [Test]
        public void AddListener12()
        {
            _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12));
            RunAndAssert(12);
        }

        [Test]
        public void AddListenerExpression12_ArgChecks()
        {
            Expression<Action<int, int, int, int, int, int, int, int, int, int, int, int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null));
        }

        [Test]
        public void AddListenerExpression12()
        {
            _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12));
            RunAndAssert(12);
        }

        [Test]
        public void AddListener13_ArgChecks()
        {
            Action<int, int, int, int, int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null));
        }

        [Test]
        public void AddListener13()
        {
            _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13));
            RunAndAssert(13);
        }

        [Test]
        public void AddListenerExpression13_ArgChecks()
        {
            Expression<Action<int, int, int, int, int, int, int, int, int, int, int, int, int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null));
        }

        [Test]
        public void AddListenerExpression13()
        {
            _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13));
            RunAndAssert(13);
        }

        [Test]
        public void AddListener14_ArgChecks()
        {
            Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, null));
        }

        [Test]
        public void AddListener14()
        {
            _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14));
            RunAndAssert(14);
        }

        [Test]
        public void AddListenerExpression14_ArgChecks()
        {
            Expression<Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, null));
        }

        [Test]
        public void AddListenerExpression14()
        {
            _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14));
            RunAndAssert(14);
        }

        [Test]
        public void AddListener15_ArgChecks()
        {
            Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, null));
        }

        [Test]
        public void AddListener15()
        {
            _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15));
            RunAndAssert(15);
        }

        [Test]
        public void AddListenerExpression15_ArgChecks()
        {
            Expression<Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, null));
        }

        [Test]
        public void AddListenerExpression15()
        {
            _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15));
            RunAndAssert(15);
        }

        [Test]
        public void AddListener16_ArgChecks()
        {
            Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, null));
        }

        [Test]
        public void AddListener16()
        {
            _b.AddListener<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16));
            RunAndAssert(16);
        }

        [Test]
        public void AddListenerExpression16_ArgChecks()
        {
            Expression<Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, I, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null, I, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, I, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, null));
        }

        [Test]
        public void AddListenerExpression16()
        {
            _b.AddListenerExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16));
            RunAndAssert(16);
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
