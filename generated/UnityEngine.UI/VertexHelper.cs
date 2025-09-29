#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
    public class VertexHelper : IDisposable
    {
        public VertexHelper();
        public VertexHelper(Mesh m);

        public int currentVertCount { get; }
        public int currentIndexCount { get; }

        public void Dispose();
        public void Clear();
        public void PopulateUIVertex(ref UIVertex vertex, int i);
        public void SetUIVertex(UIVertex vertex, int i);
        public void FillMesh(Mesh mesh);
        public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent);
        public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent);
        public void AddVert(Vector3 position, Color32 color, Vector4 uv0);
        public void AddVert(UIVertex v);
        public void AddTriangle(int idx0, int idx1, int idx2);
        public void AddUIVertexQuad(UIVertex[] verts);
        public void AddUIVertexStream(List<UIVertex> verts, List<int> indices);
        public void AddUIVertexTriangleStream(List<UIVertex> verts);
        public void GetUIVertexStream(List<UIVertex> stream);
    }
}
