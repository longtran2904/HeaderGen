#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Runtime/Graphics/RenderTexture.h")]
    [NativeHeader("Runtime/Camera/Camera.h")]
    [NativeHeader("Runtime/Graphics/RenderBufferManager.h")]
    [NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
    [UsedByNativeCode]
    public class RenderTexture : Texture
    {

        [RequiredByNativeCode]
        protected internal RenderTexture();
        public RenderTexture(RenderTextureDescriptor desc);
        public RenderTexture(RenderTexture textureToCopy);
        [ExcludeFromDocs]
        public RenderTexture(int width, int height, int depth, DefaultFormat format);
        [ExcludeFromDocs]
        public RenderTexture(int width, int height, int depth, GraphicsFormat format);
        [ExcludeFromDocs]
        public RenderTexture(int width, int height, int depth, GraphicsFormat format, int mipCount);
        [ExcludeFromDocs]
        public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount);
        [ExcludeFromDocs]
        public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat);
        public RenderTexture(int width, int height, int depth, [DefaultValue("RenderTextureFormat.Default")] RenderTextureFormat format, [DefaultValue("RenderTextureReadWrite.Default")] RenderTextureReadWrite readWrite);
        [ExcludeFromDocs]
        public RenderTexture(int width, int height, int depth, RenderTextureFormat format);
        [ExcludeFromDocs]
        public RenderTexture(int width, int height, int depth);
        [ExcludeFromDocs]
        public RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount);

        public override int width { get; set; }
        public override int height { get; set; }
        public override TextureDimension dimension { get; set; }
        [NativeProperty("ColorFormat")]
        public GraphicsFormat graphicsFormat { get; set; }
        [NativeProperty("MipMap")]
        public bool useMipMap { get; set; }
        [NativeProperty("SRGBReadWrite")]
        public bool sRGB { get; }
        [NativeProperty("VRUsage")]
        public VRTextureUsage vrUsage { get; set; }
        [NativeProperty("Memoryless")]
        public RenderTextureMemoryless memorylessMode { get; set; }
        public RenderTextureFormat format { get; set; }
        public GraphicsFormat stencilFormat { get; set; }
        public GraphicsFormat depthStencilFormat { get; set; }
        public bool autoGenerateMips { get; set; }
        public int volumeDepth { get; set; }
        public int antiAliasing { get; set; }
        public bool bindTextureMS { get; set; }
        public bool enableRandomWrite { get; set; }
        public bool useDynamicScale { get; set; }
        public bool isPowerOfTwo { get; set; }
        public static RenderTexture active { get; set; }
        public RenderBuffer colorBuffer { get; }
        public RenderBuffer depthBuffer { get; }
        public int depth { get; set; }
        public RenderTextureDescriptor descriptor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use RenderTexture.autoGenerateMips instead (UnityUpgradable) -> autoGenerateMips", False)]
        public bool generateMips { get; set; }
        [Obsolete("Use RenderTexture.dimension instead.", False)]
        public bool isCubemap { get; set; }
        [Obsolete("Use RenderTexture.dimension instead.", False)]
        public bool isVolume { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("RenderTexture.enabled is always now, no need to use it.", False)]
        public static bool enabled { get; set; }

        public nint GetNativeDepthBufferPtr();
        public void DiscardContents(bool discardColor, bool discardDepth);
        [Obsolete("This function has no effect.", False)]
        public void MarkRestoreExpected();
        public void DiscardContents();
        public void ResolveAntiAliasedSurface();
        public void ResolveAntiAliasedSurface(RenderTexture target);
        [FreeFunction(Name = "RenderTextureScripting::SetGlobalShaderProperty", HasExplicitThis = True)]
        public void SetGlobalShaderProperty(string propertyName);
        public bool Create();
        public void Release();
        public bool IsCreated();
        public void GenerateMips();
        [NativeThrows]
        public void ConvertToEquirect(RenderTexture equirect, Camera.MonoOrStereoscopicEye eye = Camera.MonoOrStereoscopicEye.Mono);
        [FreeFunction("RenderTextureSupportsStencil")]
        public static bool SupportsStencil(RenderTexture rt);
        [FreeFunction("GetRenderBufferManager().GetTextures().ReleaseTempBuffer")]
        public static void ReleaseTemporary(RenderTexture temp);
        public static RenderTexture GetTemporary(RenderTextureDescriptor desc);
        [ExcludeFromDocs]
        public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, [DefaultValue("1")] int antiAliasing, [DefaultValue("RenderTextureMemoryless.None")] RenderTextureMemoryless memorylessMode, [DefaultValue("VRTextureUsage.None")] VRTextureUsage vrUsage, [DefaultValue("false")] bool useDynamicScale);
        [ExcludeFromDocs]
        public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage);
        [ExcludeFromDocs]
        public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode);
        [ExcludeFromDocs]
        public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing);
        [ExcludeFromDocs]
        public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format);
        public static RenderTexture GetTemporary(int width, int height, [DefaultValue("0")] int depthBuffer, [DefaultValue("RenderTextureFormat.Default")] RenderTextureFormat format, [DefaultValue("RenderTextureReadWrite.Default")] RenderTextureReadWrite readWrite, [DefaultValue("1")] int antiAliasing, [DefaultValue("RenderTextureMemoryless.None")] RenderTextureMemoryless memorylessMode, [DefaultValue("VRTextureUsage.None")] VRTextureUsage vrUsage, [DefaultValue("false")] bool useDynamicScale);
        [ExcludeFromDocs]
        public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage);
        [ExcludeFromDocs]
        public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode);
        [ExcludeFromDocs]
        public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing);
        [ExcludeFromDocs]
        public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite);
        [ExcludeFromDocs]
        public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format);
        [ExcludeFromDocs]
        public static RenderTexture GetTemporary(int width, int height, int depthBuffer);
        [ExcludeFromDocs]
        public static RenderTexture GetTemporary(int width, int height);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("UsSetBorderColor is no longer supported.", True)]
        public void SetBorderColor(Color color);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("GetTexelOffset always returns zero now, no point in using it.", False)]
        public Vector2 GetTexelOffset();
    }
}
