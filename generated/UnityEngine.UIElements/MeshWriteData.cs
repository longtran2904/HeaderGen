#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using Unity.Collections;

namespace UnityEngine.UIElements
{
    public class MeshWriteData
    {

        public int vertexCount { get; }
        public int indexCount { get; }
        public Rect uvRegion { get; }

        public void SetNextVertex(Vertex vertex);
        public void SetNextIndex(ushort index);
        public void SetAllVertices(Vertex[] vertices);
        public void SetAllVertices(NativeSlice<Vertex> vertices);
        public void SetAllIndices(ushort[] indices);
        public void SetAllIndices(NativeSlice<ushort> indices);
    }
}
