#region UnityEngine.UnityWebRequestAudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityWebRequestAudioModule.dll
#endregion

using System;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.Networking
{
    [NativeHeader("Modules/UnityWebRequestAudio/Public/DownloadHandlerAudioClip.h")]
    public sealed class DownloadHandlerAudioClip : DownloadHandler
    {

        public DownloadHandlerAudioClip(string url, AudioType audioType);
        public DownloadHandlerAudioClip(Uri uri, AudioType audioType);

        [NativeThrows]
        public AudioClip audioClip { get; }
        public bool streamAudio { get; set; }
        public bool compressed { get; set; }

        protected override NativeArray<byte> GetNativeData();
        public override void Dispose();
        protected override string GetText();
        public static AudioClip GetContent(UnityWebRequest www);
    }
}
