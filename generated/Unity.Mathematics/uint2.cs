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
    public struct uint2 : IEquatable<uint2>, IFormattable
    {

        public uint x;
        public uint y;
        public static readonly uint2 zero;

        public uint2(uint x, uint y);
        public uint2(uint2 xy);
        public uint2(uint v);
        public uint2(bool v);
        public uint2(bool2 v);
        public uint2(int v);
        public uint2(int2 v);
        public uint2(float v);
        public uint2(float2 v);
        public uint2(double v);
        public uint2(double2 v);

        public uint this[int index] { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 xx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 xy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 yx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 yy { get; }

        public bool Equals(uint2 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static uint2 operator *(uint2 lhs, uint2 rhs);
        public static uint2 operator *(uint2 lhs, uint rhs);
        public static uint2 operator *(uint lhs, uint2 rhs);
        public static uint2 operator +(uint2 lhs, uint2 rhs);
        public static uint2 operator +(uint2 lhs, uint rhs);
        public static uint2 operator +(uint lhs, uint2 rhs);
        public static uint2 operator -(uint2 lhs, uint2 rhs);
        public static uint2 operator -(uint2 lhs, uint rhs);
        public static uint2 operator -(uint lhs, uint2 rhs);
        public static uint2 operator /(uint2 lhs, uint2 rhs);
        public static uint2 operator /(uint2 lhs, uint rhs);
        public static uint2 operator /(uint lhs, uint2 rhs);
        public static uint2 operator %(uint2 lhs, uint2 rhs);
        public static uint2 operator %(uint2 lhs, uint rhs);
        public static uint2 operator %(uint lhs, uint2 rhs);
        public static uint2 operator ++(uint2 val);
        public static uint2 operator --(uint2 val);
        public static bool2 operator <(uint2 lhs, uint2 rhs);
        public static bool2 operator <(uint2 lhs, uint rhs);
        public static bool2 operator <(uint lhs, uint2 rhs);
        public static bool2 operator <=(uint2 lhs, uint2 rhs);
        public static bool2 operator <=(uint2 lhs, uint rhs);
        public static bool2 operator <=(uint lhs, uint2 rhs);
        public static bool2 operator >(uint2 lhs, uint2 rhs);
        public static bool2 operator >(uint2 lhs, uint rhs);
        public static bool2 operator >(uint lhs, uint2 rhs);
        public static bool2 operator >=(uint2 lhs, uint2 rhs);
        public static bool2 operator >=(uint2 lhs, uint rhs);
        public static bool2 operator >=(uint lhs, uint2 rhs);
        public static uint2 operator -(uint2 val);
        public static uint2 operator +(uint2 val);
        public static uint2 operator <<(uint2 x, int n);
        public static uint2 operator >>(uint2 x, int n);
        public static bool2 operator ==(uint2 lhs, uint2 rhs);
        public static bool2 operator ==(uint2 lhs, uint rhs);
        public static bool2 operator ==(uint lhs, uint2 rhs);
        public static bool2 operator !=(uint2 lhs, uint2 rhs);
        public static bool2 operator !=(uint2 lhs, uint rhs);
        public static bool2 operator !=(uint lhs, uint2 rhs);
        public static uint2 operator ~(uint2 val);
        public static uint2 operator &(uint2 lhs, uint2 rhs);
        public static uint2 operator &(uint2 lhs, uint rhs);
        public static uint2 operator &(uint lhs, uint2 rhs);
        public static uint2 operator |(uint2 lhs, uint2 rhs);
        public static uint2 operator |(uint2 lhs, uint rhs);
        public static uint2 operator |(uint lhs, uint2 rhs);
        public static uint2 operator ^(uint2 lhs, uint2 rhs);
        public static uint2 operator ^(uint2 lhs, uint rhs);
        public static uint2 operator ^(uint lhs, uint2 rhs);

        public static implicit operator uint2(uint v);
        public static explicit operator uint2(bool v);
        public static explicit operator uint2(bool2 v);
        public static explicit operator uint2(int v);
        public static explicit operator uint2(int2 v);
        public static explicit operator uint2(float v);
        public static explicit operator uint2(float2 v);
        public static explicit operator uint2(double v);
        public static explicit operator uint2(double2 v);
    }
}
