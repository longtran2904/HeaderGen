#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.Media
{
    public struct VideoTrackEncoderAttributes
    {
        public MediaRational frameRate;
        public uint width;
        public uint height;
        public uint targetBitRate;
        public VideoBitrateMode bitRateMode;
        public bool includeAlpha;

        public VideoTrackEncoderAttributes(H264EncoderAttributes h264Attrs);
        public VideoTrackEncoderAttributes(VP8EncoderAttributes vp8Attrs);
    }
}
