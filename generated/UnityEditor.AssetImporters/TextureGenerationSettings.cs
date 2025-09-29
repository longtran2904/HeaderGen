#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.AssetImporters
{
    [MovedFrom("UnityEditor.Experimental.AssetImporters")]
    public struct TextureGenerationSettings
    {

        public TextureGenerationSettings(TextureImporterType type);

        public string assetPath { get; set; }
        public bool qualifyForSpritePacking { get; set; }
        public bool enablePostProcessor { get; set; }
        public TextureImporterSettings textureImporterSettings { get; set; }
        public TextureImporterPlatformSettings platformSettings { get; set; }
        public SourceTextureInformation sourceTextureInformation { get; set; }
        public SpriteImportData[] spriteImportData { get; set; }
        public string spritePackingTag { get; set; }
        public SecondarySpriteTexture[] secondarySpriteTextures { get; set; }
    }
}
