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
    public struct half2 : IEquatable<half2>, IFormattable
    {
        public half x;
        public half y;
        public static readonly half2 zero;

        public half2(half x, half y);
        public half2(half2 xy);
        public half2(half v);
        public half2(float v);
        public half2(float2 v);
        public half2(double v);
        public half2(double2 v);

        public half this[int index] { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 xx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 xy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 yx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 yy { get; }

        public bool Equals(half2 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static bool2 operator ==(half2 lhs, half2 rhs);
        public static bool2 operator ==(half2 lhs, half rhs);
        public static bool2 operator ==(half lhs, half2 rhs);
        public static bool2 operator !=(half2 lhs, half2 rhs);
        public static bool2 operator !=(half2 lhs, half rhs);
        public static bool2 operator !=(half lhs, half2 rhs);

        public static implicit operator half2(half v);
        public static explicit operator half2(float v);
        public static explicit operator half2(float2 v);
        public static explicit operator half2(double v);
        public static explicit operator half2(double2 v);
    }
}
