
using System;
using System.Linq.Expressions;

namespace dataprocessor
{
    public static partial class DataProcessorBuilderExtensions
    {
        public static void AddListener<T1>(
            this IDataProcessorBuilder builder,
            string n1,
            Action<T1> action)
        {
            if (builder == null)
                throw new ArgumentException(nameof(builder));
            if (action == null)
                throw new ArgumentException(nameof(action));

            if (n1 == null)
                throw new ArgumentException(nameof(n1));
            var p1 = Expression.Parameter(typeof(T1), n1);

            var expr = Expression.Lambda<Action<T1>>(
                Expression.Invoke(
                    Expression.Constant(action), 
                    p1),
                p1);

            builder.AddListener(new[] { n1 }, expr);
        }

        public static void AddProcessor<T1, TResult>(
            this IDataProcessorBuilder builder,
            string n1,
            string nameResult,
            Func<T1, TResult> function)
        {
            if (builder == null)
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (n1 == null)
                throw new ArgumentException(nameof(n1));
            var p1 = Expression.Parameter(typeof(T1), n1);

            var expr = Expression.Lambda<Func<T1, TResult>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1),
                p1);

            builder.AddProcessor(new[] { n1 }, nameResult, expr);
        }

        public static void AddListener<T1, T2>(
            this IDataProcessorBuilder builder,
            string n1,
            string n2,
            Action<T1, T2> action)
        {
            if (builder == null)
                throw new ArgumentException(nameof(builder));
            if (action == null)
                throw new ArgumentException(nameof(action));

            if (n1 == null)
                throw new ArgumentException(nameof(n1));
            var p1 = Expression.Parameter(typeof(T1), n1);

            if (n2 == null)
                throw new ArgumentException(nameof(n2));
            var p2 = Expression.Parameter(typeof(T2), n2);

            var expr = Expression.Lambda<Action<T1, T2>>(
                Expression.Invoke(
                    Expression.Constant(action), 
                    p1, p2),
                p1, p2);

            builder.AddListener(new[] { n1, n2 }, expr);
        }

        public static void AddProcessor<T1, T2, TResult>(
            this IDataProcessorBuilder builder,
            string n1,
            string n2,
            string nameResult,
            Func<T1, T2, TResult> function)
        {
            if (builder == null)
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (n1 == null)
                throw new ArgumentException(nameof(n1));
            var p1 = Expression.Parameter(typeof(T1), n1);

            if (n2 == null)
                throw new ArgumentException(nameof(n2));
            var p2 = Expression.Parameter(typeof(T2), n2);

            var expr = Expression.Lambda<Func<T1, T2, TResult>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2),
                p1, p2);

            builder.AddProcessor(new[] { n1, n2 }, nameResult, expr);
        }

        public static void AddListener<T1, T2, T3>(
            this IDataProcessorBuilder builder,
            string n1,
            string n2,
            string n3,
            Action<T1, T2, T3> action)
        {
            if (builder == null)
                throw new ArgumentException(nameof(builder));
            if (action == null)
                throw new ArgumentException(nameof(action));

            if (n1 == null)
                throw new ArgumentException(nameof(n1));
            var p1 = Expression.Parameter(typeof(T1), n1);

            if (n2 == null)
                throw new ArgumentException(nameof(n2));
            var p2 = Expression.Parameter(typeof(T2), n2);

            if (n3 == null)
                throw new ArgumentException(nameof(n3));
            var p3 = Expression.Parameter(typeof(T3), n3);

            var expr = Expression.Lambda<Action<T1, T2, T3>>(
                Expression.Invoke(
                    Expression.Constant(action), 
                    p1, p2, p3),
                p1, p2, p3);

            builder.AddListener(new[] { n1, n2, n3 }, expr);
        }

        public static void AddProcessor<T1, T2, T3, TResult>(
            this IDataProcessorBuilder builder,
            string n1,
            string n2,
            string n3,
            string nameResult,
            Func<T1, T2, T3, TResult> function)
        {
            if (builder == null)
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (n1 == null)
                throw new ArgumentException(nameof(n1));
            var p1 = Expression.Parameter(typeof(T1), n1);

            if (n2 == null)
                throw new ArgumentException(nameof(n2));
            var p2 = Expression.Parameter(typeof(T2), n2);

            if (n3 == null)
                throw new ArgumentException(nameof(n3));
            var p3 = Expression.Parameter(typeof(T3), n3);

            var expr = Expression.Lambda<Func<T1, T2, T3, TResult>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3),
                p1, p2, p3);

            builder.AddProcessor(new[] { n1, n2, n3 }, nameResult, expr);
        }

        public static void AddListener<T1, T2, T3, T4>(
            this IDataProcessorBuilder builder,
            string n1,
            string n2,
            string n3,
            string n4,
            Action<T1, T2, T3, T4> action)
        {
            if (builder == null)
                throw new ArgumentException(nameof(builder));
            if (action == null)
                throw new ArgumentException(nameof(action));

            if (n1 == null)
                throw new ArgumentException(nameof(n1));
            var p1 = Expression.Parameter(typeof(T1), n1);

            if (n2 == null)
                throw new ArgumentException(nameof(n2));
            var p2 = Expression.Parameter(typeof(T2), n2);

            if (n3 == null)
                throw new ArgumentException(nameof(n3));
            var p3 = Expression.Parameter(typeof(T3), n3);

            if (n4 == null)
                throw new ArgumentException(nameof(n4));
            var p4 = Expression.Parameter(typeof(T4), n4);

            var expr = Expression.Lambda<Action<T1, T2, T3, T4>>(
                Expression.Invoke(
                    Expression.Constant(action), 
                    p1, p2, p3, p4),
                p1, p2, p3, p4);

            builder.AddListener(new[] { n1, n2, n3, n4 }, expr);
        }

        public static void AddProcessor<T1, T2, T3, T4, TResult>(
            this IDataProcessorBuilder builder,
            string n1,
            string n2,
            string n3,
            string n4,
            string nameResult,
            Func<T1, T2, T3, T4, TResult> function)
        {
            if (builder == null)
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (n1 == null)
                throw new ArgumentException(nameof(n1));
            var p1 = Expression.Parameter(typeof(T1), n1);

            if (n2 == null)
                throw new ArgumentException(nameof(n2));
            var p2 = Expression.Parameter(typeof(T2), n2);

            if (n3 == null)
                throw new ArgumentException(nameof(n3));
            var p3 = Expression.Parameter(typeof(T3), n3);

            if (n4 == null)
                throw new ArgumentException(nameof(n4));
            var p4 = Expression.Parameter(typeof(T4), n4);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, TResult>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4),
                p1, p2, p3, p4);

            builder.AddProcessor(new[] { n1, n2, n3, n4 }, nameResult, expr);
        }

        public static void AddListener<T1, T2, T3, T4, T5>(
            this IDataProcessorBuilder builder,
            string n1,
            string n2,
            string n3,
            string n4,
            string n5,
            Action<T1, T2, T3, T4, T5> action)
        {
            if (builder == null)
                throw new ArgumentException(nameof(builder));
            if (action == null)
                throw new ArgumentException(nameof(action));

            if (n1 == null)
                throw new ArgumentException(nameof(n1));
            var p1 = Expression.Parameter(typeof(T1), n1);

            if (n2 == null)
                throw new ArgumentException(nameof(n2));
            var p2 = Expression.Parameter(typeof(T2), n2);

            if (n3 == null)
                throw new ArgumentException(nameof(n3));
            var p3 = Expression.Parameter(typeof(T3), n3);

            if (n4 == null)
                throw new ArgumentException(nameof(n4));
            var p4 = Expression.Parameter(typeof(T4), n4);

            if (n5 == null)
                throw new ArgumentException(nameof(n5));
            var p5 = Expression.Parameter(typeof(T5), n5);

            var expr = Expression.Lambda<Action<T1, T2, T3, T4, T5>>(
                Expression.Invoke(
                    Expression.Constant(action), 
                    p1, p2, p3, p4, p5),
                p1, p2, p3, p4, p5);

            builder.AddListener(new[] { n1, n2, n3, n4, n5 }, expr);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, TResult>(
            this IDataProcessorBuilder builder,
            string n1,
            string n2,
            string n3,
            string n4,
            string n5,
            string nameResult,
            Func<T1, T2, T3, T4, T5, TResult> function)
        {
            if (builder == null)
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (n1 == null)
                throw new ArgumentException(nameof(n1));
            var p1 = Expression.Parameter(typeof(T1), n1);

            if (n2 == null)
                throw new ArgumentException(nameof(n2));
            var p2 = Expression.Parameter(typeof(T2), n2);

            if (n3 == null)
                throw new ArgumentException(nameof(n3));
            var p3 = Expression.Parameter(typeof(T3), n3);

            if (n4 == null)
                throw new ArgumentException(nameof(n4));
            var p4 = Expression.Parameter(typeof(T4), n4);

            if (n5 == null)
                throw new ArgumentException(nameof(n5));
            var p5 = Expression.Parameter(typeof(T5), n5);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, TResult>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5),
                p1, p2, p3, p4, p5);

            builder.AddProcessor(new[] { n1, n2, n3, n4, n5 }, nameResult, expr);
        }

        public static void AddListener<T1, T2, T3, T4, T5, T6>(
            this IDataProcessorBuilder builder,
            string n1,
            string n2,
            string n3,
            string n4,
            string n5,
            string n6,
            Action<T1, T2, T3, T4, T5, T6> action)
        {
            if (builder == null)
                throw new ArgumentException(nameof(builder));
            if (action == null)
                throw new ArgumentException(nameof(action));

            if (n1 == null)
                throw new ArgumentException(nameof(n1));
            var p1 = Expression.Parameter(typeof(T1), n1);

            if (n2 == null)
                throw new ArgumentException(nameof(n2));
            var p2 = Expression.Parameter(typeof(T2), n2);

            if (n3 == null)
                throw new ArgumentException(nameof(n3));
            var p3 = Expression.Parameter(typeof(T3), n3);

            if (n4 == null)
                throw new ArgumentException(nameof(n4));
            var p4 = Expression.Parameter(typeof(T4), n4);

            if (n5 == null)
                throw new ArgumentException(nameof(n5));
            var p5 = Expression.Parameter(typeof(T5), n5);

            if (n6 == null)
                throw new ArgumentException(nameof(n6));
            var p6 = Expression.Parameter(typeof(T6), n6);

            var expr = Expression.Lambda<Action<T1, T2, T3, T4, T5, T6>>(
                Expression.Invoke(
                    Expression.Constant(action), 
                    p1, p2, p3, p4, p5, p6),
                p1, p2, p3, p4, p5, p6);

            builder.AddListener(new[] { n1, n2, n3, n4, n5, n6 }, expr);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, TResult>(
            this IDataProcessorBuilder builder,
            string n1,
            string n2,
            string n3,
            string n4,
            string n5,
            string n6,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, TResult> function)
        {
            if (builder == null)
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (n1 == null)
                throw new ArgumentException(nameof(n1));
            var p1 = Expression.Parameter(typeof(T1), n1);

            if (n2 == null)
                throw new ArgumentException(nameof(n2));
            var p2 = Expression.Parameter(typeof(T2), n2);

            if (n3 == null)
                throw new ArgumentException(nameof(n3));
            var p3 = Expression.Parameter(typeof(T3), n3);

            if (n4 == null)
                throw new ArgumentException(nameof(n4));
            var p4 = Expression.Parameter(typeof(T4), n4);

            if (n5 == null)
                throw new ArgumentException(nameof(n5));
            var p5 = Expression.Parameter(typeof(T5), n5);

            if (n6 == null)
                throw new ArgumentException(nameof(n6));
            var p6 = Expression.Parameter(typeof(T6), n6);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, TResult>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6),
                p1, p2, p3, p4, p5, p6);

            builder.AddProcessor(new[] { n1, n2, n3, n4, n5, n6 }, nameResult, expr);
        }

        public static void AddListener<T1, T2, T3, T4, T5, T6, T7>(
            this IDataProcessorBuilder builder,
            string n1,
            string n2,
            string n3,
            string n4,
            string n5,
            string n6,
            string n7,
            Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            if (builder == null)
                throw new ArgumentException(nameof(builder));
            if (action == null)
                throw new ArgumentException(nameof(action));

            if (n1 == null)
                throw new ArgumentException(nameof(n1));
            var p1 = Expression.Parameter(typeof(T1), n1);

            if (n2 == null)
                throw new ArgumentException(nameof(n2));
            var p2 = Expression.Parameter(typeof(T2), n2);

            if (n3 == null)
                throw new ArgumentException(nameof(n3));
            var p3 = Expression.Parameter(typeof(T3), n3);

            if (n4 == null)
                throw new ArgumentException(nameof(n4));
            var p4 = Expression.Parameter(typeof(T4), n4);

            if (n5 == null)
                throw new ArgumentException(nameof(n5));
            var p5 = Expression.Parameter(typeof(T5), n5);

            if (n6 == null)
                throw new ArgumentException(nameof(n6));
            var p6 = Expression.Parameter(typeof(T6), n6);

            if (n7 == null)
                throw new ArgumentException(nameof(n7));
            var p7 = Expression.Parameter(typeof(T7), n7);

            var expr = Expression.Lambda<Action<T1, T2, T3, T4, T5, T6, T7>>(
                Expression.Invoke(
                    Expression.Constant(action), 
                    p1, p2, p3, p4, p5, p6, p7),
                p1, p2, p3, p4, p5, p6, p7);

            builder.AddListener(new[] { n1, n2, n3, n4, n5, n6, n7 }, expr);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this IDataProcessorBuilder builder,
            string n1,
            string n2,
            string n3,
            string n4,
            string n5,
            string n6,
            string n7,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, T7, TResult> function)
        {
            if (builder == null)
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (n1 == null)
                throw new ArgumentException(nameof(n1));
            var p1 = Expression.Parameter(typeof(T1), n1);

            if (n2 == null)
                throw new ArgumentException(nameof(n2));
            var p2 = Expression.Parameter(typeof(T2), n2);

            if (n3 == null)
                throw new ArgumentException(nameof(n3));
            var p3 = Expression.Parameter(typeof(T3), n3);

            if (n4 == null)
                throw new ArgumentException(nameof(n4));
            var p4 = Expression.Parameter(typeof(T4), n4);

            if (n5 == null)
                throw new ArgumentException(nameof(n5));
            var p5 = Expression.Parameter(typeof(T5), n5);

            if (n6 == null)
                throw new ArgumentException(nameof(n6));
            var p6 = Expression.Parameter(typeof(T6), n6);

            if (n7 == null)
                throw new ArgumentException(nameof(n7));
            var p7 = Expression.Parameter(typeof(T7), n7);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, TResult>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6, p7),
                p1, p2, p3, p4, p5, p6, p7);

            builder.AddProcessor(new[] { n1, n2, n3, n4, n5, n6, n7 }, nameResult, expr);
        }

    }
}