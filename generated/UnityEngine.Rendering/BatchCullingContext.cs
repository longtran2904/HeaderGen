#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
    [NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
    [UsedByNativeCode]
    public struct BatchCullingContext
    {
        public readonly NativeArray<Plane> cullingPlanes;
        public NativeArray<BatchVisibility> batchVisibility;
        public NativeArray<int> visibleIndices;
        public NativeArray<int> visibleIndicesY;
        public readonly LODParameters lodParameters;
        public readonly Matrix4x4 cullingMatrix;
        public readonly float nearPlane;

        [Obsolete("For internal BatchRendererGroup use only")]
        public BatchCullingContext(NativeArray<Plane> inCullingPlanes, NativeArray<BatchVisibility> inOutBatchVisibility, NativeArray<int> outVisibleIndices, LODParameters inLodParameters);
        [Obsolete("For internal BatchRendererGroup use only")]
        public BatchCullingContext(NativeArray<Plane> inCullingPlanes, NativeArray<BatchVisibility> inOutBatchVisibility, NativeArray<int> outVisibleIndices, LODParameters inLodParameters, Matrix4x4 inCullingMatrix, float inNearPlane);
    }
}
