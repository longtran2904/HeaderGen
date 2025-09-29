#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    [Flags]
    public enum BuildAssetBundleOptions
    {
        None = 0,
        UncompressedAssetBundle = 1,
        [Obsolete("This has been made obsolete. It is always enabled in the new AssetBundle build system introduced in 5.0.")]
        CollectDependencies = 2,
        [Obsolete("This has been made obsolete. It is always enabled in the new AssetBundle build system introduced in 5.0.")]
        CompleteAssets = 4,
        DisableWriteTypeTree = 8,
        DeterministicAssetBundle = 16,
        ForceRebuildAssetBundle = 32,
        IgnoreTypeTreeChanges = 64,
        AppendHashToAssetBundleName = 128,
        ChunkBasedCompression = 256,
        StrictMode = 512,
        DryRunBuild = 1024,
        DisableLoadAssetByFileName = 4096,
        DisableLoadAssetByFileNameWithExtension = 8192,
        AssetBundleStripUnityVersion = 32768,
        UseContentHash = 65536
    }
}
