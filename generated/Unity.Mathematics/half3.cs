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
    public struct half3 : IEquatable<half3>, IFormattable
    {
        public half x;
        public half y;
        public half z;
        public static readonly half3 zero;

        public half3(half x, half y, half z);
        public half3(half x, half2 yz);
        public half3(half2 xy, half z);
        public half3(half3 xyz);
        public half3(half v);
        public half3(float v);
        public half3(float3 v);
        public half3(double v);
        public half3(double3 v);

        public half this[int index] { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 xx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 xy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 xz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 yx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 yy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 yz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 zx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 zy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 zz { get; }

        public bool Equals(half3 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static bool3 operator ==(half3 lhs, half3 rhs);
        public static bool3 operator ==(half3 lhs, half rhs);
        public static bool3 operator ==(half lhs, half3 rhs);
        public static bool3 operator !=(half3 lhs, half3 rhs);
        public static bool3 operator !=(half3 lhs, half rhs);
        public static bool3 operator !=(half lhs, half3 rhs);

        public static implicit operator half3(half v);
        public static explicit operator half3(float v);
        public static explicit operator half3(float3 v);
        public static explicit operator half3(double v);
        public static explicit operator half3(double3 v);
    }
}
