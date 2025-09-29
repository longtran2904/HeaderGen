#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal
{
    public static class RenderingUtils
    {

        public static Mesh fullscreenMesh { get; }

        public static void SetViewAndProjectionMatrices(CommandBuffer cmd, Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, bool setInverseMatrices);
        public static bool SupportsRenderTextureFormat(RenderTextureFormat format);
        public static bool SupportsGraphicsFormat(GraphicsFormat format, FormatUsage usage);
    }
}
