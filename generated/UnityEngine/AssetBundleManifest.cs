#region UnityEngine.AssetBundleModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AssetBundleModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/AssetBundle/Public/AssetBundleManifest.h")]
    public class AssetBundleManifest : Object
    {
        [NativeMethod("GetAllAssetBundles")]
        public string[] GetAllAssetBundles();
        [NativeMethod("GetAllAssetBundlesWithVariant")]
        public string[] GetAllAssetBundlesWithVariant();
        [NativeMethod("GetAssetBundleHash")]
        public Hash128 GetAssetBundleHash(string assetBundleName);
        [NativeMethod("GetDirectDependencies")]
        public string[] GetDirectDependencies(string assetBundleName);
        [NativeMethod("GetAllDependencies")]
        public string[] GetAllDependencies(string assetBundleName);
    }
}
