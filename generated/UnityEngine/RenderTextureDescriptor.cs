#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Rendering;

namespace UnityEngine
{
    public struct RenderTextureDescriptor
    {

        [ExcludeFromDocs]
        public RenderTextureDescriptor(int width, int height);
        [ExcludeFromDocs]
        public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat);
        [ExcludeFromDocs]
        public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits);
        [ExcludeFromDocs]
        public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits);
        [ExcludeFromDocs]
        public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits, int mipCount);
        public RenderTextureDescriptor(int width, int height, [DefaultValue("RenderTextureFormat.Default")] RenderTextureFormat colorFormat, [DefaultValue("0")] int depthBufferBits, [DefaultValue("Texture.GenerateAllMips")] int mipCount, [DefaultValue("RenderTextureReadWrite.Linear")] RenderTextureReadWrite readWrite);
        [ExcludeFromDocs]
        public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits, int mipCount);
        [ExcludeFromDocs]
        public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat);
        [ExcludeFromDocs]
        public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount);

        public int width { get; set; }
        public int height { get; set; }
        public int msaaSamples { get; set; }
        public int volumeDepth { get; set; }
        public int mipCount { get; set; }
        public GraphicsFormat graphicsFormat { get; set; }
        public GraphicsFormat stencilFormat { get; set; }
        public GraphicsFormat depthStencilFormat { get; set; }
        public RenderTextureFormat colorFormat { get; set; }
        public bool sRGB { get; set; }
        public int depthBufferBits { get; set; }
        public TextureDimension dimension { get; set; }
        public ShadowSamplingMode shadowSamplingMode { get; set; }
        public VRTextureUsage vrUsage { get; set; }
        public RenderTextureCreationFlags flags { get; }
        public RenderTextureMemoryless memoryless { get; set; }
        public bool useMipMap { get; set; }
        public bool autoGenerateMips { get; set; }
        public bool enableRandomWrite { get; set; }
        public bool bindMS { get; set; }
        public bool useDynamicScale { get; set; }
    }
}
