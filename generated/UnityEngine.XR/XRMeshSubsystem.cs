#region UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.XRModule.dll
#endregion

using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
    [NativeConditional("ENABLE_XR")]
    [NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshingSubsystem.h")]
    [NativeHeader("Modules/XR/XRPrefix.h")]
    [UsedByNativeCode]
    public class XRMeshSubsystem : IntegratedSubsystem<XRMeshSubsystemDescriptor>
    {
        public XRMeshSubsystem();

        public float meshDensity { get; set; }

        public bool TryGetMeshInfos(List<MeshInfo> meshInfosOut);
        public void GenerateMeshAsync(MeshId meshId, Mesh mesh, MeshCollider meshCollider, MeshVertexAttributes attributes, Action<MeshGenerationResult> onMeshGenerationComplete);
        public void GenerateMeshAsync(MeshId meshId, Mesh mesh, MeshCollider meshCollider, MeshVertexAttributes attributes, Action<MeshGenerationResult> onMeshGenerationComplete, MeshGenerationOptions options);
        public bool SetBoundingVolume(Vector3 origin, Vector3 extents);
        public NativeArray<MeshTransform> GetUpdatedMeshTransforms(Allocator allocator);
    }
}
