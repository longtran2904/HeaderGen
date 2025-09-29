#region UnityEngine.AssetBundleModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AssetBundleModule.dll
#endregion

namespace UnityEngine
{
    public enum AssetBundleLoadResult
    {

        Success = 0,
        Cancelled = 1,
        NotMatchingCrc = 2,
        FailedCache = 3,
        NotValidAssetBundle = 4,
        NoSerializedData = 5,
        NotCompatible = 6,
        AlreadyLoaded = 7,
        FailedRead = 8,
        FailedDecompression = 9,
        FailedWrite = 10,
        FailedDeleteRecompressionTarget = 11,
        RecompressionTargetIsLoaded = 12,
        RecompressionTargetExistsButNotArchive = 13
    }
}
