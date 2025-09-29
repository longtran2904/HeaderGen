#region Unity.Mathematics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Mathematics.dll
#endregion

using System;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
    [Il2CppEagerStaticClassConstruction]
    public struct RigidTransform
    {
        public quaternion rot;
        public float3 pos;
        public static readonly RigidTransform identity;

        public RigidTransform(quaternion rotation, float3 translation);
        public RigidTransform(float3x3 rotation, float3 translation);
        public RigidTransform(float4x4 transform);

        public static RigidTransform AxisAngle(float3 axis, float angle);
        public static RigidTransform EulerXYZ(float3 xyz);
        public static RigidTransform EulerXZY(float3 xyz);
        public static RigidTransform EulerYXZ(float3 xyz);
        public static RigidTransform EulerYZX(float3 xyz);
        public static RigidTransform EulerZXY(float3 xyz);
        public static RigidTransform EulerZYX(float3 xyz);
        public static RigidTransform EulerXYZ(float x, float y, float z);
        public static RigidTransform EulerXZY(float x, float y, float z);
        public static RigidTransform EulerYXZ(float x, float y, float z);
        public static RigidTransform EulerYZX(float x, float y, float z);
        public static RigidTransform EulerZXY(float x, float y, float z);
        public static RigidTransform EulerZYX(float x, float y, float z);
        public static RigidTransform Euler(float3 xyz, math.RotationOrder order = math.RotationOrder.ZXY);
        public static RigidTransform Euler(float x, float y, float z, math.RotationOrder order = math.RotationOrder.ZXY);
        public static RigidTransform RotateX(float angle);
        public static RigidTransform RotateY(float angle);
        public static RigidTransform RotateZ(float angle);
        public static RigidTransform Translate(float3 vector);
        public bool Equals(RigidTransform x);
        public override bool Equals(object x);
        public override int GetHashCode();
        public override string ToString();
        public string ToString(string format, IFormatProvider formatProvider);
    }
}
