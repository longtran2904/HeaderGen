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
    public struct double2x4 : IEquatable<double2x4>, IFormattable
    {
        public double2 c0;
        public double2 c1;
        public double2 c2;
        public double2 c3;
        public static readonly double2x4 zero;

        public double2x4(double2 c0, double2 c1, double2 c2, double2 c3);
        public double2x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13);
        public double2x4(double v);
        public double2x4(bool v);
        public double2x4(bool2x4 v);
        public double2x4(int v);
        public double2x4(int2x4 v);
        public double2x4(uint v);
        public double2x4(uint2x4 v);
        public double2x4(float v);
        public double2x4(float2x4 v);

        public ref double2 this[int index] { get; }

        public bool Equals(double2x4 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static double2x4 operator *(double2x4 lhs, double2x4 rhs);
        public static double2x4 operator *(double2x4 lhs, double rhs);
        public static double2x4 operator *(double lhs, double2x4 rhs);
        public static double2x4 operator +(double2x4 lhs, double2x4 rhs);
        public static double2x4 operator +(double2x4 lhs, double rhs);
        public static double2x4 operator +(double lhs, double2x4 rhs);
        public static double2x4 operator -(double2x4 lhs, double2x4 rhs);
        public static double2x4 operator -(double2x4 lhs, double rhs);
        public static double2x4 operator -(double lhs, double2x4 rhs);
        public static double2x4 operator /(double2x4 lhs, double2x4 rhs);
        public static double2x4 operator /(double2x4 lhs, double rhs);
        public static double2x4 operator /(double lhs, double2x4 rhs);
        public static double2x4 operator %(double2x4 lhs, double2x4 rhs);
        public static double2x4 operator %(double2x4 lhs, double rhs);
        public static double2x4 operator %(double lhs, double2x4 rhs);
        public static double2x4 operator ++(double2x4 val);
        public static double2x4 operator --(double2x4 val);
        public static bool2x4 operator <(double2x4 lhs, double2x4 rhs);
        public static bool2x4 operator <(double2x4 lhs, double rhs);
        public static bool2x4 operator <(double lhs, double2x4 rhs);
        public static bool2x4 operator <=(double2x4 lhs, double2x4 rhs);
        public static bool2x4 operator <=(double2x4 lhs, double rhs);
        public static bool2x4 operator <=(double lhs, double2x4 rhs);
        public static bool2x4 operator >(double2x4 lhs, double2x4 rhs);
        public static bool2x4 operator >(double2x4 lhs, double rhs);
        public static bool2x4 operator >(double lhs, double2x4 rhs);
        public static bool2x4 operator >=(double2x4 lhs, double2x4 rhs);
        public static bool2x4 operator >=(double2x4 lhs, double rhs);
        public static bool2x4 operator >=(double lhs, double2x4 rhs);
        public static double2x4 operator -(double2x4 val);
        public static double2x4 operator +(double2x4 val);
        public static bool2x4 operator ==(double2x4 lhs, double2x4 rhs);
        public static bool2x4 operator ==(double2x4 lhs, double rhs);
        public static bool2x4 operator ==(double lhs, double2x4 rhs);
        public static bool2x4 operator !=(double2x4 lhs, double2x4 rhs);
        public static bool2x4 operator !=(double2x4 lhs, double rhs);
        public static bool2x4 operator !=(double lhs, double2x4 rhs);

        public static implicit operator double2x4(double v);
        public static explicit operator double2x4(bool v);
        public static explicit operator double2x4(bool2x4 v);
        public static implicit operator double2x4(int v);
        public static implicit operator double2x4(int2x4 v);
        public static implicit operator double2x4(uint v);
        public static implicit operator double2x4(uint2x4 v);
        public static implicit operator double2x4(float v);
        public static implicit operator double2x4(float2x4 v);
    }
}
