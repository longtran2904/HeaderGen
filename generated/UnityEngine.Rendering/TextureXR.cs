#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering
{
    public static class TextureXR
    {
        public static int maxViews { set; }
        public static int slices { get; }
        public static bool useTexArray { get; }
        public static TextureDimension dimension { get; }

        public static RTHandle GetBlackUIntTexture();
        public static RTHandle GetClearTexture();
        public static RTHandle GetMagentaTexture();
        public static RTHandle GetBlackTexture();
        public static RTHandle GetBlackTextureArray();
        public static RTHandle GetBlackTexture3D();
        public static RTHandle GetWhiteTexture();
        public static void Initialize(CommandBuffer cmd, ComputeShader clearR32_UIntShader);
    }
}
