#region UnityEngine.UnityWebRequestAudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityWebRequestAudioModule.dll
#endregion

using System;

namespace UnityEngine.Networking
{
    public static class UnityWebRequestMultimedia
    {
        public static UnityWebRequest GetAudioClip(string uri, AudioType audioType);
        public static UnityWebRequest GetAudioClip(Uri uri, AudioType audioType);
        [Obsolete("MovieTexture is deprecated. Use VideoPlayer instead.", True)]
        public static UnityWebRequest GetMovieTexture(string uri);
        [Obsolete("MovieTexture is deprecated. Use VideoPlayer instead.", True)]
        public static UnityWebRequest GetMovieTexture(Uri uri);
    }
}
