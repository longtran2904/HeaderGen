#region Unity.Mathematics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Mathematics.dll
#endregion

using System;
using System.Reflection;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
    [DefaultMember("Item")]
    [Il2CppEagerStaticClassConstruction]
    public struct float3x3 : IEquatable<float3x3>, IFormattable
    {
        public float3 c0;
        public float3 c1;
        public float3 c2;
        public static readonly float3x3 identity;
        public static readonly float3x3 zero;

        public float3x3(float3 c0, float3 c1, float3 c2);
        public float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22);
        public float3x3(float v);
        public float3x3(bool v);
        public float3x3(bool3x3 v);
        public float3x3(int v);
        public float3x3(int3x3 v);
        public float3x3(uint v);
        public float3x3(uint3x3 v);
        public float3x3(double v);
        public float3x3(double3x3 v);
        public float3x3(float4x4 f4x4);
        public float3x3(quaternion q);

        public ref float3 this[int index] { get; }

        public bool Equals(float3x3 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);
        public static float3x3 AxisAngle(float3 axis, float angle);
        public static float3x3 EulerXYZ(float3 xyz);
        public static float3x3 EulerXZY(float3 xyz);
        public static float3x3 EulerYXZ(float3 xyz);
        public static float3x3 EulerYZX(float3 xyz);
        public static float3x3 EulerZXY(float3 xyz);
        public static float3x3 EulerZYX(float3 xyz);
        public static float3x3 EulerXYZ(float x, float y, float z);
        public static float3x3 EulerXZY(float x, float y, float z);
        public static float3x3 EulerYXZ(float x, float y, float z);
        public static float3x3 EulerYZX(float x, float y, float z);
        public static float3x3 EulerZXY(float x, float y, float z);
        public static float3x3 EulerZYX(float x, float y, float z);
        public static float3x3 Euler(float3 xyz, math.RotationOrder order = math.RotationOrder.ZXY);
        public static float3x3 Euler(float x, float y, float z, math.RotationOrder order = math.RotationOrder.ZXY);
        public static float3x3 RotateX(float angle);
        public static float3x3 RotateY(float angle);
        public static float3x3 RotateZ(float angle);
        public static float3x3 Scale(float s);
        public static float3x3 Scale(float x, float y, float z);
        public static float3x3 Scale(float3 v);
        public static float3x3 LookRotation(float3 forward, float3 up);
        public static float3x3 LookRotationSafe(float3 forward, float3 up);

        public static float3x3 operator *(float3x3 lhs, float3x3 rhs);
        public static float3x3 operator *(float3x3 lhs, float rhs);
        public static float3x3 operator *(float lhs, float3x3 rhs);
        public static float3x3 operator +(float3x3 lhs, float3x3 rhs);
        public static float3x3 operator +(float3x3 lhs, float rhs);
        public static float3x3 operator +(float lhs, float3x3 rhs);
        public static float3x3 operator -(float3x3 lhs, float3x3 rhs);
        public static float3x3 operator -(float3x3 lhs, float rhs);
        public static float3x3 operator -(float lhs, float3x3 rhs);
        public static float3x3 operator /(float3x3 lhs, float3x3 rhs);
        public static float3x3 operator /(float3x3 lhs, float rhs);
        public static float3x3 operator /(float lhs, float3x3 rhs);
        public static float3x3 operator %(float3x3 lhs, float3x3 rhs);
        public static float3x3 operator %(float3x3 lhs, float rhs);
        public static float3x3 operator %(float lhs, float3x3 rhs);
        public static float3x3 operator ++(float3x3 val);
        public static float3x3 operator --(float3x3 val);
        public static bool3x3 operator <(float3x3 lhs, float3x3 rhs);
        public static bool3x3 operator <(float3x3 lhs, float rhs);
        public static bool3x3 operator <(float lhs, float3x3 rhs);
        public static bool3x3 operator <=(float3x3 lhs, float3x3 rhs);
        public static bool3x3 operator <=(float3x3 lhs, float rhs);
        public static bool3x3 operator <=(float lhs, float3x3 rhs);
        public static bool3x3 operator >(float3x3 lhs, float3x3 rhs);
        public static bool3x3 operator >(float3x3 lhs, float rhs);
        public static bool3x3 operator >(float lhs, float3x3 rhs);
        public static bool3x3 operator >=(float3x3 lhs, float3x3 rhs);
        public static bool3x3 operator >=(float3x3 lhs, float rhs);
        public static bool3x3 operator >=(float lhs, float3x3 rhs);
        public static float3x3 operator -(float3x3 val);
        public static float3x3 operator +(float3x3 val);
        public static bool3x3 operator ==(float3x3 lhs, float3x3 rhs);
        public static bool3x3 operator ==(float3x3 lhs, float rhs);
        public static bool3x3 operator ==(float lhs, float3x3 rhs);
        public static bool3x3 operator !=(float3x3 lhs, float3x3 rhs);
        public static bool3x3 operator !=(float3x3 lhs, float rhs);
        public static bool3x3 operator !=(float lhs, float3x3 rhs);

        public static implicit operator float3x3(float v);
        public static explicit operator float3x3(bool v);
        public static explicit operator float3x3(bool3x3 v);
        public static implicit operator float3x3(int v);
        public static implicit operator float3x3(int3x3 v);
        public static implicit operator float3x3(uint v);
        public static implicit operator float3x3(uint3x3 v);
        public static explicit operator float3x3(double v);
        public static explicit operator float3x3(double3x3 v);
        public static explicit operator float3x3(float4x4 f4x4);
    }
}
