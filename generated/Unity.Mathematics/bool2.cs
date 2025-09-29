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
    public struct bool2 : IEquatable<bool2>
    {

        public bool x;
        public bool y;

        public bool2(bool x, bool y);
        public bool2(bool2 xy);
        public bool2(bool v);

        public bool this[int index] { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 xx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 xy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 yx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 yy { get; }

        public bool Equals(bool2 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();

        public static bool2 operator ==(bool2 lhs, bool2 rhs);
        public static bool2 operator ==(bool2 lhs, bool rhs);
        public static bool2 operator ==(bool lhs, bool2 rhs);
        public static bool2 operator !=(bool2 lhs, bool2 rhs);
        public static bool2 operator !=(bool2 lhs, bool rhs);
        public static bool2 operator !=(bool lhs, bool2 rhs);
        public static bool2 operator !(bool2 val);
        public static bool2 operator &(bool2 lhs, bool2 rhs);
        public static bool2 operator &(bool2 lhs, bool rhs);
        public static bool2 operator &(bool lhs, bool2 rhs);
        public static bool2 operator |(bool2 lhs, bool2 rhs);
        public static bool2 operator |(bool2 lhs, bool rhs);
        public static bool2 operator |(bool lhs, bool2 rhs);
        public static bool2 operator ^(bool2 lhs, bool2 rhs);
        public static bool2 operator ^(bool2 lhs, bool rhs);
        public static bool2 operator ^(bool lhs, bool2 rhs);

        public static implicit operator bool2(bool v);
    }
}
