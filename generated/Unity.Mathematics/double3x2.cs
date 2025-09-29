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
    public struct double3x2 : IEquatable<double3x2>, IFormattable
    {

        public double3 c0;
        public double3 c1;
        public static readonly double3x2 zero;

        public double3x2(double3 c0, double3 c1);
        public double3x2(double m00, double m01, double m10, double m11, double m20, double m21);
        public double3x2(double v);
        public double3x2(bool v);
        public double3x2(bool3x2 v);
        public double3x2(int v);
        public double3x2(int3x2 v);
        public double3x2(uint v);
        public double3x2(uint3x2 v);
        public double3x2(float v);
        public double3x2(float3x2 v);

        public ref double3 this[int index] { get; }

        public bool Equals(double3x2 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static double3x2 operator *(double3x2 lhs, double3x2 rhs);
        public static double3x2 operator *(double3x2 lhs, double rhs);
        public static double3x2 operator *(double lhs, double3x2 rhs);
        public static double3x2 operator +(double3x2 lhs, double3x2 rhs);
        public static double3x2 operator +(double3x2 lhs, double rhs);
        public static double3x2 operator +(double lhs, double3x2 rhs);
        public static double3x2 operator -(double3x2 lhs, double3x2 rhs);
        public static double3x2 operator -(double3x2 lhs, double rhs);
        public static double3x2 operator -(double lhs, double3x2 rhs);
        public static double3x2 operator /(double3x2 lhs, double3x2 rhs);
        public static double3x2 operator /(double3x2 lhs, double rhs);
        public static double3x2 operator /(double lhs, double3x2 rhs);
        public static double3x2 operator %(double3x2 lhs, double3x2 rhs);
        public static double3x2 operator %(double3x2 lhs, double rhs);
        public static double3x2 operator %(double lhs, double3x2 rhs);
        public static double3x2 operator ++(double3x2 val);
        public static double3x2 operator --(double3x2 val);
        public static bool3x2 operator <(double3x2 lhs, double3x2 rhs);
        public static bool3x2 operator <(double3x2 lhs, double rhs);
        public static bool3x2 operator <(double lhs, double3x2 rhs);
        public static bool3x2 operator <=(double3x2 lhs, double3x2 rhs);
        public static bool3x2 operator <=(double3x2 lhs, double rhs);
        public static bool3x2 operator <=(double lhs, double3x2 rhs);
        public static bool3x2 operator >(double3x2 lhs, double3x2 rhs);
        public static bool3x2 operator >(double3x2 lhs, double rhs);
        public static bool3x2 operator >(double lhs, double3x2 rhs);
        public static bool3x2 operator >=(double3x2 lhs, double3x2 rhs);
        public static bool3x2 operator >=(double3x2 lhs, double rhs);
        public static bool3x2 operator >=(double lhs, double3x2 rhs);
        public static double3x2 operator -(double3x2 val);
        public static double3x2 operator +(double3x2 val);
        public static bool3x2 operator ==(double3x2 lhs, double3x2 rhs);
        public static bool3x2 operator ==(double3x2 lhs, double rhs);
        public static bool3x2 operator ==(double lhs, double3x2 rhs);
        public static bool3x2 operator !=(double3x2 lhs, double3x2 rhs);
        public static bool3x2 operator !=(double3x2 lhs, double rhs);
        public static bool3x2 operator !=(double lhs, double3x2 rhs);

        public static implicit operator double3x2(double v);
        public static explicit operator double3x2(bool v);
        public static explicit operator double3x2(bool3x2 v);
        public static implicit operator double3x2(int v);
        public static implicit operator double3x2(int3x2 v);
        public static implicit operator double3x2(uint v);
        public static implicit operator double3x2(uint3x2 v);
        public static implicit operator double3x2(float v);
        public static implicit operator double3x2(float3x2 v);
    }
}
