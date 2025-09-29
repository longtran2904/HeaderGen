#region UnityEngine.UnityWebRequestAssetBundleModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityWebRequestAssetBundleModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Networking
{
    [NativeHeader("Modules/UnityWebRequestAssetBundle/Public/DownloadHandlerAssetBundle.h")]
    public sealed class DownloadHandlerAssetBundle : DownloadHandler
    {
        public DownloadHandlerAssetBundle(string url, uint crc);
        public DownloadHandlerAssetBundle(string url, uint version, uint crc);
        public DownloadHandlerAssetBundle(string url, Hash128 hash, uint crc);
        public DownloadHandlerAssetBundle(string url, string name, Hash128 hash, uint crc);
        public DownloadHandlerAssetBundle(string url, CachedAssetBundle cachedBundle, uint crc);

        public AssetBundle assetBundle { get; }
        public bool autoLoadAssetBundle { get; set; }
        public bool isDownloadComplete { get; }

        protected override byte[] GetData();
        protected override string GetText();
        public static AssetBundle GetContent(UnityWebRequest www);
    }
}
