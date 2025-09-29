#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Graphics/Mesh/MeshRenderer.h")]
    public class MeshRenderer : Renderer
    {

        public MeshRenderer();

        public Mesh additionalVertexStreams { get; set; }
        public Mesh enlightenVertexStream { get; set; }
        public int subMeshStartIndex { get; }
        public float scaleInLightmap { get; set; }
        public ReceiveGI receiveGI { get; set; }
        public bool stitchLightmapSeams { get; set; }
    }
}
