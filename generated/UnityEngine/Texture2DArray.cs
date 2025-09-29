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
    [NativeHeader("Runtime/Graphics/Texture2DArray.h")]
    public sealed class Texture2DArray : Texture
    {

        [ExcludeFromDocs]
        public Texture2DArray(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags);
        [ExcludeFromDocs]
        [RequiredByNativeCode]
        public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags);
        [ExcludeFromDocs]
        public Texture2DArray(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount);
        public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear);
        public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, [DefaultValue("false")] bool linear);
        [ExcludeFromDocs]
        public Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain);

        public static int allSlices { get; }
        public int depth { get; }
        public TextureFormat format { get; }
        public override bool isReadable { get; }

        [FreeFunction(Name = "Texture2DArrayScripting::GetPixels", ThrowsException = True, HasExplicitThis = True)]
        public Color[] GetPixels(int arrayElement, int miplevel);
        public Color[] GetPixels(int arrayElement);
        [FreeFunction(Name = "Texture2DArrayScripting::GetPixels32", ThrowsException = True, HasExplicitThis = True)]
        public Color32[] GetPixels32(int arrayElement, int miplevel);
        public Color32[] GetPixels32(int arrayElement);
        [FreeFunction(Name = "Texture2DArrayScripting::SetPixels", ThrowsException = True, HasExplicitThis = True)]
        public void SetPixels([Unmarshalled] Color[] colors, int arrayElement, int miplevel);
        public void SetPixels(Color[] colors, int arrayElement);
        [FreeFunction(Name = "Texture2DArrayScripting::SetPixels32", ThrowsException = True, HasExplicitThis = True)]
        public void SetPixels32([Unmarshalled] Color32[] colors, int arrayElement, int miplevel);
        public void SetPixels32(Color32[] colors, int arrayElement);
        public void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable);
        [ExcludeFromDocs]
        public void Apply(bool updateMipmaps);
        [ExcludeFromDocs]
        public void Apply();
        public void SetPixelData<T>(T[] data, int mipLevel, int element, [DefaultValue("0")] int sourceDataStartIndex = 0);
        public void SetPixelData<T>(NativeArray<T> data, int mipLevel, int element, [DefaultValue("0")] int sourceDataStartIndex = 0) where T : struct;
        public NativeArray<T> GetPixelData<T>(int mipLevel, int element) where T : struct;
    }
}
