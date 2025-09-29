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
    public struct double4 : IEquatable<double4>, IFormattable
    {

        public double x;
        public double y;
        public double z;
        public double w;
        public static readonly double4 zero;

        public double4(double x, double y, double z, double w);
        public double4(double x, double y, double2 zw);
        public double4(double x, double2 yz, double w);
        public double4(double x, double3 yzw);
        public double4(double2 xy, double z, double w);
        public double4(double2 xy, double2 zw);
        public double4(double3 xyz, double w);
        public double4(double4 xyzw);
        public double4(double v);
        public double4(bool v);
        public double4(bool4 v);
        public double4(int v);
        public double4(int4 v);
        public double4(uint v);
        public double4(uint4 v);
        public double4(half v);
        public double4(half4 v);
        public double4(float v);
        public double4(float4 v);

        public double this[int index] { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xywx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xywz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxwz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yywx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yywz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzwx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zywx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zywz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wywx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wywz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xwz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 ywx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 ywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 ywz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zwx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 www { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 xx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 xy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 xz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 xw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 yx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 yy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 yz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 yw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 zx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 zy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 zz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 zw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 wx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 wy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 wz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 ww { get; }

        public bool Equals(double4 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static double4 operator *(double4 lhs, double4 rhs);
        public static double4 operator *(double4 lhs, double rhs);
        public static double4 operator *(double lhs, double4 rhs);
        public static double4 operator +(double4 lhs, double4 rhs);
        public static double4 operator +(double4 lhs, double rhs);
        public static double4 operator +(double lhs, double4 rhs);
        public static double4 operator -(double4 lhs, double4 rhs);
        public static double4 operator -(double4 lhs, double rhs);
        public static double4 operator -(double lhs, double4 rhs);
        public static double4 operator /(double4 lhs, double4 rhs);
        public static double4 operator /(double4 lhs, double rhs);
        public static double4 operator /(double lhs, double4 rhs);
        public static double4 operator %(double4 lhs, double4 rhs);
        public static double4 operator %(double4 lhs, double rhs);
        public static double4 operator %(double lhs, double4 rhs);
        public static double4 operator ++(double4 val);
        public static double4 operator --(double4 val);
        public static bool4 operator <(double4 lhs, double4 rhs);
        public static bool4 operator <(double4 lhs, double rhs);
        public static bool4 operator <(double lhs, double4 rhs);
        public static bool4 operator <=(double4 lhs, double4 rhs);
        public static bool4 operator <=(double4 lhs, double rhs);
        public static bool4 operator <=(double lhs, double4 rhs);
        public static bool4 operator >(double4 lhs, double4 rhs);
        public static bool4 operator >(double4 lhs, double rhs);
        public static bool4 operator >(double lhs, double4 rhs);
        public static bool4 operator >=(double4 lhs, double4 rhs);
        public static bool4 operator >=(double4 lhs, double rhs);
        public static bool4 operator >=(double lhs, double4 rhs);
        public static double4 operator -(double4 val);
        public static double4 operator +(double4 val);
        public static bool4 operator ==(double4 lhs, double4 rhs);
        public static bool4 operator ==(double4 lhs, double rhs);
        public static bool4 operator ==(double lhs, double4 rhs);
        public static bool4 operator !=(double4 lhs, double4 rhs);
        public static bool4 operator !=(double4 lhs, double rhs);
        public static bool4 operator !=(double lhs, double4 rhs);

        public static implicit operator double4(double v);
        public static explicit operator double4(bool v);
        public static explicit operator double4(bool4 v);
        public static implicit operator double4(int v);
        public static implicit operator double4(int4 v);
        public static implicit operator double4(uint v);
        public static implicit operator double4(uint4 v);
        public static implicit operator double4(half v);
        public static implicit operator double4(half4 v);
        public static implicit operator double4(float v);
        public static implicit operator double4(float4 v);
    }
}
