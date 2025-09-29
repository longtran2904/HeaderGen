#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
    public struct RenderGraphParameters
    {

        public string executionName;
        public int currentFrameIndex;
        public bool rendererListCulling;
        public ScriptableRenderContext scriptableRenderContext;
        public CommandBuffer commandBuffer;
    }
}
