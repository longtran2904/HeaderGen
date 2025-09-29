#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Numerics
{
    public struct Plane : IEquatable<Plane>
    {

        public Vector3 Normal;
        public float D;

        public Plane(float x, float y, float z, float d);
        public Plane(Vector3 normal, float d);
        public Plane(Vector4 value);

        public static Plane CreateFromVertices(Vector3 point1, Vector3 point2, Vector3 point3);
        public static float Dot(Plane plane, Vector4 value);
        public static float DotCoordinate(Plane plane, Vector3 value);
        public static float DotNormal(Plane plane, Vector3 value);
        public static Plane Normalize(Plane value);
        public static Plane Transform(Plane plane, Matrix4x4 matrix);
        public static Plane Transform(Plane plane, Quaternion rotation);
        public override bool Equals(object obj);
        public bool Equals(Plane other);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(Plane value1, Plane value2);
        public static bool operator !=(Plane value1, Plane value2);
    }
}
