#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Reflection;

namespace System.Runtime.Intrinsics
{
    [DefaultMember("Item")]
    public readonly struct Vector512<T> : IEquatable<Vector512<T>>
    {

        public T this[int index] { get; }
        public static Vector512<T> AllBitsSet { get; }
        public static int Count { get; }
        public static bool IsSupported { get; }
        public static Vector512<T> One { get; }
        public static Vector512<T> Zero { get; }

        public override bool Equals(object obj);
        public bool Equals(Vector512<T> other);
        public override int GetHashCode();
        public override string ToString();

        public static Vector512<T> operator +(Vector512<T> left, Vector512<T> right);
        public static Vector512<T> operator &(Vector512<T> left, Vector512<T> right);
        public static Vector512<T> operator |(Vector512<T> left, Vector512<T> right);
        public static Vector512<T> operator /(Vector512<T> left, Vector512<T> right);
        public static Vector512<T> operator /(Vector512<T> left, T right);
        public static bool operator ==(Vector512<T> left, Vector512<T> right);
        public static Vector512<T> operator ^(Vector512<T> left, Vector512<T> right);
        public static bool operator !=(Vector512<T> left, Vector512<T> right);
        public static Vector512<T> operator <<(Vector512<T> value, int shiftCount);
        public static Vector512<T> operator *(Vector512<T> left, Vector512<T> right);
        public static Vector512<T> operator *(Vector512<T> left, T right);
        public static Vector512<T> operator *(T left, Vector512<T> right);
        public static Vector512<T> operator ~(Vector512<T> vector);
        public static Vector512<T> operator >>(Vector512<T> value, int shiftCount);
        public static Vector512<T> operator -(Vector512<T> left, Vector512<T> right);
        public static Vector512<T> operator -(Vector512<T> vector);
        public static Vector512<T> operator +(Vector512<T> value);
        public static Vector512<T> operator >>>(Vector512<T> value, int shiftCount);
    }
}
