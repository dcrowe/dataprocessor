
using System;
using System.Linq.Expressions;

namespace dataprocessor
{
    public static class DataProcessorBuilderExtensions
    {
        public static void AddListenerExpression<T1>(
            this IDataProcessorBuilder builder,
            string name1,
            Expression<Action<T1>> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            builder.AddListener(action, n1);
        }

        public static void AddListener<T1>(
            this IDataProcessorBuilder builder,
            string name1,
            Action<T1> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            var expr = Expression.Lambda<Action<T1>>(
                Expression.Invoke(
                    Expression.Constant(action), 
                    p1),
                p1);

            builder.AddListenerExpression(name1, expr);
        }

        public static void AddProcessorExpression<T1, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string nameResult,
            Expression<Func<T1, TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1);
        }

        public static void AddProcessorExpression<T1, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string nameResult,
            Expression<Func<T1, Maybe<TResult>>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1);
        }

        public static void AddProcessor<T1, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string nameResult,
            Func<T1, TResult> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            var expr = Expression.Lambda<Func<T1, TResult>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1),
                p1);

            builder.AddProcessorExpression(name1, nameResult, expr);
        }

        public static void AddProcessor<T1, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string nameResult,
            Func<T1, Maybe<TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            var expr = Expression.Lambda<Func<T1, Maybe<TResult>>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1),
                p1);

            builder.AddProcessorExpression(name1, nameResult, expr);
        }

        public static void AddListenerExpression<T1, T2>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            Expression<Action<T1, T2>> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            builder.AddListener(action, n1, n2);
        }

        public static void AddListener<T1, T2>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            Action<T1, T2> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            var expr = Expression.Lambda<Action<T1, T2>>(
                Expression.Invoke(
                    Expression.Constant(action), 
                    p1, p2),
                p1, p2);

            builder.AddListenerExpression(name1, name2, expr);
        }

        public static void AddProcessorExpression<T1, T2, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string nameResult,
            Expression<Func<T1, T2, TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2);
        }

        public static void AddProcessorExpression<T1, T2, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string nameResult,
            Expression<Func<T1, T2, Maybe<TResult>>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2);
        }

        public static void AddProcessor<T1, T2, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string nameResult,
            Func<T1, T2, TResult> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            var expr = Expression.Lambda<Func<T1, T2, TResult>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2),
                p1, p2);

            builder.AddProcessorExpression(name1, name2, nameResult, expr);
        }

        public static void AddProcessor<T1, T2, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string nameResult,
            Func<T1, T2, Maybe<TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            var expr = Expression.Lambda<Func<T1, T2, Maybe<TResult>>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2),
                p1, p2);

            builder.AddProcessorExpression(name1, name2, nameResult, expr);
        }

        public static void AddListenerExpression<T1, T2, T3>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            Expression<Action<T1, T2, T3>> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            builder.AddListener(action, n1, n2, n3);
        }

        public static void AddListener<T1, T2, T3>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            Action<T1, T2, T3> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            var expr = Expression.Lambda<Action<T1, T2, T3>>(
                Expression.Invoke(
                    Expression.Constant(action), 
                    p1, p2, p3),
                p1, p2, p3);

            builder.AddListenerExpression(name1, name2, name3, expr);
        }

        public static void AddProcessorExpression<T1, T2, T3, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string nameResult,
            Expression<Func<T1, T2, T3, TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3);
        }

        public static void AddProcessorExpression<T1, T2, T3, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string nameResult,
            Expression<Func<T1, T2, T3, Maybe<TResult>>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3);
        }

        public static void AddProcessor<T1, T2, T3, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string nameResult,
            Func<T1, T2, T3, TResult> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            var expr = Expression.Lambda<Func<T1, T2, T3, TResult>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3),
                p1, p2, p3);

            builder.AddProcessorExpression(name1, name2, name3, nameResult, expr);
        }

        public static void AddProcessor<T1, T2, T3, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string nameResult,
            Func<T1, T2, T3, Maybe<TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            var expr = Expression.Lambda<Func<T1, T2, T3, Maybe<TResult>>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3),
                p1, p2, p3);

            builder.AddProcessorExpression(name1, name2, name3, nameResult, expr);
        }

        public static void AddListenerExpression<T1, T2, T3, T4>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            Expression<Action<T1, T2, T3, T4>> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            builder.AddListener(action, n1, n2, n3, n4);
        }

        public static void AddListener<T1, T2, T3, T4>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            Action<T1, T2, T3, T4> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            var expr = Expression.Lambda<Action<T1, T2, T3, T4>>(
                Expression.Invoke(
                    Expression.Constant(action), 
                    p1, p2, p3, p4),
                p1, p2, p3, p4);

            builder.AddListenerExpression(name1, name2, name3, name4, expr);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, Maybe<TResult>>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4);
        }

        public static void AddProcessor<T1, T2, T3, T4, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string nameResult,
            Func<T1, T2, T3, T4, TResult> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, TResult>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4),
                p1, p2, p3, p4);

            builder.AddProcessorExpression(name1, name2, name3, name4, nameResult, expr);
        }

        public static void AddProcessor<T1, T2, T3, T4, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string nameResult,
            Func<T1, T2, T3, T4, Maybe<TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, Maybe<TResult>>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4),
                p1, p2, p3, p4);

            builder.AddProcessorExpression(name1, name2, name3, name4, nameResult, expr);
        }

        public static void AddListenerExpression<T1, T2, T3, T4, T5>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            Expression<Action<T1, T2, T3, T4, T5>> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            builder.AddListener(action, n1, n2, n3, n4, n5);
        }

        public static void AddListener<T1, T2, T3, T4, T5>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            Action<T1, T2, T3, T4, T5> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            var expr = Expression.Lambda<Action<T1, T2, T3, T4, T5>>(
                Expression.Invoke(
                    Expression.Constant(action), 
                    p1, p2, p3, p4, p5),
                p1, p2, p3, p4, p5);

            builder.AddListenerExpression(name1, name2, name3, name4, name5, expr);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, Maybe<TResult>>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string nameResult,
            Func<T1, T2, T3, T4, T5, TResult> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, TResult>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5),
                p1, p2, p3, p4, p5);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, nameResult, expr);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string nameResult,
            Func<T1, T2, T3, T4, T5, Maybe<TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, Maybe<TResult>>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5),
                p1, p2, p3, p4, p5);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, nameResult, expr);
        }

        public static void AddListenerExpression<T1, T2, T3, T4, T5, T6>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            Expression<Action<T1, T2, T3, T4, T5, T6>> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            builder.AddListener(action, n1, n2, n3, n4, n5, n6);
        }

        public static void AddListener<T1, T2, T3, T4, T5, T6>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            Action<T1, T2, T3, T4, T5, T6> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            var expr = Expression.Lambda<Action<T1, T2, T3, T4, T5, T6>>(
                Expression.Invoke(
                    Expression.Constant(action), 
                    p1, p2, p3, p4, p5, p6),
                p1, p2, p3, p4, p5, p6);

            builder.AddListenerExpression(name1, name2, name3, name4, name5, name6, expr);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, T6, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5, n6);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, T6, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, T6, Maybe<TResult>>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5, n6);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, TResult> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, TResult>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6),
                p1, p2, p3, p4, p5, p6);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, name6, nameResult, expr);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, Maybe<TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, Maybe<TResult>>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6),
                p1, p2, p3, p4, p5, p6);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, name6, nameResult, expr);
        }

        public static void AddListenerExpression<T1, T2, T3, T4, T5, T6, T7>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            Expression<Action<T1, T2, T3, T4, T5, T6, T7>> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            builder.AddListener(action, n1, n2, n3, n4, n5, n6, n7);
        }

        public static void AddListener<T1, T2, T3, T4, T5, T6, T7>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            var expr = Expression.Lambda<Action<T1, T2, T3, T4, T5, T6, T7>>(
                Expression.Invoke(
                    Expression.Constant(action), 
                    p1, p2, p3, p4, p5, p6, p7),
                p1, p2, p3, p4, p5, p6, p7);

            builder.AddListenerExpression(name1, name2, name3, name4, name5, name6, name7, expr);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5, n6, n7);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, Maybe<TResult>>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5, n6, n7);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, T7, TResult> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, TResult>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6, p7),
                p1, p2, p3, p4, p5, p6, p7);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, name6, name7, nameResult, expr);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, T7, Maybe<TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, Maybe<TResult>>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6, p7),
                p1, p2, p3, p4, p5, p6, p7);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, name6, name7, nameResult, expr);
        }

        public static void AddListenerExpression<T1, T2, T3, T4, T5, T6, T7, T8>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8>> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            builder.AddListener(action, n1, n2, n3, n4, n5, n6, n7, n8);
        }

        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            var expr = Expression.Lambda<Action<T1, T2, T3, T4, T5, T6, T7, T8>>(
                Expression.Invoke(
                    Expression.Constant(action), 
                    p1, p2, p3, p4, p5, p6, p7, p8),
                p1, p2, p3, p4, p5, p6, p7, p8);

            builder.AddListenerExpression(name1, name2, name3, name4, name5, name6, name7, name8, expr);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5, n6, n7, n8);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, Maybe<TResult>>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5, n6, n7, n8);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6, p7, p8),
                p1, p2, p3, p4, p5, p6, p7, p8);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, name6, name7, name8, nameResult, expr);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, Maybe<TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, T8, Maybe<TResult>>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6, p7, p8),
                p1, p2, p3, p4, p5, p6, p7, p8);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, name6, name7, name8, nameResult, expr);
        }

        public static void AddListenerExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            builder.AddListener(action, n1, n2, n3, n4, n5, n6, n7, n8, n9);
        }

        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            var expr = Expression.Lambda<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>>(
                Expression.Invoke(
                    Expression.Constant(action), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9),
                p1, p2, p3, p4, p5, p6, p7, p8, p9);

            builder.AddListenerExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, expr);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5, n6, n7, n8, n9);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Maybe<TResult>>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5, n6, n7, n8, n9);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9),
                p1, p2, p3, p4, p5, p6, p7, p8, p9);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, nameResult, expr);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Maybe<TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Maybe<TResult>>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9),
                p1, p2, p3, p4, p5, p6, p7, p8, p9);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, nameResult, expr);
        }

        public static void AddListenerExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var n10 = NameType.From<T10>(name10);

            builder.AddListener(action, n1, n2, n3, n4, n5, n6, n7, n8, n9, n10);
        }

        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var p10 = Expression.Parameter(typeof(T10), name10);

            var expr = Expression.Lambda<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>(
                Expression.Invoke(
                    Expression.Constant(action), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9, p10),
                p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);

            builder.AddListenerExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, expr);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var n10 = NameType.From<T10>(name10);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5, n6, n7, n8, n9, n10);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Maybe<TResult>>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var n10 = NameType.From<T10>(name10);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5, n6, n7, n8, n9, n10);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var p10 = Expression.Parameter(typeof(T10), name10);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9, p10),
                p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, nameResult, expr);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Maybe<TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var p10 = Expression.Parameter(typeof(T10), name10);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Maybe<TResult>>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9, p10),
                p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, nameResult, expr);
        }

        public static void AddListenerExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var n10 = NameType.From<T10>(name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var n11 = NameType.From<T11>(name11);

            builder.AddListener(action, n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11);
        }

        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var p10 = Expression.Parameter(typeof(T10), name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var p11 = Expression.Parameter(typeof(T11), name11);

            var expr = Expression.Lambda<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>(
                Expression.Invoke(
                    Expression.Constant(action), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11),
                p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);

            builder.AddListenerExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, expr);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var n10 = NameType.From<T10>(name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var n11 = NameType.From<T11>(name11);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Maybe<TResult>>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var n10 = NameType.From<T10>(name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var n11 = NameType.From<T11>(name11);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var p10 = Expression.Parameter(typeof(T10), name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var p11 = Expression.Parameter(typeof(T11), name11);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11),
                p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, nameResult, expr);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Maybe<TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var p10 = Expression.Parameter(typeof(T10), name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var p11 = Expression.Parameter(typeof(T11), name11);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Maybe<TResult>>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11),
                p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, nameResult, expr);
        }

        public static void AddListenerExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var n10 = NameType.From<T10>(name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var n11 = NameType.From<T11>(name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var n12 = NameType.From<T12>(name12);

            builder.AddListener(action, n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12);
        }

        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var p10 = Expression.Parameter(typeof(T10), name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var p11 = Expression.Parameter(typeof(T11), name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var p12 = Expression.Parameter(typeof(T12), name12);

            var expr = Expression.Lambda<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>(
                Expression.Invoke(
                    Expression.Constant(action), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12),
                p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);

            builder.AddListenerExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, expr);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var n10 = NameType.From<T10>(name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var n11 = NameType.From<T11>(name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var n12 = NameType.From<T12>(name12);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Maybe<TResult>>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var n10 = NameType.From<T10>(name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var n11 = NameType.From<T11>(name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var n12 = NameType.From<T12>(name12);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var p10 = Expression.Parameter(typeof(T10), name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var p11 = Expression.Parameter(typeof(T11), name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var p12 = Expression.Parameter(typeof(T12), name12);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12),
                p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, nameResult, expr);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Maybe<TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var p10 = Expression.Parameter(typeof(T10), name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var p11 = Expression.Parameter(typeof(T11), name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var p12 = Expression.Parameter(typeof(T12), name12);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Maybe<TResult>>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12),
                p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, nameResult, expr);
        }

        public static void AddListenerExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var n10 = NameType.From<T10>(name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var n11 = NameType.From<T11>(name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var n12 = NameType.From<T12>(name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var n13 = NameType.From<T13>(name13);

            builder.AddListener(action, n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13);
        }

        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var p10 = Expression.Parameter(typeof(T10), name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var p11 = Expression.Parameter(typeof(T11), name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var p12 = Expression.Parameter(typeof(T12), name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var p13 = Expression.Parameter(typeof(T13), name13);

            var expr = Expression.Lambda<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>(
                Expression.Invoke(
                    Expression.Constant(action), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13),
                p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);

            builder.AddListenerExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, expr);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var n10 = NameType.From<T10>(name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var n11 = NameType.From<T11>(name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var n12 = NameType.From<T12>(name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var n13 = NameType.From<T13>(name13);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Maybe<TResult>>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var n10 = NameType.From<T10>(name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var n11 = NameType.From<T11>(name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var n12 = NameType.From<T12>(name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var n13 = NameType.From<T13>(name13);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var p10 = Expression.Parameter(typeof(T10), name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var p11 = Expression.Parameter(typeof(T11), name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var p12 = Expression.Parameter(typeof(T12), name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var p13 = Expression.Parameter(typeof(T13), name13);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13),
                p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, nameResult, expr);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Maybe<TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var p10 = Expression.Parameter(typeof(T10), name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var p11 = Expression.Parameter(typeof(T11), name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var p12 = Expression.Parameter(typeof(T12), name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var p13 = Expression.Parameter(typeof(T13), name13);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Maybe<TResult>>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13),
                p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, nameResult, expr);
        }

        public static void AddListenerExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            string name14,
            Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var n10 = NameType.From<T10>(name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var n11 = NameType.From<T11>(name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var n12 = NameType.From<T12>(name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var n13 = NameType.From<T13>(name13);

            if (name14 == null)
                throw new ArgumentNullException(nameof(name14));
            var n14 = NameType.From<T14>(name14);

            builder.AddListener(action, n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14);
        }

        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            string name14,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var p10 = Expression.Parameter(typeof(T10), name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var p11 = Expression.Parameter(typeof(T11), name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var p12 = Expression.Parameter(typeof(T12), name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var p13 = Expression.Parameter(typeof(T13), name13);

            if (name14 == null)
                throw new ArgumentNullException(nameof(name14));
            var p14 = Expression.Parameter(typeof(T14), name14);

            var expr = Expression.Lambda<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>(
                Expression.Invoke(
                    Expression.Constant(action), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14),
                p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);

            builder.AddListenerExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, name14, expr);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            string name14,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var n10 = NameType.From<T10>(name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var n11 = NameType.From<T11>(name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var n12 = NameType.From<T12>(name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var n13 = NameType.From<T13>(name13);

            if (name14 == null)
                throw new ArgumentNullException(nameof(name14));
            var n14 = NameType.From<T14>(name14);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            string name14,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Maybe<TResult>>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var n10 = NameType.From<T10>(name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var n11 = NameType.From<T11>(name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var n12 = NameType.From<T12>(name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var n13 = NameType.From<T13>(name13);

            if (name14 == null)
                throw new ArgumentNullException(nameof(name14));
            var n14 = NameType.From<T14>(name14);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            string name14,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var p10 = Expression.Parameter(typeof(T10), name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var p11 = Expression.Parameter(typeof(T11), name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var p12 = Expression.Parameter(typeof(T12), name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var p13 = Expression.Parameter(typeof(T13), name13);

            if (name14 == null)
                throw new ArgumentNullException(nameof(name14));
            var p14 = Expression.Parameter(typeof(T14), name14);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14),
                p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, name14, nameResult, expr);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            string name14,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Maybe<TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var p10 = Expression.Parameter(typeof(T10), name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var p11 = Expression.Parameter(typeof(T11), name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var p12 = Expression.Parameter(typeof(T12), name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var p13 = Expression.Parameter(typeof(T13), name13);

            if (name14 == null)
                throw new ArgumentNullException(nameof(name14));
            var p14 = Expression.Parameter(typeof(T14), name14);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Maybe<TResult>>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14),
                p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, name14, nameResult, expr);
        }

        public static void AddListenerExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            string name14,
            string name15,
            Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var n10 = NameType.From<T10>(name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var n11 = NameType.From<T11>(name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var n12 = NameType.From<T12>(name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var n13 = NameType.From<T13>(name13);

            if (name14 == null)
                throw new ArgumentNullException(nameof(name14));
            var n14 = NameType.From<T14>(name14);

            if (name15 == null)
                throw new ArgumentNullException(nameof(name15));
            var n15 = NameType.From<T15>(name15);

            builder.AddListener(action, n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15);
        }

        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            string name14,
            string name15,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var p10 = Expression.Parameter(typeof(T10), name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var p11 = Expression.Parameter(typeof(T11), name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var p12 = Expression.Parameter(typeof(T12), name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var p13 = Expression.Parameter(typeof(T13), name13);

            if (name14 == null)
                throw new ArgumentNullException(nameof(name14));
            var p14 = Expression.Parameter(typeof(T14), name14);

            if (name15 == null)
                throw new ArgumentNullException(nameof(name15));
            var p15 = Expression.Parameter(typeof(T15), name15);

            var expr = Expression.Lambda<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(
                Expression.Invoke(
                    Expression.Constant(action), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15),
                p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);

            builder.AddListenerExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, name14, name15, expr);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            string name14,
            string name15,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var n10 = NameType.From<T10>(name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var n11 = NameType.From<T11>(name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var n12 = NameType.From<T12>(name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var n13 = NameType.From<T13>(name13);

            if (name14 == null)
                throw new ArgumentNullException(nameof(name14));
            var n14 = NameType.From<T14>(name14);

            if (name15 == null)
                throw new ArgumentNullException(nameof(name15));
            var n15 = NameType.From<T15>(name15);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            string name14,
            string name15,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Maybe<TResult>>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var n10 = NameType.From<T10>(name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var n11 = NameType.From<T11>(name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var n12 = NameType.From<T12>(name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var n13 = NameType.From<T13>(name13);

            if (name14 == null)
                throw new ArgumentNullException(nameof(name14));
            var n14 = NameType.From<T14>(name14);

            if (name15 == null)
                throw new ArgumentNullException(nameof(name15));
            var n15 = NameType.From<T15>(name15);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            string name14,
            string name15,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var p10 = Expression.Parameter(typeof(T10), name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var p11 = Expression.Parameter(typeof(T11), name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var p12 = Expression.Parameter(typeof(T12), name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var p13 = Expression.Parameter(typeof(T13), name13);

            if (name14 == null)
                throw new ArgumentNullException(nameof(name14));
            var p14 = Expression.Parameter(typeof(T14), name14);

            if (name15 == null)
                throw new ArgumentNullException(nameof(name15));
            var p15 = Expression.Parameter(typeof(T15), name15);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15),
                p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, name14, name15, nameResult, expr);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            string name14,
            string name15,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Maybe<TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var p10 = Expression.Parameter(typeof(T10), name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var p11 = Expression.Parameter(typeof(T11), name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var p12 = Expression.Parameter(typeof(T12), name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var p13 = Expression.Parameter(typeof(T13), name13);

            if (name14 == null)
                throw new ArgumentNullException(nameof(name14));
            var p14 = Expression.Parameter(typeof(T14), name14);

            if (name15 == null)
                throw new ArgumentNullException(nameof(name15));
            var p15 = Expression.Parameter(typeof(T15), name15);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Maybe<TResult>>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15),
                p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, name14, name15, nameResult, expr);
        }

        public static void AddListenerExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            string name14,
            string name15,
            string name16,
            Expression<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var n10 = NameType.From<T10>(name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var n11 = NameType.From<T11>(name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var n12 = NameType.From<T12>(name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var n13 = NameType.From<T13>(name13);

            if (name14 == null)
                throw new ArgumentNullException(nameof(name14));
            var n14 = NameType.From<T14>(name14);

            if (name15 == null)
                throw new ArgumentNullException(nameof(name15));
            var n15 = NameType.From<T15>(name15);

            if (name16 == null)
                throw new ArgumentNullException(nameof(name16));
            var n16 = NameType.From<T16>(name16);

            builder.AddListener(action, n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15, n16);
        }

        public static void AddListener<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            string name14,
            string name15,
            string name16,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var p10 = Expression.Parameter(typeof(T10), name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var p11 = Expression.Parameter(typeof(T11), name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var p12 = Expression.Parameter(typeof(T12), name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var p13 = Expression.Parameter(typeof(T13), name13);

            if (name14 == null)
                throw new ArgumentNullException(nameof(name14));
            var p14 = Expression.Parameter(typeof(T14), name14);

            if (name15 == null)
                throw new ArgumentNullException(nameof(name15));
            var p15 = Expression.Parameter(typeof(T15), name15);

            if (name16 == null)
                throw new ArgumentNullException(nameof(name16));
            var p16 = Expression.Parameter(typeof(T16), name16);

            var expr = Expression.Lambda<Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(
                Expression.Invoke(
                    Expression.Constant(action), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16),
                p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);

            builder.AddListenerExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, name14, name15, name16, expr);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            string name14,
            string name15,
            string name16,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var n10 = NameType.From<T10>(name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var n11 = NameType.From<T11>(name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var n12 = NameType.From<T12>(name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var n13 = NameType.From<T13>(name13);

            if (name14 == null)
                throw new ArgumentNullException(nameof(name14));
            var n14 = NameType.From<T14>(name14);

            if (name15 == null)
                throw new ArgumentNullException(nameof(name15));
            var n15 = NameType.From<T15>(name15);

            if (name16 == null)
                throw new ArgumentNullException(nameof(name16));
            var n16 = NameType.From<T16>(name16);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15, n16);
        }

        public static void AddProcessorExpression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            string name14,
            string name15,
            string name16,
            string nameResult,
            Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Maybe<TResult>>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var n7 = NameType.From<T7>(name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var n8 = NameType.From<T8>(name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var n9 = NameType.From<T9>(name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var n10 = NameType.From<T10>(name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var n11 = NameType.From<T11>(name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var n12 = NameType.From<T12>(name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var n13 = NameType.From<T13>(name13);

            if (name14 == null)
                throw new ArgumentNullException(nameof(name14));
            var n14 = NameType.From<T14>(name14);

            if (name15 == null)
                throw new ArgumentNullException(nameof(name15));
            var n15 = NameType.From<T15>(name15);

            if (name16 == null)
                throw new ArgumentNullException(nameof(name16));
            var n16 = NameType.From<T16>(name16);

            builder.AddProcessor(function, NameType.From<TResult>(nameResult), n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15, n16);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            string name14,
            string name15,
            string name16,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var p10 = Expression.Parameter(typeof(T10), name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var p11 = Expression.Parameter(typeof(T11), name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var p12 = Expression.Parameter(typeof(T12), name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var p13 = Expression.Parameter(typeof(T13), name13);

            if (name14 == null)
                throw new ArgumentNullException(nameof(name14));
            var p14 = Expression.Parameter(typeof(T14), name14);

            if (name15 == null)
                throw new ArgumentNullException(nameof(name15));
            var p15 = Expression.Parameter(typeof(T15), name15);

            if (name16 == null)
                throw new ArgumentNullException(nameof(name16));
            var p16 = Expression.Parameter(typeof(T16), name16);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16),
                p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, name14, name15, name16, nameResult, expr);
        }

        public static void AddProcessor<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this IDataProcessorBuilder builder,
            string name1,
            string name2,
            string name3,
            string name4,
            string name5,
            string name6,
            string name7,
            string name8,
            string name9,
            string name10,
            string name11,
            string name12,
            string name13,
            string name14,
            string name15,
            string name16,
            string nameResult,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Maybe<TResult>> function)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentNullException(nameof(nameResult));
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            if (name1 == null)
                throw new ArgumentNullException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentNullException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentNullException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentNullException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentNullException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentNullException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentNullException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            if (name8 == null)
                throw new ArgumentNullException(nameof(name8));
            var p8 = Expression.Parameter(typeof(T8), name8);

            if (name9 == null)
                throw new ArgumentNullException(nameof(name9));
            var p9 = Expression.Parameter(typeof(T9), name9);

            if (name10 == null)
                throw new ArgumentNullException(nameof(name10));
            var p10 = Expression.Parameter(typeof(T10), name10);

            if (name11 == null)
                throw new ArgumentNullException(nameof(name11));
            var p11 = Expression.Parameter(typeof(T11), name11);

            if (name12 == null)
                throw new ArgumentNullException(nameof(name12));
            var p12 = Expression.Parameter(typeof(T12), name12);

            if (name13 == null)
                throw new ArgumentNullException(nameof(name13));
            var p13 = Expression.Parameter(typeof(T13), name13);

            if (name14 == null)
                throw new ArgumentNullException(nameof(name14));
            var p14 = Expression.Parameter(typeof(T14), name14);

            if (name15 == null)
                throw new ArgumentNullException(nameof(name15));
            var p15 = Expression.Parameter(typeof(T15), name15);

            if (name16 == null)
                throw new ArgumentNullException(nameof(name16));
            var p16 = Expression.Parameter(typeof(T16), name16);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Maybe<TResult>>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16),
                p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, name14, name15, name16, nameResult, expr);
        }

    }
}