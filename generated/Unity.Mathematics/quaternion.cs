#region Unity.Mathematics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Mathematics.dll
#endregion

using System;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
    [Il2CppEagerStaticClassConstruction]
    public struct quaternion : IEquatable<quaternion>, IFormattable
    {
        public float4 value;
        public static readonly quaternion identity;

        public quaternion(float x, float y, float z, float w);
        public quaternion(float4 value);
        public quaternion(float3x3 m);
        public quaternion(float4x4 m);

        public static quaternion AxisAngle(float3 axis, float angle);
        public static quaternion EulerXYZ(float3 xyz);
        public static quaternion EulerXZY(float3 xyz);
        public static quaternion EulerYXZ(float3 xyz);
        public static quaternion EulerYZX(float3 xyz);
        public static quaternion EulerZXY(float3 xyz);
        public static quaternion EulerZYX(float3 xyz);
        public static quaternion EulerXYZ(float x, float y, float z);
        public static quaternion EulerXZY(float x, float y, float z);
        public static quaternion EulerYXZ(float x, float y, float z);
        public static quaternion EulerYZX(float x, float y, float z);
        public static quaternion EulerZXY(float x, float y, float z);
        public static quaternion EulerZYX(float x, float y, float z);
        public static quaternion Euler(float3 xyz, math.RotationOrder order = math.RotationOrder.ZXY);
        public static quaternion Euler(float x, float y, float z, math.RotationOrder order = math.RotationOrder.ZXY);
        public static quaternion RotateX(float angle);
        public static quaternion RotateY(float angle);
        public static quaternion RotateZ(float angle);
        public static quaternion LookRotation(float3 forward, float3 up);
        public static quaternion LookRotationSafe(float3 forward, float3 up);
        public bool Equals(quaternion x);
        public override bool Equals(object x);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);

        public static implicit operator Quaternion(quaternion q);
        public static implicit operator quaternion(Quaternion q);
        public static implicit operator quaternion(float4 v);
    }
}
