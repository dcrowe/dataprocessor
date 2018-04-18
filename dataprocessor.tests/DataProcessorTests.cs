using System;
using NUnit.Framework;
namespace dataprocessor.tests
{
    public class DataProcessorTests
    {
        public class Closable : IClosable
        {
            public void Close() => IsClosed = true;
            public bool IsClosed { get; set; }
        }

        [Test]
        public void NoClosables()
        {
            var dp = new DataProcessor(null);
            dp.Close();
            ((IDisposable)dp).Dispose();
        }

        [Test]
        public void Closables_Close()
        {
            var c = new Closable();
            new DataProcessor(new[] { c }).Close();
            Assert.IsTrue(c.IsClosed);
        }

        [Test]
        public void Closables_Dispose()
        {
            var c = new Closable();
            using (new DataProcessor(new[] { c })) { }
            Assert.IsTrue(c.IsClosed);
        }
    }
}
