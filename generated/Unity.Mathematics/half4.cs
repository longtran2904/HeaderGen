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
    public struct half4 : IEquatable<half4>, IFormattable
    {
        public half x;
        public half y;
        public half z;
        public half w;
        public static readonly half4 zero;

        public half4(half x, half y, half z, half w);
        public half4(half x, half y, half2 zw);
        public half4(half x, half2 yz, half w);
        public half4(half x, half3 yzw);
        public half4(half2 xy, half z, half w);
        public half4(half2 xy, half2 zw);
        public half4(half3 xyz, half w);
        public half4(half4 xyzw);
        public half4(half v);
        public half4(float v);
        public half4(float4 v);
        public half4(double v);
        public half4(double4 v);

        public half this[int index] { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xywx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xywz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xwxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xwxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xwxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xwxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xwyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xwyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xwyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xwyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xwzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xwzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xwzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xwzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xwwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xwwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xwwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 xwww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxwz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yywx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yywz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzwx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 yzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 ywxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 ywxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 ywxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 ywxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 ywyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 ywyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 ywyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 ywyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 ywzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 ywzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 ywzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 ywzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 ywwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 ywwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 ywwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 ywww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zyxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zyzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zywx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zywz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zwxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zwxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zwxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zwxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zwyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zwyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zwyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zwyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zwzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zwzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zwzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zwzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zwwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zwwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zwwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 zwww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wxyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wxyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wxzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wxzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wxwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wxwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wyxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wyxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wyzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wyzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wywx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wywz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wzxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wzxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wzyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wzyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wzwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wzwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wwxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wwxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wwxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wwxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wwyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wwyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wwyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wwyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wwzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wwzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wwzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wwzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wwwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wwwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wwwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half4 wwww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xwz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 xww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 ywx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 ywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 ywz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 yww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zwx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 zww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 wxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 wxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 wxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 wxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 wyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 wyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 wyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 wyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 wzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 wzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 wzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 wzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 wwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 wwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 wwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half3 www { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 xx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 xy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 xz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 xw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 yx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 yy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 yz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 yw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 zx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 zy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 zz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 zw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 wx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 wy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 wz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public half2 ww { get; }

        public bool Equals(half4 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static bool4 operator ==(half4 lhs, half4 rhs);
        public static bool4 operator ==(half4 lhs, half rhs);
        public static bool4 operator ==(half lhs, half4 rhs);
        public static bool4 operator !=(half4 lhs, half4 rhs);
        public static bool4 operator !=(half4 lhs, half rhs);
        public static bool4 operator !=(half lhs, half4 rhs);

        public static implicit operator half4(half v);
        public static explicit operator half4(float v);
        public static explicit operator half4(float4 v);
        public static explicit operator half4(double v);
        public static explicit operator half4(double4 v);
    }
}
