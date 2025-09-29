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
    public struct int4 : IEquatable<int4>, IFormattable
    {

        public int x;
        public int y;
        public int z;
        public int w;
        public static readonly int4 zero;

        public int4(int x, int y, int z, int w);
        public int4(int x, int y, int2 zw);
        public int4(int x, int2 yz, int w);
        public int4(int x, int3 yzw);
        public int4(int2 xy, int z, int w);
        public int4(int2 xy, int2 zw);
        public int4(int3 xyz, int w);
        public int4(int4 xyzw);
        public int4(int v);
        public int4(bool v);
        public int4(bool4 v);
        public int4(uint v);
        public int4(uint4 v);
        public int4(float v);
        public int4(float4 v);
        public int4(double v);
        public int4(double4 v);

        public int this[int index] { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xywx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xywz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xwxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xwxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xwxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xwxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xwyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xwyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xwyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xwyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xwzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xwzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xwzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xwzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xwwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xwwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xwwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 xwww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxwz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yywx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yywz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzwx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 yzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 ywxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 ywxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 ywxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 ywxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 ywyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 ywyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 ywyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 ywyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 ywzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 ywzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 ywzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 ywzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 ywwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 ywwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 ywwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 ywww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zyxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zyzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zywx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zywz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zwxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zwxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zwxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zwxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zwyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zwyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zwyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zwyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zwzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zwzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zwzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zwzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zwwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zwwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zwwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 zwww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wxyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wxyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wxzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wxzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wxwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wxwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wyxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wyxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wyzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wyzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wywx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wywz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wzxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wzxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wzyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wzyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wzwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wzwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wwxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wwxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wwxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wwxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wwyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wwyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wwyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wwyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wwzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wwzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wwzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wwzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wwwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wwwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wwwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int4 wwww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xwz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 xww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 ywx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 ywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 ywz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 yww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zwx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 zww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 wxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 wxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 wxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 wxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 wyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 wyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 wyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 wyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 wzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 wzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 wzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 wzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 wwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 wwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 wwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int3 www { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 xx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 xy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 xz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 xw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 yx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 yy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 yz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 yw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 zx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 zy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 zz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 zw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 wx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 wy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 wz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int2 ww { get; }

        public bool Equals(int4 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static int4 operator *(int4 lhs, int4 rhs);
        public static int4 operator *(int4 lhs, int rhs);
        public static int4 operator *(int lhs, int4 rhs);
        public static int4 operator +(int4 lhs, int4 rhs);
        public static int4 operator +(int4 lhs, int rhs);
        public static int4 operator +(int lhs, int4 rhs);
        public static int4 operator -(int4 lhs, int4 rhs);
        public static int4 operator -(int4 lhs, int rhs);
        public static int4 operator -(int lhs, int4 rhs);
        public static int4 operator /(int4 lhs, int4 rhs);
        public static int4 operator /(int4 lhs, int rhs);
        public static int4 operator /(int lhs, int4 rhs);
        public static int4 operator %(int4 lhs, int4 rhs);
        public static int4 operator %(int4 lhs, int rhs);
        public static int4 operator %(int lhs, int4 rhs);
        public static int4 operator ++(int4 val);
        public static int4 operator --(int4 val);
        public static bool4 operator <(int4 lhs, int4 rhs);
        public static bool4 operator <(int4 lhs, int rhs);
        public static bool4 operator <(int lhs, int4 rhs);
        public static bool4 operator <=(int4 lhs, int4 rhs);
        public static bool4 operator <=(int4 lhs, int rhs);
        public static bool4 operator <=(int lhs, int4 rhs);
        public static bool4 operator >(int4 lhs, int4 rhs);
        public static bool4 operator >(int4 lhs, int rhs);
        public static bool4 operator >(int lhs, int4 rhs);
        public static bool4 operator >=(int4 lhs, int4 rhs);
        public static bool4 operator >=(int4 lhs, int rhs);
        public static bool4 operator >=(int lhs, int4 rhs);
        public static int4 operator -(int4 val);
        public static int4 operator +(int4 val);
        public static int4 operator <<(int4 x, int n);
        public static int4 operator >>(int4 x, int n);
        public static bool4 operator ==(int4 lhs, int4 rhs);
        public static bool4 operator ==(int4 lhs, int rhs);
        public static bool4 operator ==(int lhs, int4 rhs);
        public static bool4 operator !=(int4 lhs, int4 rhs);
        public static bool4 operator !=(int4 lhs, int rhs);
        public static bool4 operator !=(int lhs, int4 rhs);
        public static int4 operator ~(int4 val);
        public static int4 operator &(int4 lhs, int4 rhs);
        public static int4 operator &(int4 lhs, int rhs);
        public static int4 operator &(int lhs, int4 rhs);
        public static int4 operator |(int4 lhs, int4 rhs);
        public static int4 operator |(int4 lhs, int rhs);
        public static int4 operator |(int lhs, int4 rhs);
        public static int4 operator ^(int4 lhs, int4 rhs);
        public static int4 operator ^(int4 lhs, int rhs);
        public static int4 operator ^(int lhs, int4 rhs);

        public static implicit operator int4(int v);
        public static explicit operator int4(bool v);
        public static explicit operator int4(bool4 v);
        public static explicit operator int4(uint v);
        public static explicit operator int4(uint4 v);
        public static explicit operator int4(float v);
        public static explicit operator int4(float4 v);
        public static explicit operator int4(double v);
        public static explicit operator int4(double4 v);
    }
}
