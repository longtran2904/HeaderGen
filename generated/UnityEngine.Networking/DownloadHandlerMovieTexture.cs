#region UnityEngine.UnityWebRequestAudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityWebRequestAudioModule.dll
#endregion

using System;

namespace UnityEngine.Networking
{
    [Obsolete("MovieTexture is deprecated. Use VideoPlayer instead.", True)]
    public sealed class DownloadHandlerMovieTexture : DownloadHandler
    {
        public DownloadHandlerMovieTexture();

        public MovieTexture movieTexture { get; }

        protected override byte[] GetData();
        protected override string GetText();
        public static MovieTexture GetContent(UnityWebRequest uwr);
    }
}
