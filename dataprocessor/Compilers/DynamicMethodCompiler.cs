using System;
using System.Linq.Expressions;

namespace dataprocessor.Compilers
{
    public class DynamicMethodCompiler : ICompiler
    {
        public Delegate Compile(string name, LambdaExpression expression)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            if (expression == null)
                throw new ArgumentNullException(nameof(expression));

            using (Timer.Step("DynamicMethodCompiler.Compile"))
                return expression.Compile();
        }
    }
}
