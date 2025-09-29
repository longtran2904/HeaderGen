#region UnityEngine.AssetBundleModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AssetBundleModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromAsyncOperation.h")]
    [RequiredByNativeCode]
    public class AssetBundleCreateRequest : AsyncOperation
    {
        public AssetBundleCreateRequest();

        public AssetBundle assetBundle { get; }
    }
}
