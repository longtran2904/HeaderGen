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
    public struct bool4 : IEquatable<bool4>
    {
        public bool x;
        public bool y;
        public bool z;
        public bool w;

        public bool4(bool x, bool y, bool z, bool w);
        public bool4(bool x, bool y, bool2 zw);
        public bool4(bool x, bool2 yz, bool w);
        public bool4(bool x, bool3 yzw);
        public bool4(bool2 xy, bool z, bool w);
        public bool4(bool2 xy, bool2 zw);
        public bool4(bool3 xyz, bool w);
        public bool4(bool4 xyzw);
        public bool4(bool v);

        public bool this[int index] { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xywx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xywz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xwxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xwxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xwxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xwxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xwyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xwyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xwyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xwyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xwzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xwzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xwzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xwzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xwwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xwwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xwwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 xwww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxwz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yywx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yywz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzwx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 yzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 ywxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 ywxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 ywxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 ywxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 ywyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 ywyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 ywyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 ywyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 ywzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 ywzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 ywzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 ywzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 ywwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 ywwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 ywwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 ywww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zyxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zyzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zywx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zywz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zwxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zwxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zwxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zwxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zwyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zwyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zwyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zwyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zwzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zwzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zwzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zwzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zwwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zwwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zwwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 zwww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wxyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wxyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wxzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wxzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wxwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wxwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wyxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wyxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wyzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wyzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wywx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wywz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wzxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wzxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wzyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wzyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wzwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wzwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wwxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wwxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wwxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wwxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wwyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wwyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wwyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wwyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wwzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wwzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wwzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wwzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wwwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wwwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wwwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool4 wwww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xwz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 xww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 ywx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 ywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 ywz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 yww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zwx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 zww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 wxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 wxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 wxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 wxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 wyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 wyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 wyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 wyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 wzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 wzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 wzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 wzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 wwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 wwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 wwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool3 www { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 xx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 xy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 xz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 xw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 yx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 yy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 yz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 yw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 zx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 zy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 zz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 zw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 wx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 wy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 wz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool2 ww { get; }

        public bool Equals(bool4 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();

        public static bool4 operator ==(bool4 lhs, bool4 rhs);
        public static bool4 operator ==(bool4 lhs, bool rhs);
        public static bool4 operator ==(bool lhs, bool4 rhs);
        public static bool4 operator !=(bool4 lhs, bool4 rhs);
        public static bool4 operator !=(bool4 lhs, bool rhs);
        public static bool4 operator !=(bool lhs, bool4 rhs);
        public static bool4 operator !(bool4 val);
        public static bool4 operator &(bool4 lhs, bool4 rhs);
        public static bool4 operator &(bool4 lhs, bool rhs);
        public static bool4 operator &(bool lhs, bool4 rhs);
        public static bool4 operator |(bool4 lhs, bool4 rhs);
        public static bool4 operator |(bool4 lhs, bool rhs);
        public static bool4 operator |(bool lhs, bool4 rhs);
        public static bool4 operator ^(bool4 lhs, bool4 rhs);
        public static bool4 operator ^(bool4 lhs, bool rhs);
        public static bool4 operator ^(bool lhs, bool4 rhs);

        public static implicit operator bool4(bool v);
    }
}
