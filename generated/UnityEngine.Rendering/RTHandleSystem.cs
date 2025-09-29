#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
    public class RTHandleSystem : IDisposable
    {
        public RTHandleSystem();

        public RTHandleProperties rtHandleProperties { get; }

        public void Dispose();
        public void Initialize(int width, int height);
        public void Release(RTHandle rth);
        public void ResetReferenceSize(int width, int height);
        public void SetReferenceSize(int width, int height);
        public void SetReferenceSize(int width, int height, bool reset);
        public void SetHardwareDynamicResolutionState(bool enableHWDynamicRes);
        public int GetMaxWidth();
        public int GetMaxHeight();
        public RTHandle Alloc(int width, int height, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, string name = "");
        public RTHandle Alloc(int width, int height, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW = TextureWrapMode.Repeat, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, string name = "");
        public RTHandle Alloc(Vector2 scaleFactor, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, string name = "");
        public RTHandle Alloc(ScaleFunc scaleFunc, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, string name = "");
        public RTHandle Alloc(RenderTexture texture);
        public RTHandle Alloc(Texture texture);
        public RTHandle Alloc(RenderTargetIdentifier texture);
        public RTHandle Alloc(RenderTargetIdentifier texture, string name);
    }
}
