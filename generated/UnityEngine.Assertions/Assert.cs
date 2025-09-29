#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace UnityEngine.Assertions
{
    public static class Assert
    {
        [Obsolete("Future versions of Unity are expected to always throw exceptions and not have this field.")]
        public static bool raiseExceptions;

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Assert.Equals should not be used for Assertions", True)]
        public static bool Equals(object obj1, object obj2);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Assert.ReferenceEquals should not be used for Assertions", True)]
        public static bool ReferenceEquals(object obj1, object obj2);
        [Conditional("UNITY_ASSERTIONS")]
        public static void IsTrue(bool condition);
        [Conditional("UNITY_ASSERTIONS")]
        public static void IsTrue(bool condition, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void IsFalse(bool condition);
        [Conditional("UNITY_ASSERTIONS")]
        public static void IsFalse(bool condition, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreApproximatelyEqual(float expected, float actual);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreApproximatelyEqual(float expected, float actual, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreApproximatelyEqual(float expected, float actual, float tolerance);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreApproximatelyEqual(float expected, float actual, float tolerance, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotApproximatelyEqual(float expected, float actual);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotApproximatelyEqual(float expected, float actual, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotApproximatelyEqual(float expected, float actual, float tolerance);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotApproximatelyEqual(float expected, float actual, float tolerance, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreEqual<T>(T expected, T actual);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreEqual<T>(T expected, T actual, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreEqual(Object expected, Object actual, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotEqual<T>(T expected, T actual);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotEqual<T>(T expected, T actual, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotEqual(Object expected, Object actual, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void IsNull<T>(T value) where T : class;
        [Conditional("UNITY_ASSERTIONS")]
        public static void IsNull<T>(T value, string message) where T : class;
        [Conditional("UNITY_ASSERTIONS")]
        public static void IsNull(Object value, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void IsNotNull<T>(T value) where T : class;
        [Conditional("UNITY_ASSERTIONS")]
        public static void IsNotNull<T>(T value, string message) where T : class;
        [Conditional("UNITY_ASSERTIONS")]
        public static void IsNotNull(Object value, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreEqual(sbyte expected, sbyte actual);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreEqual(sbyte expected, sbyte actual, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotEqual(sbyte expected, sbyte actual);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotEqual(sbyte expected, sbyte actual, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreEqual(byte expected, byte actual);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreEqual(byte expected, byte actual, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotEqual(byte expected, byte actual);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotEqual(byte expected, byte actual, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreEqual(char expected, char actual);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreEqual(char expected, char actual, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotEqual(char expected, char actual);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotEqual(char expected, char actual, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreEqual(short expected, short actual);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreEqual(short expected, short actual, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotEqual(short expected, short actual);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotEqual(short expected, short actual, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreEqual(ushort expected, ushort actual);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreEqual(ushort expected, ushort actual, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotEqual(ushort expected, ushort actual);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotEqual(ushort expected, ushort actual, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreEqual(int expected, int actual);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreEqual(int expected, int actual, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotEqual(int expected, int actual);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotEqual(int expected, int actual, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreEqual(uint expected, uint actual);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreEqual(uint expected, uint actual, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotEqual(uint expected, uint actual);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotEqual(uint expected, uint actual, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreEqual(long expected, long actual);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreEqual(long expected, long actual, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotEqual(long expected, long actual);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotEqual(long expected, long actual, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreEqual(ulong expected, ulong actual);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreEqual(ulong expected, ulong actual, string message);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotEqual(ulong expected, ulong actual);
        [Conditional("UNITY_ASSERTIONS")]
        public static void AreNotEqual(ulong expected, ulong actual, string message);
    }
}
