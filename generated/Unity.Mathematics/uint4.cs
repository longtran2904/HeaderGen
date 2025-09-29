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
    public struct uint4 : IEquatable<uint4>, IFormattable
    {

        public uint x;
        public uint y;
        public uint z;
        public uint w;
        public static readonly uint4 zero;

        public uint4(uint x, uint y, uint z, uint w);
        public uint4(uint x, uint y, uint2 zw);
        public uint4(uint x, uint2 yz, uint w);
        public uint4(uint x, uint3 yzw);
        public uint4(uint2 xy, uint z, uint w);
        public uint4(uint2 xy, uint2 zw);
        public uint4(uint3 xyz, uint w);
        public uint4(uint4 xyzw);
        public uint4(uint v);
        public uint4(bool v);
        public uint4(bool4 v);
        public uint4(int v);
        public uint4(int4 v);
        public uint4(float v);
        public uint4(float4 v);
        public uint4(double v);
        public uint4(double4 v);

        public uint this[int index] { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xywx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xywz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xwxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xwxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xwxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xwxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xwyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xwyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xwyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xwyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xwzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xwzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xwzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xwzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xwwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xwwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xwwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 xwww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxwz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yywx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yywz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzwx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 yzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 ywxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 ywxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 ywxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 ywxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 ywyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 ywyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 ywyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 ywyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 ywzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 ywzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 ywzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 ywzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 ywwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 ywwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 ywwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 ywww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zyxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zyzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zywx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zywz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zwxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zwxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zwxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zwxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zwyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zwyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zwyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zwyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zwzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zwzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zwzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zwzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zwwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zwwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zwwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 zwww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wxyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wxyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wxzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wxzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wxwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wxwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wyxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wyxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wyzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wyzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wywx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wywz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wzxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wzxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wzyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wzyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wzwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wzwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wwxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wwxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wwxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wwxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wwyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wwyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wwyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wwyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wwzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wwzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wwzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wwzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wwwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wwwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wwwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint4 wwww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xwz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 xww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 ywx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 ywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 ywz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 yww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zwx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 zww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 wxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 wxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 wxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 wxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 wyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 wyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 wyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 wyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 wzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 wzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 wzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 wzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 wwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 wwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 wwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint3 www { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 xx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 xy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 xz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 xw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 yx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 yy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 yz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 yw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 zx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 zy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 zz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 zw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 wx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 wy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 wz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint2 ww { get; }

        public bool Equals(uint4 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static uint4 operator *(uint4 lhs, uint4 rhs);
        public static uint4 operator *(uint4 lhs, uint rhs);
        public static uint4 operator *(uint lhs, uint4 rhs);
        public static uint4 operator +(uint4 lhs, uint4 rhs);
        public static uint4 operator +(uint4 lhs, uint rhs);
        public static uint4 operator +(uint lhs, uint4 rhs);
        public static uint4 operator -(uint4 lhs, uint4 rhs);
        public static uint4 operator -(uint4 lhs, uint rhs);
        public static uint4 operator -(uint lhs, uint4 rhs);
        public static uint4 operator /(uint4 lhs, uint4 rhs);
        public static uint4 operator /(uint4 lhs, uint rhs);
        public static uint4 operator /(uint lhs, uint4 rhs);
        public static uint4 operator %(uint4 lhs, uint4 rhs);
        public static uint4 operator %(uint4 lhs, uint rhs);
        public static uint4 operator %(uint lhs, uint4 rhs);
        public static uint4 operator ++(uint4 val);
        public static uint4 operator --(uint4 val);
        public static bool4 operator <(uint4 lhs, uint4 rhs);
        public static bool4 operator <(uint4 lhs, uint rhs);
        public static bool4 operator <(uint lhs, uint4 rhs);
        public static bool4 operator <=(uint4 lhs, uint4 rhs);
        public static bool4 operator <=(uint4 lhs, uint rhs);
        public static bool4 operator <=(uint lhs, uint4 rhs);
        public static bool4 operator >(uint4 lhs, uint4 rhs);
        public static bool4 operator >(uint4 lhs, uint rhs);
        public static bool4 operator >(uint lhs, uint4 rhs);
        public static bool4 operator >=(uint4 lhs, uint4 rhs);
        public static bool4 operator >=(uint4 lhs, uint rhs);
        public static bool4 operator >=(uint lhs, uint4 rhs);
        public static uint4 operator -(uint4 val);
        public static uint4 operator +(uint4 val);
        public static uint4 operator <<(uint4 x, int n);
        public static uint4 operator >>(uint4 x, int n);
        public static bool4 operator ==(uint4 lhs, uint4 rhs);
        public static bool4 operator ==(uint4 lhs, uint rhs);
        public static bool4 operator ==(uint lhs, uint4 rhs);
        public static bool4 operator !=(uint4 lhs, uint4 rhs);
        public static bool4 operator !=(uint4 lhs, uint rhs);
        public static bool4 operator !=(uint lhs, uint4 rhs);
        public static uint4 operator ~(uint4 val);
        public static uint4 operator &(uint4 lhs, uint4 rhs);
        public static uint4 operator &(uint4 lhs, uint rhs);
        public static uint4 operator &(uint lhs, uint4 rhs);
        public static uint4 operator |(uint4 lhs, uint4 rhs);
        public static uint4 operator |(uint4 lhs, uint rhs);
        public static uint4 operator |(uint lhs, uint4 rhs);
        public static uint4 operator ^(uint4 lhs, uint4 rhs);
        public static uint4 operator ^(uint4 lhs, uint rhs);
        public static uint4 operator ^(uint lhs, uint4 rhs);

        public static implicit operator uint4(uint v);
        public static explicit operator uint4(bool v);
        public static explicit operator uint4(bool4 v);
        public static explicit operator uint4(int v);
        public static explicit operator uint4(int4 v);
        public static explicit operator uint4(float v);
        public static explicit operator uint4(float4 v);
        public static explicit operator uint4(double v);
        public static explicit operator uint4(double4 v);
    }
}
