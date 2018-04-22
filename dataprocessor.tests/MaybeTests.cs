using System;
using System.Linq.Expressions;
using NUnit.Framework;
namespace dataprocessor.tests
{
    public class MaybeTests
    {
        [Test]
        public void Just()
        {
            var j = Maybe<int>.Just(1);
            Assert.AreEqual(1, j.Value);
            Assert.AreEqual(true, j.IsPresent);
        }

        [Test]
        public void Cast()
        {
            Maybe<int> j = 1;
            Assert.AreEqual(1, j.Value);
            Assert.AreEqual(true, j.IsPresent);
        }

        [Test]
        public void Nothing()
        {
            var j = Maybe<int>.Nothing;
            Assert.AreEqual(0, j.Value);
            Assert.AreEqual(false, j.IsPresent);
        }

        [Test]
        public void IsMaybe()
        {
            Assert.IsTrue(typeof(Maybe<int>).IsMaybe());
            Assert.IsFalse(typeof(int).IsMaybe());
            Assert.Throws<ArgumentNullException>(() => Maybe.IsMaybe(null));
        }

        [Test]
        public void ToMaybe()
        {
            Assert.AreEqual(typeof(Maybe<int>), typeof(int).ToMaybe());
            Assert.Throws<ArgumentNullException>(() => Maybe.ToMaybe(null));
        }
    }
}
