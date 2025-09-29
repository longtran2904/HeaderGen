#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;

namespace UnityEngine
{
    [NativeHeader("Runtime/Graphics/SparseTexture.h")]
    public sealed class SparseTexture : Texture
    {
        [ExcludeFromDocs]
        public SparseTexture(int width, int height, DefaultFormat format, int mipCount);
        [ExcludeFromDocs]
        public SparseTexture(int width, int height, GraphicsFormat format, int mipCount);
        [ExcludeFromDocs]
        public SparseTexture(int width, int height, TextureFormat textureFormat, int mipCount);
        public SparseTexture(int width, int height, TextureFormat textureFormat, int mipCount, [DefaultValue("false")] bool linear);

        public int tileWidth { get; }
        public int tileHeight { get; }
        public bool isCreated { get; }

        [FreeFunction(Name = "SparseTextureScripting::UpdateTile", HasExplicitThis = True)]
        public void UpdateTile(int tileX, int tileY, int miplevel, [Unmarshalled] Color32[] data);
        [FreeFunction(Name = "SparseTextureScripting::UpdateTileRaw", HasExplicitThis = True)]
        public void UpdateTileRaw(int tileX, int tileY, int miplevel, [Unmarshalled] byte[] data);
        public void UnloadTile(int tileX, int tileY, int miplevel);
    }
}
