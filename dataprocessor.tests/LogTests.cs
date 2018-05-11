using System;
using System.Diagnostics;
using System.Linq.Expressions;
using NUnit.Framework;
namespace dataprocessor.tests
{
    public class LogTests
    {
        private StubListener _listener;
        private SourceLevels _origLevel;

        [SetUp]
        public void SetUp() 
        {
            _listener = new StubListener();
            Log.Src.Listeners.Add(_listener);

            _origLevel = Log.Src.Switch.Level;
            Log.Src.Switch.Level = SourceLevels.Off;
        }

        [TearDown]
        public void TearDown() 
        {
            Log.Src.Listeners.Remove(_listener);
            Log.Src.Switch.Level = _origLevel;
        }

        private class StubListener : TraceListener
        {
            public string Last;

            public override void Write(string message)
            {
                Last = message;
            }

            public override void WriteLine(string message)
            {
                Last = message;
            }
        }

        [Test]
        public void Verbose()
        {
            Log.Verbose("test");
            Assert.IsFalse(Log.IsVerbose);
            Assert.IsNull(_listener.Last);

            Log.Src.Switch.Level = SourceLevels.Verbose;

            Log.Verbose("test");
            Assert.IsTrue(Log.IsVerbose);
            Assert.AreEqual("test", _listener.Last);
        }

        [Test]
        public void Info()
        {
            Log.Info("test");
            Assert.IsFalse(Log.IsInfo);
            Assert.IsNull(_listener.Last);

            Log.Src.Switch.Level = SourceLevels.Information;

            Log.Info("test");
            Assert.IsTrue(Log.IsInfo);
            Assert.AreEqual("test", _listener.Last);
        }

        [Test]
        public void Warn()
        {
            Log.Warn("test");
            Assert.IsFalse(Log.IsWarn);
            Assert.IsNull(_listener.Last);

            Log.Src.Switch.Level = SourceLevels.Warning;

            Log.Warn("test");
            Assert.IsTrue(Log.IsWarn);
            Assert.AreEqual("test", _listener.Last);
        }

        [Test]
        public void Error()
        {
            Log.Error("test");
            Assert.IsFalse(Log.IsError);
            Assert.IsNull(_listener.Last);

            Log.Src.Switch.Level = SourceLevels.Error;

            Log.Error("test");
            Assert.IsTrue(Log.IsError);
            Assert.AreEqual("test", _listener.Last);
        }

        [Test]
        public void Verbose_Expr()
        {
            var expr = Expression.Lambda(Expression.Constant(1));

            Log.Verbose("test", expr);
            Assert.IsNull(_listener.Last);

            Log.Src.Switch.Level = SourceLevels.Verbose;

            Log.Verbose("test", expr);
            Assert.IsTrue(_listener.Last.StartsWith("test - .Lambda", StringComparison.InvariantCulture));

            Log.Verbose("test", null);
            Assert.IsTrue(_listener.Last.StartsWith("test - ", StringComparison.InvariantCulture));
        }

        [Test]
        public void TestTimer()
        {
            using (Timer.Step("test")) { }
            Assert.IsNull(_listener.Last);

            Log.Src.Switch.Level = SourceLevels.Verbose;

            using (Timer.Step("test")) { }
            Assert.IsTrue(_listener.Last.StartsWith("test: 0", StringComparison.InvariantCulture));
        }
    }
}