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
    public struct int2 : IEquatable<int2>, IFormattable
    {
        public int x;
        public int y;
        public static readonly int2 zero;

        public int2(int x, int y);
        public int2(int2 xy);
        public int2(int v);
        public int2(bool v);
        public int2(bool2 v);
        public int2(uint v);
        public int2(uint2 v);
        public int2(float v);
        public int2(float2 v);
        public int2(double v);
        public int2(double2 v);

        public int this[int index] { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 xx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 xy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 yx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 yy { get; }

        public bool Equals(int2 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static int2 operator *(int2 lhs, int2 rhs);
        public static int2 operator *(int2 lhs, int rhs);
        public static int2 operator *(int lhs, int2 rhs);
        public static int2 operator +(int2 lhs, int2 rhs);
        public static int2 operator +(int2 lhs, int rhs);
        public static int2 operator +(int lhs, int2 rhs);
        public static int2 operator -(int2 lhs, int2 rhs);
        public static int2 operator -(int2 lhs, int rhs);
        public static int2 operator -(int lhs, int2 rhs);
        public static int2 operator /(int2 lhs, int2 rhs);
        public static int2 operator /(int2 lhs, int rhs);
        public static int2 operator /(int lhs, int2 rhs);
        public static int2 operator %(int2 lhs, int2 rhs);
        public static int2 operator %(int2 lhs, int rhs);
        public static int2 operator %(int lhs, int2 rhs);
        public static int2 operator ++(int2 val);
        public static int2 operator --(int2 val);
        public static bool2 operator <(int2 lhs, int2 rhs);
        public static bool2 operator <(int2 lhs, int rhs);
        public static bool2 operator <(int lhs, int2 rhs);
        public static bool2 operator <=(int2 lhs, int2 rhs);
        public static bool2 operator <=(int2 lhs, int rhs);
        public static bool2 operator <=(int lhs, int2 rhs);
        public static bool2 operator >(int2 lhs, int2 rhs);
        public static bool2 operator >(int2 lhs, int rhs);
        public static bool2 operator >(int lhs, int2 rhs);
        public static bool2 operator >=(int2 lhs, int2 rhs);
        public static bool2 operator >=(int2 lhs, int rhs);
        public static bool2 operator >=(int lhs, int2 rhs);
        public static int2 operator -(int2 val);
        public static int2 operator +(int2 val);
        public static int2 operator <<(int2 x, int n);
        public static int2 operator >>(int2 x, int n);
        public static bool2 operator ==(int2 lhs, int2 rhs);
        public static bool2 operator ==(int2 lhs, int rhs);
        public static bool2 operator ==(int lhs, int2 rhs);
        public static bool2 operator !=(int2 lhs, int2 rhs);
        public static bool2 operator !=(int2 lhs, int rhs);
        public static bool2 operator !=(int lhs, int2 rhs);
        public static int2 operator ~(int2 val);
        public static int2 operator &(int2 lhs, int2 rhs);
        public static int2 operator &(int2 lhs, int rhs);
        public static int2 operator &(int lhs, int2 rhs);
        public static int2 operator |(int2 lhs, int2 rhs);
        public static int2 operator |(int2 lhs, int rhs);
        public static int2 operator |(int lhs, int2 rhs);
        public static int2 operator ^(int2 lhs, int2 rhs);
        public static int2 operator ^(int2 lhs, int rhs);
        public static int2 operator ^(int lhs, int2 rhs);

        public static implicit operator int2(int v);
        public static explicit operator int2(bool v);
        public static explicit operator int2(bool2 v);
        public static explicit operator int2(uint v);
        public static explicit operator int2(uint2 v);
        public static explicit operator int2(float v);
        public static explicit operator int2(float2 v);
        public static explicit operator int2(double v);
        public static explicit operator int2(double2 v);
    }
}
