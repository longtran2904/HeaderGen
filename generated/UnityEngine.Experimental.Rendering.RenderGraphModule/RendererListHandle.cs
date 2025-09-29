#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using UnityEngine.Rendering.RendererUtils;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
    public struct RendererListHandle
    {

        public bool IsValid();

        public static implicit operator int(RendererListHandle handle);
        public static implicit operator UnityEngine.Rendering.RendererUtils.RendererList(RendererListHandle rendererList);
    }
}
