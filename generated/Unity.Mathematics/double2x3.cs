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
    public struct double2x3 : IEquatable<double2x3>, IFormattable
    {

        public double2 c0;
        public double2 c1;
        public double2 c2;
        public static readonly double2x3 zero;

        public double2x3(double2 c0, double2 c1, double2 c2);
        public double2x3(double m00, double m01, double m02, double m10, double m11, double m12);
        public double2x3(double v);
        public double2x3(bool v);
        public double2x3(bool2x3 v);
        public double2x3(int v);
        public double2x3(int2x3 v);
        public double2x3(uint v);
        public double2x3(uint2x3 v);
        public double2x3(float v);
        public double2x3(float2x3 v);

        public ref double2 this[int index] { get; }

        public bool Equals(double2x3 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static double2x3 operator *(double2x3 lhs, double2x3 rhs);
        public static double2x3 operator *(double2x3 lhs, double rhs);
        public static double2x3 operator *(double lhs, double2x3 rhs);
        public static double2x3 operator +(double2x3 lhs, double2x3 rhs);
        public static double2x3 operator +(double2x3 lhs, double rhs);
        public static double2x3 operator +(double lhs, double2x3 rhs);
        public static double2x3 operator -(double2x3 lhs, double2x3 rhs);
        public static double2x3 operator -(double2x3 lhs, double rhs);
        public static double2x3 operator -(double lhs, double2x3 rhs);
        public static double2x3 operator /(double2x3 lhs, double2x3 rhs);
        public static double2x3 operator /(double2x3 lhs, double rhs);
        public static double2x3 operator /(double lhs, double2x3 rhs);
        public static double2x3 operator %(double2x3 lhs, double2x3 rhs);
        public static double2x3 operator %(double2x3 lhs, double rhs);
        public static double2x3 operator %(double lhs, double2x3 rhs);
        public static double2x3 operator ++(double2x3 val);
        public static double2x3 operator --(double2x3 val);
        public static bool2x3 operator <(double2x3 lhs, double2x3 rhs);
        public static bool2x3 operator <(double2x3 lhs, double rhs);
        public static bool2x3 operator <(double lhs, double2x3 rhs);
        public static bool2x3 operator <=(double2x3 lhs, double2x3 rhs);
        public static bool2x3 operator <=(double2x3 lhs, double rhs);
        public static bool2x3 operator <=(double lhs, double2x3 rhs);
        public static bool2x3 operator >(double2x3 lhs, double2x3 rhs);
        public static bool2x3 operator >(double2x3 lhs, double rhs);
        public static bool2x3 operator >(double lhs, double2x3 rhs);
        public static bool2x3 operator >=(double2x3 lhs, double2x3 rhs);
        public static bool2x3 operator >=(double2x3 lhs, double rhs);
        public static bool2x3 operator >=(double lhs, double2x3 rhs);
        public static double2x3 operator -(double2x3 val);
        public static double2x3 operator +(double2x3 val);
        public static bool2x3 operator ==(double2x3 lhs, double2x3 rhs);
        public static bool2x3 operator ==(double2x3 lhs, double rhs);
        public static bool2x3 operator ==(double lhs, double2x3 rhs);
        public static bool2x3 operator !=(double2x3 lhs, double2x3 rhs);
        public static bool2x3 operator !=(double2x3 lhs, double rhs);
        public static bool2x3 operator !=(double lhs, double2x3 rhs);

        public static implicit operator double2x3(double v);
        public static explicit operator double2x3(bool v);
        public static explicit operator double2x3(bool2x3 v);
        public static implicit operator double2x3(int v);
        public static implicit operator double2x3(int2x3 v);
        public static implicit operator double2x3(uint v);
        public static implicit operator double2x3(uint2x3 v);
        public static implicit operator double2x3(float v);
        public static implicit operator double2x3(float2x3 v);
    }
}
