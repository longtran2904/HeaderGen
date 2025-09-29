#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeConditional("ENABLE_VIDEO")]
    [NativeHeader("Modules/AssetPipelineEditor/Public/VideoClipImporter.h")]
    [NativeHeader("Modules/AssetPipelineEditor/Public/VideoClipImporter.bindings.h")]
    public class VideoClipImporter : AssetImporter
    {

        public VideoClipImporter();

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("VideoClipImporter.quality has no effect anymore (was only used for MovieTexture which is removed)", False)]
        public float quality { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("VideoClipImporter.linearColor has no effect anymore (was only used for MovieTexture which is removed)", False)]
        public bool linearColor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("VideoClipImporter.useLegacyImporter has no effect anymore (was only used for MovieTexture which is removed)", False)]
        public bool useLegacyImporter { get; set; }
        public ulong sourceFileSize { get; }
        public ulong outputFileSize { get; }
        public int frameCount { get; }
        public double frameRate { get; }
        [NativeProperty("EncodeAlpha")]
        public bool keepAlpha { get; set; }
        public bool sourceHasAlpha { get; }
        [NativeProperty("Deinterlace")]
        public VideoDeinterlaceMode deinterlaceMode { get; set; }
        public bool flipVertical { get; set; }
        public bool flipHorizontal { get; set; }
        public bool importAudio { get; set; }
        [NativeName("sRGBClip")]
        public bool sRGBClip { get; set; }
        public VideoImporterTargetSettings defaultTargetSettings { get; set; }
        public bool isPlayingPreview { get; }
        public ushort sourceAudioTrackCount { get; }
        public int pixelAspectRatioNumerator { get; }
        public int pixelAspectRatioDenominator { get; }
        public bool transcodeSkipped { get; }

        public VideoImporterTargetSettings GetTargetSettings(string platform);
        public void SetTargetSettings(string platform, VideoImporterTargetSettings settings);
        public void ClearTargetSettings(string platform);
        [NativeName("StartPreview")]
        public void PlayPreview();
        public void StopPreview();
        public Texture GetPreviewTexture();
        public string GetResizeModeName(VideoResizeMode mode);
        [NativeName("GetDefaultResizeWidth")]
        public int GetResizeWidth(VideoResizeMode mode);
        [NativeName("GetDefaultResizeHeight")]
        public int GetResizeHeight(VideoResizeMode mode);
        public ushort GetSourceAudioChannelCount(ushort audioTrackIdx);
        public uint GetSourceAudioSampleRate(ushort audioTrackIdx);
        [NativeMethod("operator==")]
        public bool Equals([NotNull("NullExceptionObject")] VideoClipImporter rhs);
    }
}
