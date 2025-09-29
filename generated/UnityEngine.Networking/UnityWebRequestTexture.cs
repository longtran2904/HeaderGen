#region UnityEngine.UnityWebRequestTextureModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityWebRequestTextureModule.dll
#endregion

using System;

namespace UnityEngine.Networking
{
    public static class UnityWebRequestTexture
    {
        public static UnityWebRequest GetTexture(string uri);
        public static UnityWebRequest GetTexture(Uri uri);
        public static UnityWebRequest GetTexture(string uri, bool nonReadable);
        public static UnityWebRequest GetTexture(Uri uri, bool nonReadable);
    }
}
