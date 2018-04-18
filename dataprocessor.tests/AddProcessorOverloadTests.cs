
using System;
using System.Linq;
using System.Linq.Expressions;
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
        public void AddProcessor1_ArgChecks()
        {
            Func<int, int> func = (p1) => Sum(p1);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int>(null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int>(I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int>(I, "o", (Func<int, int>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, "o", func));
        }

        [Test]
        public void AddProcessor1()
        {
            Func<int, int> func = (p1) => Sum(p1);
            _b.AddProcessor<int, int>(I, "o", func);
            RunAndAssert(1);
        }

        [Test]
        public void AddProcessorMaybe1_ArgChecks()
        {
            Func<int, Maybe<int>> func = (p1) => Maybe<int>.Just(Sum(p1));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int>(null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int>(I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int>(I, "o", (Func<int, Maybe<int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, "o", func));
        }

        [Test]
        public void AddProcessorMaybe1()
        {
            _b.AddProcessor<int, int>(I, "o", (p1) => Maybe<int>.Just(Sum(p1)));
            RunAndAssert(1);
        }

        [Test]
        public void AddProcessorExpression1_ArgChecks()
        {
            Expression<Func<int, int>> func = (p1) => Sum(p1);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int>(null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int>(I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int>(I, "o", (Expression<Func<int, int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, "o", func));
        }

        [Test]
        public void AddProcessorExpression1()
        {
            _b.AddProcessorExpression<int, int>(I, "o", (p1) => Sum(p1));
            RunAndAssert(1);
        }

        [Test]
        public void AddProcessorExpressionMaybe1_ArgChecks()
        {
            Expression<Func<int, Maybe<int>>> func = (p1) => Sum(p1);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int>(null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int>(I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int>(I, "o", (Expression<Func<int, Maybe<int>>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, "o", func));
        }

        [Test]
        public void AddProcessorExpressionMaybe1()
        {
            _b.AddProcessorExpression<int, int>(I, "o", (p1) => Maybe<int>.Just(Sum(p1)));
            RunAndAssert(1);
        }

        [Test]
        public void AddProcessor2_ArgChecks()
        {
            Func<int, int, int> func = (p1, p2) => Sum(p1, p2);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int>(null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int>(I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int>(I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int>(I, I, "o", (Func<int, int, int>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, "o", func));
        }

        [Test]
        public void AddProcessor2()
        {
            Func<int, int, int> func = (p1, p2) => Sum(p1, p2);
            _b.AddProcessor<int, int, int>(I, I, "o", func);
            RunAndAssert(2);
        }

        [Test]
        public void AddProcessorMaybe2_ArgChecks()
        {
            Func<int, int, Maybe<int>> func = (p1, p2) => Maybe<int>.Just(Sum(p1, p2));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int>(null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int>(I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int>(I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int>(I, I, "o", (Func<int, int, Maybe<int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, "o", func));
        }

        [Test]
        public void AddProcessorMaybe2()
        {
            _b.AddProcessor<int, int, int>(I, I, "o", (p1, p2) => Maybe<int>.Just(Sum(p1, p2)));
            RunAndAssert(2);
        }

        [Test]
        public void AddProcessorExpression2_ArgChecks()
        {
            Expression<Func<int, int, int>> func = (p1, p2) => Sum(p1, p2);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int>(null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int>(I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int>(I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int>(I, I, "o", (Expression<Func<int, int, int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpression2()
        {
            _b.AddProcessorExpression<int, int, int>(I, I, "o", (p1, p2) => Sum(p1, p2));
            RunAndAssert(2);
        }

        [Test]
        public void AddProcessorExpressionMaybe2_ArgChecks()
        {
            Expression<Func<int, int, Maybe<int>>> func = (p1, p2) => Sum(p1, p2);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int>(null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int>(I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int>(I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int>(I, I, "o", (Expression<Func<int, int, Maybe<int>>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpressionMaybe2()
        {
            _b.AddProcessorExpression<int, int, int>(I, I, "o", (p1, p2) => Maybe<int>.Just(Sum(p1, p2)));
            RunAndAssert(2);
        }

        [Test]
        public void AddProcessor3_ArgChecks()
        {
            Func<int, int, int, int> func = (p1, p2, p3) => Sum(p1, p2, p3);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int>(null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int>(I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int>(I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int>(I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int>(I, I, I, "o", (Func<int, int, int, int>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessor3()
        {
            Func<int, int, int, int> func = (p1, p2, p3) => Sum(p1, p2, p3);
            _b.AddProcessor<int, int, int, int>(I, I, I, "o", func);
            RunAndAssert(3);
        }

        [Test]
        public void AddProcessorMaybe3_ArgChecks()
        {
            Func<int, int, int, Maybe<int>> func = (p1, p2, p3) => Maybe<int>.Just(Sum(p1, p2, p3));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int>(null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int>(I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int>(I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int>(I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int>(I, I, I, "o", (Func<int, int, int, Maybe<int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorMaybe3()
        {
            _b.AddProcessor<int, int, int, int>(I, I, I, "o", (p1, p2, p3) => Maybe<int>.Just(Sum(p1, p2, p3)));
            RunAndAssert(3);
        }

        [Test]
        public void AddProcessorExpression3_ArgChecks()
        {
            Expression<Func<int, int, int, int>> func = (p1, p2, p3) => Sum(p1, p2, p3);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int>(null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int>(I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int>(I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int>(I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int>(I, I, I, "o", (Expression<Func<int, int, int, int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpression3()
        {
            _b.AddProcessorExpression<int, int, int, int>(I, I, I, "o", (p1, p2, p3) => Sum(p1, p2, p3));
            RunAndAssert(3);
        }

        [Test]
        public void AddProcessorExpressionMaybe3_ArgChecks()
        {
            Expression<Func<int, int, int, Maybe<int>>> func = (p1, p2, p3) => Sum(p1, p2, p3);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int>(null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int>(I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int>(I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int>(I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int>(I, I, I, "o", (Expression<Func<int, int, int, Maybe<int>>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpressionMaybe3()
        {
            _b.AddProcessorExpression<int, int, int, int>(I, I, I, "o", (p1, p2, p3) => Maybe<int>.Just(Sum(p1, p2, p3)));
            RunAndAssert(3);
        }

        [Test]
        public void AddProcessor4_ArgChecks()
        {
            Func<int, int, int, int, int> func = (p1, p2, p3, p4) => Sum(p1, p2, p3, p4);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int>(null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int>(I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int>(I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int>(I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int>(I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int>(I, I, I, I, "o", (Func<int, int, int, int, int>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessor4()
        {
            Func<int, int, int, int, int> func = (p1, p2, p3, p4) => Sum(p1, p2, p3, p4);
            _b.AddProcessor<int, int, int, int, int>(I, I, I, I, "o", func);
            RunAndAssert(4);
        }

        [Test]
        public void AddProcessorMaybe4_ArgChecks()
        {
            Func<int, int, int, int, Maybe<int>> func = (p1, p2, p3, p4) => Maybe<int>.Just(Sum(p1, p2, p3, p4));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int>(null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int>(I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int>(I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int>(I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int>(I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int>(I, I, I, I, "o", (Func<int, int, int, int, Maybe<int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorMaybe4()
        {
            _b.AddProcessor<int, int, int, int, int>(I, I, I, I, "o", (p1, p2, p3, p4) => Maybe<int>.Just(Sum(p1, p2, p3, p4)));
            RunAndAssert(4);
        }

        [Test]
        public void AddProcessorExpression4_ArgChecks()
        {
            Expression<Func<int, int, int, int, int>> func = (p1, p2, p3, p4) => Sum(p1, p2, p3, p4);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int>(null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int>(I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int>(I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int>(I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int>(I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int>(I, I, I, I, "o", (Expression<Func<int, int, int, int, int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpression4()
        {
            _b.AddProcessorExpression<int, int, int, int, int>(I, I, I, I, "o", (p1, p2, p3, p4) => Sum(p1, p2, p3, p4));
            RunAndAssert(4);
        }

        [Test]
        public void AddProcessorExpressionMaybe4_ArgChecks()
        {
            Expression<Func<int, int, int, int, Maybe<int>>> func = (p1, p2, p3, p4) => Sum(p1, p2, p3, p4);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int>(null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int>(I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int>(I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int>(I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int>(I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int>(I, I, I, I, "o", (Expression<Func<int, int, int, int, Maybe<int>>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpressionMaybe4()
        {
            _b.AddProcessorExpression<int, int, int, int, int>(I, I, I, I, "o", (p1, p2, p3, p4) => Maybe<int>.Just(Sum(p1, p2, p3, p4)));
            RunAndAssert(4);
        }

        [Test]
        public void AddProcessor5_ArgChecks()
        {
            Func<int, int, int, int, int, int> func = (p1, p2, p3, p4, p5) => Sum(p1, p2, p3, p4, p5);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int>(null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int>(I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int>(I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int>(I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int>(I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int>(I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int>(I, I, I, I, I, "o", (Func<int, int, int, int, int, int>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessor5()
        {
            Func<int, int, int, int, int, int> func = (p1, p2, p3, p4, p5) => Sum(p1, p2, p3, p4, p5);
            _b.AddProcessor<int, int, int, int, int, int>(I, I, I, I, I, "o", func);
            RunAndAssert(5);
        }

        [Test]
        public void AddProcessorMaybe5_ArgChecks()
        {
            Func<int, int, int, int, int, Maybe<int>> func = (p1, p2, p3, p4, p5) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int>(null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int>(I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int>(I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int>(I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int>(I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int>(I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int>(I, I, I, I, I, "o", (Func<int, int, int, int, int, Maybe<int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorMaybe5()
        {
            _b.AddProcessor<int, int, int, int, int, int>(I, I, I, I, I, "o", (p1, p2, p3, p4, p5) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5)));
            RunAndAssert(5);
        }

        [Test]
        public void AddProcessorExpression5_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, int>> func = (p1, p2, p3, p4, p5) => Sum(p1, p2, p3, p4, p5);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int>(null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int>(I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int>(I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int>(I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int>(I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int>(I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int>(I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpression5()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int>(I, I, I, I, I, "o", (p1, p2, p3, p4, p5) => Sum(p1, p2, p3, p4, p5));
            RunAndAssert(5);
        }

        [Test]
        public void AddProcessorExpressionMaybe5_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, Maybe<int>>> func = (p1, p2, p3, p4, p5) => Sum(p1, p2, p3, p4, p5);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int>(null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int>(I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int>(I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int>(I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int>(I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int>(I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int>(I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, Maybe<int>>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpressionMaybe5()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int>(I, I, I, I, I, "o", (p1, p2, p3, p4, p5) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5)));
            RunAndAssert(5);
        }

        [Test]
        public void AddProcessor6_ArgChecks()
        {
            Func<int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6) => Sum(p1, p2, p3, p4, p5, p6);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int>(null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int>(I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int>(I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int>(I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int>(I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int>(I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int>(I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int>(I, I, I, I, I, I, "o", (Func<int, int, int, int, int, int, int>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessor6()
        {
            Func<int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6) => Sum(p1, p2, p3, p4, p5, p6);
            _b.AddProcessor<int, int, int, int, int, int, int>(I, I, I, I, I, I, "o", func);
            RunAndAssert(6);
        }

        [Test]
        public void AddProcessorMaybe6_ArgChecks()
        {
            Func<int, int, int, int, int, int, Maybe<int>> func = (p1, p2, p3, p4, p5, p6) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int>(null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int>(I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int>(I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int>(I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int>(I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int>(I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int>(I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int>(I, I, I, I, I, I, "o", (Func<int, int, int, int, int, int, Maybe<int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorMaybe6()
        {
            _b.AddProcessor<int, int, int, int, int, int, int>(I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6)));
            RunAndAssert(6);
        }

        [Test]
        public void AddProcessorExpression6_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, int, int>> func = (p1, p2, p3, p4, p5, p6) => Sum(p1, p2, p3, p4, p5, p6);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int>(null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int>(I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int>(I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int>(I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int>(I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int>(I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int>(I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int>(I, I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, int, int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpression6()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int>(I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6) => Sum(p1, p2, p3, p4, p5, p6));
            RunAndAssert(6);
        }

        [Test]
        public void AddProcessorExpressionMaybe6_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, int, Maybe<int>>> func = (p1, p2, p3, p4, p5, p6) => Sum(p1, p2, p3, p4, p5, p6);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int>(null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int>(I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int>(I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int>(I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int>(I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int>(I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int>(I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int>(I, I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, int, Maybe<int>>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpressionMaybe6()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int>(I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6)));
            RunAndAssert(6);
        }

        [Test]
        public void AddProcessor7_ArgChecks()
        {
            Func<int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7) => Sum(p1, p2, p3, p4, p5, p6, p7);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, "o", (Func<int, int, int, int, int, int, int, int>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessor7()
        {
            Func<int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7) => Sum(p1, p2, p3, p4, p5, p6, p7);
            _b.AddProcessor<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, "o", func);
            RunAndAssert(7);
        }

        [Test]
        public void AddProcessorMaybe7_ArgChecks()
        {
            Func<int, int, int, int, int, int, int, Maybe<int>> func = (p1, p2, p3, p4, p5, p6, p7) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, "o", (Func<int, int, int, int, int, int, int, Maybe<int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorMaybe7()
        {
            _b.AddProcessor<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7)));
            RunAndAssert(7);
        }

        [Test]
        public void AddProcessorExpression7_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, int, int, int>> func = (p1, p2, p3, p4, p5, p6, p7) => Sum(p1, p2, p3, p4, p5, p6, p7);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, int, int, int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpression7()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7) => Sum(p1, p2, p3, p4, p5, p6, p7));
            RunAndAssert(7);
        }

        [Test]
        public void AddProcessorExpressionMaybe7_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, int, int, Maybe<int>>> func = (p1, p2, p3, p4, p5, p6, p7) => Sum(p1, p2, p3, p4, p5, p6, p7);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, int, int, Maybe<int>>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpressionMaybe7()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7)));
            RunAndAssert(7);
        }

        [Test]
        public void AddProcessor8_ArgChecks()
        {
            Func<int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8) => Sum(p1, p2, p3, p4, p5, p6, p7, p8);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, "o", (Func<int, int, int, int, int, int, int, int, int>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessor8()
        {
            Func<int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8) => Sum(p1, p2, p3, p4, p5, p6, p7, p8);
            _b.AddProcessor<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, "o", func);
            RunAndAssert(8);
        }

        [Test]
        public void AddProcessorMaybe8_ArgChecks()
        {
            Func<int, int, int, int, int, int, int, int, Maybe<int>> func = (p1, p2, p3, p4, p5, p6, p7, p8) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, "o", (Func<int, int, int, int, int, int, int, int, Maybe<int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorMaybe8()
        {
            _b.AddProcessor<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8)));
            RunAndAssert(8);
        }

        [Test]
        public void AddProcessorExpression8_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int>> func = (p1, p2, p3, p4, p5, p6, p7, p8) => Sum(p1, p2, p3, p4, p5, p6, p7, p8);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, int, int, int, int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpression8()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8) => Sum(p1, p2, p3, p4, p5, p6, p7, p8));
            RunAndAssert(8);
        }

        [Test]
        public void AddProcessorExpressionMaybe8_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, int, int, int, Maybe<int>>> func = (p1, p2, p3, p4, p5, p6, p7, p8) => Sum(p1, p2, p3, p4, p5, p6, p7, p8);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, int, int, int, Maybe<int>>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpressionMaybe8()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8)));
            RunAndAssert(8);
        }

        [Test]
        public void AddProcessor9_ArgChecks()
        {
            Func<int, int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, "o", (Func<int, int, int, int, int, int, int, int, int, int>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessor9()
        {
            Func<int, int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9);
            _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, "o", func);
            RunAndAssert(9);
        }

        [Test]
        public void AddProcessorMaybe9_ArgChecks()
        {
            Func<int, int, int, int, int, int, int, int, int, Maybe<int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, "o", (Func<int, int, int, int, int, int, int, int, int, Maybe<int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorMaybe9()
        {
            _b.AddProcessor<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9)));
            RunAndAssert(9);
        }

        [Test]
        public void AddProcessorExpression9_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, int, int, int, int, int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpression9()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9));
            RunAndAssert(9);
        }

        [Test]
        public void AddProcessorExpressionMaybe9_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, Maybe<int>>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, int, int, int, int, Maybe<int>>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpressionMaybe9()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9)));
            RunAndAssert(9);
        }

        [Test]
        public void AddProcessor10_ArgChecks()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, "o", (Func<int, int, int, int, int, int, int, int, int, int, int>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessor10()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
            _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, "o", func);
            RunAndAssert(10);
        }

        [Test]
        public void AddProcessorMaybe10_ArgChecks()
        {
            Func<int, int, int, int, int, int, int, int, int, int, Maybe<int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, "o", (Func<int, int, int, int, int, int, int, int, int, int, Maybe<int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorMaybe10()
        {
            _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10)));
            RunAndAssert(10);
        }

        [Test]
        public void AddProcessorExpression10_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, int, int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, int, int, int, int, int, int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpression10()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10));
            RunAndAssert(10);
        }

        [Test]
        public void AddProcessorExpressionMaybe10_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, int, Maybe<int>>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, int, int, int, int, int, Maybe<int>>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpressionMaybe10()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10)));
            RunAndAssert(10);
        }

        [Test]
        public void AddProcessor11_ArgChecks()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, "o", (Func<int, int, int, int, int, int, int, int, int, int, int, int>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessor11()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
            _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, "o", func);
            RunAndAssert(11);
        }

        [Test]
        public void AddProcessorMaybe11_ArgChecks()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, Maybe<int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, "o", (Func<int, int, int, int, int, int, int, int, int, int, int, Maybe<int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorMaybe11()
        {
            _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11)));
            RunAndAssert(11);
        }

        [Test]
        public void AddProcessorExpression11_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpression11()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11));
            RunAndAssert(11);
        }

        [Test]
        public void AddProcessorExpressionMaybe11_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, int, int, Maybe<int>>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, int, int, int, int, int, int, Maybe<int>>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpressionMaybe11()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11)));
            RunAndAssert(11);
        }

        [Test]
        public void AddProcessor12_ArgChecks()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, "o", (Func<int, int, int, int, int, int, int, int, int, int, int, int, int>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessor12()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
            _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, "o", func);
            RunAndAssert(12);
        }

        [Test]
        public void AddProcessorMaybe12_ArgChecks()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, Maybe<int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, "o", (Func<int, int, int, int, int, int, int, int, int, int, int, int, Maybe<int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorMaybe12()
        {
            _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12)));
            RunAndAssert(12);
        }

        [Test]
        public void AddProcessorExpression12_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpression12()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12));
            RunAndAssert(12);
        }

        [Test]
        public void AddProcessorExpressionMaybe12_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, Maybe<int>>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, Maybe<int>>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpressionMaybe12()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12)));
            RunAndAssert(12);
        }

        [Test]
        public void AddProcessor13_ArgChecks()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessor13()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
            _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func);
            RunAndAssert(13);
        }

        [Test]
        public void AddProcessorMaybe13_ArgChecks()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, Maybe<int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (Func<int, int, int, int, int, int, int, int, int, int, int, int, int, Maybe<int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorMaybe13()
        {
            _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13)));
            RunAndAssert(13);
        }

        [Test]
        public void AddProcessorExpression13_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpression13()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13));
            RunAndAssert(13);
        }

        [Test]
        public void AddProcessorExpressionMaybe13_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, Maybe<int>>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, Maybe<int>>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpressionMaybe13()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13)));
            RunAndAssert(13);
        }

        [Test]
        public void AddProcessor14_ArgChecks()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessor14()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
            _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func);
            RunAndAssert(14);
        }

        [Test]
        public void AddProcessorMaybe14_ArgChecks()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, Maybe<int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, Maybe<int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorMaybe14()
        {
            _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14)));
            RunAndAssert(14);
        }

        [Test]
        public void AddProcessorExpression14_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpression14()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14));
            RunAndAssert(14);
        }

        [Test]
        public void AddProcessorExpressionMaybe14_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, Maybe<int>>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, Maybe<int>>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpressionMaybe14()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14)));
            RunAndAssert(14);
        }

        [Test]
        public void AddProcessor15_ArgChecks()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessor15()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
            _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func);
            RunAndAssert(15);
        }

        [Test]
        public void AddProcessorMaybe15_ArgChecks()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, Maybe<int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, Maybe<int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorMaybe15()
        {
            _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15)));
            RunAndAssert(15);
        }

        [Test]
        public void AddProcessorExpression15_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpression15()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15));
            RunAndAssert(15);
        }

        [Test]
        public void AddProcessorExpressionMaybe15_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, Maybe<int>>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, Maybe<int>>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpressionMaybe15()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15)));
            RunAndAssert(15);
        }

        [Test]
        public void AddProcessor16_ArgChecks()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessor16()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
            _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func);
            RunAndAssert(16);
        }

        [Test]
        public void AddProcessorMaybe16_ArgChecks()
        {
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, Maybe<int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, Maybe<int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessor(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorMaybe16()
        {
            _b.AddProcessor<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16)));
            RunAndAssert(16);
        }

        [Test]
        public void AddProcessorExpression16_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpression16()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16));
            RunAndAssert(16);
        }

        [Test]
        public void AddProcessorExpressionMaybe16_ArgChecks()
        {
            Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, Maybe<int>>> func = (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, null, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, null, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, null, I, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, null, I, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, null, I, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, null, I, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, null, I, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, null, I, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, null, I, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, null, I, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, null, I, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, null, I, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, I, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, "o", func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, null, func));
            Assert.Throws<ArgumentNullException>(() => _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (Expression<Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, Maybe<int>>>)null));
            Assert.Throws<ArgumentNullException>(() => DataProcessorBuilderExtensions.AddProcessorExpression(null, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", func));
        }

        [Test]
        public void AddProcessorExpressionMaybe16()
        {
            _b.AddProcessorExpression<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>(I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, I, "o", (p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16) => Maybe<int>.Just(Sum(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16)));
            RunAndAssert(16);
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
