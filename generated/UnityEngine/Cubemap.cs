#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [ExcludeFromPreset]
    [NativeHeader("Runtime/Graphics/CubemapTexture.h")]
    public sealed class Cubemap : Texture
    {
        [ExcludeFromDocs]
        public Cubemap(int width, DefaultFormat format, TextureCreationFlags flags);
        [ExcludeFromDocs]
        [RequiredByNativeCode]
        public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags);
        public Cubemap(int width, TextureFormat format, int mipCount);
        [ExcludeFromDocs]
        public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount);
        public Cubemap(int width, TextureFormat textureFormat, bool mipChain);

        public TextureFormat format { get; }
        public override bool isReadable { get; }
        public bool streamingMipmaps { get; }
        public int streamingMipmapsPriority { get; }
        public int requestedMipmapLevel { get; set; }
        public int desiredMipmapLevel { get; }
        public int loadingMipmapLevel { get; }
        public int loadedMipmapLevel { get; }

        [FreeFunction("CubemapScripting::UpdateExternalTexture", HasExplicitThis = True)]
        public void UpdateExternalTexture(nint nativeTexture);
        [NativeName("FixupEdges")]
        public void SmoothEdges([DefaultValue("1")] int smoothRegionWidthInPixels);
        public void SmoothEdges();
        [FreeFunction(Name = "CubemapScripting::GetPixels", ThrowsException = True, HasExplicitThis = True)]
        public Color[] GetPixels(CubemapFace face, int miplevel);
        public Color[] GetPixels(CubemapFace face);
        [FreeFunction(Name = "CubemapScripting::SetPixels", ThrowsException = True, HasExplicitThis = True)]
        public void SetPixels([Unmarshalled] Color[] colors, CubemapFace face, int miplevel);
        public void SetPixels(Color[] colors, CubemapFace face);
        [FreeFunction(Name = "GetTextureStreamingManager().ClearRequestedMipmapLevel", HasExplicitThis = True)]
        public void ClearRequestedMipmapLevel();
        [FreeFunction(Name = "GetTextureStreamingManager().IsRequestedMipmapLevelLoaded", HasExplicitThis = True)]
        public bool IsRequestedMipmapLevelLoaded();
        public static Cubemap CreateExternalTexture(int width, TextureFormat format, bool mipmap, nint nativeTex);
        public void SetPixelData<T>(T[] data, int mipLevel, CubemapFace face, [DefaultValue("0")] int sourceDataStartIndex = 0);
        public void SetPixelData<T>(NativeArray<T> data, int mipLevel, CubemapFace face, [DefaultValue("0")] int sourceDataStartIndex = 0) where T : struct;
        public NativeArray<T> GetPixelData<T>(int mipLevel, CubemapFace face) where T : struct;
        [ExcludeFromDocs]
        public void SetPixel(CubemapFace face, int x, int y, Color color);
        public void SetPixel(CubemapFace face, int x, int y, Color color, [DefaultValue("0")] int mip);
        [ExcludeFromDocs]
        public Color GetPixel(CubemapFace face, int x, int y);
        public Color GetPixel(CubemapFace face, int x, int y, [DefaultValue("0")] int mip);
        public void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable);
        [ExcludeFromDocs]
        public void Apply(bool updateMipmaps);
        [ExcludeFromDocs]
        public void Apply();
    }
}
