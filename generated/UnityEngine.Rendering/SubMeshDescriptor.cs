#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine.Rendering
{
    public struct SubMeshDescriptor
    {

        public SubMeshDescriptor(int indexStart, int indexCount, MeshTopology topology = MeshTopology.Triangles);

        public Bounds bounds { get; set; }
        public MeshTopology topology { get; set; }
        public int indexStart { get; set; }
        public int indexCount { get; set; }
        public int baseVertex { get; set; }
        public int firstVertex { get; set; }
        public int vertexCount { get; set; }

        public override string ToString();
    }
}
