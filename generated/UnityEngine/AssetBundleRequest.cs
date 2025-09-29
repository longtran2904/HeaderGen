#region UnityEngine.AssetBundleModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AssetBundleModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
    [RequiredByNativeCode]
    public class AssetBundleRequest : ResourceRequest
    {

        public AssetBundleRequest();

        public Object asset { get; }
        public Object[] allAssets { get; }

        [NativeMethod("GetLoadedAsset")]
        protected override Object GetResult();
    }
}
