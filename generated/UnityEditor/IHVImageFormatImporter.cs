#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/AssetPipeline/TextureImporting/IHVImageFormatImporter.h")]
    public sealed class IHVImageFormatImporter : AssetImporter
    {
        public IHVImageFormatImporter();

        public bool isReadable { get; set; }
        public FilterMode filterMode { get; set; }
        public TextureWrapMode wrapMode { get; set; }
        [NativeName("WrapU")]
        public TextureWrapMode wrapModeU { get; set; }
        [NativeName("WrapV")]
        public TextureWrapMode wrapModeV { get; set; }
        [NativeName("WrapW")]
        public TextureWrapMode wrapModeW { get; set; }
        [NativeConditional("ENABLE_TEXTURE_STREAMING")]
        public bool streamingMipmaps { get; set; }
        [NativeConditional("ENABLE_TEXTURE_STREAMING")]
        public int streamingMipmapsPriority { get; set; }
    }
}
