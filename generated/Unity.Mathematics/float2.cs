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
    public struct float2 : IEquatable<float2>, IFormattable
    {
        public float x;
        public float y;
        public static readonly float2 zero;

        public float2(float x, float y);
        public float2(float2 xy);
        public float2(float v);
        public float2(bool v);
        public float2(bool2 v);
        public float2(int v);
        public float2(int2 v);
        public float2(uint v);
        public float2(uint2 v);
        public float2(half v);
        public float2(half2 v);
        public float2(double v);
        public float2(double2 v);

        public float this[int index] { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 xx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 xy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 yx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 yy { get; }

        public bool Equals(float2 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static float2 operator *(float2 lhs, float2 rhs);
        public static float2 operator *(float2 lhs, float rhs);
        public static float2 operator *(float lhs, float2 rhs);
        public static float2 operator +(float2 lhs, float2 rhs);
        public static float2 operator +(float2 lhs, float rhs);
        public static float2 operator +(float lhs, float2 rhs);
        public static float2 operator -(float2 lhs, float2 rhs);
        public static float2 operator -(float2 lhs, float rhs);
        public static float2 operator -(float lhs, float2 rhs);
        public static float2 operator /(float2 lhs, float2 rhs);
        public static float2 operator /(float2 lhs, float rhs);
        public static float2 operator /(float lhs, float2 rhs);
        public static float2 operator %(float2 lhs, float2 rhs);
        public static float2 operator %(float2 lhs, float rhs);
        public static float2 operator %(float lhs, float2 rhs);
        public static float2 operator ++(float2 val);
        public static float2 operator --(float2 val);
        public static bool2 operator <(float2 lhs, float2 rhs);
        public static bool2 operator <(float2 lhs, float rhs);
        public static bool2 operator <(float lhs, float2 rhs);
        public static bool2 operator <=(float2 lhs, float2 rhs);
        public static bool2 operator <=(float2 lhs, float rhs);
        public static bool2 operator <=(float lhs, float2 rhs);
        public static bool2 operator >(float2 lhs, float2 rhs);
        public static bool2 operator >(float2 lhs, float rhs);
        public static bool2 operator >(float lhs, float2 rhs);
        public static bool2 operator >=(float2 lhs, float2 rhs);
        public static bool2 operator >=(float2 lhs, float rhs);
        public static bool2 operator >=(float lhs, float2 rhs);
        public static float2 operator -(float2 val);
        public static float2 operator +(float2 val);
        public static bool2 operator ==(float2 lhs, float2 rhs);
        public static bool2 operator ==(float2 lhs, float rhs);
        public static bool2 operator ==(float lhs, float2 rhs);
        public static bool2 operator !=(float2 lhs, float2 rhs);
        public static bool2 operator !=(float2 lhs, float rhs);
        public static bool2 operator !=(float lhs, float2 rhs);

        public static implicit operator float2(float v);
        public static explicit operator float2(bool v);
        public static explicit operator float2(bool2 v);
        public static implicit operator float2(int v);
        public static implicit operator float2(int2 v);
        public static implicit operator float2(uint v);
        public static implicit operator float2(uint2 v);
        public static implicit operator float2(half v);
        public static implicit operator float2(half2 v);
        public static explicit operator float2(double v);
        public static explicit operator float2(double2 v);
        public static implicit operator Vector2(float2 v);
        public static implicit operator float2(Vector2 v);
    }
}
