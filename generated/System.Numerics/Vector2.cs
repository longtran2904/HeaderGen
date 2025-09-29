#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Reflection;

namespace System.Numerics
{
    [DefaultMember("Item")]
    public struct Vector2 : IEquatable<Vector2>, IFormattable
    {

        public float X;
        public float Y;

        public Vector2(float value);
        public Vector2(float x, float y);
        public Vector2(ReadOnlySpan<float> values);

        public float this[int index] { get; set; }
        public static Vector2 Zero { get; }
        public static Vector2 One { get; }
        public static Vector2 UnitX { get; }
        public static Vector2 UnitY { get; }

        public static Vector2 Abs(Vector2 value);
        public static Vector2 Add(Vector2 left, Vector2 right);
        public static Vector2 Clamp(Vector2 value1, Vector2 min, Vector2 max);
        public static float Distance(Vector2 value1, Vector2 value2);
        public static float DistanceSquared(Vector2 value1, Vector2 value2);
        public static Vector2 Divide(Vector2 left, Vector2 right);
        public static Vector2 Divide(Vector2 left, float divisor);
        public static float Dot(Vector2 value1, Vector2 value2);
        public static Vector2 Lerp(Vector2 value1, Vector2 value2, float amount);
        public static Vector2 Max(Vector2 value1, Vector2 value2);
        public static Vector2 Min(Vector2 value1, Vector2 value2);
        public static Vector2 Multiply(Vector2 left, Vector2 right);
        public static Vector2 Multiply(Vector2 left, float right);
        public static Vector2 Multiply(float left, Vector2 right);
        public static Vector2 Negate(Vector2 value);
        public static Vector2 Normalize(Vector2 value);
        public static Vector2 Reflect(Vector2 vector, Vector2 normal);
        public static Vector2 SquareRoot(Vector2 value);
        public static Vector2 Subtract(Vector2 left, Vector2 right);
        public static Vector2 Transform(Vector2 position, Matrix3x2 matrix);
        public static Vector2 Transform(Vector2 position, Matrix4x4 matrix);
        public static Vector2 Transform(Vector2 value, Quaternion rotation);
        public static Vector2 TransformNormal(Vector2 normal, Matrix3x2 matrix);
        public static Vector2 TransformNormal(Vector2 normal, Matrix4x4 matrix);
        public void CopyTo(float[] array);
        public void CopyTo(float[] array, int index);
        public void CopyTo(Span<float> destination);
        public bool TryCopyTo(Span<float> destination);
        public override bool Equals(object obj);
        public bool Equals(Vector2 other);
        public override int GetHashCode();
        public float Length();
        public float LengthSquared();
        public override string ToString();
        public string ToString(string format);
        public string ToString(string format, IFormatProvider formatProvider);

        public static Vector2 operator +(Vector2 left, Vector2 right);
        public static Vector2 operator /(Vector2 left, Vector2 right);
        public static Vector2 operator /(Vector2 value1, float value2);
        public static bool operator ==(Vector2 left, Vector2 right);
        public static bool operator !=(Vector2 left, Vector2 right);
        public static Vector2 operator *(Vector2 left, Vector2 right);
        public static Vector2 operator *(Vector2 left, float right);
        public static Vector2 operator *(float left, Vector2 right);
        public static Vector2 operator -(Vector2 left, Vector2 right);
        public static Vector2 operator -(Vector2 value);
    }
}
