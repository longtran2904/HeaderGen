#region UnityEngine.VideoModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VideoModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Video
{
    [NativeHeader("Modules/Video/Public/VideoClip.h")]
    [RequiredByNativeCode]
    public sealed class VideoClip : Object
    {

        public string originalPath { get; }
        public ulong frameCount { get; }
        public double frameRate { get; }
        [NativeName("Duration")]
        public double length { get; }
        public uint width { get; }
        public uint height { get; }
        public uint pixelAspectRatioNumerator { get; }
        public uint pixelAspectRatioDenominator { get; }
        public bool sRGB { get; }
        public ushort audioTrackCount { get; }

        public ushort GetAudioChannelCount(ushort audioTrackIdx);
        public uint GetAudioSampleRate(ushort audioTrackIdx);
        public string GetAudioLanguage(ushort audioTrackIdx);
    }
}
