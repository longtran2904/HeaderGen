#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Reflection;

namespace System.Numerics
{
    [DefaultMember("Item")]
    public struct Vector4 : IEquatable<Vector4>, IFormattable
    {
        public float X;
        public float Y;
        public float Z;
        public float W;

        public Vector4(float value);
        public Vector4(Vector2 value, float z, float w);
        public Vector4(Vector3 value, float w);
        public Vector4(float x, float y, float z, float w);
        public Vector4(ReadOnlySpan<float> values);

        public float this[int index] { get; set; }
        public static Vector4 Zero { get; }
        public static Vector4 One { get; }
        public static Vector4 UnitX { get; }
        public static Vector4 UnitY { get; }
        public static Vector4 UnitZ { get; }
        public static Vector4 UnitW { get; }

        public static Vector4 Abs(Vector4 value);
        public static Vector4 Add(Vector4 left, Vector4 right);
        public static Vector4 Clamp(Vector4 value1, Vector4 min, Vector4 max);
        public static float Distance(Vector4 value1, Vector4 value2);
        public static float DistanceSquared(Vector4 value1, Vector4 value2);
        public static Vector4 Divide(Vector4 left, Vector4 right);
        public static Vector4 Divide(Vector4 left, float divisor);
        public static float Dot(Vector4 vector1, Vector4 vector2);
        public static Vector4 Lerp(Vector4 value1, Vector4 value2, float amount);
        public static Vector4 Max(Vector4 value1, Vector4 value2);
        public static Vector4 Min(Vector4 value1, Vector4 value2);
        public static Vector4 Multiply(Vector4 left, Vector4 right);
        public static Vector4 Multiply(Vector4 left, float right);
        public static Vector4 Multiply(float left, Vector4 right);
        public static Vector4 Negate(Vector4 value);
        public static Vector4 Normalize(Vector4 vector);
        public static Vector4 SquareRoot(Vector4 value);
        public static Vector4 Subtract(Vector4 left, Vector4 right);
        public static Vector4 Transform(Vector2 position, Matrix4x4 matrix);
        public static Vector4 Transform(Vector2 value, Quaternion rotation);
        public static Vector4 Transform(Vector3 position, Matrix4x4 matrix);
        public static Vector4 Transform(Vector3 value, Quaternion rotation);
        public static Vector4 Transform(Vector4 vector, Matrix4x4 matrix);
        public static Vector4 Transform(Vector4 value, Quaternion rotation);
        public void CopyTo(float[] array);
        public void CopyTo(float[] array, int index);
        public void CopyTo(Span<float> destination);
        public bool TryCopyTo(Span<float> destination);
        public bool Equals(Vector4 other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public float Length();
        public float LengthSquared();
        public override string ToString();
        public string ToString(string format);
        public string ToString(string format, IFormatProvider formatProvider);

        public static Vector4 operator +(Vector4 left, Vector4 right);
        public static Vector4 operator /(Vector4 left, Vector4 right);
        public static Vector4 operator /(Vector4 value1, float value2);
        public static bool operator ==(Vector4 left, Vector4 right);
        public static bool operator !=(Vector4 left, Vector4 right);
        public static Vector4 operator *(Vector4 left, Vector4 right);
        public static Vector4 operator *(Vector4 left, float right);
        public static Vector4 operator *(float left, Vector4 right);
        public static Vector4 operator -(Vector4 left, Vector4 right);
        public static Vector4 operator -(Vector4 value);
    }
}
