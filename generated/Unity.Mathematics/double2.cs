#region Unity.Mathematics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Mathematics.dll
#endregion

using System;
using System.ComponentModel;
using System.Reflection;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
    [DefaultMember("Item")]
    [Il2CppEagerStaticClassConstruction]
    public struct double2 : IEquatable<double2>, IFormattable
    {
        public double x;
        public double y;
        public static readonly double2 zero;

        public double2(double x, double y);
        public double2(double2 xy);
        public double2(double v);
        public double2(bool v);
        public double2(bool2 v);
        public double2(int v);
        public double2(int2 v);
        public double2(uint v);
        public double2(uint2 v);
        public double2(half v);
        public double2(half2 v);
        public double2(float v);
        public double2(float2 v);

        public double this[int index] { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 xx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 xy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 yx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 yy { get; }

        public bool Equals(double2 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static double2 operator *(double2 lhs, double2 rhs);
        public static double2 operator *(double2 lhs, double rhs);
        public static double2 operator *(double lhs, double2 rhs);
        public static double2 operator +(double2 lhs, double2 rhs);
        public static double2 operator +(double2 lhs, double rhs);
        public static double2 operator +(double lhs, double2 rhs);
        public static double2 operator -(double2 lhs, double2 rhs);
        public static double2 operator -(double2 lhs, double rhs);
        public static double2 operator -(double lhs, double2 rhs);
        public static double2 operator /(double2 lhs, double2 rhs);
        public static double2 operator /(double2 lhs, double rhs);
        public static double2 operator /(double lhs, double2 rhs);
        public static double2 operator %(double2 lhs, double2 rhs);
        public static double2 operator %(double2 lhs, double rhs);
        public static double2 operator %(double lhs, double2 rhs);
        public static double2 operator ++(double2 val);
        public static double2 operator --(double2 val);
        public static bool2 operator <(double2 lhs, double2 rhs);
        public static bool2 operator <(double2 lhs, double rhs);
        public static bool2 operator <(double lhs, double2 rhs);
        public static bool2 operator <=(double2 lhs, double2 rhs);
        public static bool2 operator <=(double2 lhs, double rhs);
        public static bool2 operator <=(double lhs, double2 rhs);
        public static bool2 operator >(double2 lhs, double2 rhs);
        public static bool2 operator >(double2 lhs, double rhs);
        public static bool2 operator >(double lhs, double2 rhs);
        public static bool2 operator >=(double2 lhs, double2 rhs);
        public static bool2 operator >=(double2 lhs, double rhs);
        public static bool2 operator >=(double lhs, double2 rhs);
        public static double2 operator -(double2 val);
        public static double2 operator +(double2 val);
        public static bool2 operator ==(double2 lhs, double2 rhs);
        public static bool2 operator ==(double2 lhs, double rhs);
        public static bool2 operator ==(double lhs, double2 rhs);
        public static bool2 operator !=(double2 lhs, double2 rhs);
        public static bool2 operator !=(double2 lhs, double rhs);
        public static bool2 operator !=(double lhs, double2 rhs);

        public static implicit operator double2(double v);
        public static explicit operator double2(bool v);
        public static explicit operator double2(bool2 v);
        public static implicit operator double2(int v);
        public static implicit operator double2(int2 v);
        public static implicit operator double2(uint v);
        public static implicit operator double2(uint2 v);
        public static implicit operator double2(half v);
        public static implicit operator double2(half2 v);
        public static implicit operator double2(float v);
        public static implicit operator double2(float2 v);
    }
}
