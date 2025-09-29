#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Reflection;

namespace System.Runtime.Intrinsics
{
    [DefaultMember("Item")]
    public readonly struct Vector64<T> : IEquatable<Vector64<T>>
    {
        public T this[int index] { get; }
        public static Vector64<T> AllBitsSet { get; }
        public static int Count { get; }
        public static bool IsSupported { get; }
        public static Vector64<T> One { get; }
        public static Vector64<T> Zero { get; }

        public override bool Equals(object obj);
        public bool Equals(Vector64<T> other);
        public override int GetHashCode();
        public override string ToString();

        public static Vector64<T> operator +(Vector64<T> left, Vector64<T> right);
        public static Vector64<T> operator &(Vector64<T> left, Vector64<T> right);
        public static Vector64<T> operator |(Vector64<T> left, Vector64<T> right);
        public static Vector64<T> operator /(Vector64<T> left, Vector64<T> right);
        public static Vector64<T> operator /(Vector64<T> left, T right);
        public static bool operator ==(Vector64<T> left, Vector64<T> right);
        public static Vector64<T> operator ^(Vector64<T> left, Vector64<T> right);
        public static bool operator !=(Vector64<T> left, Vector64<T> right);
        public static Vector64<T> operator <<(Vector64<T> value, int shiftCount);
        public static Vector64<T> operator *(Vector64<T> left, Vector64<T> right);
        public static Vector64<T> operator *(Vector64<T> left, T right);
        public static Vector64<T> operator *(T left, Vector64<T> right);
        public static Vector64<T> operator ~(Vector64<T> vector);
        public static Vector64<T> operator >>(Vector64<T> value, int shiftCount);
        public static Vector64<T> operator -(Vector64<T> left, Vector64<T> right);
        public static Vector64<T> operator -(Vector64<T> vector);
        public static Vector64<T> operator +(Vector64<T> value);
        public static Vector64<T> operator >>>(Vector64<T> value, int shiftCount);
    }
}
