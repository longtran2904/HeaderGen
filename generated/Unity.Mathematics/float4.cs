#region Unity.Mathematics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Mathematics.dll
#endregion

using System;
using System.ComponentModel;
using System.Reflection;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
    [DefaultMember("Item")]
    [Il2CppEagerStaticClassConstruction]
    public struct float4 : IEquatable<float4>, IFormattable
    {
        public float x;
        public float y;
        public float z;
        public float w;
        public static readonly float4 zero;

        public float4(float x, float y, float z, float w);
        public float4(float x, float y, float2 zw);
        public float4(float x, float2 yz, float w);
        public float4(float x, float3 yzw);
        public float4(float2 xy, float z, float w);
        public float4(float2 xy, float2 zw);
        public float4(float3 xyz, float w);
        public float4(float4 xyzw);
        public float4(float v);
        public float4(bool v);
        public float4(bool4 v);
        public float4(int v);
        public float4(int4 v);
        public float4(uint v);
        public float4(uint4 v);
        public float4(half v);
        public float4(half4 v);
        public float4(double v);
        public float4(double4 v);

        public float this[int index] { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xywx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xywz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xwxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xwxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xwxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xwxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xwyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xwyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xwyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xwyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xwzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xwzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xwzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xwzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xwwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xwwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xwwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 xwww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxwz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yywx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yywz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzwx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 yzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 ywxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 ywxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 ywxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 ywxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 ywyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 ywyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 ywyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 ywyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 ywzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 ywzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 ywzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 ywzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 ywwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 ywwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 ywwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 ywww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zyxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zyxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zyzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zyzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zywx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zywz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zwxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zwxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zwxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zwxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zwyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zwyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zwyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zwyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zwzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zwzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zwzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zwzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zwwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zwwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zwwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 zwww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wxxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wxxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wxxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wxxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wxyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wxyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wxyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wxyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wxzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wxzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wxzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wxzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wxwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wxwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wxwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wxww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wyxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wyxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wyxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wyxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wyyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wyyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wyyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wyyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wyzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wyzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wyzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wyzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wywx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wywz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wyww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wzxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wzxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wzxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wzxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wzyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wzyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wzyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wzyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wzzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wzzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wzzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wzzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wzwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wzwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wzwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wzww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wwxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wwxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wwxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wwxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wwyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wwyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wwyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wwyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wwzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wwzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wwzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wwzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wwwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wwwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wwwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float4 wwww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xwz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 xww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yxy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yyx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yzw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 ywx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 ywy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 ywz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 yww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zxz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zxw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zyz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zyw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zzx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zzy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zwx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zwy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 zww { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 wxx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 wxy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 wxz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 wxw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 wyx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 wyy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 wyz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 wyw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 wzx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 wzy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 wzz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 wzw { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 wwx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 wwy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 wwz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float3 www { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 xx { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 xy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 xz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 xw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 yx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 yy { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 yz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 yw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 zx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 zy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 zz { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 zw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 wx { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 wy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 wz { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float2 ww { get; }

        public bool Equals(float4 rhs);
        public override bool Equals(object o);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static float4 operator *(float4 lhs, float4 rhs);
        public static float4 operator *(float4 lhs, float rhs);
        public static float4 operator *(float lhs, float4 rhs);
        public static float4 operator +(float4 lhs, float4 rhs);
        public static float4 operator +(float4 lhs, float rhs);
        public static float4 operator +(float lhs, float4 rhs);
        public static float4 operator -(float4 lhs, float4 rhs);
        public static float4 operator -(float4 lhs, float rhs);
        public static float4 operator -(float lhs, float4 rhs);
        public static float4 operator /(float4 lhs, float4 rhs);
        public static float4 operator /(float4 lhs, float rhs);
        public static float4 operator /(float lhs, float4 rhs);
        public static float4 operator %(float4 lhs, float4 rhs);
        public static float4 operator %(float4 lhs, float rhs);
        public static float4 operator %(float lhs, float4 rhs);
        public static float4 operator ++(float4 val);
        public static float4 operator --(float4 val);
        public static bool4 operator <(float4 lhs, float4 rhs);
        public static bool4 operator <(float4 lhs, float rhs);
        public static bool4 operator <(float lhs, float4 rhs);
        public static bool4 operator <=(float4 lhs, float4 rhs);
        public static bool4 operator <=(float4 lhs, float rhs);
        public static bool4 operator <=(float lhs, float4 rhs);
        public static bool4 operator >(float4 lhs, float4 rhs);
        public static bool4 operator >(float4 lhs, float rhs);
        public static bool4 operator >(float lhs, float4 rhs);
        public static bool4 operator >=(float4 lhs, float4 rhs);
        public static bool4 operator >=(float4 lhs, float rhs);
        public static bool4 operator >=(float lhs, float4 rhs);
        public static float4 operator -(float4 val);
        public static float4 operator +(float4 val);
        public static bool4 operator ==(float4 lhs, float4 rhs);
        public static bool4 operator ==(float4 lhs, float rhs);
        public static bool4 operator ==(float lhs, float4 rhs);
        public static bool4 operator !=(float4 lhs, float4 rhs);
        public static bool4 operator !=(float4 lhs, float rhs);
        public static bool4 operator !=(float lhs, float4 rhs);

        public static implicit operator float4(float v);
        public static explicit operator float4(bool v);
        public static explicit operator float4(bool4 v);
        public static implicit operator float4(int v);
        public static implicit operator float4(int4 v);
        public static implicit operator float4(uint v);
        public static implicit operator float4(uint4 v);
        public static implicit operator float4(half v);
        public static implicit operator float4(half4 v);
        public static explicit operator float4(double v);
        public static explicit operator float4(double4 v);
        public static implicit operator float4(Vector4 v);
        public static implicit operator Vector4(float4 v);
    }
}
