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
    public struct float3x2 : IEquatable<float3x2>, IFormattable
    {

        public float3 c0;
        public float3 c1;
        public static readonly float3x2 zero;

        public float3x2(float3 c0, float3 c1);
        public float3x2(float m00, float m01, float m10, float m11, float m20, float m21);
        public float3x2(float v);
        public float3x2(bool v);
        public float3x2(bool3x2 v);
        public float3x2(int v);
        public float3x2(int3x2 v);
        public float3x2(uint v);
        public float3x2(uint3x2 v);
        public float3x2(double v);
        public float3x2(double3x2 v);

        public ref float3 this[int index] { get; }

        public bool Equals(float3x2 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static float3x2 operator *(float3x2 lhs, float3x2 rhs);
        public static float3x2 operator *(float3x2 lhs, float rhs);
        public static float3x2 operator *(float lhs, float3x2 rhs);
        public static float3x2 operator +(float3x2 lhs, float3x2 rhs);
        public static float3x2 operator +(float3x2 lhs, float rhs);
        public static float3x2 operator +(float lhs, float3x2 rhs);
        public static float3x2 operator -(float3x2 lhs, float3x2 rhs);
        public static float3x2 operator -(float3x2 lhs, float rhs);
        public static float3x2 operator -(float lhs, float3x2 rhs);
        public static float3x2 operator /(float3x2 lhs, float3x2 rhs);
        public static float3x2 operator /(float3x2 lhs, float rhs);
        public static float3x2 operator /(float lhs, float3x2 rhs);
        public static float3x2 operator %(float3x2 lhs, float3x2 rhs);
        public static float3x2 operator %(float3x2 lhs, float rhs);
        public static float3x2 operator %(float lhs, float3x2 rhs);
        public static float3x2 operator ++(float3x2 val);
        public static float3x2 operator --(float3x2 val);
        public static bool3x2 operator <(float3x2 lhs, float3x2 rhs);
        public static bool3x2 operator <(float3x2 lhs, float rhs);
        public static bool3x2 operator <(float lhs, float3x2 rhs);
        public static bool3x2 operator <=(float3x2 lhs, float3x2 rhs);
        public static bool3x2 operator <=(float3x2 lhs, float rhs);
        public static bool3x2 operator <=(float lhs, float3x2 rhs);
        public static bool3x2 operator >(float3x2 lhs, float3x2 rhs);
        public static bool3x2 operator >(float3x2 lhs, float rhs);
        public static bool3x2 operator >(float lhs, float3x2 rhs);
        public static bool3x2 operator >=(float3x2 lhs, float3x2 rhs);
        public static bool3x2 operator >=(float3x2 lhs, float rhs);
        public static bool3x2 operator >=(float lhs, float3x2 rhs);
        public static float3x2 operator -(float3x2 val);
        public static float3x2 operator +(float3x2 val);
        public static bool3x2 operator ==(float3x2 lhs, float3x2 rhs);
        public static bool3x2 operator ==(float3x2 lhs, float rhs);
        public static bool3x2 operator ==(float lhs, float3x2 rhs);
        public static bool3x2 operator !=(float3x2 lhs, float3x2 rhs);
        public static bool3x2 operator !=(float3x2 lhs, float rhs);
        public static bool3x2 operator !=(float lhs, float3x2 rhs);

        public static implicit operator float3x2(float v);
        public static explicit operator float3x2(bool v);
        public static explicit operator float3x2(bool3x2 v);
        public static implicit operator float3x2(int v);
        public static implicit operator float3x2(int3x2 v);
        public static implicit operator float3x2(uint v);
        public static implicit operator float3x2(uint3x2 v);
        public static explicit operator float3x2(double v);
        public static explicit operator float3x2(double3x2 v);
    }
}
