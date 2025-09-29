#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Runtime/Graphics/GeneratedTextures.h")]
    [NativeHeader("Runtime/Graphics/Texture2D.h")]
    [UsedByNativeCode]
    public sealed class Texture2D : Texture
    {
        [ExcludeFromDocs]
        public Texture2D(int width, int height, DefaultFormat format, TextureCreationFlags flags);
        [ExcludeFromDocs]
        public Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags);
        [ExcludeFromDocs]
        public Texture2D(int width, int height, GraphicsFormat format, int mipCount, TextureCreationFlags flags);
        public Texture2D(int width, int height, [DefaultValue("TextureFormat.RGBA32")] TextureFormat textureFormat, [DefaultValue("-1")] int mipCount, [DefaultValue("false")] bool linear);
        public Texture2D(int width, int height, [DefaultValue("TextureFormat.RGBA32")] TextureFormat textureFormat, [DefaultValue("true")] bool mipChain, [DefaultValue("false")] bool linear);
        [ExcludeFromDocs]
        public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain);
        [ExcludeFromDocs]
        public Texture2D(int width, int height);

        public TextureFormat format { get; }
        public bool ignoreMipmapLimit { get; set; }
        [StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
        public static Texture2D whiteTexture { get; }
        [StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
        public static Texture2D blackTexture { get; }
        [StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
        public static Texture2D redTexture { get; }
        [StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
        public static Texture2D grayTexture { get; }
        [StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
        public static Texture2D linearGrayTexture { get; }
        [StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
        public static Texture2D normalTexture { get; }
        public override bool isReadable { get; }
        [NativeConditional("ENABLE_VIRTUALTEXTURING && UNITY_EDITOR")]
        [NativeName("VTOnly")]
        public bool vtOnly { get; }
        public bool streamingMipmaps { get; }
        public int streamingMipmapsPriority { get; }
        public int requestedMipmapLevel { get; set; }
        public int minimumMipmapLevel { get; set; }
        public int calculatedMipmapLevel { get; }
        public int desiredMipmapLevel { get; }
        public int loadingMipmapLevel { get; }
        public int loadedMipmapLevel { get; }
        public bool alphaIsTransparency { get; set; }

        public void Compress(bool highQuality);
        [FreeFunction(Name = "GetTextureStreamingManager().ClearRequestedMipmapLevel", HasExplicitThis = True)]
        public void ClearRequestedMipmapLevel();
        [FreeFunction(Name = "GetTextureStreamingManager().IsRequestedMipmapLevelLoaded", HasExplicitThis = True)]
        public bool IsRequestedMipmapLevelLoaded();
        [FreeFunction(Name = "GetTextureStreamingManager().ClearMinimumMipmapLevel", HasExplicitThis = True)]
        public void ClearMinimumMipmapLevel();
        [FreeFunction("Texture2DScripting::UpdateExternalTexture", HasExplicitThis = True)]
        public void UpdateExternalTexture(nint nativeTex);
        [FreeFunction("Texture2DScripting::GetRawTextureData", ThrowsException = True, HasExplicitThis = True)]
        public byte[] GetRawTextureData();
        [FreeFunction("Texture2DScripting::GetPixels", ThrowsException = True, HasExplicitThis = True)]
        public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, [DefaultValue("0")] int miplevel);
        [ExcludeFromDocs]
        public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight);
        [FreeFunction("Texture2DScripting::GetPixels32", ThrowsException = True, HasExplicitThis = True)]
        public Color32[] GetPixels32([DefaultValue("0")] int miplevel);
        [ExcludeFromDocs]
        public Color32[] GetPixels32();
        [FreeFunction("Texture2DScripting::PackTextures", HasExplicitThis = True)]
        public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable);
        public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize);
        public Rect[] PackTextures(Texture2D[] textures, int padding);
        public static Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipChain, bool linear, nint nativeTex);
        [ExcludeFromDocs]
        public void SetPixel(int x, int y, Color color);
        public void SetPixel(int x, int y, Color color, [DefaultValue("0")] int mipLevel);
        public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, [DefaultValue("0")] int miplevel);
        [ExcludeFromDocs]
        public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors);
        public void SetPixels(Color[] colors, [DefaultValue("0")] int miplevel);
        [ExcludeFromDocs]
        public void SetPixels(Color[] colors);
        [ExcludeFromDocs]
        public Color GetPixel(int x, int y);
        public Color GetPixel(int x, int y, [DefaultValue("0")] int mipLevel);
        [ExcludeFromDocs]
        public Color GetPixelBilinear(float u, float v);
        public Color GetPixelBilinear(float u, float v, [DefaultValue("0")] int mipLevel);
        public void LoadRawTextureData(nint data, int size);
        public void LoadRawTextureData(byte[] data);
        public void LoadRawTextureData<T>(NativeArray<T> data) where T : struct;
        public void SetPixelData<T>(T[] data, int mipLevel, [DefaultValue("0")] int sourceDataStartIndex = 0);
        public void SetPixelData<T>(NativeArray<T> data, int mipLevel, [DefaultValue("0")] int sourceDataStartIndex = 0) where T : struct;
        public NativeArray<T> GetPixelData<T>(int mipLevel) where T : struct;
        public NativeArray<T> GetRawTextureData<T>() where T : struct;
        public void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable);
        [ExcludeFromDocs]
        public void Apply(bool updateMipmaps);
        [ExcludeFromDocs]
        public void Apply();
        public bool Reinitialize(int width, int height);
        public bool Reinitialize(int width, int height, TextureFormat format, bool hasMipMap);
        public bool Reinitialize(int width, int height, GraphicsFormat format, bool hasMipMap);
        [Obsolete("Texture2D.Resize(int, int) has been deprecated because it actually reinitializes the texture. Use Texture2D.Reinitialize(int, int) instead (UnityUpgradable) -> Reinitialize([*] System.Int32, [*] System.Int32)", False)]
        public bool Resize(int width, int height);
        [Obsolete("Texture2D.Resize(int, int, TextureFormat, bool) has been deprecated because it actually reinitializes the texture. Use Texture2D.Reinitialize(int, int, TextureFormat, bool) instead (UnityUpgradable) -> Reinitialize([*] System.Int32, [*] System.Int32, UnityEngine.TextureFormat, [*] System.Boolean)", False)]
        public bool Resize(int width, int height, TextureFormat format, bool hasMipMap);
        [Obsolete("Texture2D.Resize(int, int, GraphicsFormat, bool) has been deprecated because it actually reinitializes the texture. Use Texture2D.Reinitialize(int, int, GraphicsFormat, bool) instead (UnityUpgradable) -> Reinitialize([*] System.Int32, [*] System.Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, [*] System.Boolean)", False)]
        public bool Resize(int width, int height, GraphicsFormat format, bool hasMipMap);
        public void ReadPixels(Rect source, int destX, int destY, [DefaultValue("true")] bool recalculateMipMaps);
        [ExcludeFromDocs]
        public void ReadPixels(Rect source, int destX, int destY);
        public static bool GenerateAtlas(Vector2[] sizes, int padding, int atlasSize, List<Rect> results);
        public void SetPixels32(Color32[] colors, [DefaultValue("0")] int miplevel);
        [ExcludeFromDocs]
        public void SetPixels32(Color32[] colors);
        public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, [DefaultValue("0")] int miplevel);
        [ExcludeFromDocs]
        public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors);
        public Color[] GetPixels([DefaultValue("0")] int miplevel);
        [ExcludeFromDocs]
        public Color[] GetPixels();

        [Flags]
        public enum EXRFlags
        {
            None = 0,
            OutputAsFloat = 1,
            CompressZIP = 2,
            CompressRLE = 4,
            CompressPIZ = 8
        }
    }
}
