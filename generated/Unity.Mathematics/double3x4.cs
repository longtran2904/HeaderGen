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
    public struct double3x4 : IEquatable<double3x4>, IFormattable
    {

        public double3 c0;
        public double3 c1;
        public double3 c2;
        public double3 c3;
        public static readonly double3x4 zero;

        public double3x4(double3 c0, double3 c1, double3 c2, double3 c3);
        public double3x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23);
        public double3x4(double v);
        public double3x4(bool v);
        public double3x4(bool3x4 v);
        public double3x4(int v);
        public double3x4(int3x4 v);
        public double3x4(uint v);
        public double3x4(uint3x4 v);
        public double3x4(float v);
        public double3x4(float3x4 v);

        public ref double3 this[int index] { get; }

        public bool Equals(double3x4 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static double3x4 operator *(double3x4 lhs, double3x4 rhs);
        public static double3x4 operator *(double3x4 lhs, double rhs);
        public static double3x4 operator *(double lhs, double3x4 rhs);
        public static double3x4 operator +(double3x4 lhs, double3x4 rhs);
        public static double3x4 operator +(double3x4 lhs, double rhs);
        public static double3x4 operator +(double lhs, double3x4 rhs);
        public static double3x4 operator -(double3x4 lhs, double3x4 rhs);
        public static double3x4 operator -(double3x4 lhs, double rhs);
        public static double3x4 operator -(double lhs, double3x4 rhs);
        public static double3x4 operator /(double3x4 lhs, double3x4 rhs);
        public static double3x4 operator /(double3x4 lhs, double rhs);
        public static double3x4 operator /(double lhs, double3x4 rhs);
        public static double3x4 operator %(double3x4 lhs, double3x4 rhs);
        public static double3x4 operator %(double3x4 lhs, double rhs);
        public static double3x4 operator %(double lhs, double3x4 rhs);
        public static double3x4 operator ++(double3x4 val);
        public static double3x4 operator --(double3x4 val);
        public static bool3x4 operator <(double3x4 lhs, double3x4 rhs);
        public static bool3x4 operator <(double3x4 lhs, double rhs);
        public static bool3x4 operator <(double lhs, double3x4 rhs);
        public static bool3x4 operator <=(double3x4 lhs, double3x4 rhs);
        public static bool3x4 operator <=(double3x4 lhs, double rhs);
        public static bool3x4 operator <=(double lhs, double3x4 rhs);
        public static bool3x4 operator >(double3x4 lhs, double3x4 rhs);
        public static bool3x4 operator >(double3x4 lhs, double rhs);
        public static bool3x4 operator >(double lhs, double3x4 rhs);
        public static bool3x4 operator >=(double3x4 lhs, double3x4 rhs);
        public static bool3x4 operator >=(double3x4 lhs, double rhs);
        public static bool3x4 operator >=(double lhs, double3x4 rhs);
        public static double3x4 operator -(double3x4 val);
        public static double3x4 operator +(double3x4 val);
        public static bool3x4 operator ==(double3x4 lhs, double3x4 rhs);
        public static bool3x4 operator ==(double3x4 lhs, double rhs);
        public static bool3x4 operator ==(double lhs, double3x4 rhs);
        public static bool3x4 operator !=(double3x4 lhs, double3x4 rhs);
        public static bool3x4 operator !=(double3x4 lhs, double rhs);
        public static bool3x4 operator !=(double lhs, double3x4 rhs);

        public static implicit operator double3x4(double v);
        public static explicit operator double3x4(bool v);
        public static explicit operator double3x4(bool3x4 v);
        public static implicit operator double3x4(int v);
        public static implicit operator double3x4(int3x4 v);
        public static implicit operator double3x4(uint v);
        public static implicit operator double3x4(uint3x4 v);
        public static implicit operator double3x4(float v);
        public static implicit operator double3x4(float3x4 v);
    }
}
