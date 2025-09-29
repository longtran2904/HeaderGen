#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.ComponentModel;
using System.Numerics;
using System.Runtime.Serialization;

namespace System
{
    public class ArgumentOutOfRangeException : ArgumentException
    {
        public ArgumentOutOfRangeException();
        public ArgumentOutOfRangeException(string paramName);
        public ArgumentOutOfRangeException(string paramName, string message);
        public ArgumentOutOfRangeException(string message, Exception innerException);
        public ArgumentOutOfRangeException(string paramName, object actualValue, string message);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        protected ArgumentOutOfRangeException(SerializationInfo info, StreamingContext context);

        public override string Message { get; }
        public virtual object ActualValue { get; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public static void ThrowIfZero<T>(T value, string paramName = null) where T : INumberBase<T>;
        public static void ThrowIfNegative<T>(T value, string paramName = null) where T : INumberBase<T>;
        public static void ThrowIfNegativeOrZero<T>(T value, string paramName = null) where T : INumberBase<T>;
        public static void ThrowIfEqual<T>(T value, T other, string paramName = null) where T : IEquatable<T>;
        public static void ThrowIfNotEqual<T>(T value, T other, string paramName = null) where T : IEquatable<T>;
        public static void ThrowIfGreaterThan<T>(T value, T other, string paramName = null) where T : IComparable<T>;
        public static void ThrowIfGreaterThanOrEqual<T>(T value, T other, string paramName = null) where T : IComparable<T>;
        public static void ThrowIfLessThan<T>(T value, T other, string paramName = null) where T : IComparable<T>;
        public static void ThrowIfLessThanOrEqual<T>(T value, T other, string paramName = null) where T : IComparable<T>;
    }
}
