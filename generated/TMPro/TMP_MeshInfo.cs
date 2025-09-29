#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace TMPro
{
    public struct TMP_MeshInfo
    {
        public Mesh mesh;
        public int vertexCount;
        public Vector3[] vertices;
        public Vector3[] normals;
        public Vector4[] tangents;
        public Vector2[] uvs0;
        public Vector2[] uvs2;
        public Color32[] colors32;
        public int[] triangles;
        public Material material;

        public TMP_MeshInfo(Mesh mesh, int size);
        public TMP_MeshInfo(Mesh mesh, int size, bool isVolumetric);

        public void ResizeMeshInfo(int size);
        public void ResizeMeshInfo(int size, bool isVolumetric);
        public void Clear();
        public void Clear(bool uploadChanges);
        public void ClearUnusedVertices();
        public void ClearUnusedVertices(int startIndex);
        public void ClearUnusedVertices(int startIndex, bool updateMesh);
        public void SortGeometry(VertexSortingOrder order);
        public void SortGeometry(IList<int> sortingOrder);
        public void SwapVertexData(int src, int dst);
    }
}
