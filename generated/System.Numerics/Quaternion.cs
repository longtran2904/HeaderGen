#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Reflection;

namespace System.Numerics
{
    [DefaultMember("Item")]
    public struct Quaternion : IEquatable<Quaternion>
    {
        public float X;
        public float Y;
        public float Z;
        public float W;

        public Quaternion(float x, float y, float z, float w);
        public Quaternion(Vector3 vectorPart, float scalarPart);

        public float this[int index] { get; set; }
        public static Quaternion Zero { get; }
        public static Quaternion Identity { get; }
        public bool IsIdentity { get; }

        public static Quaternion Add(Quaternion value1, Quaternion value2);
        public static Quaternion Concatenate(Quaternion value1, Quaternion value2);
        public static Quaternion Conjugate(Quaternion value);
        public static Quaternion CreateFromAxisAngle(Vector3 axis, float angle);
        public static Quaternion CreateFromRotationMatrix(Matrix4x4 matrix);
        public static Quaternion CreateFromYawPitchRoll(float yaw, float pitch, float roll);
        public static Quaternion Divide(Quaternion value1, Quaternion value2);
        public static float Dot(Quaternion quaternion1, Quaternion quaternion2);
        public static Quaternion Inverse(Quaternion value);
        public static Quaternion Lerp(Quaternion quaternion1, Quaternion quaternion2, float amount);
        public static Quaternion Multiply(Quaternion value1, Quaternion value2);
        public static Quaternion Multiply(Quaternion value1, float value2);
        public static Quaternion Negate(Quaternion value);
        public static Quaternion Normalize(Quaternion value);
        public static Quaternion Slerp(Quaternion quaternion1, Quaternion quaternion2, float amount);
        public static Quaternion Subtract(Quaternion value1, Quaternion value2);
        public override bool Equals(object obj);
        public bool Equals(Quaternion other);
        public override int GetHashCode();
        public float Length();
        public float LengthSquared();
        public override string ToString();

        public static Quaternion operator +(Quaternion value1, Quaternion value2);
        public static Quaternion operator /(Quaternion value1, Quaternion value2);
        public static bool operator ==(Quaternion value1, Quaternion value2);
        public static bool operator !=(Quaternion value1, Quaternion value2);
        public static Quaternion operator *(Quaternion value1, Quaternion value2);
        public static Quaternion operator *(Quaternion value1, float value2);
        public static Quaternion operator -(Quaternion value1, Quaternion value2);
        public static Quaternion operator -(Quaternion value);
    }
}
