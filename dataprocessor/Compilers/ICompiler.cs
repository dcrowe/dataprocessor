using System;
using System.Linq.Expressions;

namespace dataprocessor.Compilers
{
    public interface ICompiler
    {
        Delegate Compile(string name, LambdaExpression expression);
    }
}
