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
    public struct double4x4 : IEquatable<double4x4>, IFormattable
    {
        public double4 c0;
        public double4 c1;
        public double4 c2;
        public double4 c3;
        public static readonly double4x4 identity;
        public static readonly double4x4 zero;

        public double4x4(double4 c0, double4 c1, double4 c2, double4 c3);
        public double4x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33);
        public double4x4(double v);
        public double4x4(bool v);
        public double4x4(bool4x4 v);
        public double4x4(int v);
        public double4x4(int4x4 v);
        public double4x4(uint v);
        public double4x4(uint4x4 v);
        public double4x4(float v);
        public double4x4(float4x4 v);

        public ref double4 this[int index] { get; }

        public bool Equals(double4x4 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static double4x4 operator *(double4x4 lhs, double4x4 rhs);
        public static double4x4 operator *(double4x4 lhs, double rhs);
        public static double4x4 operator *(double lhs, double4x4 rhs);
        public static double4x4 operator +(double4x4 lhs, double4x4 rhs);
        public static double4x4 operator +(double4x4 lhs, double rhs);
        public static double4x4 operator +(double lhs, double4x4 rhs);
        public static double4x4 operator -(double4x4 lhs, double4x4 rhs);
        public static double4x4 operator -(double4x4 lhs, double rhs);
        public static double4x4 operator -(double lhs, double4x4 rhs);
        public static double4x4 operator /(double4x4 lhs, double4x4 rhs);
        public static double4x4 operator /(double4x4 lhs, double rhs);
        public static double4x4 operator /(double lhs, double4x4 rhs);
        public static double4x4 operator %(double4x4 lhs, double4x4 rhs);
        public static double4x4 operator %(double4x4 lhs, double rhs);
        public static double4x4 operator %(double lhs, double4x4 rhs);
        public static double4x4 operator ++(double4x4 val);
        public static double4x4 operator --(double4x4 val);
        public static bool4x4 operator <(double4x4 lhs, double4x4 rhs);
        public static bool4x4 operator <(double4x4 lhs, double rhs);
        public static bool4x4 operator <(double lhs, double4x4 rhs);
        public static bool4x4 operator <=(double4x4 lhs, double4x4 rhs);
        public static bool4x4 operator <=(double4x4 lhs, double rhs);
        public static bool4x4 operator <=(double lhs, double4x4 rhs);
        public static bool4x4 operator >(double4x4 lhs, double4x4 rhs);
        public static bool4x4 operator >(double4x4 lhs, double rhs);
        public static bool4x4 operator >(double lhs, double4x4 rhs);
        public static bool4x4 operator >=(double4x4 lhs, double4x4 rhs);
        public static bool4x4 operator >=(double4x4 lhs, double rhs);
        public static bool4x4 operator >=(double lhs, double4x4 rhs);
        public static double4x4 operator -(double4x4 val);
        public static double4x4 operator +(double4x4 val);
        public static bool4x4 operator ==(double4x4 lhs, double4x4 rhs);
        public static bool4x4 operator ==(double4x4 lhs, double rhs);
        public static bool4x4 operator ==(double lhs, double4x4 rhs);
        public static bool4x4 operator !=(double4x4 lhs, double4x4 rhs);
        public static bool4x4 operator !=(double4x4 lhs, double rhs);
        public static bool4x4 operator !=(double lhs, double4x4 rhs);

        public static implicit operator double4x4(double v);
        public static explicit operator double4x4(bool v);
        public static explicit operator double4x4(bool4x4 v);
        public static implicit operator double4x4(int v);
        public static implicit operator double4x4(int4x4 v);
        public static implicit operator double4x4(uint v);
        public static implicit operator double4x4(uint4x4 v);
        public static implicit operator double4x4(float v);
        public static implicit operator double4x4(float4x4 v);
    }
}
