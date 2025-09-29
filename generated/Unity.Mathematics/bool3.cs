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
    public struct bool3 : IEquatable<bool3>
    {

        public bool x;
        public bool y;
        public bool z;

        public bool3(bool x, bool y, bool z);
        public bool3(bool x, bool2 yz);
        public bool3(bool2 xy, bool z);
        public bool3(bool3 xyz);
        public bool3(bool v);

        public bool this[int index] { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 xx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 xy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 xz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 yx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 yy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 yz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 zx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 zy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 zz { get; }

        public bool Equals(bool3 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();

        public static bool3 operator ==(bool3 lhs, bool3 rhs);
        public static bool3 operator ==(bool3 lhs, bool rhs);
        public static bool3 operator ==(bool lhs, bool3 rhs);
        public static bool3 operator !=(bool3 lhs, bool3 rhs);
        public static bool3 operator !=(bool3 lhs, bool rhs);
        public static bool3 operator !=(bool lhs, bool3 rhs);
        public static bool3 operator !(bool3 val);
        public static bool3 operator &(bool3 lhs, bool3 rhs);
        public static bool3 operator &(bool3 lhs, bool rhs);
        public static bool3 operator &(bool lhs, bool3 rhs);
        public static bool3 operator |(bool3 lhs, bool3 rhs);
        public static bool3 operator |(bool3 lhs, bool rhs);
        public static bool3 operator |(bool lhs, bool3 rhs);
        public static bool3 operator ^(bool3 lhs, bool3 rhs);
        public static bool3 operator ^(bool3 lhs, bool rhs);
        public static bool3 operator ^(bool lhs, bool3 rhs);

        public static implicit operator bool3(bool v);
    }
}
