#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Diagnostics;

namespace UnityEngine.Assertions.Must
{
    [Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
    public static class MustExtensions
    {
        [Conditional("UNITY_ASSERTIONS")]
        [Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
        public static void MustBeTrue(this bool value);
        [Conditional("UNITY_ASSERTIONS")]
        [Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
        public static void MustBeTrue(this bool value, string message);
        [Conditional("UNITY_ASSERTIONS")]
        [Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
        public static void MustBeFalse(this bool value);
        [Conditional("UNITY_ASSERTIONS")]
        [Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
        public static void MustBeFalse(this bool value, string message);
        [Conditional("UNITY_ASSERTIONS")]
        [Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
        public static void MustBeApproximatelyEqual(this float actual, float expected);
        [Conditional("UNITY_ASSERTIONS")]
        [Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
        public static void MustBeApproximatelyEqual(this float actual, float expected, string message);
        [Conditional("UNITY_ASSERTIONS")]
        [Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
        public static void MustBeApproximatelyEqual(this float actual, float expected, float tolerance);
        [Conditional("UNITY_ASSERTIONS")]
        [Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
        public static void MustBeApproximatelyEqual(this float actual, float expected, float tolerance, string message);
        [Conditional("UNITY_ASSERTIONS")]
        [Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
        public static void MustNotBeApproximatelyEqual(this float actual, float expected);
        [Conditional("UNITY_ASSERTIONS")]
        [Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
        public static void MustNotBeApproximatelyEqual(this float actual, float expected, string message);
        [Conditional("UNITY_ASSERTIONS")]
        [Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
        public static void MustNotBeApproximatelyEqual(this float actual, float expected, float tolerance);
        [Conditional("UNITY_ASSERTIONS")]
        [Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
        public static void MustNotBeApproximatelyEqual(this float actual, float expected, float tolerance, string message);
        [Conditional("UNITY_ASSERTIONS")]
        [Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
        public static void MustBeEqual<T>(this T actual, T expected);
        [Conditional("UNITY_ASSERTIONS")]
        [Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
        public static void MustBeEqual<T>(this T actual, T expected, string message);
        [Conditional("UNITY_ASSERTIONS")]
        [Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
        public static void MustNotBeEqual<T>(this T actual, T expected);
        [Conditional("UNITY_ASSERTIONS")]
        [Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
        public static void MustNotBeEqual<T>(this T actual, T expected, string message);
        [Conditional("UNITY_ASSERTIONS")]
        [Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
        public static void MustBeNull<T>(this T expected) where T : class;
        [Conditional("UNITY_ASSERTIONS")]
        [Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
        public static void MustBeNull<T>(this T expected, string message) where T : class;
        [Conditional("UNITY_ASSERTIONS")]
        [Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
        public static void MustNotBeNull<T>(this T expected) where T : class;
        [Conditional("UNITY_ASSERTIONS")]
        [Obsolete("Must extensions are deprecated. Use UnityEngine.Assertions.Assert instead")]
        public static void MustNotBeNull<T>(this T expected, string message) where T : class;
    }
}
