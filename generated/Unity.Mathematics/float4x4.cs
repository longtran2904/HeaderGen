#region Unity.Mathematics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Mathematics.dll
#endregion

using System;
using System.Reflection;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
    [DefaultMember("Item")]
    [Il2CppEagerStaticClassConstruction]
    public struct float4x4 : IEquatable<float4x4>, IFormattable
    {

        public float4 c0;
        public float4 c1;
        public float4 c2;
        public float4 c3;
        public static readonly float4x4 identity;
        public static readonly float4x4 zero;

        public float4x4(float4 c0, float4 c1, float4 c2, float4 c3);
        public float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33);
        public float4x4(float v);
        public float4x4(bool v);
        public float4x4(bool4x4 v);
        public float4x4(int v);
        public float4x4(int4x4 v);
        public float4x4(uint v);
        public float4x4(uint4x4 v);
        public float4x4(double v);
        public float4x4(double4x4 v);
        public float4x4(float3x3 rotation, float3 translation);
        public float4x4(quaternion rotation, float3 translation);
        public float4x4(RigidTransform transform);

        public ref float4 this[int index] { get; }

        public bool Equals(float4x4 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);
        public static float4x4 AxisAngle(float3 axis, float angle);
        public static float4x4 EulerXYZ(float3 xyz);
        public static float4x4 EulerXZY(float3 xyz);
        public static float4x4 EulerYXZ(float3 xyz);
        public static float4x4 EulerYZX(float3 xyz);
        public static float4x4 EulerZXY(float3 xyz);
        public static float4x4 EulerZYX(float3 xyz);
        public static float4x4 EulerXYZ(float x, float y, float z);
        public static float4x4 EulerXZY(float x, float y, float z);
        public static float4x4 EulerYXZ(float x, float y, float z);
        public static float4x4 EulerYZX(float x, float y, float z);
        public static float4x4 EulerZXY(float x, float y, float z);
        public static float4x4 EulerZYX(float x, float y, float z);
        public static float4x4 Euler(float3 xyz, math.RotationOrder order = math.RotationOrder.ZXY);
        public static float4x4 Euler(float x, float y, float z, math.RotationOrder order = math.RotationOrder.ZXY);
        public static float4x4 RotateX(float angle);
        public static float4x4 RotateY(float angle);
        public static float4x4 RotateZ(float angle);
        public static float4x4 Scale(float s);
        public static float4x4 Scale(float x, float y, float z);
        public static float4x4 Scale(float3 scales);
        public static float4x4 Translate(float3 vector);
        public static float4x4 LookAt(float3 eye, float3 target, float3 up);
        public static float4x4 Ortho(float width, float height, float near, float far);
        public static float4x4 OrthoOffCenter(float left, float right, float bottom, float top, float near, float far);
        public static float4x4 PerspectiveFov(float verticalFov, float aspect, float near, float far);
        public static float4x4 PerspectiveOffCenter(float left, float right, float bottom, float top, float near, float far);
        public static float4x4 TRS(float3 translation, quaternion rotation, float3 scale);

        public static float4x4 operator *(float4x4 lhs, float4x4 rhs);
        public static float4x4 operator *(float4x4 lhs, float rhs);
        public static float4x4 operator *(float lhs, float4x4 rhs);
        public static float4x4 operator +(float4x4 lhs, float4x4 rhs);
        public static float4x4 operator +(float4x4 lhs, float rhs);
        public static float4x4 operator +(float lhs, float4x4 rhs);
        public static float4x4 operator -(float4x4 lhs, float4x4 rhs);
        public static float4x4 operator -(float4x4 lhs, float rhs);
        public static float4x4 operator -(float lhs, float4x4 rhs);
        public static float4x4 operator /(float4x4 lhs, float4x4 rhs);
        public static float4x4 operator /(float4x4 lhs, float rhs);
        public static float4x4 operator /(float lhs, float4x4 rhs);
        public static float4x4 operator %(float4x4 lhs, float4x4 rhs);
        public static float4x4 operator %(float4x4 lhs, float rhs);
        public static float4x4 operator %(float lhs, float4x4 rhs);
        public static float4x4 operator ++(float4x4 val);
        public static float4x4 operator --(float4x4 val);
        public static bool4x4 operator <(float4x4 lhs, float4x4 rhs);
        public static bool4x4 operator <(float4x4 lhs, float rhs);
        public static bool4x4 operator <(float lhs, float4x4 rhs);
        public static bool4x4 operator <=(float4x4 lhs, float4x4 rhs);
        public static bool4x4 operator <=(float4x4 lhs, float rhs);
        public static bool4x4 operator <=(float lhs, float4x4 rhs);
        public static bool4x4 operator >(float4x4 lhs, float4x4 rhs);
        public static bool4x4 operator >(float4x4 lhs, float rhs);
        public static bool4x4 operator >(float lhs, float4x4 rhs);
        public static bool4x4 operator >=(float4x4 lhs, float4x4 rhs);
        public static bool4x4 operator >=(float4x4 lhs, float rhs);
        public static bool4x4 operator >=(float lhs, float4x4 rhs);
        public static float4x4 operator -(float4x4 val);
        public static float4x4 operator +(float4x4 val);
        public static bool4x4 operator ==(float4x4 lhs, float4x4 rhs);
        public static bool4x4 operator ==(float4x4 lhs, float rhs);
        public static bool4x4 operator ==(float lhs, float4x4 rhs);
        public static bool4x4 operator !=(float4x4 lhs, float4x4 rhs);
        public static bool4x4 operator !=(float4x4 lhs, float rhs);
        public static bool4x4 operator !=(float lhs, float4x4 rhs);

        public static implicit operator float4x4(float v);
        public static explicit operator float4x4(bool v);
        public static explicit operator float4x4(bool4x4 v);
        public static implicit operator float4x4(int v);
        public static implicit operator float4x4(int4x4 v);
        public static implicit operator float4x4(uint v);
        public static implicit operator float4x4(uint4x4 v);
        public static explicit operator float4x4(double v);
        public static explicit operator float4x4(double4x4 v);
        public static implicit operator float4x4(Matrix4x4 m);
        public static implicit operator Matrix4x4(float4x4 m);
    }
}
