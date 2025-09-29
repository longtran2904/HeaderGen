#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
    [RequiredByNativeCode]
    public sealed class Mesh : Object
    {

        [RequiredByNativeCode]
        public Mesh();

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Property Mesh.uv1 has been deprecated. Use Mesh.uv2 instead (UnityUpgradable) -> uv2", True)]
        public Vector2[] uv1 { get; set; }
        public IndexFormat indexFormat { get; set; }
        public int vertexBufferCount { get; }
        public GraphicsBuffer.Target vertexBufferTarget { get; set; }
        public GraphicsBuffer.Target indexBufferTarget { get; set; }
        public int blendShapeCount { get; }
        [NativeName("BindPosesFromScript")]
        public Matrix4x4[] bindposes { get; set; }
        public bool isReadable { get; }
        public int vertexCount { get; }
        public int subMeshCount { get; set; }
        public Bounds bounds { get; set; }
        public Vector3[] vertices { get; set; }
        public Vector3[] normals { get; set; }
        public Vector4[] tangents { get; set; }
        public Vector2[] uv { get; set; }
        public Vector2[] uv2 { get; set; }
        public Vector2[] uv3 { get; set; }
        public Vector2[] uv4 { get; set; }
        public Vector2[] uv5 { get; set; }
        public Vector2[] uv6 { get; set; }
        public Vector2[] uv7 { get; set; }
        public Vector2[] uv8 { get; set; }
        public Color[] colors { get; set; }
        public Color32[] colors32 { get; set; }
        public int vertexAttributeCount { get; }
        public int[] triangles { get; set; }
        public BoneWeight[] boneWeights { get; set; }

        [FreeFunction(Name = "MeshScripting::SetIndexBufferParams", ThrowsException = True, HasExplicitThis = True)]
        public void SetIndexBufferParams(int indexCount, IndexFormat format);
        [FreeFunction(Name = "MeshScripting::GetVertexAttributeByIndex", ThrowsException = True, HasExplicitThis = True)]
        public VertexAttributeDescriptor GetVertexAttribute(int index);
        [FreeFunction(Name = "MeshScripting::HasChannel", HasExplicitThis = True)]
        public bool HasVertexAttribute(VertexAttribute attr);
        [FreeFunction(Name = "MeshScripting::GetChannelDimension", HasExplicitThis = True)]
        public int GetVertexAttributeDimension(VertexAttribute attr);
        [FreeFunction(Name = "MeshScripting::GetChannelFormat", HasExplicitThis = True)]
        public VertexAttributeFormat GetVertexAttributeFormat(VertexAttribute attr);
        [FreeFunction(Name = "MeshScripting::GetChannelStream", HasExplicitThis = True)]
        public int GetVertexAttributeStream(VertexAttribute attr);
        [FreeFunction(Name = "MeshScripting::GetChannelOffset", HasExplicitThis = True)]
        public int GetVertexAttributeOffset(VertexAttribute attr);
        [FreeFunction(Name = "MeshScripting::GetVertexBufferStride", HasExplicitThis = True)]
        public int GetVertexBufferStride(int stream);
        [FreeFunction(Name = "MeshScripting::GetNativeVertexBufferPtr", HasExplicitThis = True)]
        [NativeThrows]
        public nint GetNativeVertexBufferPtr(int index);
        [FreeFunction(Name = "MeshScripting::GetNativeIndexBufferPtr", HasExplicitThis = True)]
        public nint GetNativeIndexBufferPtr();
        [FreeFunction(Name = "MeshScripting::ClearBlendShapes", HasExplicitThis = True)]
        public void ClearBlendShapes();
        [FreeFunction(Name = "MeshScripting::GetBlendShapeName", ThrowsException = True, HasExplicitThis = True)]
        public string GetBlendShapeName(int shapeIndex);
        [FreeFunction(Name = "MeshScripting::GetBlendShapeIndex", ThrowsException = True, HasExplicitThis = True)]
        public int GetBlendShapeIndex(string blendShapeName);
        [FreeFunction(Name = "MeshScripting::GetBlendShapeFrameCount", ThrowsException = True, HasExplicitThis = True)]
        public int GetBlendShapeFrameCount(int shapeIndex);
        [FreeFunction(Name = "MeshScripting::GetBlendShapeFrameWeight", ThrowsException = True, HasExplicitThis = True)]
        public float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex);
        [FreeFunction(Name = "GetBlendShapeFrameVerticesFromScript", ThrowsException = True, HasExplicitThis = True)]
        public void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, [Unmarshalled] Vector3[] deltaVertices, [Unmarshalled] Vector3[] deltaNormals, [Unmarshalled] Vector3[] deltaTangents);
        [FreeFunction(Name = "AddBlendShapeFrameFromScript", ThrowsException = True, HasExplicitThis = True)]
        public void AddBlendShapeFrame(string shapeName, float frameWeight, [Unmarshalled] Vector3[] deltaVertices, [Unmarshalled] Vector3[] deltaNormals, [Unmarshalled] Vector3[] deltaTangents);
        public void SetBoneWeights(NativeArray<byte> bonesPerVertex, NativeArray<BoneWeight1> weights);
        public NativeArray<BoneWeight1> GetAllBoneWeights();
        public NativeArray<byte> GetBonesPerVertex();
        [FreeFunction("MeshScripting::SetSubMesh", ThrowsException = True, HasExplicitThis = True)]
        public void SetSubMesh(int index, SubMeshDescriptor desc, MeshUpdateFlags flags = MeshUpdateFlags.Default);
        [FreeFunction("MeshScripting::GetSubMesh", ThrowsException = True, HasExplicitThis = True)]
        public SubMeshDescriptor GetSubMesh(int index);
        [NativeMethod("MarkModified")]
        public void MarkModified();
        [NativeMethod("GetMeshMetric")]
        public float GetUVDistributionMetric(int uvSetIndex);
        public void GetVertices(List<Vector3> vertices);
        public void SetVertices(List<Vector3> inVertices);
        [ExcludeFromDocs]
        public void SetVertices(List<Vector3> inVertices, int start, int length);
        public void SetVertices(List<Vector3> inVertices, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags);
        public void SetVertices(Vector3[] inVertices);
        [ExcludeFromDocs]
        public void SetVertices(Vector3[] inVertices, int start, int length);
        public void SetVertices(Vector3[] inVertices, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags);
        public void SetVertices<T>(NativeArray<T> inVertices) where T : struct;
        [ExcludeFromDocs]
        public void SetVertices<T>(NativeArray<T> inVertices, int start, int length) where T : struct;
        public void SetVertices<T>(NativeArray<T> inVertices, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags) where T : struct;
        public void GetNormals(List<Vector3> normals);
        public void SetNormals(List<Vector3> inNormals);
        [ExcludeFromDocs]
        public void SetNormals(List<Vector3> inNormals, int start, int length);
        public void SetNormals(List<Vector3> inNormals, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags);
        public void SetNormals(Vector3[] inNormals);
        [ExcludeFromDocs]
        public void SetNormals(Vector3[] inNormals, int start, int length);
        public void SetNormals(Vector3[] inNormals, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags);
        public void SetNormals<T>(NativeArray<T> inNormals) where T : struct;
        [ExcludeFromDocs]
        public void SetNormals<T>(NativeArray<T> inNormals, int start, int length) where T : struct;
        public void SetNormals<T>(NativeArray<T> inNormals, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags) where T : struct;
        public void GetTangents(List<Vector4> tangents);
        public void SetTangents(List<Vector4> inTangents);
        [ExcludeFromDocs]
        public void SetTangents(List<Vector4> inTangents, int start, int length);
        public void SetTangents(List<Vector4> inTangents, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags);
        public void SetTangents(Vector4[] inTangents);
        [ExcludeFromDocs]
        public void SetTangents(Vector4[] inTangents, int start, int length);
        public void SetTangents(Vector4[] inTangents, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags);
        public void SetTangents<T>(NativeArray<T> inTangents) where T : struct;
        [ExcludeFromDocs]
        public void SetTangents<T>(NativeArray<T> inTangents, int start, int length) where T : struct;
        public void SetTangents<T>(NativeArray<T> inTangents, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags) where T : struct;
        public void GetColors(List<Color> colors);
        public void SetColors(List<Color> inColors);
        [ExcludeFromDocs]
        public void SetColors(List<Color> inColors, int start, int length);
        public void SetColors(List<Color> inColors, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags);
        public void SetColors(Color[] inColors);
        [ExcludeFromDocs]
        public void SetColors(Color[] inColors, int start, int length);
        public void SetColors(Color[] inColors, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags);
        public void GetColors(List<Color32> colors);
        public void SetColors(List<Color32> inColors);
        [ExcludeFromDocs]
        public void SetColors(List<Color32> inColors, int start, int length);
        public void SetColors(List<Color32> inColors, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags);
        public void SetColors(Color32[] inColors);
        [ExcludeFromDocs]
        public void SetColors(Color32[] inColors, int start, int length);
        public void SetColors(Color32[] inColors, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags);
        public void SetColors<T>(NativeArray<T> inColors) where T : struct;
        [ExcludeFromDocs]
        public void SetColors<T>(NativeArray<T> inColors, int start, int length) where T : struct;
        public void SetColors<T>(NativeArray<T> inColors, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags) where T : struct;
        public void SetUVs(int channel, List<Vector2> uvs);
        public void SetUVs(int channel, List<Vector3> uvs);
        public void SetUVs(int channel, List<Vector4> uvs);
        [ExcludeFromDocs]
        public void SetUVs(int channel, List<Vector2> uvs, int start, int length);
        public void SetUVs(int channel, List<Vector2> uvs, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags);
        [ExcludeFromDocs]
        public void SetUVs(int channel, List<Vector3> uvs, int start, int length);
        public void SetUVs(int channel, List<Vector3> uvs, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags);
        [ExcludeFromDocs]
        public void SetUVs(int channel, List<Vector4> uvs, int start, int length);
        public void SetUVs(int channel, List<Vector4> uvs, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags);
        public void SetUVs(int channel, Vector2[] uvs);
        public void SetUVs(int channel, Vector3[] uvs);
        public void SetUVs(int channel, Vector4[] uvs);
        [ExcludeFromDocs]
        public void SetUVs(int channel, Vector2[] uvs, int start, int length);
        public void SetUVs(int channel, Vector2[] uvs, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags);
        [ExcludeFromDocs]
        public void SetUVs(int channel, Vector3[] uvs, int start, int length);
        public void SetUVs(int channel, Vector3[] uvs, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags);
        [ExcludeFromDocs]
        public void SetUVs(int channel, Vector4[] uvs, int start, int length);
        public void SetUVs(int channel, Vector4[] uvs, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags);
        public void SetUVs<T>(int channel, NativeArray<T> uvs) where T : struct;
        [ExcludeFromDocs]
        public void SetUVs<T>(int channel, NativeArray<T> uvs, int start, int length) where T : struct;
        public void SetUVs<T>(int channel, NativeArray<T> uvs, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags) where T : struct;
        public void GetUVs(int channel, List<Vector2> uvs);
        public void GetUVs(int channel, List<Vector3> uvs);
        public void GetUVs(int channel, List<Vector4> uvs);
        public VertexAttributeDescriptor[] GetVertexAttributes();
        public int GetVertexAttributes(VertexAttributeDescriptor[] attributes);
        public int GetVertexAttributes(List<VertexAttributeDescriptor> attributes);
        public void SetVertexBufferParams(int vertexCount, params VertexAttributeDescriptor[] attributes);
        public void SetVertexBufferParams(int vertexCount, NativeArray<VertexAttributeDescriptor> attributes);
        public void SetVertexBufferData<T>(NativeArray<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct;
        public void SetVertexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct;
        public void SetVertexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct;
        public static MeshDataArray AcquireReadOnlyMeshData(Mesh mesh);
        public static MeshDataArray AcquireReadOnlyMeshData(Mesh[] meshes);
        public static MeshDataArray AcquireReadOnlyMeshData(List<Mesh> meshes);
        public static MeshDataArray AllocateWritableMeshData(int meshCount);
        public static void ApplyAndDisposeWritableMeshData(MeshDataArray data, Mesh mesh, MeshUpdateFlags flags = MeshUpdateFlags.Default);
        public static void ApplyAndDisposeWritableMeshData(MeshDataArray data, Mesh[] meshes, MeshUpdateFlags flags = MeshUpdateFlags.Default);
        public static void ApplyAndDisposeWritableMeshData(MeshDataArray data, List<Mesh> meshes, MeshUpdateFlags flags = MeshUpdateFlags.Default);
        public GraphicsBuffer GetVertexBuffer(int index);
        public GraphicsBuffer GetIndexBuffer();
        public int[] GetTriangles(int submesh);
        public int[] GetTriangles(int submesh, [DefaultValue("true")] bool applyBaseVertex);
        public void GetTriangles(List<int> triangles, int submesh);
        public void GetTriangles(List<int> triangles, int submesh, [DefaultValue("true")] bool applyBaseVertex);
        public void GetTriangles(List<ushort> triangles, int submesh, bool applyBaseVertex = True);
        [ExcludeFromDocs]
        public int[] GetIndices(int submesh);
        public int[] GetIndices(int submesh, [DefaultValue("true")] bool applyBaseVertex);
        [ExcludeFromDocs]
        public void GetIndices(List<int> indices, int submesh);
        public void GetIndices(List<int> indices, int submesh, [DefaultValue("true")] bool applyBaseVertex);
        public void GetIndices(List<ushort> indices, int submesh, bool applyBaseVertex = True);
        public void SetIndexBufferData<T>(NativeArray<T> data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct;
        public void SetIndexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct;
        public void SetIndexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct;
        public uint GetIndexStart(int submesh);
        public uint GetIndexCount(int submesh);
        public uint GetBaseVertex(int submesh);
        [ExcludeFromDocs]
        public void SetTriangles(int[] triangles, int submesh);
        [ExcludeFromDocs]
        public void SetTriangles(int[] triangles, int submesh, bool calculateBounds);
        public void SetTriangles(int[] triangles, int submesh, [DefaultValue("true")] bool calculateBounds, [DefaultValue("0")] int baseVertex);
        public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0);
        public void SetTriangles(ushort[] triangles, int submesh, bool calculateBounds = True, int baseVertex = 0);
        public void SetTriangles(ushort[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0);
        [ExcludeFromDocs]
        public void SetTriangles(List<int> triangles, int submesh);
        [ExcludeFromDocs]
        public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds);
        public void SetTriangles(List<int> triangles, int submesh, [DefaultValue("true")] bool calculateBounds, [DefaultValue("0")] int baseVertex);
        public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0);
        public void SetTriangles(List<ushort> triangles, int submesh, bool calculateBounds = True, int baseVertex = 0);
        public void SetTriangles(List<ushort> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0);
        [ExcludeFromDocs]
        public void SetIndices(int[] indices, MeshTopology topology, int submesh);
        [ExcludeFromDocs]
        public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds);
        public void SetIndices(int[] indices, MeshTopology topology, int submesh, [DefaultValue("true")] bool calculateBounds, [DefaultValue("0")] int baseVertex);
        public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0);
        public void SetIndices(ushort[] indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0);
        public void SetIndices(ushort[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0);
        public void SetIndices<T>(NativeArray<T> indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) where T : struct;
        public void SetIndices<T>(NativeArray<T> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0) where T : struct;
        public void SetIndices(List<int> indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0);
        public void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0);
        public void SetIndices(List<ushort> indices, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0);
        public void SetIndices(List<ushort> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = True, int baseVertex = 0);
        public void SetSubMeshes(SubMeshDescriptor[] desc, int start, int count, MeshUpdateFlags flags = MeshUpdateFlags.Default);
        public void SetSubMeshes(SubMeshDescriptor[] desc, MeshUpdateFlags flags = MeshUpdateFlags.Default);
        public void SetSubMeshes(List<SubMeshDescriptor> desc, int start, int count, MeshUpdateFlags flags = MeshUpdateFlags.Default);
        public void SetSubMeshes(List<SubMeshDescriptor> desc, MeshUpdateFlags flags = MeshUpdateFlags.Default);
        public void SetSubMeshes<T>(NativeArray<T> desc, int start, int count, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct;
        public void SetSubMeshes<T>(NativeArray<T> desc, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct;
        public void GetBindposes(List<Matrix4x4> bindposes);
        public void GetBoneWeights(List<BoneWeight> boneWeights);
        public void Clear([DefaultValue("true")] bool keepVertexLayout);
        [ExcludeFromDocs]
        public void Clear();
        [ExcludeFromDocs]
        public void RecalculateBounds();
        [ExcludeFromDocs]
        public void RecalculateNormals();
        [ExcludeFromDocs]
        public void RecalculateTangents();
        public void RecalculateBounds([DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags);
        public void RecalculateNormals([DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags);
        public void RecalculateTangents([DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags);
        public void RecalculateUVDistributionMetric(int uvSetIndex, float uvAreaThreshold = 1E-09F);
        public void RecalculateUVDistributionMetrics(float uvAreaThreshold = 1E-09F);
        public void MarkDynamic();
        public void UploadMeshData(bool markNoLongerReadable);
        public void Optimize();
        public void OptimizeIndexBuffers();
        public void OptimizeReorderVertexBuffer();
        public MeshTopology GetTopology(int submesh);
        public void CombineMeshes(CombineInstance[] combine, [DefaultValue("true")] bool mergeSubMeshes, [DefaultValue("true")] bool useMatrices, [DefaultValue("false")] bool hasLightmapData);
        [ExcludeFromDocs]
        public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices);
        [ExcludeFromDocs]
        public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes);
        [ExcludeFromDocs]
        public void CombineMeshes(CombineInstance[] combine);
        [NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
        [StaticAccessor("MeshDataBindings", StaticAccessorType.DoubleColon)]
        public struct MeshData
        {

            public int vertexCount { get; }
            public int vertexBufferCount { get; }
            public IndexFormat indexFormat { get; }
            public int subMeshCount { get; set; }

            public int GetVertexBufferStride(int stream);
            public bool HasVertexAttribute(VertexAttribute attr);
            public int GetVertexAttributeDimension(VertexAttribute attr);
            public VertexAttributeFormat GetVertexAttributeFormat(VertexAttribute attr);
            public int GetVertexAttributeStream(VertexAttribute attr);
            public int GetVertexAttributeOffset(VertexAttribute attr);
            public void GetVertices(NativeArray<Vector3> outVertices);
            public void GetNormals(NativeArray<Vector3> outNormals);
            public void GetTangents(NativeArray<Vector4> outTangents);
            public void GetColors(NativeArray<Color> outColors);
            public void GetColors(NativeArray<Color32> outColors);
            public void GetUVs(int channel, NativeArray<Vector2> outUVs);
            public void GetUVs(int channel, NativeArray<Vector3> outUVs);
            public void GetUVs(int channel, NativeArray<Vector4> outUVs);
            public NativeArray<T> GetVertexData<T>([DefaultValue("0")] int stream = 0) where T : struct;
            public void SetVertexBufferParams(int vertexCount, params VertexAttributeDescriptor[] attributes);
            public void SetVertexBufferParams(int vertexCount, NativeArray<VertexAttributeDescriptor> attributes);
            public void SetIndexBufferParams(int indexCount, IndexFormat format);
            public void GetIndices(NativeArray<ushort> outIndices, int submesh, [DefaultValue("true")] bool applyBaseVertex = True);
            public void GetIndices(NativeArray<int> outIndices, int submesh, [DefaultValue("true")] bool applyBaseVertex = True);
            public NativeArray<T> GetIndexData<T>() where T : struct;
            public SubMeshDescriptor GetSubMesh(int index);
            public void SetSubMesh(int index, SubMeshDescriptor desc, MeshUpdateFlags flags = MeshUpdateFlags.Default);
        }
        [DefaultMember("Item")]
        [NativeContainer]
        [NativeContainerSupportsMinMaxWriteRestriction]
        [StaticAccessor("MeshDataArrayBindings", StaticAccessorType.DoubleColon)]
        public struct MeshDataArray : IDisposable
        {

            public MeshData this[int index] { get; }
            public int Length { get; }

            public void Dispose();
        }
    }
}
