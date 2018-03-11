using System;
using System.Linq.Expressions;
using System.Reflection;
using dataprocessor.Compilers;
using NUnit.Framework;

namespace dataprocessor.tests
{
    public abstract class VerifyCompiler
    {
        private ICompiler _c;

        protected abstract ICompiler GetCompiler();

        [SetUp]
        public void SetUp()
        {
            _c = GetCompiler();
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void CheckArgs()
        {
            var e = Expression.Lambda(Expression.Empty());

            Assert.Throws<ArgumentNullException>(() => _c.Compile(null, e));
            Assert.Throws<ArgumentNullException>(() => _c.Compile("bob", null));
        }

        [Test]
        public void CompilesAndRuns() 
        {
            var p = Expression.Parameter(typeof(int));
            var e = Expression.Lambda(
                typeof(Func<int, int>),
                Expression.Add(p, Expression.Constant(1)),
                p);

            var del = (Func<int, int>)_c.Compile("test", e);
            Assert.AreEqual(3, del(2));
        }

        [Test]
        public void FailEarlyIfPrivateMethodsAreNotSupported()
        {
            Func<int, int> del;

            try
            {
                var p = Expression.Parameter(typeof(int));
                var e = Expression.Lambda(
                    typeof(Func<int, int>),
                    Expression.Call(
                        typeof(VerifyCompiler),
                        "PrivateMethod",
                        null,
                        p),
                    p);

                del = (Func<int, int>)_c.Compile("test", e);
            }
            catch(MethodAccessException)
            {
                Assert.Pass();
                return;
            }

            Assert.AreEqual(3, del(2));
        }

        private static int PrivateMethod(int v) => v + 1;

    }

    public class VerifyDynamicMethodCompiler : VerifyCompiler
    {
        protected override ICompiler GetCompiler()
        {
            return new DynamicMethodCompiler();
        }
    }

    public class VerifyMethodBuilderCompiler : VerifyCompiler
    {
        protected override ICompiler GetCompiler()
        {
            return new MethodBuilderCompiler(
                new AssemblyName("Tests"));
        }
    }
}
