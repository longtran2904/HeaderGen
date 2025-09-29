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
    public struct float4x2 : IEquatable<float4x2>, IFormattable
    {
        public float4 c0;
        public float4 c1;
        public static readonly float4x2 zero;

        public float4x2(float4 c0, float4 c1);
        public float4x2(float m00, float m01, float m10, float m11, float m20, float m21, float m30, float m31);
        public float4x2(float v);
        public float4x2(bool v);
        public float4x2(bool4x2 v);
        public float4x2(int v);
        public float4x2(int4x2 v);
        public float4x2(uint v);
        public float4x2(uint4x2 v);
        public float4x2(double v);
        public float4x2(double4x2 v);

        public ref float4 this[int index] { get; }

        public bool Equals(float4x2 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static float4x2 operator *(float4x2 lhs, float4x2 rhs);
        public static float4x2 operator *(float4x2 lhs, float rhs);
        public static float4x2 operator *(float lhs, float4x2 rhs);
        public static float4x2 operator +(float4x2 lhs, float4x2 rhs);
        public static float4x2 operator +(float4x2 lhs, float rhs);
        public static float4x2 operator +(float lhs, float4x2 rhs);
        public static float4x2 operator -(float4x2 lhs, float4x2 rhs);
        public static float4x2 operator -(float4x2 lhs, float rhs);
        public static float4x2 operator -(float lhs, float4x2 rhs);
        public static float4x2 operator /(float4x2 lhs, float4x2 rhs);
        public static float4x2 operator /(float4x2 lhs, float rhs);
        public static float4x2 operator /(float lhs, float4x2 rhs);
        public static float4x2 operator %(float4x2 lhs, float4x2 rhs);
        public static float4x2 operator %(float4x2 lhs, float rhs);
        public static float4x2 operator %(float lhs, float4x2 rhs);
        public static float4x2 operator ++(float4x2 val);
        public static float4x2 operator --(float4x2 val);
        public static bool4x2 operator <(float4x2 lhs, float4x2 rhs);
        public static bool4x2 operator <(float4x2 lhs, float rhs);
        public static bool4x2 operator <(float lhs, float4x2 rhs);
        public static bool4x2 operator <=(float4x2 lhs, float4x2 rhs);
        public static bool4x2 operator <=(float4x2 lhs, float rhs);
        public static bool4x2 operator <=(float lhs, float4x2 rhs);
        public static bool4x2 operator >(float4x2 lhs, float4x2 rhs);
        public static bool4x2 operator >(float4x2 lhs, float rhs);
        public static bool4x2 operator >(float lhs, float4x2 rhs);
        public static bool4x2 operator >=(float4x2 lhs, float4x2 rhs);
        public static bool4x2 operator >=(float4x2 lhs, float rhs);
        public static bool4x2 operator >=(float lhs, float4x2 rhs);
        public static float4x2 operator -(float4x2 val);
        public static float4x2 operator +(float4x2 val);
        public static bool4x2 operator ==(float4x2 lhs, float4x2 rhs);
        public static bool4x2 operator ==(float4x2 lhs, float rhs);
        public static bool4x2 operator ==(float lhs, float4x2 rhs);
        public static bool4x2 operator !=(float4x2 lhs, float4x2 rhs);
        public static bool4x2 operator !=(float4x2 lhs, float rhs);
        public static bool4x2 operator !=(float lhs, float4x2 rhs);

        public static implicit operator float4x2(float v);
        public static explicit operator float4x2(bool v);
        public static explicit operator float4x2(bool4x2 v);
        public static implicit operator float4x2(int v);
        public static implicit operator float4x2(int4x2 v);
        public static implicit operator float4x2(uint v);
        public static implicit operator float4x2(uint4x2 v);
        public static explicit operator float4x2(double v);
        public static explicit operator float4x2(double4x2 v);
    }
}
