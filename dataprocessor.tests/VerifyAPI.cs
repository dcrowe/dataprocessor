using NUnit.Framework;
using System;
using dataprocessor.Compilers;
using dataprocessor.Old;

namespace dataprocessor.tests
{
    public abstract class VerifyAPI
    {
        private IDataProcessorBuilder _b;
        private IDataProcessor _dp;
        private int _actual;
        private int _actual2;

        protected abstract IDataProcessorBuilder GetBuilder();

        [SetUp]
        public void SetUp()
        {
            _b = GetBuilder();
            _actual = 0;
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
            _b.AddListener<int>("bob", SetActual);
            var w = _b.AddInput<int>("bob");

            _dp = _b.Build();

            w.Send(1);
            Assert.AreEqual(1, _actual, "once");

            w.Send(2);
            Assert.AreEqual(2, _actual, "twice");
        }

        [Test]
        public void TwoIn_OneOut()
        {
            _b.AddListenerExpression<int, int>("a", "b", (a, b) => SetActual(a + b));
            var w1 = _b.AddInput<int>("a");
            var w2 = _b.AddInput<int>("b");

            _dp = _b.Build();
            w1.Send(1);
            w2.Send(2);
            Assert.AreEqual(3, _actual, "once");

            w1.Send(2);
            w2.Send(3);
            Assert.AreEqual(5, _actual, "twice");
        }

        [Test]
        public void OneIn_DifferentOut()
        {
            _b.AddListener<int>("jane", SetActual);
            var w = _b.AddInput<int>("bob");

            _dp = _b.Build();
            w.Send(1);
            Assert.AreEqual(0, _actual, "once");

            w.Send(2);
            Assert.AreEqual(0, _actual, "twice");
        }

        [Test]
        public void OneIn_TwoOut()
        {
            _b.AddListener<int>("bob", SetActual);
            _b.AddListener<int>("bob", SetActual2);
            var w = _b.AddInput<int>("bob");

            _dp = _b.Build();
            w.Send(1);
            Assert.AreEqual(1, _actual, "once1");
            Assert.AreEqual(1, _actual2, "once2");

            w.Send(2);
            Assert.AreEqual(2, _actual, "twice");
            Assert.AreEqual(2, _actual2, "twice");
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
            _b.AddProcessor<int, int>("in", "out", Plus1);
            _b.AddListener<int>("out", SetActual);

            _dp = _b.Build();

            w.Send(32);
            Assert.AreEqual(33, _actual, "once");

            w.Send(25);
            Assert.AreEqual(26, _actual, "twice");
        }

        [Test]
        public void Processor_TwoIn_OneOut_SeparatePackets()
        {
            var w1 = _b.AddInput<int>("in1");
            var w2 = _b.AddInput<int>("in2");
            _b.AddProcessor<int,int,int>( "in1", "in2" , "out", Add);

            _b.AddListener<int>("out", SetActual);

            _dp = _b.Build();

            w1.Send(32);
            Assert.AreEqual(0, _actual, "not yet");

            w2.Send(23);
            Assert.AreEqual(55, _actual, "once");

            w1.Send(1);
            Assert.AreEqual(55, _actual, "not yet 2");

            w2.Send(2);
            Assert.AreEqual(3, _actual, "twice");
        }

        [Test]
        public void Processor_Chained()
        {
            var w = _b.AddInput<int>("in");
            _b.AddProcessor<int, int>("in", "tmp1", Plus1);
            _b.AddProcessor<int, int>("in", "tmp2", Plus2);
            _b.AddProcessor<int, int, int>("tmp1", "tmp2", "out", Add);

            _b.AddListener<int>("out", SetActual);

            _dp = _b.Build();

            w.Send(1);
            Assert.AreEqual(5, _actual);
            w.Send(10);
            Assert.AreEqual(23, _actual);
            w.Send(3);
            Assert.AreEqual(9, _actual);
        }

        [Test]
        public void Processor_TwoIn_Chained() 
        {
            var w1 = _b.AddInput<int>("in1");
            var w2 = _b.AddInput<int>("in2");
            _b.AddProcessor<int, int>("in1", "tmp1", Plus1);
            _b.AddProcessor<int, int>("in2", "tmp2", Plus2);
            _b.AddProcessor<int, int, int>("tmp1", "tmp2", "out", Add);
            _b.AddListener<int>("out", SetActual);
            _dp = _b.Build();

            w1.Send(1);
            Assert.AreEqual(0, _actual);
            w2.Send(3);
            Assert.AreEqual(7, _actual);
        }

        [Test]
        public void Processor_Optional()
        {
            var w = _b.AddInput<int>("in");
            _b.AddProcessorExpression<int, int>(
                "in", "out",
                i => i == 10 ? Maybe<int>.Nothing : Maybe<int>.Just(i));
            _b.AddListener<int>("out", SetActual);
            _dp = _b.Build();

            w.Send(1);
            Assert.AreEqual(1, _actual);

            w.Send(10);
            Assert.AreEqual(1, _actual);

            w.Send(2);
            Assert.AreEqual(2, _actual);

            w.Send(10);
            Assert.AreEqual(2, _actual);
        }

        [Test]
        public void Processor_Optional_Two()
        {
            var w1 = _b.AddInput<int>("in1");
            var w2 = _b.AddInput<int>("in2");
            _b.AddProcessorExpression<int, int, int>(
                "in1", "in2", "out",
                (i,j) => i == 0 ? Maybe<int>.Nothing : Maybe<int>.Just(j));
            _b.AddListener<int>("out", SetActual);
            _dp = _b.Build();

            w1.Send(1);
            w2.Send(1);
            Assert.AreEqual(1, _actual);

            w2.Send(2);
            w1.Send(1);
            Assert.AreEqual(2, _actual);

            w1.Send(0);
            w2.Send(3);
            Assert.AreEqual(2, _actual);

            w2.Send(4);
            w1.Send(0);
            Assert.AreEqual(2, _actual);
        }

        [Test]
        public void Processor_Optional_Chained()
        {
            var w1 = _b.AddInput<int>("in1");
            _b.AddProcessorExpression<int, int>(
                "in1", "in2",
                i => i == 10 ? Maybe<int>.Nothing : Maybe<int>.Just(i));
            _b.AddProcessorExpression<int, int>(
                "in2", "out",
                i => i + 1);
            _b.AddListener<int>("out", SetActual);
            _dp = _b.Build();

            w1.Send(1);
            Assert.AreEqual(2, _actual);

            w1.Send(2);
            Assert.AreEqual(3, _actual);

            w1.Send(10);
            Assert.AreEqual(3, _actual);

            w1.Send(11);
            Assert.AreEqual(12, _actual);
        }

        public int Add(int i, int j) => i + j;
        public int Plus1(int i) => i + 1;
        public int Plus2(int i) => i + 2;
        public void SetActual(int i) => _actual = i;
        public void SetActual2(int i) => _actual2 = i;

        [Test]
        public void GetName()
        {
            Assert.Throws<ArgumentNullException>(() => _b.GetName(null));

            _b.AddInput<int>("yep");

            Assert.AreEqual(NameType.Empty, _b.GetName("nope"));
            Assert.AreEqual(NameType.From<int>("yep"), _b.GetName("yep"));
        }

        [Test]
        public void GetAllNames()
        {
            CollectionAssert.IsEmpty(_b.GetAllNames());

            _b.AddInput<int>("a");
            _b.AddInput<float>("b");
            _b.AddInput<char>("c");

            var expected = new[]
            {
                NameType.From<int>("a"),
                NameType.From<float>("b"),
                NameType.From<char>("c"),
            };
            CollectionAssert.AreEquivalent(expected, _b.GetAllNames());
        }
    }

    [TestFixture]
    public class Naive : VerifyAPI
    {
        protected override IDataProcessorBuilder GetBuilder() =>
            new NaiveDataProcessor();
    }

    [TestFixture]
    public class Actual_DynamicMethod : VerifyAPI
    {
        protected override IDataProcessorBuilder GetBuilder() =>
            new DataProcessorBuilder();
    }

    [TestFixture]
    public class Actual_MethodBuilder : VerifyAPI
    {
        protected override IDataProcessorBuilder GetBuilder() =>
            new DataProcessorBuilder(new MethodBuilderCompiler());
    }
}
