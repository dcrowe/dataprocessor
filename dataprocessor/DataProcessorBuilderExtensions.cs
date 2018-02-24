using System;
using System.Linq.Expressions;

namespace dataprocessor
{
    public static class DataProcessorBuilderExtensions
    {
        public static void AddListener<T>(this IDataProcessorBuilder b, string name, Action<T> action)
        {
            if (name == null)
                throw new ArgumentException();
            if (action == null)
                throw new ArgumentException();

            var p = Expression.Parameter(typeof(T), name);
            var expr = Expression.Lambda<Action<T>>(Expression.Invoke(Expression.Constant(action), p), p);

            b.AddListener(new[] { name }, expr);
        }

        public static void AddProcessor<TI, TO>(this IDataProcessorBuilder b,
                                                string nameIn,
                                                string nameOut,
                                                Expression<Func<TI, TO>> processor)
        {
            b.AddProcessor(new[] { nameIn }, nameOut, processor);
        }

        private static readonly System.Reflection.PropertyInfo _debugViewProperty =
                                          typeof(Expression).GetProperty(
                                              "DebugView",
                                              System.Reflection.BindingFlags.GetProperty |
                                              System.Reflection.BindingFlags.NonPublic |
                                              System.Reflection.BindingFlags.Instance);

        public static string GetDebugString(this Expression expr)
        {
            var dv = (string)_debugViewProperty.GetValue(expr);
            return dv;
        }
    }
}
