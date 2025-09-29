#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
    public struct TextureHandle
    {
        public static TextureHandle nullHandle { get; }

        public bool IsValid();
        public void SetFallBackResource(TextureHandle texture);

        public static implicit operator RenderTargetIdentifier(TextureHandle texture);
        public static implicit operator Texture(TextureHandle texture);
        public static implicit operator RenderTexture(TextureHandle texture);
        public static implicit operator RTHandle(TextureHandle texture);
    }
}
