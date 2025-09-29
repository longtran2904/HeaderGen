#region Unity.Mathematics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Mathematics.dll
#endregion

using System;
using System.ComponentModel;
using System.Reflection;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
    [DefaultMember("Item")]
    [Il2CppEagerStaticClassConstruction]
    public struct float3 : IEquatable<float3>, IFormattable
    {
        public float x;
        public float y;
        public float z;
        public static readonly float3 zero;

        public float3(float x, float y, float z);
        public float3(float x, float2 yz);
        public float3(float2 xy, float z);
        public float3(float3 xyz);
        public float3(float v);
        public float3(bool v);
        public float3(bool3 v);
        public float3(int v);
        public float3(int3 v);
        public float3(uint v);
        public float3(uint3 v);
        public float3(half v);
        public float3(half3 v);
        public float3(double v);
        public float3(double3 v);

        public float this[int index] { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 xx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 xy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 xz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 yx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 yy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 yz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 zx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 zy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 zz { get; }

        public bool Equals(float3 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static float3 operator *(float3 lhs, float3 rhs);
        public static float3 operator *(float3 lhs, float rhs);
        public static float3 operator *(float lhs, float3 rhs);
        public static float3 operator +(float3 lhs, float3 rhs);
        public static float3 operator +(float3 lhs, float rhs);
        public static float3 operator +(float lhs, float3 rhs);
        public static float3 operator -(float3 lhs, float3 rhs);
        public static float3 operator -(float3 lhs, float rhs);
        public static float3 operator -(float lhs, float3 rhs);
        public static float3 operator /(float3 lhs, float3 rhs);
        public static float3 operator /(float3 lhs, float rhs);
        public static float3 operator /(float lhs, float3 rhs);
        public static float3 operator %(float3 lhs, float3 rhs);
        public static float3 operator %(float3 lhs, float rhs);
        public static float3 operator %(float lhs, float3 rhs);
        public static float3 operator ++(float3 val);
        public static float3 operator --(float3 val);
        public static bool3 operator <(float3 lhs, float3 rhs);
        public static bool3 operator <(float3 lhs, float rhs);
        public static bool3 operator <(float lhs, float3 rhs);
        public static bool3 operator <=(float3 lhs, float3 rhs);
        public static bool3 operator <=(float3 lhs, float rhs);
        public static bool3 operator <=(float lhs, float3 rhs);
        public static bool3 operator >(float3 lhs, float3 rhs);
        public static bool3 operator >(float3 lhs, float rhs);
        public static bool3 operator >(float lhs, float3 rhs);
        public static bool3 operator >=(float3 lhs, float3 rhs);
        public static bool3 operator >=(float3 lhs, float rhs);
        public static bool3 operator >=(float lhs, float3 rhs);
        public static float3 operator -(float3 val);
        public static float3 operator +(float3 val);
        public static bool3 operator ==(float3 lhs, float3 rhs);
        public static bool3 operator ==(float3 lhs, float rhs);
        public static bool3 operator ==(float lhs, float3 rhs);
        public static bool3 operator !=(float3 lhs, float3 rhs);
        public static bool3 operator !=(float3 lhs, float rhs);
        public static bool3 operator !=(float lhs, float3 rhs);

        public static implicit operator float3(float v);
        public static explicit operator float3(bool v);
        public static explicit operator float3(bool3 v);
        public static implicit operator float3(int v);
        public static implicit operator float3(int3 v);
        public static implicit operator float3(uint v);
        public static implicit operator float3(uint3 v);
        public static implicit operator float3(half v);
        public static implicit operator float3(half3 v);
        public static explicit operator float3(double v);
        public static explicit operator float3(double3 v);
        public static implicit operator Vector3(float3 v);
        public static implicit operator float3(Vector3 v);
    }
}
