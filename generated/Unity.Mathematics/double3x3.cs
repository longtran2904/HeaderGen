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
    public struct double3x3 : IEquatable<double3x3>, IFormattable
    {
        public double3 c0;
        public double3 c1;
        public double3 c2;
        public static readonly double3x3 identity;
        public static readonly double3x3 zero;

        public double3x3(double3 c0, double3 c1, double3 c2);
        public double3x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22);
        public double3x3(double v);
        public double3x3(bool v);
        public double3x3(bool3x3 v);
        public double3x3(int v);
        public double3x3(int3x3 v);
        public double3x3(uint v);
        public double3x3(uint3x3 v);
        public double3x3(float v);
        public double3x3(float3x3 v);

        public ref double3 this[int index] { get; }

        public bool Equals(double3x3 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static double3x3 operator *(double3x3 lhs, double3x3 rhs);
        public static double3x3 operator *(double3x3 lhs, double rhs);
        public static double3x3 operator *(double lhs, double3x3 rhs);
        public static double3x3 operator +(double3x3 lhs, double3x3 rhs);
        public static double3x3 operator +(double3x3 lhs, double rhs);
        public static double3x3 operator +(double lhs, double3x3 rhs);
        public static double3x3 operator -(double3x3 lhs, double3x3 rhs);
        public static double3x3 operator -(double3x3 lhs, double rhs);
        public static double3x3 operator -(double lhs, double3x3 rhs);
        public static double3x3 operator /(double3x3 lhs, double3x3 rhs);
        public static double3x3 operator /(double3x3 lhs, double rhs);
        public static double3x3 operator /(double lhs, double3x3 rhs);
        public static double3x3 operator %(double3x3 lhs, double3x3 rhs);
        public static double3x3 operator %(double3x3 lhs, double rhs);
        public static double3x3 operator %(double lhs, double3x3 rhs);
        public static double3x3 operator ++(double3x3 val);
        public static double3x3 operator --(double3x3 val);
        public static bool3x3 operator <(double3x3 lhs, double3x3 rhs);
        public static bool3x3 operator <(double3x3 lhs, double rhs);
        public static bool3x3 operator <(double lhs, double3x3 rhs);
        public static bool3x3 operator <=(double3x3 lhs, double3x3 rhs);
        public static bool3x3 operator <=(double3x3 lhs, double rhs);
        public static bool3x3 operator <=(double lhs, double3x3 rhs);
        public static bool3x3 operator >(double3x3 lhs, double3x3 rhs);
        public static bool3x3 operator >(double3x3 lhs, double rhs);
        public static bool3x3 operator >(double lhs, double3x3 rhs);
        public static bool3x3 operator >=(double3x3 lhs, double3x3 rhs);
        public static bool3x3 operator >=(double3x3 lhs, double rhs);
        public static bool3x3 operator >=(double lhs, double3x3 rhs);
        public static double3x3 operator -(double3x3 val);
        public static double3x3 operator +(double3x3 val);
        public static bool3x3 operator ==(double3x3 lhs, double3x3 rhs);
        public static bool3x3 operator ==(double3x3 lhs, double rhs);
        public static bool3x3 operator ==(double lhs, double3x3 rhs);
        public static bool3x3 operator !=(double3x3 lhs, double3x3 rhs);
        public static bool3x3 operator !=(double3x3 lhs, double rhs);
        public static bool3x3 operator !=(double lhs, double3x3 rhs);

        public static implicit operator double3x3(double v);
        public static explicit operator double3x3(bool v);
        public static explicit operator double3x3(bool3x3 v);
        public static implicit operator double3x3(int v);
        public static implicit operator double3x3(int3x3 v);
        public static implicit operator double3x3(uint v);
        public static implicit operator double3x3(uint3x3 v);
        public static implicit operator double3x3(float v);
        public static implicit operator double3x3(float3x3 v);
    }
}
