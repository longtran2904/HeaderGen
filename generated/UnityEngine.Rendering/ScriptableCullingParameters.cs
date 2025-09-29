#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
    [UsedByNativeCode]
    public struct ScriptableCullingParameters : IEquatable<ScriptableCullingParameters>
    {
        public static readonly int maximumCullingPlaneCount;
        public static readonly int layerCount;

        public int maximumVisibleLights { get; set; }
        public bool conservativeEnclosingSphere { get; set; }
        public int numIterationsEnclosingSphere { get; set; }
        public int cullingPlaneCount { get; set; }
        public bool isOrthographic { get; set; }
        public LODParameters lodParameters { get; set; }
        public uint cullingMask { get; set; }
        public Matrix4x4 cullingMatrix { get; set; }
        public Vector3 origin { get; set; }
        public float shadowDistance { get; set; }
        public float shadowNearPlaneOffset { get; set; }
        public CullingOptions cullingOptions { get; set; }
        public ReflectionProbeSortingCriteria reflectionProbeSortingCriteria { get; set; }
        public CameraProperties cameraProperties { get; set; }
        public Matrix4x4 stereoViewMatrix { get; set; }
        public Matrix4x4 stereoProjectionMatrix { get; set; }
        public float stereoSeparationDistance { get; set; }
        public float accurateOcclusionThreshold { get; set; }
        public int maximumPortalCullingJobs { get; set; }
        public static int cullingJobsLowerLimit { get; }
        public static int cullingJobsUpperLimit { get; }

        public float GetLayerCullingDistance(int layerIndex);
        public void SetLayerCullingDistance(int layerIndex, float distance);
        public Plane GetCullingPlane(int index);
        public void SetCullingPlane(int index, Plane plane);
        public bool Equals(ScriptableCullingParameters other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(ScriptableCullingParameters left, ScriptableCullingParameters right);
        public static bool operator !=(ScriptableCullingParameters left, ScriptableCullingParameters right);
    }
}
