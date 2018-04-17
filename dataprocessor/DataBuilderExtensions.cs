
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
                throw new ArgumentException(nameof(builder));
            if (action == null)
                throw new ArgumentException(nameof(action));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            builder.AddListener(action, n1);
        }

        public static void AddListener<T1>(
            this IDataProcessorBuilder builder,
            string name1,
            Action<T1> action)
        {
            if (builder == null)
                throw new ArgumentException(nameof(builder));
            if (action == null)
                throw new ArgumentException(nameof(action));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
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
                throw new ArgumentException(nameof(builder));
            if (action == null)
                throw new ArgumentException(nameof(action));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
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
                throw new ArgumentException(nameof(builder));
            if (action == null)
                throw new ArgumentException(nameof(action));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
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
                throw new ArgumentException(nameof(builder));
            if (action == null)
                throw new ArgumentException(nameof(action));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
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
                throw new ArgumentException(nameof(builder));
            if (action == null)
                throw new ArgumentException(nameof(action));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
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
                throw new ArgumentException(nameof(builder));
            if (action == null)
                throw new ArgumentException(nameof(action));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
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
                throw new ArgumentException(nameof(builder));
            if (action == null)
                throw new ArgumentException(nameof(action));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
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
                throw new ArgumentException(nameof(builder));
            if (action == null)
                throw new ArgumentException(nameof(action));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentException(nameof(name5));
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
                throw new ArgumentException(nameof(builder));
            if (action == null)
                throw new ArgumentException(nameof(action));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentException(nameof(name5));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentException(nameof(name5));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentException(nameof(name5));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentException(nameof(name5));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentException(nameof(name5));
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
                throw new ArgumentException(nameof(builder));
            if (action == null)
                throw new ArgumentException(nameof(action));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentException(nameof(name6));
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
                throw new ArgumentException(nameof(builder));
            if (action == null)
                throw new ArgumentException(nameof(action));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentException(nameof(name6));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentException(nameof(name6));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentException(nameof(name6));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentException(nameof(name6));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentException(nameof(name6));
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
                throw new ArgumentException(nameof(builder));
            if (action == null)
                throw new ArgumentException(nameof(action));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentException(nameof(name7));
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
                throw new ArgumentException(nameof(builder));
            if (action == null)
                throw new ArgumentException(nameof(action));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentException(nameof(name7));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentException(nameof(name7));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var n1 = NameType.From<T1>(name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var n2 = NameType.From<T2>(name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var n3 = NameType.From<T3>(name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
            var n4 = NameType.From<T4>(name4);

            if (name5 == null)
                throw new ArgumentException(nameof(name5));
            var n5 = NameType.From<T5>(name5);

            if (name6 == null)
                throw new ArgumentException(nameof(name6));
            var n6 = NameType.From<T6>(name6);

            if (name7 == null)
                throw new ArgumentException(nameof(name7));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentException(nameof(name7));
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
                throw new ArgumentException(nameof(builder));
            if (nameResult == null)
                throw new ArgumentException(nameof(nameResult));
            if (function == null)
                throw new ArgumentException(nameof(function));

            if (name1 == null)
                throw new ArgumentException(nameof(name1));
            var p1 = Expression.Parameter(typeof(T1), name1);

            if (name2 == null)
                throw new ArgumentException(nameof(name2));
            var p2 = Expression.Parameter(typeof(T2), name2);

            if (name3 == null)
                throw new ArgumentException(nameof(name3));
            var p3 = Expression.Parameter(typeof(T3), name3);

            if (name4 == null)
                throw new ArgumentException(nameof(name4));
            var p4 = Expression.Parameter(typeof(T4), name4);

            if (name5 == null)
                throw new ArgumentException(nameof(name5));
            var p5 = Expression.Parameter(typeof(T5), name5);

            if (name6 == null)
                throw new ArgumentException(nameof(name6));
            var p6 = Expression.Parameter(typeof(T6), name6);

            if (name7 == null)
                throw new ArgumentException(nameof(name7));
            var p7 = Expression.Parameter(typeof(T7), name7);

            var expr = Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, Maybe<TResult>>>(
                Expression.Invoke(
                    Expression.Constant(function), 
                    p1, p2, p3, p4, p5, p6, p7),
                p1, p2, p3, p4, p5, p6, p7);

            builder.AddProcessorExpression(name1, name2, name3, name4, name5, name6, name7, nameResult, expr);
        }

    }
}