#region UnityEngine.ClothModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.ClothModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
    [NativeClass("Unity::Cloth")]
    [NativeHeader("Modules/Cloth/Cloth.h")]
    [RequireComponent(typeof(Transform), typeof(SkinnedMeshRenderer))]
    public sealed class Cloth : Component
    {

        public Cloth();

        public Vector3[] vertices { get; }
        public Vector3[] normals { get; }
        public ClothSkinningCoefficient[] coefficients { get; set; }
        public CapsuleCollider[] capsuleColliders { get; set; }
        public ClothSphereColliderPair[] sphereColliders { get; set; }
        public float sleepThreshold { get; set; }
        public float bendingStiffness { get; set; }
        public float stretchingStiffness { get; set; }
        public float damping { get; set; }
        public Vector3 externalAcceleration { get; set; }
        public Vector3 randomAcceleration { get; set; }
        public bool useGravity { get; set; }
        public bool enabled { get; set; }
        public float friction { get; set; }
        public float collisionMassScale { get; set; }
        public bool enableContinuousCollision { get; set; }
        public float useVirtualParticles { get; set; }
        public float worldVelocityScale { get; set; }
        public float worldAccelerationScale { get; set; }
        public float clothSolverFrequency { get; set; }
        [Obsolete("Parameter solverFrequency is obsolete and no longer supported. Please use clothSolverFrequency instead.")]
        public bool solverFrequency { get; set; }
        public bool useTethers { get; set; }
        public float stiffnessFrequency { get; set; }
        public float selfCollisionDistance { get; set; }
        public float selfCollisionStiffness { get; set; }
        [Obsolete("useContinuousCollision is no longer supported, use enableContinuousCollision instead")]
        public float useContinuousCollision { get; set; }
        [Obsolete("Deprecated.Cloth.selfCollisions is no longer supported since Unity 5.0.", True)]
        public bool selfCollision { get; }

        public void ClearTransformMotion();
        public void GetSelfAndInterCollisionIndices([NotNull("ArgumentNullException")] List<uint> indices);
        public void SetSelfAndInterCollisionIndices([NotNull("ArgumentNullException")] List<uint> indices);
        public void GetVirtualParticleIndices([NotNull("ArgumentNullException")] List<uint> indicesOutList);
        public void SetVirtualParticleIndices([NotNull("ArgumentNullException")] List<uint> indicesIn);
        public void GetVirtualParticleWeights([NotNull("ArgumentNullException")] List<Vector3> weightsOutList);
        public void SetVirtualParticleWeights([NotNull("ArgumentNullException")] List<Vector3> weights);
        public void SetEnabledFading(bool enabled, float interpolationTime);
        [ExcludeFromDocs]
        public void SetEnabledFading(bool enabled);
    }
}
