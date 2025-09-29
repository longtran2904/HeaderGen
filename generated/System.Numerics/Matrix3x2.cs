#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Reflection;

namespace System.Numerics
{
    [DefaultMember("Item")]
    public struct Matrix3x2 : IEquatable<Matrix3x2>
    {

        public float M11;
        public float M12;
        public float M21;
        public float M22;
        public float M31;
        public float M32;

        public Matrix3x2(float m11, float m12, float m21, float m22, float m31, float m32);

        public float this[int row, int column] { get; set; }
        public static Matrix3x2 Identity { get; }
        public bool IsIdentity { get; }
        public Vector2 Translation { get; set; }

        public static Matrix3x2 Add(Matrix3x2 value1, Matrix3x2 value2);
        public static Matrix3x2 CreateRotation(float radians);
        public static Matrix3x2 CreateRotation(float radians, Vector2 centerPoint);
        public static Matrix3x2 CreateScale(Vector2 scales);
        public static Matrix3x2 CreateScale(float xScale, float yScale);
        public static Matrix3x2 CreateScale(float xScale, float yScale, Vector2 centerPoint);
        public static Matrix3x2 CreateScale(Vector2 scales, Vector2 centerPoint);
        public static Matrix3x2 CreateScale(float scale);
        public static Matrix3x2 CreateScale(float scale, Vector2 centerPoint);
        public static Matrix3x2 CreateSkew(float radiansX, float radiansY);
        public static Matrix3x2 CreateSkew(float radiansX, float radiansY, Vector2 centerPoint);
        public static Matrix3x2 CreateTranslation(Vector2 position);
        public static Matrix3x2 CreateTranslation(float xPosition, float yPosition);
        public static bool Invert(Matrix3x2 matrix, out Matrix3x2 result);
        public static Matrix3x2 Lerp(Matrix3x2 matrix1, Matrix3x2 matrix2, float amount);
        public static Matrix3x2 Multiply(Matrix3x2 value1, Matrix3x2 value2);
        public static Matrix3x2 Multiply(Matrix3x2 value1, float value2);
        public static Matrix3x2 Negate(Matrix3x2 value);
        public static Matrix3x2 Subtract(Matrix3x2 value1, Matrix3x2 value2);
        public override bool Equals(object obj);
        public bool Equals(Matrix3x2 other);
        public float GetDeterminant();
        public override int GetHashCode();
        public override string ToString();

        public static Matrix3x2 operator +(Matrix3x2 value1, Matrix3x2 value2);
        public static bool operator ==(Matrix3x2 value1, Matrix3x2 value2);
        public static bool operator !=(Matrix3x2 value1, Matrix3x2 value2);
        public static Matrix3x2 operator *(Matrix3x2 value1, Matrix3x2 value2);
        public static Matrix3x2 operator *(Matrix3x2 value1, float value2);
        public static Matrix3x2 operator -(Matrix3x2 value1, Matrix3x2 value2);
        public static Matrix3x2 operator -(Matrix3x2 value);
    }
}
