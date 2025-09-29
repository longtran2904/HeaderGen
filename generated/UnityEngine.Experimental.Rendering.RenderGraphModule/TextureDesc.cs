#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
    public struct TextureDesc
    {

        public TextureSizeMode sizeMode;
        public int width;
        public int height;
        public int slices;
        public Vector2 scale;
        public ScaleFunc func;
        public DepthBits depthBufferBits;
        public GraphicsFormat colorFormat;
        public FilterMode filterMode;
        public TextureWrapMode wrapMode;
        public TextureDimension dimension;
        public bool enableRandomWrite;
        public bool useMipMap;
        public bool autoGenerateMips;
        public bool isShadowMap;
        public int anisoLevel;
        public float mipMapBias;
        public MSAASamples msaaSamples;
        public bool bindTextureMS;
        public bool useDynamicScale;
        public RenderTextureMemoryless memoryless;
        public string name;
        public FastMemoryDesc fastMemoryDesc;
        public bool fallBackToBlackTexture;
        public bool clearBuffer;
        public Color clearColor;

        public TextureDesc(int width, int height, bool dynamicResolution = False, bool xrReady = False);
        public TextureDesc(Vector2 scale, bool dynamicResolution = False, bool xrReady = False);
        public TextureDesc(ScaleFunc func, bool dynamicResolution = False, bool xrReady = False);
        public TextureDesc(TextureDesc input);

        public override int GetHashCode();
    }
}
