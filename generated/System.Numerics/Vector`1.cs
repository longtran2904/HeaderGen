#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Reflection;

namespace System.Numerics
{
    [DefaultMember("Item")]
    public readonly struct Vector<T> : IEquatable<Vector<T>>, IFormattable
    {

        public Vector(T value);
        public Vector(T[] values);
        public Vector(T[] values, int index);
        public Vector(ReadOnlySpan<T> values);
        public Vector(ReadOnlySpan<byte> values);
        public Vector(Span<T> values);

        public T this[int index] { get; }
        public static Vector<T> AllBitsSet { get; }
        public static int Count { get; }
        public static bool IsSupported { get; }
        public static Vector<T> One { get; }
        public static Vector<T> Zero { get; }

        public void CopyTo(T[] destination);
        public void CopyTo(T[] destination, int startIndex);
        public void CopyTo(Span<byte> destination);
        public void CopyTo(Span<T> destination);
        public override bool Equals(object obj);
        public bool Equals(Vector<T> other);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format);
        public string ToString(string format, IFormatProvider formatProvider);
        public bool TryCopyTo(Span<byte> destination);
        public bool TryCopyTo(Span<T> destination);

        public static Vector<T> operator +(Vector<T> left, Vector<T> right);
        public static Vector<T> operator &(Vector<T> left, Vector<T> right);
        public static Vector<T> operator |(Vector<T> left, Vector<T> right);
        public static Vector<T> operator /(Vector<T> left, Vector<T> right);
        public static Vector<T> operator /(Vector<T> left, T right);
        public static bool operator ==(Vector<T> left, Vector<T> right);
        public static Vector<T> operator ^(Vector<T> left, Vector<T> right);
        public static bool operator !=(Vector<T> left, Vector<T> right);
        public static Vector<T> operator <<(Vector<T> value, int shiftCount);
        public static Vector<T> operator *(Vector<T> left, Vector<T> right);
        public static Vector<T> operator *(Vector<T> value, T factor);
        public static Vector<T> operator *(T factor, Vector<T> value);
        public static Vector<T> operator ~(Vector<T> value);
        public static Vector<T> operator >>(Vector<T> value, int shiftCount);
        public static Vector<T> operator -(Vector<T> left, Vector<T> right);
        public static Vector<T> operator -(Vector<T> value);
        public static Vector<T> operator +(Vector<T> value);
        public static Vector<T> operator >>>(Vector<T> value, int shiftCount);

        public static explicit operator Vector<byte>(Vector<T> value);
        public static explicit operator Vector<double>(Vector<T> value);
        public static explicit operator Vector<short>(Vector<T> value);
        public static explicit operator Vector<int>(Vector<T> value);
        public static explicit operator Vector<long>(Vector<T> value);
        public static explicit operator Vector<nint>(Vector<T> value);
        [CLSCompliant(False)]
        public static explicit operator Vector<nuint>(Vector<T> value);
        [CLSCompliant(False)]
        public static explicit operator Vector<sbyte>(Vector<T> value);
        public static explicit operator Vector<float>(Vector<T> value);
        [CLSCompliant(False)]
        public static explicit operator Vector<ushort>(Vector<T> value);
        [CLSCompliant(False)]
        public static explicit operator Vector<uint>(Vector<T> value);
        [CLSCompliant(False)]
        public static explicit operator Vector<ulong>(Vector<T> value);
    }
}
