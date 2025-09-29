#region UnityEngine.ParticleSystemModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.ParticleSystemModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/ParticleSystem/ParticleSystemRenderer.h")]
    [NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemRendererScriptBindings.h")]
    [NativeHeader("ParticleSystemScriptingClasses.h")]
    [RequireComponent(typeof(Transform))]
    public sealed class ParticleSystemRenderer : Renderer
    {

        public ParticleSystemRenderer();

        [NativeName("RenderAlignment")]
        public ParticleSystemRenderSpace alignment { get; set; }
        public ParticleSystemRenderMode renderMode { get; set; }
        public ParticleSystemMeshDistribution meshDistribution { get; set; }
        public ParticleSystemSortMode sortMode { get; set; }
        public float lengthScale { get; set; }
        public float velocityScale { get; set; }
        public float cameraVelocityScale { get; set; }
        public float normalDirection { get; set; }
        public float shadowBias { get; set; }
        public float sortingFudge { get; set; }
        public float minParticleSize { get; set; }
        public float maxParticleSize { get; set; }
        public Vector3 pivot { get; set; }
        public Vector3 flip { get; set; }
        public SpriteMaskInteraction maskInteraction { get; set; }
        public Material trailMaterial { get; set; }
        public bool enableGPUInstancing { get; set; }
        public bool allowRoll { get; set; }
        public bool freeformStretching { get; set; }
        public bool rotateWithStretchDirection { get; set; }
        public Mesh mesh { get; set; }
        public int meshCount { get; }
        public int activeVertexStreamsCount { get; }
        public bool supportsMeshInstancing { get; }

        [Obsolete("EnableVertexStreams is deprecated.Use SetActiveVertexStreams instead.", False)]
        public void EnableVertexStreams(ParticleSystemVertexStreams streams);
        [Obsolete("DisableVertexStreams is deprecated.Use SetActiveVertexStreams instead.", False)]
        public void DisableVertexStreams(ParticleSystemVertexStreams streams);
        [Obsolete("AreVertexStreamsEnabled is deprecated.Use GetActiveVertexStreams instead.", False)]
        public bool AreVertexStreamsEnabled(ParticleSystemVertexStreams streams);
        [Obsolete("GetEnabledVertexStreams is deprecated.Use GetActiveVertexStreams instead.", False)]
        public ParticleSystemVertexStreams GetEnabledVertexStreams(ParticleSystemVertexStreams streams);
        [FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshes", HasExplicitThis = True)]
        [RequiredByNativeCode]
        public int GetMeshes([NotNull("ArgumentNullException")] out Mesh[] meshes);
        [FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMeshes", HasExplicitThis = True)]
        public void SetMeshes([NotNull("ArgumentNullException")] Mesh[] meshes, int size);
        public void SetMeshes(Mesh[] meshes);
        [FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshWeightings", HasExplicitThis = True)]
        public int GetMeshWeightings([NotNull("ArgumentNullException")] out float[] weightings);
        [FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMeshWeightings", HasExplicitThis = True)]
        public void SetMeshWeightings([NotNull("ArgumentNullException")] float[] weightings, int size);
        public void SetMeshWeightings(float[] weightings);
        public void BakeMesh(Mesh mesh, bool useTransform = False);
        public void BakeMesh([NotNull("ArgumentNullException")] Mesh mesh, [NotNull("ArgumentNullException")] Camera camera, bool useTransform = False);
        public void BakeTrailsMesh(Mesh mesh, bool useTransform = False);
        public void BakeTrailsMesh([NotNull("ArgumentNullException")] Mesh mesh, [NotNull("ArgumentNullException")] Camera camera, bool useTransform = False);
        [FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetActiveVertexStreams", HasExplicitThis = True)]
        public void SetActiveVertexStreams([NotNull("ArgumentNullException")] List<ParticleSystemVertexStream> streams);
        [FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetActiveVertexStreams", HasExplicitThis = True)]
        public void GetActiveVertexStreams([NotNull("ArgumentNullException")] List<ParticleSystemVertexStream> streams);
    }
}
