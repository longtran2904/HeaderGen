#region UnityEngine.UnityWebRequestAssetBundleModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityWebRequestAssetBundleModule.dll
#endregion

using System;

namespace UnityEngine.Networking
{
    public static class UnityWebRequestAssetBundle
    {

        public static UnityWebRequest GetAssetBundle(string uri);
        public static UnityWebRequest GetAssetBundle(Uri uri);
        public static UnityWebRequest GetAssetBundle(string uri, uint crc);
        public static UnityWebRequest GetAssetBundle(Uri uri, uint crc);
        public static UnityWebRequest GetAssetBundle(string uri, uint version, uint crc);
        public static UnityWebRequest GetAssetBundle(Uri uri, uint version, uint crc);
        public static UnityWebRequest GetAssetBundle(string uri, Hash128 hash, uint crc = 0);
        public static UnityWebRequest GetAssetBundle(Uri uri, Hash128 hash, uint crc = 0);
        public static UnityWebRequest GetAssetBundle(string uri, CachedAssetBundle cachedAssetBundle, uint crc = 0);
        public static UnityWebRequest GetAssetBundle(Uri uri, CachedAssetBundle cachedAssetBundle, uint crc = 0);
    }
}
