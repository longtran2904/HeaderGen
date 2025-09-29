#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeAsStruct]
    [NativeHeader("Editor/Src/AssetPipeline/TextureImporting/TextureImporter.bindings.h")]
    [NativeType(CodegenOptions.Custom, "TextureImporterPlatformSettings_Marshalling")]
    public sealed class TextureImporterPlatformSettings
    {
        public TextureImporterPlatformSettings();

        public string name { get; set; }
        public bool overridden { get; set; }
        public int maxTextureSize { get; set; }
        public TextureResizeAlgorithm resizeAlgorithm { get; set; }
        public TextureImporterFormat format { get; set; }
        public TextureImporterCompression textureCompression { get; set; }
        public int compressionQuality { get; set; }
        public bool crunchedCompression { get; set; }
        public bool allowsAlphaSplitting { get; set; }
        public AndroidETC2FallbackOverride androidETC2FallbackOverride { get; set; }

        public void CopyTo(TextureImporterPlatformSettings target);
    }
}
