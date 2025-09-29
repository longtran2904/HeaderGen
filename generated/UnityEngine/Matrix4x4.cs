#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Reflection;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [DefaultMember("Item")]
    [Il2CppEagerStaticClassConstruction]
    [NativeClass("Matrix4x4f")]
    [NativeHeader("Runtime/Math/MathScripting.h")]
    [NativeType(Header = "Runtime/Math/Matrix4x4.h")]
    [RequiredByNativeCode(Optional = True, GenerateProxy = True)]
    public struct Matrix4x4 : IEquatable<Matrix4x4>, IFormattable
    {
        [NativeName("m_Data[0]")]
        public float m00;
        [NativeName("m_Data[1]")]
        public float m10;
        [NativeName("m_Data[2]")]
        public float m20;
        [NativeName("m_Data[3]")]
        public float m30;
        [NativeName("m_Data[4]")]
        public float m01;
        [NativeName("m_Data[5]")]
        public float m11;
        [NativeName("m_Data[6]")]
        public float m21;
        [NativeName("m_Data[7]")]
        public float m31;
        [NativeName("m_Data[8]")]
        public float m02;
        [NativeName("m_Data[9]")]
        public float m12;
        [NativeName("m_Data[10]")]
        public float m22;
        [NativeName("m_Data[11]")]
        public float m32;
        [NativeName("m_Data[12]")]
        public float m03;
        [NativeName("m_Data[13]")]
        public float m13;
        [NativeName("m_Data[14]")]
        public float m23;
        [NativeName("m_Data[15]")]
        public float m33;

        public Matrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3);

        public float this[int row, int column] { get; set; }
        public float this[int index] { get; set; }
        public Quaternion rotation { get; }
        public Vector3 lossyScale { get; }
        public bool isIdentity { get; }
        public float determinant { get; }
        public FrustumPlanes decomposeProjection { get; }
        public Matrix4x4 inverse { get; }
        public Matrix4x4 transpose { get; }
        public static Matrix4x4 zero { get; }
        public static Matrix4x4 identity { get; }

        [ThreadSafe]
        public bool ValidTRS();
        public static float Determinant(Matrix4x4 m);
        [FreeFunction("MatrixScripting::TRS", IsThreadSafe = True)]
        public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s);
        public void SetTRS(Vector3 pos, Quaternion q, Vector3 s);
        [FreeFunction("MatrixScripting::Inverse3DAffine", IsThreadSafe = True)]
        public static bool Inverse3DAffine(Matrix4x4 input, ref Matrix4x4 result);
        [FreeFunction("MatrixScripting::Inverse", IsThreadSafe = True)]
        public static Matrix4x4 Inverse(Matrix4x4 m);
        [FreeFunction("MatrixScripting::Transpose", IsThreadSafe = True)]
        public static Matrix4x4 Transpose(Matrix4x4 m);
        [FreeFunction("MatrixScripting::Ortho", IsThreadSafe = True)]
        public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar);
        [FreeFunction("MatrixScripting::Perspective", IsThreadSafe = True)]
        public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar);
        [FreeFunction("MatrixScripting::LookAt", IsThreadSafe = True)]
        public static Matrix4x4 LookAt(Vector3 from, Vector3 to, Vector3 up);
        [FreeFunction("MatrixScripting::Frustum", IsThreadSafe = True)]
        public static Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar);
        public static Matrix4x4 Frustum(FrustumPlanes fp);
        public override int GetHashCode();
        public override bool Equals(object other);
        public bool Equals(Matrix4x4 other);
        public Vector4 GetColumn(int index);
        public Vector4 GetRow(int index);
        public Vector3 GetPosition();
        public void SetColumn(int index, Vector4 column);
        public void SetRow(int index, Vector4 row);
        public Vector3 MultiplyPoint(Vector3 point);
        public Vector3 MultiplyPoint3x4(Vector3 point);
        public Vector3 MultiplyVector(Vector3 vector);
        public Plane TransformPlane(Plane plane);
        public static Matrix4x4 Scale(Vector3 vector);
        public static Matrix4x4 Translate(Vector3 vector);
        public static Matrix4x4 Rotate(Quaternion q);
        public override string ToString();
        public string ToString(string format);
        public string ToString(string format, IFormatProvider formatProvider);

        public static Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs);
        public static Vector4 operator *(Matrix4x4 lhs, Vector4 vector);
        public static bool operator ==(Matrix4x4 lhs, Matrix4x4 rhs);
        public static bool operator !=(Matrix4x4 lhs, Matrix4x4 rhs);
    }
}
