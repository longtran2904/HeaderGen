#region UnityEngine.UnityWebRequestTextureModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityWebRequestTextureModule.dll
#endregion

using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.Networking
{
    [NativeHeader("Modules/UnityWebRequestTexture/Public/DownloadHandlerTexture.h")]
    public sealed class DownloadHandlerTexture : DownloadHandler
    {
        public DownloadHandlerTexture();
        public DownloadHandlerTexture(bool readable);

        public Texture2D texture { get; }

        protected override NativeArray<byte> GetNativeData();
        public override void Dispose();
        public static Texture2D GetContent(UnityWebRequest www);
    }
}
