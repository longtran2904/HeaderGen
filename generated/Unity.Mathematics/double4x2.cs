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
    public struct double4x2 : IEquatable<double4x2>, IFormattable
    {

        public double4 c0;
        public double4 c1;
        public static readonly double4x2 zero;

        public double4x2(double4 c0, double4 c1);
        public double4x2(double m00, double m01, double m10, double m11, double m20, double m21, double m30, double m31);
        public double4x2(double v);
        public double4x2(bool v);
        public double4x2(bool4x2 v);
        public double4x2(int v);
        public double4x2(int4x2 v);
        public double4x2(uint v);
        public double4x2(uint4x2 v);
        public double4x2(float v);
        public double4x2(float4x2 v);

        public ref double4 this[int index] { get; }

        public bool Equals(double4x2 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static double4x2 operator *(double4x2 lhs, double4x2 rhs);
        public static double4x2 operator *(double4x2 lhs, double rhs);
        public static double4x2 operator *(double lhs, double4x2 rhs);
        public static double4x2 operator +(double4x2 lhs, double4x2 rhs);
        public static double4x2 operator +(double4x2 lhs, double rhs);
        public static double4x2 operator +(double lhs, double4x2 rhs);
        public static double4x2 operator -(double4x2 lhs, double4x2 rhs);
        public static double4x2 operator -(double4x2 lhs, double rhs);
        public static double4x2 operator -(double lhs, double4x2 rhs);
        public static double4x2 operator /(double4x2 lhs, double4x2 rhs);
        public static double4x2 operator /(double4x2 lhs, double rhs);
        public static double4x2 operator /(double lhs, double4x2 rhs);
        public static double4x2 operator %(double4x2 lhs, double4x2 rhs);
        public static double4x2 operator %(double4x2 lhs, double rhs);
        public static double4x2 operator %(double lhs, double4x2 rhs);
        public static double4x2 operator ++(double4x2 val);
        public static double4x2 operator --(double4x2 val);
        public static bool4x2 operator <(double4x2 lhs, double4x2 rhs);
        public static bool4x2 operator <(double4x2 lhs, double rhs);
        public static bool4x2 operator <(double lhs, double4x2 rhs);
        public static bool4x2 operator <=(double4x2 lhs, double4x2 rhs);
        public static bool4x2 operator <=(double4x2 lhs, double rhs);
        public static bool4x2 operator <=(double lhs, double4x2 rhs);
        public static bool4x2 operator >(double4x2 lhs, double4x2 rhs);
        public static bool4x2 operator >(double4x2 lhs, double rhs);
        public static bool4x2 operator >(double lhs, double4x2 rhs);
        public static bool4x2 operator >=(double4x2 lhs, double4x2 rhs);
        public static bool4x2 operator >=(double4x2 lhs, double rhs);
        public static bool4x2 operator >=(double lhs, double4x2 rhs);
        public static double4x2 operator -(double4x2 val);
        public static double4x2 operator +(double4x2 val);
        public static bool4x2 operator ==(double4x2 lhs, double4x2 rhs);
        public static bool4x2 operator ==(double4x2 lhs, double rhs);
        public static bool4x2 operator ==(double lhs, double4x2 rhs);
        public static bool4x2 operator !=(double4x2 lhs, double4x2 rhs);
        public static bool4x2 operator !=(double4x2 lhs, double rhs);
        public static bool4x2 operator !=(double lhs, double4x2 rhs);

        public static implicit operator double4x2(double v);
        public static explicit operator double4x2(bool v);
        public static explicit operator double4x2(bool4x2 v);
        public static implicit operator double4x2(int v);
        public static implicit operator double4x2(int4x2 v);
        public static implicit operator double4x2(uint v);
        public static implicit operator double4x2(uint4x2 v);
        public static implicit operator double4x2(float v);
        public static implicit operator double4x2(float4x2 v);
    }
}
