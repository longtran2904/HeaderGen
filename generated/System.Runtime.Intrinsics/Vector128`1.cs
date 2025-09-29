#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Reflection;

namespace System.Runtime.Intrinsics
{
    [DefaultMember("Item")]
    public readonly struct Vector128<T> : IEquatable<Vector128<T>>
    {

        public T this[int index] { get; }
        public static Vector128<T> AllBitsSet { get; }
        public static int Count { get; }
        public static bool IsSupported { get; }
        public static Vector128<T> One { get; }
        public static Vector128<T> Zero { get; }

        public override bool Equals(object obj);
        public bool Equals(Vector128<T> other);
        public override int GetHashCode();
        public override string ToString();

        public static Vector128<T> operator +(Vector128<T> left, Vector128<T> right);
        public static Vector128<T> operator &(Vector128<T> left, Vector128<T> right);
        public static Vector128<T> operator |(Vector128<T> left, Vector128<T> right);
        public static Vector128<T> operator /(Vector128<T> left, Vector128<T> right);
        public static Vector128<T> operator /(Vector128<T> left, T right);
        public static bool operator ==(Vector128<T> left, Vector128<T> right);
        public static Vector128<T> operator ^(Vector128<T> left, Vector128<T> right);
        public static bool operator !=(Vector128<T> left, Vector128<T> right);
        public static Vector128<T> operator <<(Vector128<T> value, int shiftCount);
        public static Vector128<T> operator *(Vector128<T> left, Vector128<T> right);
        public static Vector128<T> operator *(Vector128<T> left, T right);
        public static Vector128<T> operator *(T left, Vector128<T> right);
        public static Vector128<T> operator ~(Vector128<T> vector);
        public static Vector128<T> operator >>(Vector128<T> value, int shiftCount);
        public static Vector128<T> operator -(Vector128<T> left, Vector128<T> right);
        public static Vector128<T> operator -(Vector128<T> vector);
        public static Vector128<T> operator +(Vector128<T> value);
        public static Vector128<T> operator >>>(Vector128<T> value, int shiftCount);
    }
}
