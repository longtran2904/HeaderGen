#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.U2D;

namespace UnityEditor.U2D
{
    [NativeHeader("Editor/Src/2D/SpriteAtlas/SpriteAtlasAsset.h")]
    [NativeType(Header = "Editor/Src/2D/SpriteAtlas/SpriteAtlasAsset.h")]
    public class SpriteAtlasAsset : UnityEngine.Object
    {

        public SpriteAtlasAsset();

        public bool isVariant { get; }

        public void SetIsVariant(bool value);
        public void SetMasterAtlas(SpriteAtlas atlas);
        public void SetIncludeInBuild(bool value);
        public bool IsIncludeInBuild();
        public SpriteAtlas GetMasterAtlas();
        public void SetVariantScale(float value);
        public void SetPlatformSettings(TextureImporterPlatformSettings src);
        public TextureImporterPlatformSettings GetPlatformSettings(string buildTarget);
        public SpriteAtlasTextureSettings GetTextureSettings();
        public void SetTextureSettings(SpriteAtlasTextureSettings src);
        public SpriteAtlasPackingSettings GetPackingSettings();
        public void SetPackingSettings(SpriteAtlasPackingSettings src);
        public void Add(UnityEngine.Object[] objects);
        public void Remove(UnityEngine.Object[] objects);
        public static SpriteAtlasAsset Load(string assetPath);
        public static void Save(SpriteAtlasAsset asset, string assetPath);
    }
}
