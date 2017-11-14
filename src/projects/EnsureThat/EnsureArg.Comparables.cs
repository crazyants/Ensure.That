﻿using System;
using System.Diagnostics;
using JetBrains.Annotations;

namespace EnsureThat
{
    public static partial class EnsureArg
    {
        [DebuggerStepThrough]
        public static T Is<T>(T value, T expected, [InvokerParameterName] string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.Is(value, expected, paramName);

        [DebuggerStepThrough]
        public static T IsNot<T>(T value, T expected, [InvokerParameterName] string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsNot(value, expected, paramName);

        [DebuggerStepThrough]
        public static T IsLt<T>(T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsLt(value, limit, paramName);

        [DebuggerStepThrough]
        public static T IsLte<T>(T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsLte(value, limit, paramName);

        [DebuggerStepThrough]
        public static T IsGt<T>(T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsGt(value, limit, paramName);

        [DebuggerStepThrough]
        public static T IsGte<T>(T value, T limit, [InvokerParameterName] string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsGte(value, limit, paramName);

        [DebuggerStepThrough]
        public static T IsInRange<T>(T value, T min, T max, [InvokerParameterName] string paramName = Param.DefaultName) where T : IComparable<T>
            => Ensure.Comparable.IsInRange(value, min, max, paramName);
    }
}