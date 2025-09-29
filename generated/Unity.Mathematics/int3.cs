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
    public struct int3 : IEquatable<int3>, IFormattable
    {

        public int x;
        public int y;
        public int z;
        public static readonly int3 zero;

        public int3(int x, int y, int z);
        public int3(int x, int2 yz);
        public int3(int2 xy, int z);
        public int3(int3 xyz);
        public int3(int v);
        public int3(bool v);
        public int3(bool3 v);
        public int3(uint v);
        public int3(uint3 v);
        public int3(float v);
        public int3(float3 v);
        public int3(double v);
        public int3(double3 v);

        public int this[int index] { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 xx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 xy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 xz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 yx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 yy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 yz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 zx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 zy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 zz { get; }

        public bool Equals(int3 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static int3 operator *(int3 lhs, int3 rhs);
        public static int3 operator *(int3 lhs, int rhs);
        public static int3 operator *(int lhs, int3 rhs);
        public static int3 operator +(int3 lhs, int3 rhs);
        public static int3 operator +(int3 lhs, int rhs);
        public static int3 operator +(int lhs, int3 rhs);
        public static int3 operator -(int3 lhs, int3 rhs);
        public static int3 operator -(int3 lhs, int rhs);
        public static int3 operator -(int lhs, int3 rhs);
        public static int3 operator /(int3 lhs, int3 rhs);
        public static int3 operator /(int3 lhs, int rhs);
        public static int3 operator /(int lhs, int3 rhs);
        public static int3 operator %(int3 lhs, int3 rhs);
        public static int3 operator %(int3 lhs, int rhs);
        public static int3 operator %(int lhs, int3 rhs);
        public static int3 operator ++(int3 val);
        public static int3 operator --(int3 val);
        public static bool3 operator <(int3 lhs, int3 rhs);
        public static bool3 operator <(int3 lhs, int rhs);
        public static bool3 operator <(int lhs, int3 rhs);
        public static bool3 operator <=(int3 lhs, int3 rhs);
        public static bool3 operator <=(int3 lhs, int rhs);
        public static bool3 operator <=(int lhs, int3 rhs);
        public static bool3 operator >(int3 lhs, int3 rhs);
        public static bool3 operator >(int3 lhs, int rhs);
        public static bool3 operator >(int lhs, int3 rhs);
        public static bool3 operator >=(int3 lhs, int3 rhs);
        public static bool3 operator >=(int3 lhs, int rhs);
        public static bool3 operator >=(int lhs, int3 rhs);
        public static int3 operator -(int3 val);
        public static int3 operator +(int3 val);
        public static int3 operator <<(int3 x, int n);
        public static int3 operator >>(int3 x, int n);
        public static bool3 operator ==(int3 lhs, int3 rhs);
        public static bool3 operator ==(int3 lhs, int rhs);
        public static bool3 operator ==(int lhs, int3 rhs);
        public static bool3 operator !=(int3 lhs, int3 rhs);
        public static bool3 operator !=(int3 lhs, int rhs);
        public static bool3 operator !=(int lhs, int3 rhs);
        public static int3 operator ~(int3 val);
        public static int3 operator &(int3 lhs, int3 rhs);
        public static int3 operator &(int3 lhs, int rhs);
        public static int3 operator &(int lhs, int3 rhs);
        public static int3 operator |(int3 lhs, int3 rhs);
        public static int3 operator |(int3 lhs, int rhs);
        public static int3 operator |(int lhs, int3 rhs);
        public static int3 operator ^(int3 lhs, int3 rhs);
        public static int3 operator ^(int3 lhs, int rhs);
        public static int3 operator ^(int lhs, int3 rhs);

        public static implicit operator int3(int v);
        public static explicit operator int3(bool v);
        public static explicit operator int3(bool3 v);
        public static explicit operator int3(uint v);
        public static explicit operator int3(uint3 v);
        public static explicit operator int3(float v);
        public static explicit operator int3(float3 v);
        public static explicit operator int3(double v);
        public static explicit operator int3(double3 v);
    }
}
