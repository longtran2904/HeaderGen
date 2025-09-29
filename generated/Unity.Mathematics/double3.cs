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
    public struct double3 : IEquatable<double3>, IFormattable
    {
        public double x;
        public double y;
        public double z;
        public static readonly double3 zero;

        public double3(double x, double y, double z);
        public double3(double x, double2 yz);
        public double3(double2 xy, double z);
        public double3(double3 xyz);
        public double3(double v);
        public double3(bool v);
        public double3(bool3 v);
        public double3(int v);
        public double3(int3 v);
        public double3(uint v);
        public double3(uint3 v);
        public double3(half v);
        public double3(half3 v);
        public double3(float v);
        public double3(float3 v);

        public double this[int index] { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 xx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 xy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 xz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 yx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 yy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 yz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 zx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 zy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 zz { get; }

        public bool Equals(double3 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static double3 operator *(double3 lhs, double3 rhs);
        public static double3 operator *(double3 lhs, double rhs);
        public static double3 operator *(double lhs, double3 rhs);
        public static double3 operator +(double3 lhs, double3 rhs);
        public static double3 operator +(double3 lhs, double rhs);
        public static double3 operator +(double lhs, double3 rhs);
        public static double3 operator -(double3 lhs, double3 rhs);
        public static double3 operator -(double3 lhs, double rhs);
        public static double3 operator -(double lhs, double3 rhs);
        public static double3 operator /(double3 lhs, double3 rhs);
        public static double3 operator /(double3 lhs, double rhs);
        public static double3 operator /(double lhs, double3 rhs);
        public static double3 operator %(double3 lhs, double3 rhs);
        public static double3 operator %(double3 lhs, double rhs);
        public static double3 operator %(double lhs, double3 rhs);
        public static double3 operator ++(double3 val);
        public static double3 operator --(double3 val);
        public static bool3 operator <(double3 lhs, double3 rhs);
        public static bool3 operator <(double3 lhs, double rhs);
        public static bool3 operator <(double lhs, double3 rhs);
        public static bool3 operator <=(double3 lhs, double3 rhs);
        public static bool3 operator <=(double3 lhs, double rhs);
        public static bool3 operator <=(double lhs, double3 rhs);
        public static bool3 operator >(double3 lhs, double3 rhs);
        public static bool3 operator >(double3 lhs, double rhs);
        public static bool3 operator >(double lhs, double3 rhs);
        public static bool3 operator >=(double3 lhs, double3 rhs);
        public static bool3 operator >=(double3 lhs, double rhs);
        public static bool3 operator >=(double lhs, double3 rhs);
        public static double3 operator -(double3 val);
        public static double3 operator +(double3 val);
        public static bool3 operator ==(double3 lhs, double3 rhs);
        public static bool3 operator ==(double3 lhs, double rhs);
        public static bool3 operator ==(double lhs, double3 rhs);
        public static bool3 operator !=(double3 lhs, double3 rhs);
        public static bool3 operator !=(double3 lhs, double rhs);
        public static bool3 operator !=(double lhs, double3 rhs);

        public static implicit operator double3(double v);
        public static explicit operator double3(bool v);
        public static explicit operator double3(bool3 v);
        public static implicit operator double3(int v);
        public static implicit operator double3(int3 v);
        public static implicit operator double3(uint v);
        public static implicit operator double3(uint3 v);
        public static implicit operator double3(half v);
        public static implicit operator double3(half3 v);
        public static implicit operator double3(float v);
        public static implicit operator double3(float3 v);
    }
}
