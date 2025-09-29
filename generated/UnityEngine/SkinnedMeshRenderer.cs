#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Runtime/Graphics/Mesh/SkinnedMeshRenderer.h")]
    [RequiredByNativeCode]
    public class SkinnedMeshRenderer : Renderer
    {

        public SkinnedMeshRenderer();

        public SkinQuality quality { get; set; }
        public bool updateWhenOffscreen { get; set; }
        public bool forceMatrixRecalculationPerRender { get; set; }
        public Transform rootBone { get; set; }
        public Transform[] bones { get; set; }
        [NativeProperty("Mesh")]
        public Mesh sharedMesh { get; set; }
        [NativeProperty("SkinnedMeshMotionVectors")]
        public bool skinnedMotionVectors { get; set; }
        public GraphicsBuffer.Target vertexBufferTarget { get; set; }

        public float GetBlendShapeWeight(int index);
        public void SetBlendShapeWeight(int index, float value);
        public void BakeMesh(Mesh mesh);
        public void BakeMesh([NotNull("NullExceptionObject")] Mesh mesh, bool useScale);
        public GraphicsBuffer GetVertexBuffer();
        public GraphicsBuffer GetPreviousVertexBuffer();
    }
}
