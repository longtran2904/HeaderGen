#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor
{
    [NativeAsStruct]
    [NativeType(Header = "Modules/AssetPipelineEditor/Public/VideoClipImporter.h")]
    [RequiredByNativeCode]
    public class VideoImporterTargetSettings
    {
        public bool enableTranscoding;
        public VideoCodec codec;
        [NativeName("resizeFormat")]
        public VideoResizeMode resizeMode;
        public VideoEncodeAspectRatio aspectRatio;
        public int customWidth;
        public int customHeight;
        public VideoBitrateMode bitrateMode;
        public VideoSpatialQuality spatialQuality;

        public VideoImporterTargetSettings();
    }
}
