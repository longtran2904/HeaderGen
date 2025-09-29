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
    public struct float3x4 : IEquatable<float3x4>, IFormattable
    {
        public float3 c0;
        public float3 c1;
        public float3 c2;
        public float3 c3;
        public static readonly float3x4 zero;

        public float3x4(float3 c0, float3 c1, float3 c2, float3 c3);
        public float3x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23);
        public float3x4(float v);
        public float3x4(bool v);
        public float3x4(bool3x4 v);
        public float3x4(int v);
        public float3x4(int3x4 v);
        public float3x4(uint v);
        public float3x4(uint3x4 v);
        public float3x4(double v);
        public float3x4(double3x4 v);

        public ref float3 this[int index] { get; }

        public bool Equals(float3x4 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static float3x4 operator *(float3x4 lhs, float3x4 rhs);
        public static float3x4 operator *(float3x4 lhs, float rhs);
        public static float3x4 operator *(float lhs, float3x4 rhs);
        public static float3x4 operator +(float3x4 lhs, float3x4 rhs);
        public static float3x4 operator +(float3x4 lhs, float rhs);
        public static float3x4 operator +(float lhs, float3x4 rhs);
        public static float3x4 operator -(float3x4 lhs, float3x4 rhs);
        public static float3x4 operator -(float3x4 lhs, float rhs);
        public static float3x4 operator -(float lhs, float3x4 rhs);
        public static float3x4 operator /(float3x4 lhs, float3x4 rhs);
        public static float3x4 operator /(float3x4 lhs, float rhs);
        public static float3x4 operator /(float lhs, float3x4 rhs);
        public static float3x4 operator %(float3x4 lhs, float3x4 rhs);
        public static float3x4 operator %(float3x4 lhs, float rhs);
        public static float3x4 operator %(float lhs, float3x4 rhs);
        public static float3x4 operator ++(float3x4 val);
        public static float3x4 operator --(float3x4 val);
        public static bool3x4 operator <(float3x4 lhs, float3x4 rhs);
        public static bool3x4 operator <(float3x4 lhs, float rhs);
        public static bool3x4 operator <(float lhs, float3x4 rhs);
        public static bool3x4 operator <=(float3x4 lhs, float3x4 rhs);
        public static bool3x4 operator <=(float3x4 lhs, float rhs);
        public static bool3x4 operator <=(float lhs, float3x4 rhs);
        public static bool3x4 operator >(float3x4 lhs, float3x4 rhs);
        public static bool3x4 operator >(float3x4 lhs, float rhs);
        public static bool3x4 operator >(float lhs, float3x4 rhs);
        public static bool3x4 operator >=(float3x4 lhs, float3x4 rhs);
        public static bool3x4 operator >=(float3x4 lhs, float rhs);
        public static bool3x4 operator >=(float lhs, float3x4 rhs);
        public static float3x4 operator -(float3x4 val);
        public static float3x4 operator +(float3x4 val);
        public static bool3x4 operator ==(float3x4 lhs, float3x4 rhs);
        public static bool3x4 operator ==(float3x4 lhs, float rhs);
        public static bool3x4 operator ==(float lhs, float3x4 rhs);
        public static bool3x4 operator !=(float3x4 lhs, float3x4 rhs);
        public static bool3x4 operator !=(float3x4 lhs, float rhs);
        public static bool3x4 operator !=(float lhs, float3x4 rhs);

        public static implicit operator float3x4(float v);
        public static explicit operator float3x4(bool v);
        public static explicit operator float3x4(bool3x4 v);
        public static implicit operator float3x4(int v);
        public static implicit operator float3x4(int3x4 v);
        public static implicit operator float3x4(uint v);
        public static implicit operator float3x4(uint3x4 v);
        public static explicit operator float3x4(double v);
        public static explicit operator float3x4(double3x4 v);
    }
}
