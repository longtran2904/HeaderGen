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
    public struct float2x2 : IEquatable<float2x2>, IFormattable
    {

        public float2 c0;
        public float2 c1;
        public static readonly float2x2 identity;
        public static readonly float2x2 zero;

        public float2x2(float2 c0, float2 c1);
        public float2x2(float m00, float m01, float m10, float m11);
        public float2x2(float v);
        public float2x2(bool v);
        public float2x2(bool2x2 v);
        public float2x2(int v);
        public float2x2(int2x2 v);
        public float2x2(uint v);
        public float2x2(uint2x2 v);
        public float2x2(double v);
        public float2x2(double2x2 v);

        public ref float2 this[int index] { get; }

        public bool Equals(float2x2 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);
        public static float2x2 Rotate(float angle);
        public static float2x2 Scale(float s);
        public static float2x2 Scale(float x, float y);
        public static float2x2 Scale(float2 v);

        public static float2x2 operator *(float2x2 lhs, float2x2 rhs);
        public static float2x2 operator *(float2x2 lhs, float rhs);
        public static float2x2 operator *(float lhs, float2x2 rhs);
        public static float2x2 operator +(float2x2 lhs, float2x2 rhs);
        public static float2x2 operator +(float2x2 lhs, float rhs);
        public static float2x2 operator +(float lhs, float2x2 rhs);
        public static float2x2 operator -(float2x2 lhs, float2x2 rhs);
        public static float2x2 operator -(float2x2 lhs, float rhs);
        public static float2x2 operator -(float lhs, float2x2 rhs);
        public static float2x2 operator /(float2x2 lhs, float2x2 rhs);
        public static float2x2 operator /(float2x2 lhs, float rhs);
        public static float2x2 operator /(float lhs, float2x2 rhs);
        public static float2x2 operator %(float2x2 lhs, float2x2 rhs);
        public static float2x2 operator %(float2x2 lhs, float rhs);
        public static float2x2 operator %(float lhs, float2x2 rhs);
        public static float2x2 operator ++(float2x2 val);
        public static float2x2 operator --(float2x2 val);
        public static bool2x2 operator <(float2x2 lhs, float2x2 rhs);
        public static bool2x2 operator <(float2x2 lhs, float rhs);
        public static bool2x2 operator <(float lhs, float2x2 rhs);
        public static bool2x2 operator <=(float2x2 lhs, float2x2 rhs);
        public static bool2x2 operator <=(float2x2 lhs, float rhs);
        public static bool2x2 operator <=(float lhs, float2x2 rhs);
        public static bool2x2 operator >(float2x2 lhs, float2x2 rhs);
        public static bool2x2 operator >(float2x2 lhs, float rhs);
        public static bool2x2 operator >(float lhs, float2x2 rhs);
        public static bool2x2 operator >=(float2x2 lhs, float2x2 rhs);
        public static bool2x2 operator >=(float2x2 lhs, float rhs);
        public static bool2x2 operator >=(float lhs, float2x2 rhs);
        public static float2x2 operator -(float2x2 val);
        public static float2x2 operator +(float2x2 val);
        public static bool2x2 operator ==(float2x2 lhs, float2x2 rhs);
        public static bool2x2 operator ==(float2x2 lhs, float rhs);
        public static bool2x2 operator ==(float lhs, float2x2 rhs);
        public static bool2x2 operator !=(float2x2 lhs, float2x2 rhs);
        public static bool2x2 operator !=(float2x2 lhs, float rhs);
        public static bool2x2 operator !=(float lhs, float2x2 rhs);

        public static implicit operator float2x2(float v);
        public static explicit operator float2x2(bool v);
        public static explicit operator float2x2(bool2x2 v);
        public static implicit operator float2x2(int v);
        public static implicit operator float2x2(int2x2 v);
        public static implicit operator float2x2(uint v);
        public static implicit operator float2x2(uint2x2 v);
        public static explicit operator float2x2(double v);
        public static explicit operator float2x2(double2x2 v);
    }
}
