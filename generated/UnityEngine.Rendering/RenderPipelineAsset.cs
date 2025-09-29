#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine.Rendering
{
    public abstract class RenderPipelineAsset : ScriptableObject
    {

        protected RenderPipelineAsset();

        public virtual int terrainBrushPassIndex { get; }
        public virtual string[] renderingLayerMaskNames { get; }
        public virtual string[] prefixedRenderingLayerMaskNames { get; }
        public virtual Material defaultMaterial { get; }
        public virtual Shader autodeskInteractiveShader { get; }
        public virtual Shader autodeskInteractiveTransparentShader { get; }
        public virtual Shader autodeskInteractiveMaskedShader { get; }
        public virtual Shader terrainDetailLitShader { get; }
        public virtual Shader terrainDetailGrassShader { get; }
        public virtual Shader terrainDetailGrassBillboardShader { get; }
        public virtual Material defaultParticleMaterial { get; }
        public virtual Material defaultLineMaterial { get; }
        public virtual Material defaultTerrainMaterial { get; }
        public virtual Material defaultUIMaterial { get; }
        public virtual Material defaultUIOverdrawMaterial { get; }
        public virtual Material defaultUIETC1SupportedMaterial { get; }
        public virtual Material default2DMaterial { get; }
        public virtual Material default2DMaskMaterial { get; }
        public virtual Shader defaultShader { get; }
        public virtual Shader defaultSpeedTree7Shader { get; }
        public virtual Shader defaultSpeedTree8Shader { get; }

        protected abstract RenderPipeline CreatePipeline();
        protected virtual void OnValidate();
        protected virtual void OnDisable();
    }
}
