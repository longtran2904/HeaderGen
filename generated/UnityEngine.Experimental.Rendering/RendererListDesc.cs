#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering
{
    [Obsolete("Use the updated RendererList API which is defined in the UnityEngine.Rendering.RendererUtils namespace.")]
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
