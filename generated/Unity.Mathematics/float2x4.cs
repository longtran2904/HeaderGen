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
    public struct float2x4 : IEquatable<float2x4>, IFormattable
    {

        public float2 c0;
        public float2 c1;
        public float2 c2;
        public float2 c3;
        public static readonly float2x4 zero;

        public float2x4(float2 c0, float2 c1, float2 c2, float2 c3);
        public float2x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13);
        public float2x4(float v);
        public float2x4(bool v);
        public float2x4(bool2x4 v);
        public float2x4(int v);
        public float2x4(int2x4 v);
        public float2x4(uint v);
        public float2x4(uint2x4 v);
        public float2x4(double v);
        public float2x4(double2x4 v);

        public ref float2 this[int index] { get; }

        public bool Equals(float2x4 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static float2x4 operator *(float2x4 lhs, float2x4 rhs);
        public static float2x4 operator *(float2x4 lhs, float rhs);
        public static float2x4 operator *(float lhs, float2x4 rhs);
        public static float2x4 operator +(float2x4 lhs, float2x4 rhs);
        public static float2x4 operator +(float2x4 lhs, float rhs);
        public static float2x4 operator +(float lhs, float2x4 rhs);
        public static float2x4 operator -(float2x4 lhs, float2x4 rhs);
        public static float2x4 operator -(float2x4 lhs, float rhs);
        public static float2x4 operator -(float lhs, float2x4 rhs);
        public static float2x4 operator /(float2x4 lhs, float2x4 rhs);
        public static float2x4 operator /(float2x4 lhs, float rhs);
        public static float2x4 operator /(float lhs, float2x4 rhs);
        public static float2x4 operator %(float2x4 lhs, float2x4 rhs);
        public static float2x4 operator %(float2x4 lhs, float rhs);
        public static float2x4 operator %(float lhs, float2x4 rhs);
        public static float2x4 operator ++(float2x4 val);
        public static float2x4 operator --(float2x4 val);
        public static bool2x4 operator <(float2x4 lhs, float2x4 rhs);
        public static bool2x4 operator <(float2x4 lhs, float rhs);
        public static bool2x4 operator <(float lhs, float2x4 rhs);
        public static bool2x4 operator <=(float2x4 lhs, float2x4 rhs);
        public static bool2x4 operator <=(float2x4 lhs, float rhs);
        public static bool2x4 operator <=(float lhs, float2x4 rhs);
        public static bool2x4 operator >(float2x4 lhs, float2x4 rhs);
        public static bool2x4 operator >(float2x4 lhs, float rhs);
        public static bool2x4 operator >(float lhs, float2x4 rhs);
        public static bool2x4 operator >=(float2x4 lhs, float2x4 rhs);
        public static bool2x4 operator >=(float2x4 lhs, float rhs);
        public static bool2x4 operator >=(float lhs, float2x4 rhs);
        public static float2x4 operator -(float2x4 val);
        public static float2x4 operator +(float2x4 val);
        public static bool2x4 operator ==(float2x4 lhs, float2x4 rhs);
        public static bool2x4 operator ==(float2x4 lhs, float rhs);
        public static bool2x4 operator ==(float lhs, float2x4 rhs);
        public static bool2x4 operator !=(float2x4 lhs, float2x4 rhs);
        public static bool2x4 operator !=(float2x4 lhs, float rhs);
        public static bool2x4 operator !=(float lhs, float2x4 rhs);

        public static implicit operator float2x4(float v);
        public static explicit operator float2x4(bool v);
        public static explicit operator float2x4(bool2x4 v);
        public static implicit operator float2x4(int v);
        public static implicit operator float2x4(int2x4 v);
        public static implicit operator float2x4(uint v);
        public static implicit operator float2x4(uint2x4 v);
        public static explicit operator float2x4(double v);
        public static explicit operator float2x4(double2x4 v);
    }
}
