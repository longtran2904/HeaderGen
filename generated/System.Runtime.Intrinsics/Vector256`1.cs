#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Reflection;

namespace System.Runtime.Intrinsics
{
    [DefaultMember("Item")]
    public readonly struct Vector256<T> : IEquatable<Vector256<T>>
    {

        public T this[int index] { get; }
        public static Vector256<T> AllBitsSet { get; }
        public static int Count { get; }
        public static bool IsSupported { get; }
        public static Vector256<T> One { get; }
        public static Vector256<T> Zero { get; }

        public override bool Equals(object obj);
        public bool Equals(Vector256<T> other);
        public override int GetHashCode();
        public override string ToString();

        public static Vector256<T> operator +(Vector256<T> left, Vector256<T> right);
        public static Vector256<T> operator &(Vector256<T> left, Vector256<T> right);
        public static Vector256<T> operator |(Vector256<T> left, Vector256<T> right);
        public static Vector256<T> operator /(Vector256<T> left, Vector256<T> right);
        public static Vector256<T> operator /(Vector256<T> left, T right);
        public static bool operator ==(Vector256<T> left, Vector256<T> right);
        public static Vector256<T> operator ^(Vector256<T> left, Vector256<T> right);
        public static bool operator !=(Vector256<T> left, Vector256<T> right);
        public static Vector256<T> operator <<(Vector256<T> value, int shiftCount);
        public static Vector256<T> operator *(Vector256<T> left, Vector256<T> right);
        public static Vector256<T> operator *(Vector256<T> left, T right);
        public static Vector256<T> operator *(T left, Vector256<T> right);
        public static Vector256<T> operator ~(Vector256<T> vector);
        public static Vector256<T> operator >>(Vector256<T> value, int shiftCount);
        public static Vector256<T> operator -(Vector256<T> left, Vector256<T> right);
        public static Vector256<T> operator -(Vector256<T> vector);
        public static Vector256<T> operator +(Vector256<T> value);
        public static Vector256<T> operator >>>(Vector256<T> value, int shiftCount);
    }
}
