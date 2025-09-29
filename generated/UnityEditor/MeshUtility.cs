#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Mono/MeshUtility.bindings.h")]
    [NativeHeader("Runtime/Graphics/Mesh/MeshOptimizer.h")]
    [NativeHeader("Runtime/Graphics/Texture.h")]
    [StaticAccessor("MeshUtility", StaticAccessorType.DoubleColon)]
    public class MeshUtility
    {
        public MeshUtility();

        public static void Optimize(Mesh mesh);
        public static void SetMeshCompression(Mesh mesh, ModelImporterMeshCompression compression);
        public static ModelImporterMeshCompression GetMeshCompression(Mesh mesh);
        public static void SetPerTriangleUV2(Mesh src, Vector2[] triUV);
        public static Mesh.MeshDataArray AcquireReadOnlyMeshData(Mesh mesh);
        public static Mesh.MeshDataArray AcquireReadOnlyMeshData(Mesh[] meshes);
        public static Mesh.MeshDataArray AcquireReadOnlyMeshData(List<Mesh> meshes);
    }
}
