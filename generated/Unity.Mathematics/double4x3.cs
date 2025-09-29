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
    public struct double4x3 : IEquatable<double4x3>, IFormattable
    {

        public double4 c0;
        public double4 c1;
        public double4 c2;
        public static readonly double4x3 zero;

        public double4x3(double4 c0, double4 c1, double4 c2);
        public double4x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22, double m30, double m31, double m32);
        public double4x3(double v);
        public double4x3(bool v);
        public double4x3(bool4x3 v);
        public double4x3(int v);
        public double4x3(int4x3 v);
        public double4x3(uint v);
        public double4x3(uint4x3 v);
        public double4x3(float v);
        public double4x3(float4x3 v);

        public ref double4 this[int index] { get; }

        public bool Equals(double4x3 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static double4x3 operator *(double4x3 lhs, double4x3 rhs);
        public static double4x3 operator *(double4x3 lhs, double rhs);
        public static double4x3 operator *(double lhs, double4x3 rhs);
        public static double4x3 operator +(double4x3 lhs, double4x3 rhs);
        public static double4x3 operator +(double4x3 lhs, double rhs);
        public static double4x3 operator +(double lhs, double4x3 rhs);
        public static double4x3 operator -(double4x3 lhs, double4x3 rhs);
        public static double4x3 operator -(double4x3 lhs, double rhs);
        public static double4x3 operator -(double lhs, double4x3 rhs);
        public static double4x3 operator /(double4x3 lhs, double4x3 rhs);
        public static double4x3 operator /(double4x3 lhs, double rhs);
        public static double4x3 operator /(double lhs, double4x3 rhs);
        public static double4x3 operator %(double4x3 lhs, double4x3 rhs);
        public static double4x3 operator %(double4x3 lhs, double rhs);
        public static double4x3 operator %(double lhs, double4x3 rhs);
        public static double4x3 operator ++(double4x3 val);
        public static double4x3 operator --(double4x3 val);
        public static bool4x3 operator <(double4x3 lhs, double4x3 rhs);
        public static bool4x3 operator <(double4x3 lhs, double rhs);
        public static bool4x3 operator <(double lhs, double4x3 rhs);
        public static bool4x3 operator <=(double4x3 lhs, double4x3 rhs);
        public static bool4x3 operator <=(double4x3 lhs, double rhs);
        public static bool4x3 operator <=(double lhs, double4x3 rhs);
        public static bool4x3 operator >(double4x3 lhs, double4x3 rhs);
        public static bool4x3 operator >(double4x3 lhs, double rhs);
        public static bool4x3 operator >(double lhs, double4x3 rhs);
        public static bool4x3 operator >=(double4x3 lhs, double4x3 rhs);
        public static bool4x3 operator >=(double4x3 lhs, double rhs);
        public static bool4x3 operator >=(double lhs, double4x3 rhs);
        public static double4x3 operator -(double4x3 val);
        public static double4x3 operator +(double4x3 val);
        public static bool4x3 operator ==(double4x3 lhs, double4x3 rhs);
        public static bool4x3 operator ==(double4x3 lhs, double rhs);
        public static bool4x3 operator ==(double lhs, double4x3 rhs);
        public static bool4x3 operator !=(double4x3 lhs, double4x3 rhs);
        public static bool4x3 operator !=(double4x3 lhs, double rhs);
        public static bool4x3 operator !=(double lhs, double4x3 rhs);

        public static implicit operator double4x3(double v);
        public static explicit operator double4x3(bool v);
        public static explicit operator double4x3(bool4x3 v);
        public static implicit operator double4x3(int v);
        public static implicit operator double4x3(int4x3 v);
        public static implicit operator double4x3(uint v);
        public static implicit operator double4x3(uint4x3 v);
        public static implicit operator double4x3(float v);
        public static implicit operator double4x3(float4x3 v);
    }
}
