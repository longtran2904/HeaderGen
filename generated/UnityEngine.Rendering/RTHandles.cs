#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
    public static class RTHandles
    {

        public static int maxWidth { get; }
        public static int maxHeight { get; }
        public static RTHandleProperties rtHandleProperties { get; }

        public static RTHandle Alloc(int width, int height, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, string name = "");
        public static RTHandle Alloc(int width, int height, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW = TextureWrapMode.Repeat, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, string name = "");
        public static RTHandle Alloc(Vector2 scaleFactor, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, string name = "");
        public static RTHandle Alloc(ScaleFunc scaleFunc, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, string name = "");
        public static RTHandle Alloc(Texture tex);
        public static RTHandle Alloc(RenderTexture tex);
        public static RTHandle Alloc(RenderTargetIdentifier tex);
        public static RTHandle Alloc(RenderTargetIdentifier tex, string name);
        public static void Initialize(int width, int height);
        public static void Release(RTHandle rth);
        public static void SetHardwareDynamicResolutionState(bool hwDynamicResRequested);
        public static void SetReferenceSize(int width, int height);
        public static void ResetReferenceSize(int width, int height);
        public static Vector2 CalculateRatioAgainstMaxSize(int width, int height);
    }
}
