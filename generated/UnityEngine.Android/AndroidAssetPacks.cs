#region UnityEngine.AndroidJNIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AndroidJNIModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine.Android
{
    [NativeHeader("Modules/AndroidJNI/Public/AndroidAssetPacksBindingsHelpers.h")]
    [StaticAccessor("AndroidAssetPacksBindingsHelpers", StaticAccessorType.DoubleColon)]
    public static class AndroidAssetPacks
    {

        public static bool coreUnityAssetPacksDownloaded { get; }

        public static string[] GetCoreUnityAssetPackNames();
        public static void GetAssetPackStateAsync(string[] assetPackNames, Action<ulong, AndroidAssetPackState[]> callback);
        public static GetAssetPackStateAsyncOperation GetAssetPackStateAsync(string[] assetPackNames);
        public static void DownloadAssetPackAsync(string[] assetPackNames, Action<AndroidAssetPackInfo> callback);
        public static DownloadAssetPackAsyncOperation DownloadAssetPackAsync(string[] assetPackNames);
        public static void RequestToUseMobileDataAsync(Action<AndroidAssetPackUseMobileDataRequestResult> callback);
        public static RequestToUseMobileDataAsyncOperation RequestToUseMobileDataAsync();
        public static string GetAssetPackPath(string assetPackName);
        public static void CancelAssetPackDownload(string[] assetPackNames);
        public static void RemoveAssetPack(string assetPackName);
    }
}
