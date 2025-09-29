#region UnityEngine.AssetBundleModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AssetBundleModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Experimental.AssetBundlePatching
{
    [NativeHeader("Modules/AssetBundle/Public/AssetBundlePatching.h")]
    public static class AssetBundleUtility
    {
        [FreeFunction]
        public static void PatchAssetBundles(AssetBundle[] bundles, string[] filenames);
    }
}
