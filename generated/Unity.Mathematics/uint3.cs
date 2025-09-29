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
    public struct uint3 : IEquatable<uint3>, IFormattable
    {

        public uint x;
        public uint y;
        public uint z;
        public static readonly uint3 zero;

        public uint3(uint x, uint y, uint z);
        public uint3(uint x, uint2 yz);
        public uint3(uint2 xy, uint z);
        public uint3(uint3 xyz);
        public uint3(uint v);
        public uint3(bool v);
        public uint3(bool3 v);
        public uint3(int v);
        public uint3(int3 v);
        public uint3(float v);
        public uint3(float3 v);
        public uint3(double v);
        public uint3(double3 v);

        public uint this[int index] { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 xx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 xy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 xz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 yx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 yy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 yz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 zx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 zy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 zz { get; }

        public bool Equals(uint3 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static uint3 operator *(uint3 lhs, uint3 rhs);
        public static uint3 operator *(uint3 lhs, uint rhs);
        public static uint3 operator *(uint lhs, uint3 rhs);
        public static uint3 operator +(uint3 lhs, uint3 rhs);
        public static uint3 operator +(uint3 lhs, uint rhs);
        public static uint3 operator +(uint lhs, uint3 rhs);
        public static uint3 operator -(uint3 lhs, uint3 rhs);
        public static uint3 operator -(uint3 lhs, uint rhs);
        public static uint3 operator -(uint lhs, uint3 rhs);
        public static uint3 operator /(uint3 lhs, uint3 rhs);
        public static uint3 operator /(uint3 lhs, uint rhs);
        public static uint3 operator /(uint lhs, uint3 rhs);
        public static uint3 operator %(uint3 lhs, uint3 rhs);
        public static uint3 operator %(uint3 lhs, uint rhs);
        public static uint3 operator %(uint lhs, uint3 rhs);
        public static uint3 operator ++(uint3 val);
        public static uint3 operator --(uint3 val);
        public static bool3 operator <(uint3 lhs, uint3 rhs);
        public static bool3 operator <(uint3 lhs, uint rhs);
        public static bool3 operator <(uint lhs, uint3 rhs);
        public static bool3 operator <=(uint3 lhs, uint3 rhs);
        public static bool3 operator <=(uint3 lhs, uint rhs);
        public static bool3 operator <=(uint lhs, uint3 rhs);
        public static bool3 operator >(uint3 lhs, uint3 rhs);
        public static bool3 operator >(uint3 lhs, uint rhs);
        public static bool3 operator >(uint lhs, uint3 rhs);
        public static bool3 operator >=(uint3 lhs, uint3 rhs);
        public static bool3 operator >=(uint3 lhs, uint rhs);
        public static bool3 operator >=(uint lhs, uint3 rhs);
        public static uint3 operator -(uint3 val);
        public static uint3 operator +(uint3 val);
        public static uint3 operator <<(uint3 x, int n);
        public static uint3 operator >>(uint3 x, int n);
        public static bool3 operator ==(uint3 lhs, uint3 rhs);
        public static bool3 operator ==(uint3 lhs, uint rhs);
        public static bool3 operator ==(uint lhs, uint3 rhs);
        public static bool3 operator !=(uint3 lhs, uint3 rhs);
        public static bool3 operator !=(uint3 lhs, uint rhs);
        public static bool3 operator !=(uint lhs, uint3 rhs);
        public static uint3 operator ~(uint3 val);
        public static uint3 operator &(uint3 lhs, uint3 rhs);
        public static uint3 operator &(uint3 lhs, uint rhs);
        public static uint3 operator &(uint lhs, uint3 rhs);
        public static uint3 operator |(uint3 lhs, uint3 rhs);
        public static uint3 operator |(uint3 lhs, uint rhs);
        public static uint3 operator |(uint lhs, uint3 rhs);
        public static uint3 operator ^(uint3 lhs, uint3 rhs);
        public static uint3 operator ^(uint3 lhs, uint rhs);
        public static uint3 operator ^(uint lhs, uint3 rhs);

        public static implicit operator uint3(uint v);
        public static explicit operator uint3(bool v);
        public static explicit operator uint3(bool3 v);
        public static explicit operator uint3(int v);
        public static explicit operator uint3(int3 v);
        public static explicit operator uint3(float v);
        public static explicit operator uint3(float3 v);
        public static explicit operator uint3(double v);
        public static explicit operator uint3(double3 v);
    }
}
