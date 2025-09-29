#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
    [NativeHeader("Runtime/Math/Matrix4x4.h")]
    [NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
    [RequiredByNativeCode]
    public class BatchRendererGroup : IDisposable
    {

        public BatchRendererGroup(OnPerformCulling cullingCallback);

        public void Dispose();
        public int AddBatch(Mesh mesh, int subMeshIndex, Material material, int layer, ShadowCastingMode castShadows, bool receiveShadows, bool invertCulling, Bounds bounds, int instanceCount, MaterialPropertyBlock customProps, GameObject associatedSceneObject, ulong sceneCullingMask = 9223372036854775808, uint renderingLayerMask = 4294967295);
        public void SetBatchFlags(int batchIndex, ulong flags);
        public void SetBatchPropertyMetadata(int batchIndex, NativeArray<int> cbufferLengths, NativeArray<int> cbufferMetadata);
        public void SetInstancingData(int batchIndex, int instanceCount, MaterialPropertyBlock customProps);
        public NativeArray<Matrix4x4> GetBatchMatrices(int batchIndex);
        public NativeArray<int> GetBatchScalarArrayInt(int batchIndex, string propertyName);
        public NativeArray<float> GetBatchScalarArray(int batchIndex, string propertyName);
        public NativeArray<int> GetBatchVectorArrayInt(int batchIndex, string propertyName);
        public NativeArray<Vector4> GetBatchVectorArray(int batchIndex, string propertyName);
        public NativeArray<Matrix4x4> GetBatchMatrixArray(int batchIndex, string propertyName);
        public NativeArray<int> GetBatchScalarArrayInt(int batchIndex, int propertyName);
        public NativeArray<float> GetBatchScalarArray(int batchIndex, int propertyName);
        public NativeArray<int> GetBatchVectorArrayInt(int batchIndex, int propertyName);
        public NativeArray<Vector4> GetBatchVectorArray(int batchIndex, int propertyName);
        public NativeArray<Matrix4x4> GetBatchMatrixArray(int batchIndex, int propertyName);
        public void SetBatchBounds(int batchIndex, Bounds bounds);
        public int GetNumBatches();
        public void RemoveBatch(int index);
        public void EnableVisibleIndicesYArray(bool enabled);
        public delegate JobHandle OnPerformCulling(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext);
    }
}
