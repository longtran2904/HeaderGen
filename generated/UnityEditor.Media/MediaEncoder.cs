#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using Unity.Collections;
using UnityEngine;

namespace UnityEditor.Media
{
    public class MediaEncoder : IDisposable
    {
        [Obsolete("Was made public by mistake. Not meant to be used by user code.", True)]
        public nint m_Ptr;

        public MediaEncoder(string filePath, VideoTrackAttributes videoAttrs, AudioTrackAttributes[] audioAttrs);
        public MediaEncoder(string filePath, VideoTrackEncoderAttributes videoAttrs, AudioTrackAttributes[] audioAttrs);
        public MediaEncoder(string filePath, VideoTrackEncoderAttributes videoAttrs, AudioTrackAttributes audioAttrs);
        public MediaEncoder(string filePath, VideoTrackEncoderAttributes videoAttrs);
        public MediaEncoder(string filePath, VideoTrackAttributes videoAttrs, AudioTrackAttributes audioAttrs);
        public MediaEncoder(string filePath, VideoTrackAttributes videoAttrs);
        public MediaEncoder(string filePath, AudioTrackAttributes[] audioAttrs);
        public MediaEncoder(string filePath, AudioTrackAttributes audioAttrs);

        ~MediaEncoder();

        public bool AddFrame(int width, int height, int rowBytes, TextureFormat format, NativeArray<byte> data);
        public bool AddFrame(int width, int height, int rowBytes, TextureFormat format, NativeArray<byte> data, MediaTime time);
        public bool AddFrame(Texture2D texture);
        public bool AddFrame(Texture2D texture, MediaTime time);
        public bool AddSamples(ushort trackIndex, NativeArray<float> interleavedSamples);
        public bool AddSamples(NativeArray<float> interleavedSamples);
        public void Dispose();
    }
}
