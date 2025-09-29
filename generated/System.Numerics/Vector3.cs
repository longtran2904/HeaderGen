#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Reflection;

namespace System.Numerics
{
    [DefaultMember("Item")]
    public struct Vector3 : IEquatable<Vector3>, IFormattable
    {
        public float X;
        public float Y;
        public float Z;

        public Vector3(float value);
        public Vector3(Vector2 value, float z);
        public Vector3(float x, float y, float z);
        public Vector3(ReadOnlySpan<float> values);

        public float this[int index] { get; set; }
        public static Vector3 Zero { get; }
        public static Vector3 One { get; }
        public static Vector3 UnitX { get; }
        public static Vector3 UnitY { get; }
        public static Vector3 UnitZ { get; }

        public static Vector3 Abs(Vector3 value);
        public static Vector3 Add(Vector3 left, Vector3 right);
        public static Vector3 Clamp(Vector3 value1, Vector3 min, Vector3 max);
        public static Vector3 Cross(Vector3 vector1, Vector3 vector2);
        public static float Distance(Vector3 value1, Vector3 value2);
        public static float DistanceSquared(Vector3 value1, Vector3 value2);
        public static Vector3 Divide(Vector3 left, Vector3 right);
        public static Vector3 Divide(Vector3 left, float divisor);
        public static float Dot(Vector3 vector1, Vector3 vector2);
        public static Vector3 Lerp(Vector3 value1, Vector3 value2, float amount);
        public static Vector3 Max(Vector3 value1, Vector3 value2);
        public static Vector3 Min(Vector3 value1, Vector3 value2);
        public static Vector3 Multiply(Vector3 left, Vector3 right);
        public static Vector3 Multiply(Vector3 left, float right);
        public static Vector3 Multiply(float left, Vector3 right);
        public static Vector3 Negate(Vector3 value);
        public static Vector3 Normalize(Vector3 value);
        public static Vector3 Reflect(Vector3 vector, Vector3 normal);
        public static Vector3 SquareRoot(Vector3 value);
        public static Vector3 Subtract(Vector3 left, Vector3 right);
        public static Vector3 Transform(Vector3 position, Matrix4x4 matrix);
        public static Vector3 Transform(Vector3 value, Quaternion rotation);
        public static Vector3 TransformNormal(Vector3 normal, Matrix4x4 matrix);
        public void CopyTo(float[] array);
        public void CopyTo(float[] array, int index);
        public void CopyTo(Span<float> destination);
        public bool TryCopyTo(Span<float> destination);
        public override bool Equals(object obj);
        public bool Equals(Vector3 other);
        public override int GetHashCode();
        public float Length();
        public float LengthSquared();
        public override string ToString();
        public string ToString(string format);
        public string ToString(string format, IFormatProvider formatProvider);

        public static Vector3 operator +(Vector3 left, Vector3 right);
        public static Vector3 operator /(Vector3 left, Vector3 right);
        public static Vector3 operator /(Vector3 value1, float value2);
        public static bool operator ==(Vector3 left, Vector3 right);
        public static bool operator !=(Vector3 left, Vector3 right);
        public static Vector3 operator *(Vector3 left, Vector3 right);
        public static Vector3 operator *(Vector3 left, float right);
        public static Vector3 operator *(float left, Vector3 right);
        public static Vector3 operator -(Vector3 left, Vector3 right);
        public static Vector3 operator -(Vector3 value);
    }
}
