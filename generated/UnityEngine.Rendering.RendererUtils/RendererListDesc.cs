#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine.Rendering.RendererUtils
{
    public struct RendererListDesc
    {

        public SortingCriteria sortingCriteria;
        public PerObjectData rendererConfiguration;
        public RenderQueueRange renderQueueRange;
        public RenderStateBlock? stateBlock;
        public Material overrideMaterial;
        public bool excludeObjectMotionVectors;
        public int layerMask;
        public int overrideMaterialPassIndex;

        public RendererListDesc(ShaderTagId passName, CullingResults cullingResult, Camera camera);
        public RendererListDesc(ShaderTagId[] passNames, CullingResults cullingResult, Camera camera);

        public bool IsValid();
    }
}
