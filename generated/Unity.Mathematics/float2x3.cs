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
    public struct float2x3 : IEquatable<float2x3>, IFormattable
    {
        public float2 c0;
        public float2 c1;
        public float2 c2;
        public static readonly float2x3 zero;

        public float2x3(float2 c0, float2 c1, float2 c2);
        public float2x3(float m00, float m01, float m02, float m10, float m11, float m12);
        public float2x3(float v);
        public float2x3(bool v);
        public float2x3(bool2x3 v);
        public float2x3(int v);
        public float2x3(int2x3 v);
        public float2x3(uint v);
        public float2x3(uint2x3 v);
        public float2x3(double v);
        public float2x3(double2x3 v);

        public ref float2 this[int index] { get; }

        public bool Equals(float2x3 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static float2x3 operator *(float2x3 lhs, float2x3 rhs);
        public static float2x3 operator *(float2x3 lhs, float rhs);
        public static float2x3 operator *(float lhs, float2x3 rhs);
        public static float2x3 operator +(float2x3 lhs, float2x3 rhs);
        public static float2x3 operator +(float2x3 lhs, float rhs);
        public static float2x3 operator +(float lhs, float2x3 rhs);
        public static float2x3 operator -(float2x3 lhs, float2x3 rhs);
        public static float2x3 operator -(float2x3 lhs, float rhs);
        public static float2x3 operator -(float lhs, float2x3 rhs);
        public static float2x3 operator /(float2x3 lhs, float2x3 rhs);
        public static float2x3 operator /(float2x3 lhs, float rhs);
        public static float2x3 operator /(float lhs, float2x3 rhs);
        public static float2x3 operator %(float2x3 lhs, float2x3 rhs);
        public static float2x3 operator %(float2x3 lhs, float rhs);
        public static float2x3 operator %(float lhs, float2x3 rhs);
        public static float2x3 operator ++(float2x3 val);
        public static float2x3 operator --(float2x3 val);
        public static bool2x3 operator <(float2x3 lhs, float2x3 rhs);
        public static bool2x3 operator <(float2x3 lhs, float rhs);
        public static bool2x3 operator <(float lhs, float2x3 rhs);
        public static bool2x3 operator <=(float2x3 lhs, float2x3 rhs);
        public static bool2x3 operator <=(float2x3 lhs, float rhs);
        public static bool2x3 operator <=(float lhs, float2x3 rhs);
        public static bool2x3 operator >(float2x3 lhs, float2x3 rhs);
        public static bool2x3 operator >(float2x3 lhs, float rhs);
        public static bool2x3 operator >(float lhs, float2x3 rhs);
        public static bool2x3 operator >=(float2x3 lhs, float2x3 rhs);
        public static bool2x3 operator >=(float2x3 lhs, float rhs);
        public static bool2x3 operator >=(float lhs, float2x3 rhs);
        public static float2x3 operator -(float2x3 val);
        public static float2x3 operator +(float2x3 val);
        public static bool2x3 operator ==(float2x3 lhs, float2x3 rhs);
        public static bool2x3 operator ==(float2x3 lhs, float rhs);
        public static bool2x3 operator ==(float lhs, float2x3 rhs);
        public static bool2x3 operator !=(float2x3 lhs, float2x3 rhs);
        public static bool2x3 operator !=(float2x3 lhs, float rhs);
        public static bool2x3 operator !=(float lhs, float2x3 rhs);

        public static implicit operator float2x3(float v);
        public static explicit operator float2x3(bool v);
        public static explicit operator float2x3(bool2x3 v);
        public static implicit operator float2x3(int v);
        public static implicit operator float2x3(int2x3 v);
        public static implicit operator float2x3(uint v);
        public static implicit operator float2x3(uint2x3 v);
        public static explicit operator float2x3(double v);
        public static explicit operator float2x3(double2x3 v);
    }
}
