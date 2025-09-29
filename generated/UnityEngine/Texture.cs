#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Runtime/Streaming/TextureStreamingManager.h")]
    [NativeHeader("Runtime/Graphics/Texture.h")]
    [UsedByNativeCode]
    public class Texture : Object
    {

        public static readonly int GenerateAllMips;

        protected Texture();

        [NativeProperty("GlobalMasterTextureLimit")]
        public static int masterTextureLimit { get; set; }
        public int mipmapCount { get; }
        [NativeProperty("AnisoLimit")]
        public static AnisotropicFiltering anisotropicFiltering { get; set; }
        public virtual GraphicsFormat graphicsFormat { get; }
        public virtual int width { get; set; }
        public virtual int height { get; set; }
        public virtual TextureDimension dimension { get; set; }
        public virtual bool isReadable { get; }
        public TextureWrapMode wrapMode { get; set; }
        public TextureWrapMode wrapModeU { get; set; }
        public TextureWrapMode wrapModeV { get; set; }
        public TextureWrapMode wrapModeW { get; set; }
        public FilterMode filterMode { get; set; }
        public int anisoLevel { get; set; }
        public float mipMapBias { get; set; }
        public Vector2 texelSize { get; }
        public uint updateCount { get; }
        public bool isDataSRGB { get; }
        public Hash128 imageContentsHash { get; set; }
        public static ulong totalTextureMemory { get; }
        public static ulong desiredTextureMemory { get; }
        public static ulong targetTextureMemory { get; }
        public static ulong currentTextureMemory { get; }
        public static ulong nonStreamingTextureMemory { get; }
        public static ulong streamingMipmapUploadCount { get; }
        public static ulong streamingRendererCount { get; }
        public static ulong streamingTextureCount { get; }
        public static ulong nonStreamingTextureCount { get; }
        public static ulong streamingTexturePendingLoadCount { get; }
        public static ulong streamingTextureLoadingCount { get; }
        public static bool streamingTextureForceLoadAll { get; set; }
        public static bool streamingTextureDiscardUnusedMips { get; set; }
        public static bool allowThreadedTextureCreation { get; set; }

        [NativeName("SetGlobalAnisoLimits")]
        public static void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax);
        public nint GetNativeTexturePtr();
        [Obsolete("Use GetNativeTexturePtr instead.", False)]
        public int GetNativeTextureID();
        public void IncrementUpdateCount();
        [FreeFunction("GetTextureStreamingManager().SetStreamingTextureMaterialDebugProperties")]
        public static void SetStreamingTextureMaterialDebugProperties();
    }
}
