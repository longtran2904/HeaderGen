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
    public struct double2x2 : IEquatable<double2x2>, IFormattable
    {

        public double2 c0;
        public double2 c1;
        public static readonly double2x2 identity;
        public static readonly double2x2 zero;

        public double2x2(double2 c0, double2 c1);
        public double2x2(double m00, double m01, double m10, double m11);
        public double2x2(double v);
        public double2x2(bool v);
        public double2x2(bool2x2 v);
        public double2x2(int v);
        public double2x2(int2x2 v);
        public double2x2(uint v);
        public double2x2(uint2x2 v);
        public double2x2(float v);
        public double2x2(float2x2 v);

        public ref double2 this[int index] { get; }

        public bool Equals(double2x2 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static double2x2 operator *(double2x2 lhs, double2x2 rhs);
        public static double2x2 operator *(double2x2 lhs, double rhs);
        public static double2x2 operator *(double lhs, double2x2 rhs);
        public static double2x2 operator +(double2x2 lhs, double2x2 rhs);
        public static double2x2 operator +(double2x2 lhs, double rhs);
        public static double2x2 operator +(double lhs, double2x2 rhs);
        public static double2x2 operator -(double2x2 lhs, double2x2 rhs);
        public static double2x2 operator -(double2x2 lhs, double rhs);
        public static double2x2 operator -(double lhs, double2x2 rhs);
        public static double2x2 operator /(double2x2 lhs, double2x2 rhs);
        public static double2x2 operator /(double2x2 lhs, double rhs);
        public static double2x2 operator /(double lhs, double2x2 rhs);
        public static double2x2 operator %(double2x2 lhs, double2x2 rhs);
        public static double2x2 operator %(double2x2 lhs, double rhs);
        public static double2x2 operator %(double lhs, double2x2 rhs);
        public static double2x2 operator ++(double2x2 val);
        public static double2x2 operator --(double2x2 val);
        public static bool2x2 operator <(double2x2 lhs, double2x2 rhs);
        public static bool2x2 operator <(double2x2 lhs, double rhs);
        public static bool2x2 operator <(double lhs, double2x2 rhs);
        public static bool2x2 operator <=(double2x2 lhs, double2x2 rhs);
        public static bool2x2 operator <=(double2x2 lhs, double rhs);
        public static bool2x2 operator <=(double lhs, double2x2 rhs);
        public static bool2x2 operator >(double2x2 lhs, double2x2 rhs);
        public static bool2x2 operator >(double2x2 lhs, double rhs);
        public static bool2x2 operator >(double lhs, double2x2 rhs);
        public static bool2x2 operator >=(double2x2 lhs, double2x2 rhs);
        public static bool2x2 operator >=(double2x2 lhs, double rhs);
        public static bool2x2 operator >=(double lhs, double2x2 rhs);
        public static double2x2 operator -(double2x2 val);
        public static double2x2 operator +(double2x2 val);
        public static bool2x2 operator ==(double2x2 lhs, double2x2 rhs);
        public static bool2x2 operator ==(double2x2 lhs, double rhs);
        public static bool2x2 operator ==(double lhs, double2x2 rhs);
        public static bool2x2 operator !=(double2x2 lhs, double2x2 rhs);
        public static bool2x2 operator !=(double2x2 lhs, double rhs);
        public static bool2x2 operator !=(double lhs, double2x2 rhs);

        public static implicit operator double2x2(double v);
        public static explicit operator double2x2(bool v);
        public static explicit operator double2x2(bool2x2 v);
        public static implicit operator double2x2(int v);
        public static implicit operator double2x2(int2x2 v);
        public static implicit operator double2x2(uint v);
        public static implicit operator double2x2(uint2x2 v);
        public static implicit operator double2x2(float v);
        public static implicit operator double2x2(float2x2 v);
    }
}
