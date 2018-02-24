using NUnit.Framework;
using System;
using System.Linq.Expressions;
using dataprocessor;

namespace dataprocessor.tests
{
    public abstract class VerifyAPI
    {
        private IDataProcessorBuilder _b;
        private IDataProcessor _dp;

        protected abstract IDataProcessorBuilder GetBuilder();

        [SetUp]
        public void SetUp()
        {
            _b = GetBuilder();
        }

        [TearDown]
        public void TearDown()
        {
            _dp?.Close();
        }

        [Test]
        public void AddInput_ArgChecks()
        {
            var a = new NameType("a", typeof(bool));
            var b = new NameType("b", typeof(bool));
            var c = new NameType("c", typeof(bool));

            Assert.Throws<ArgumentException>(() => _b.AddInput<bool>(null), "null args");
            Assert.Throws<InvalidOperationException>(
                () => _b.AddInput<bool>("a").Send(true),
                "send before build");
            
            Assert.IsNotNull(_b.AddInput<bool>("c"), "success once");

            Assert.Throws<InvalidOperationException>(() => _b.AddInput<bool>("c"), "reject twice");
            Assert.Throws<InvalidOperationException>(() => _b.AddInput<int>("c"), "reject thrice");
        }

        [Test]
        public void AddListener_ArgChecks()
        {
            Assert.Throws<ArgumentException>(() => _b.AddListener<int>(null, _ => { }), "null name");
            Assert.Throws<ArgumentException>(() => _b.AddListener<int>("bob", null), "null action");

            Assert.DoesNotThrow(() => _b.AddListener<int>("bob", _ => { }), "success once");
            Assert.DoesNotThrow(() => _b.AddListener<int>("bob", _ => { }), "success twice");
            Assert.DoesNotThrow(() => _b.AddListener<int>("bob", _ => { }), "success thrice");
        }

        [Test]
        public void OneIn_OneOut()
        {
            var actual = 0;
            _b.AddListener<int>("bob", v => actual = v);
            var w = _b.AddInput<int>("bob");

            _dp = _b.Build();

            w.Send(1);
            Assert.AreEqual(1, actual, "once");

            w.Send(2);
            Assert.AreEqual(2, actual, "twice");
        }

        [Test, Explicit]
        public void OneIn_OneOut_MiniBench_Optimal()
        {
            var actual = 0;
            Action<int> w;

            using (Timer.Step("Setup"))
            {
                var listener = (Action<int>)(v => actual = v);

                var p = Expression.Parameter(typeof(int), "bob");
                var expr = Expression.Lambda<Action<int>>(
                    Expression.Invoke(
                        Expression.Constant(listener),
                        p),
                    p);
                
                w = expr.Compile();
            }

            using (Timer.Step("100 iterations"))
            {
                for (var ix = 0; ix < 100; ix++)
                {
                    w(1);
                    Assert.AreEqual(1, actual, "once");

                    w(2);
                    Assert.AreEqual(2, actual, "twice");
                }
            }

            using (Timer.Step("1000 iterations"))
            {
                for (var ix = 0; ix < 1000; ix++)
                {
                    w(1);
                    Assert.AreEqual(1, actual, "once");

                    w(2);
                    Assert.AreEqual(2, actual, "twice");
                }
            }
        }

        [Test, Explicit]
        public void OneIn_OneOut_MiniBench()
        {
            var actual = 0;
            IWriter<int> w;

            using (Timer.Step("Setup"))
            {
                _b.AddListener<int>("bob", v => actual = v);
                w = _b.AddInput<int>("bob");

                _dp = _b.Build();
            }

            using (Timer.Step("100 iterations"))
            {
                for (var ix = 0; ix < 100; ix++)
                {
                    w.Send(1);
                    Assert.AreEqual(1, actual, "once");

                    w.Send(2);
                    Assert.AreEqual(2, actual, "twice");
                }
            }

            using (Timer.Step("1000 iterations"))
            {
                for (var ix = 0; ix < 1000; ix++)
                {
                    w.Send(1);
                    Assert.AreEqual(1, actual, "once");

                    w.Send(2);
                    Assert.AreEqual(2, actual, "twice");
                }
            }
        }

        [Test]
        public void TwoIn_OneOut()
        {
            var actual = new int[] { 0 };

            var a = Expression.Parameter(typeof(int), "a");
            var b = Expression.Parameter(typeof(int), "b");
            _b.AddListener(new[] { "a", "b" }, Expression.Lambda(
                Expression.Assign(
                    Expression.ArrayAccess(
                        Expression.Constant(actual),
                        Expression.Constant(0)),
                    Expression.Add(a, b)),
                a, b));
            
            var w1 = _b.AddInput<int>("a");
            var w2 = _b.AddInput<int>("b");

            _dp = _b.Build();
            w1.Send(1);
            w2.Send(2);
            Assert.AreEqual(3, actual[0], "once");

            w1.Send(2);
            w2.Send(3);
            Assert.AreEqual(5, actual[0], "twice");
        }

        [Test]
        public void OneIn_DifferentOut()
        {
            var actual = 0;
            _b.AddListener<int>("jane", v => actual = v);
            var w = _b.AddInput<int>("bob");

            _dp = _b.Build();
            w.Send(1);
            Assert.AreEqual(0, actual, "once");

            w.Send(2);
            Assert.AreEqual(0, actual, "twice");
        }

        [Test]
        public void OneIn_TwoOut()
        {
            var actual1 = 0;
            var actual2 = 0;
            _b.AddListener<int>("bob", v => actual1 = v);
            _b.AddListener<int>("bob", v => actual2 = v);
            var w = _b.AddInput<int>("bob");

            _dp = _b.Build();
            w.Send(1);
            Assert.AreEqual(1, actual1, "once1");
            Assert.AreEqual(1, actual2, "once2");

            w.Send(2);
            Assert.AreEqual(2, actual1, "twice");
            Assert.AreEqual(2, actual2, "twice");
        }

        [Test]
        public void OneIn_ZeroOut()
        {
            var w = _b.AddInput<int>("bob");
            _dp = _b.Build();
            w.Send(1);
            w.Send(2);
        }

        [Test]
        public void Processor_OneIn_OneOut()
        {
            var w = _b.AddInput<int>("in");
            _b.AddProcessor<int, int>("in", "out", i => i + 15);

            var actual = 0;
            _b.AddListener<int>("out", v => actual = v);

            _dp = _b.Build();

            w.Send(32);
            Assert.AreEqual(47, actual, "once");

            w.Send(25);
            Assert.AreEqual(40, actual, "twice");
        }

        [Test]
        public void Processor_TwoIn_OneOut_SeparatePackets()
        {
            var w1 = _b.AddInput<int>("in1");
            var w2 = _b.AddInput<int>("in2");

            Expression<Func<int, int, int>> expr = (in1, in2) => in1 + in2;
            _b.AddProcessor(new[] { "in1", "in2" }, "out", expr);

            var actual = 0;
            _b.AddListener<int>("out", v => actual = v);

            _dp = _b.Build();

            w1.Send(32);
            Assert.AreEqual(0, actual, "not yet");

            w2.Send(23);
            Assert.AreEqual(55, actual, "once");

            w1.Send(1);
            Assert.AreEqual(55, actual, "not yet 2");

            w2.Send(2);
            Assert.AreEqual(3, actual, "twice");
        }

        [Test]
        public void Processor_Chained()
        {
            var w = _b.AddInput<int>("in");
            _b.AddProcessor<int, int>("in", "tmp1", (int i) => i + 1);
            _b.AddProcessor<int, int>("in", "tmp2", (int i) => i + 2);
            _b.AddProcessor(new[] { "tmp1", "tmp2" }, "out",
                           (Expression<Func<int, int, int>>)((int tmp1, int tmp2) => tmp1 + tmp2));

            var actual = 0;
            _b.AddListener<int>("out", v => actual = v);

            _dp = _b.Build();

            w.Send(1);
            Assert.AreEqual(5, actual);
            w.Send(10);
            Assert.AreEqual(23, actual);
            w.Send(3);
            Assert.AreEqual(9, actual);
        }
    }

    [TestFixture]
    public class Naive : VerifyAPI
    {
        protected override IDataProcessorBuilder GetBuilder() =>
            new NaiveDataProcessor();
    }

    [TestFixture]
    public class Draft1 : VerifyAPI
    {
        protected override IDataProcessorBuilder GetBuilder() =>
            new Draft1DataProcessor();
    }

    [TestFixture]
    public class Draft2 : VerifyAPI
    {
        protected override IDataProcessorBuilder GetBuilder() =>
            new Draft2DataProcessor();
    }
}
