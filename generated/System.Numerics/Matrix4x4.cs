#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Reflection;

namespace System.Numerics
{
    [DefaultMember("Item")]
    public struct Matrix4x4 : IEquatable<Matrix4x4>
    {

        public float M11;
        public float M12;
        public float M13;
        public float M14;
        public float M21;
        public float M22;
        public float M23;
        public float M24;
        public float M31;
        public float M32;
        public float M33;
        public float M34;
        public float M41;
        public float M42;
        public float M43;
        public float M44;

        public Matrix4x4(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44);
        public Matrix4x4(Matrix3x2 value);

        public float this[int row, int column] { get; set; }
        public static Matrix4x4 Identity { get; }
        public bool IsIdentity { get; }
        public Vector3 Translation { get; set; }

        public static Matrix4x4 Add(Matrix4x4 value1, Matrix4x4 value2);
        public static Matrix4x4 CreateBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 cameraUpVector, Vector3 cameraForwardVector);
        public static Matrix4x4 CreateConstrainedBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 rotateAxis, Vector3 cameraForwardVector, Vector3 objectForwardVector);
        public static Matrix4x4 CreateFromAxisAngle(Vector3 axis, float angle);
        public static Matrix4x4 CreateFromQuaternion(Quaternion quaternion);
        public static Matrix4x4 CreateFromYawPitchRoll(float yaw, float pitch, float roll);
        public static Matrix4x4 CreateLookAt(Vector3 cameraPosition, Vector3 cameraTarget, Vector3 cameraUpVector);
        public static Matrix4x4 CreateLookAtLeftHanded(Vector3 cameraPosition, Vector3 cameraTarget, Vector3 cameraUpVector);
        public static Matrix4x4 CreateLookTo(Vector3 cameraPosition, Vector3 cameraDirection, Vector3 cameraUpVector);
        public static Matrix4x4 CreateLookToLeftHanded(Vector3 cameraPosition, Vector3 cameraDirection, Vector3 cameraUpVector);
        public static Matrix4x4 CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane);
        public static Matrix4x4 CreateOrthographicLeftHanded(float width, float height, float zNearPlane, float zFarPlane);
        public static Matrix4x4 CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane);
        public static Matrix4x4 CreateOrthographicOffCenterLeftHanded(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane);
        public static Matrix4x4 CreatePerspective(float width, float height, float nearPlaneDistance, float farPlaneDistance);
        public static Matrix4x4 CreatePerspectiveLeftHanded(float width, float height, float nearPlaneDistance, float farPlaneDistance);
        public static Matrix4x4 CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance);
        public static Matrix4x4 CreatePerspectiveFieldOfViewLeftHanded(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance);
        public static Matrix4x4 CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance);
        public static Matrix4x4 CreatePerspectiveOffCenterLeftHanded(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance);
        public static Matrix4x4 CreateReflection(Plane value);
        public static Matrix4x4 CreateRotationX(float radians);
        public static Matrix4x4 CreateRotationX(float radians, Vector3 centerPoint);
        public static Matrix4x4 CreateRotationY(float radians);
        public static Matrix4x4 CreateRotationY(float radians, Vector3 centerPoint);
        public static Matrix4x4 CreateRotationZ(float radians);
        public static Matrix4x4 CreateRotationZ(float radians, Vector3 centerPoint);
        public static Matrix4x4 CreateScale(float xScale, float yScale, float zScale);
        public static Matrix4x4 CreateScale(float xScale, float yScale, float zScale, Vector3 centerPoint);
        public static Matrix4x4 CreateScale(Vector3 scales);
        public static Matrix4x4 CreateScale(Vector3 scales, Vector3 centerPoint);
        public static Matrix4x4 CreateScale(float scale);
        public static Matrix4x4 CreateScale(float scale, Vector3 centerPoint);
        public static Matrix4x4 CreateShadow(Vector3 lightDirection, Plane plane);
        public static Matrix4x4 CreateTranslation(Vector3 position);
        public static Matrix4x4 CreateTranslation(float xPosition, float yPosition, float zPosition);
        public static Matrix4x4 CreateViewport(float x, float y, float width, float height, float minDepth, float maxDepth);
        public static Matrix4x4 CreateViewportLeftHanded(float x, float y, float width, float height, float minDepth, float maxDepth);
        public static Matrix4x4 CreateWorld(Vector3 position, Vector3 forward, Vector3 up);
        public static bool Decompose(Matrix4x4 matrix, out Vector3 scale, out Quaternion rotation, out Vector3 translation);
        public static bool Invert(Matrix4x4 matrix, out Matrix4x4 result);
        public static Matrix4x4 Lerp(Matrix4x4 matrix1, Matrix4x4 matrix2, float amount);
        public static Matrix4x4 Multiply(Matrix4x4 value1, Matrix4x4 value2);
        public static Matrix4x4 Multiply(Matrix4x4 value1, float value2);
        public static Matrix4x4 Negate(Matrix4x4 value);
        public static Matrix4x4 Subtract(Matrix4x4 value1, Matrix4x4 value2);
        public static Matrix4x4 Transform(Matrix4x4 value, Quaternion rotation);
        public static Matrix4x4 Transpose(Matrix4x4 matrix);
        public override bool Equals(object obj);
        public bool Equals(Matrix4x4 other);
        public float GetDeterminant();
        public override int GetHashCode();
        public override string ToString();

        public static Matrix4x4 operator +(Matrix4x4 value1, Matrix4x4 value2);
        public static bool operator ==(Matrix4x4 value1, Matrix4x4 value2);
        public static bool operator !=(Matrix4x4 value1, Matrix4x4 value2);
        public static Matrix4x4 operator *(Matrix4x4 value1, Matrix4x4 value2);
        public static Matrix4x4 operator *(Matrix4x4 value1, float value2);
        public static Matrix4x4 operator -(Matrix4x4 value1, Matrix4x4 value2);
        public static Matrix4x4 operator -(Matrix4x4 value);
    }
}
