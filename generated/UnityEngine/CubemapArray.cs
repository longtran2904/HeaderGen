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
    [NativeHeader("Runtime/Graphics/CubemapArrayTexture.h")]
    public sealed class CubemapArray : Texture
    {
        [ExcludeFromDocs]
        public CubemapArray(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags);
        [ExcludeFromDocs]
        [RequiredByNativeCode]
        public CubemapArray(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags);
        [ExcludeFromDocs]
        public CubemapArray(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, [DefaultValue("-1")] int mipCount);
        public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear);
        public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, [DefaultValue("false")] bool linear);
        [ExcludeFromDocs]
        public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain);

        public int cubemapCount { get; }
        public TextureFormat format { get; }
        public override bool isReadable { get; }

        [FreeFunction(Name = "CubemapArrayScripting::GetPixels", ThrowsException = True, HasExplicitThis = True)]
        public Color[] GetPixels(CubemapFace face, int arrayElement, int miplevel);
        public Color[] GetPixels(CubemapFace face, int arrayElement);
        [FreeFunction(Name = "CubemapArrayScripting::GetPixels32", ThrowsException = True, HasExplicitThis = True)]
        public Color32[] GetPixels32(CubemapFace face, int arrayElement, int miplevel);
        public Color32[] GetPixels32(CubemapFace face, int arrayElement);
        [FreeFunction(Name = "CubemapArrayScripting::SetPixels", ThrowsException = True, HasExplicitThis = True)]
        public void SetPixels([Unmarshalled] Color[] colors, CubemapFace face, int arrayElement, int miplevel);
        public void SetPixels(Color[] colors, CubemapFace face, int arrayElement);
        [FreeFunction(Name = "CubemapArrayScripting::SetPixels32", ThrowsException = True, HasExplicitThis = True)]
        public void SetPixels32([Unmarshalled] Color32[] colors, CubemapFace face, int arrayElement, int miplevel);
        public void SetPixels32(Color32[] colors, CubemapFace face, int arrayElement);
        public void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable);
        [ExcludeFromDocs]
        public void Apply(bool updateMipmaps);
        [ExcludeFromDocs]
        public void Apply();
        public void SetPixelData<T>(T[] data, int mipLevel, CubemapFace face, int element, [DefaultValue("0")] int sourceDataStartIndex = 0);
        public void SetPixelData<T>(NativeArray<T> data, int mipLevel, CubemapFace face, int element, [DefaultValue("0")] int sourceDataStartIndex = 0) where T : struct;
        public NativeArray<T> GetPixelData<T>(int mipLevel, CubemapFace face, int element) where T : struct;
    }
}
