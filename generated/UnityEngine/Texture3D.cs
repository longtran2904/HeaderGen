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
    [NativeHeader("Runtime/Graphics/Texture3D.h")]
    public sealed class Texture3D : Texture
    {
        [ExcludeFromDocs]
        public Texture3D(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags);
        [ExcludeFromDocs]
        [RequiredByNativeCode]
        public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags);
        [ExcludeFromDocs]
        public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, [DefaultValue("-1")] int mipCount);
        [ExcludeFromDocs]
        public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount);
        public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount, [DefaultValue("IntPtr.Zero")] nint nativeTex);
        [ExcludeFromDocs]
        public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain);
        public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, [DefaultValue("IntPtr.Zero")] nint nativeTex);

        public int depth { get; }
        public TextureFormat format { get; }
        public override bool isReadable { get; }

        [FreeFunction("Texture3DScripting::UpdateExternalTexture", HasExplicitThis = True)]
        public void UpdateExternalTexture(nint nativeTex);
        [FreeFunction(Name = "Texture3DScripting::GetPixels", ThrowsException = True, HasExplicitThis = True)]
        public Color[] GetPixels(int miplevel);
        public Color[] GetPixels();
        [FreeFunction(Name = "Texture3DScripting::GetPixels32", ThrowsException = True, HasExplicitThis = True)]
        public Color32[] GetPixels32(int miplevel);
        public Color32[] GetPixels32();
        [FreeFunction(Name = "Texture3DScripting::SetPixels", ThrowsException = True, HasExplicitThis = True)]
        public void SetPixels([Unmarshalled] Color[] colors, int miplevel);
        public void SetPixels(Color[] colors);
        [FreeFunction(Name = "Texture3DScripting::SetPixels32", ThrowsException = True, HasExplicitThis = True)]
        public void SetPixels32([Unmarshalled] Color32[] colors, int miplevel);
        public void SetPixels32(Color32[] colors);
        public static Texture3D CreateExternalTexture(int width, int height, int depth, TextureFormat format, bool mipChain, nint nativeTex);
        public void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable);
        [ExcludeFromDocs]
        public void Apply(bool updateMipmaps);
        [ExcludeFromDocs]
        public void Apply();
        [ExcludeFromDocs]
        public void SetPixel(int x, int y, int z, Color color);
        public void SetPixel(int x, int y, int z, Color color, [DefaultValue("0")] int mipLevel);
        [ExcludeFromDocs]
        public Color GetPixel(int x, int y, int z);
        public Color GetPixel(int x, int y, int z, [DefaultValue("0")] int mipLevel);
        [ExcludeFromDocs]
        public Color GetPixelBilinear(float u, float v, float w);
        public Color GetPixelBilinear(float u, float v, float w, [DefaultValue("0")] int mipLevel);
        public void SetPixelData<T>(T[] data, int mipLevel, [DefaultValue("0")] int sourceDataStartIndex = 0);
        public void SetPixelData<T>(NativeArray<T> data, int mipLevel, [DefaultValue("0")] int sourceDataStartIndex = 0) where T : struct;
        public NativeArray<T> GetPixelData<T>(int mipLevel) where T : struct;
    }
}
