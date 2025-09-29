#region UnityEngine.AssetBundleModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AssetBundleModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/AssetBundle/Public/AssetBundleRecompressOperation.h")]
    [RequiredByNativeCode]
    public class AssetBundleRecompressOperation : AsyncOperation
    {
        public AssetBundleRecompressOperation();

        public string humanReadableResult { get; }
        public string inputPath { get; }
        public string outputPath { get; }
        public AssetBundleLoadResult result { get; }
        public bool success { get; }
    }
}
