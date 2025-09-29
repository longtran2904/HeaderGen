#region UnityEngine.UnityWebRequestWWWModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityWebRequestWWWModule.dll
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace UnityEngine
{
    [Obsolete("Use UnityWebRequest, a fully featured replacement which is more efficient and has additional features")]
    public class WWW : CustomYieldInstruction, IDisposable
    {

        public WWW(string url);
        public WWW(string url, WWWForm form);
        public WWW(string url, byte[] postData);
        [Obsolete("This overload is deprecated. Use UnityEngine.WWW.WWW(string, byte[], System.Collections.Generic.Dictionary<string, string>) instead.")]
        public WWW(string url, byte[] postData, Hashtable headers);
        public WWW(string url, byte[] postData, Dictionary<string, string> headers);

        public AssetBundle assetBundle { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Obsolete msg (UnityUpgradable) -> * UnityEngine.WWW.GetAudioClip()", True)]
        public Object audioClip { get; }
        public byte[] bytes { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Obsolete msg (UnityUpgradable) -> * UnityEngine.WWW.GetMovieTexture()", True)]
        public Object movie { get; }
        [Obsolete("WWW.size is obsolete. Please use WWW.bytesDownloaded instead")]
        public int size { get; }
        public int bytesDownloaded { get; }
        public string error { get; }
        public bool isDone { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Obsolete msg (UnityUpgradable) -> * UnityEngine.WWW.GetAudioClip()", True)]
        public Object oggVorbis { get; }
        public float progress { get; }
        public Dictionary<string, string> responseHeaders { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Please use WWW.text instead. (UnityUpgradable) -> text", True)]
        public string data { get; }
        public string text { get; }
        public Texture2D texture { get; }
        public Texture2D textureNonReadable { get; }
        public ThreadPriority threadPriority { get; set; }
        public float uploadProgress { get; }
        public string url { get; }
        public override bool keepWaiting { get; }

        public static string EscapeURL(string s);
        public static string EscapeURL(string s, Encoding e);
        public static string UnEscapeURL(string s);
        public static string UnEscapeURL(string s, Encoding e);
        public static WWW LoadFromCacheOrDownload(string url, int version);
        public static WWW LoadFromCacheOrDownload(string url, int version, uint crc);
        public static WWW LoadFromCacheOrDownload(string url, Hash128 hash);
        public static WWW LoadFromCacheOrDownload(string url, Hash128 hash, uint crc);
        public static WWW LoadFromCacheOrDownload(string url, CachedAssetBundle cachedBundle, uint crc = 0);
        public void LoadImageIntoTexture(Texture2D texture);
        public void Dispose();
        public AudioClip GetAudioClip();
        public AudioClip GetAudioClip(bool threeD);
        public AudioClip GetAudioClip(bool threeD, bool stream);
        public AudioClip GetAudioClip(bool threeD, bool stream, AudioType audioType);
        public AudioClip GetAudioClipCompressed();
        public AudioClip GetAudioClipCompressed(bool threeD);
        public AudioClip GetAudioClipCompressed(bool threeD, AudioType audioType);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("MovieTexture is deprecated. Use VideoPlayer instead.", False)]
        public MovieTexture GetMovieTexture();
    }
}
