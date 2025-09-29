#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Runtime/Misc/CachingManager.h")]
    [StaticAccessor("GetCachingManager()", StaticAccessorType.Dot)]
    public sealed class Caching
    {

        public Caching();

        public static bool compressionEnabled { get; set; }
        public static bool ready { get; }
        [Obsolete("Please use use Cache.spaceOccupied to get used bytes per cache.")]
        public static int spaceUsed { get; }
        [Obsolete("This property is only used for the current cache, use Cache.spaceOccupied to get used bytes per cache.")]
        public static long spaceOccupied { get; }
        [Obsolete("Please use use Cache.spaceOccupied to get used bytes per cache.")]
        public static int spaceAvailable { get; }
        [Obsolete("This property is only used for the current cache, use Cache.spaceFree to get unused bytes per cache.")]
        public static long spaceFree { get; }
        [Obsolete("This property is only used for the current cache, use Cache.maximumAvailableStorageSpace to access the maximum available storage space per cache.")]
        [StaticAccessor("GetCachingManager().GetCurrentCache()", StaticAccessorType.Dot)]
        public static long maximumAvailableDiskSpace { get; set; }
        [Obsolete("This property is only used for the current cache, use Cache.expirationDelay to access the expiration delay per cache.")]
        [StaticAccessor("GetCachingManager().GetCurrentCache()", StaticAccessorType.Dot)]
        public static int expirationDelay { get; set; }
        public static int cacheCount { get; }
        [StaticAccessor("CachingManagerWrapper", StaticAccessorType.DoubleColon)]
        public static Cache defaultCache { get; }
        [StaticAccessor("CachingManagerWrapper", StaticAccessorType.DoubleColon)]
        public static Cache currentCacheForWriting { get; set; }

        public static bool ClearCache();
        public static bool ClearCache(int expiration);
        public static bool ClearCachedVersion(string assetBundleName, Hash128 hash);
        public static bool ClearOtherCachedVersions(string assetBundleName, Hash128 hash);
        public static bool ClearAllCachedVersions(string assetBundleName);
        public static void GetCachedVersions(string assetBundleName, List<Hash128> outCachedVersions);
        [Obsolete("Please use IsVersionCached with Hash128 instead.")]
        public static bool IsVersionCached(string url, int version);
        public static bool IsVersionCached(string url, Hash128 hash);
        public static bool IsVersionCached(CachedAssetBundle cachedBundle);
        [Obsolete("Please use MarkAsUsed with Hash128 instead.")]
        public static bool MarkAsUsed(string url, int version);
        public static bool MarkAsUsed(string url, Hash128 hash);
        public static bool MarkAsUsed(CachedAssetBundle cachedBundle);
        [Obsolete("Please use SetNoBackupFlag with Hash128 instead.")]
        public static void SetNoBackupFlag(string url, int version);
        public static void SetNoBackupFlag(string url, Hash128 hash);
        public static void SetNoBackupFlag(CachedAssetBundle cachedBundle);
        [Obsolete("Please use ResetNoBackupFlag with Hash128 instead.")]
        public static void ResetNoBackupFlag(string url, int version);
        public static void ResetNoBackupFlag(string url, Hash128 hash);
        public static void ResetNoBackupFlag(CachedAssetBundle cachedBundle);
        [Obsolete("This function is obsolete and will always return -1. Use IsVersionCached instead.")]
        public static int GetVersionFromCache(string url);
        public static Cache AddCache(string cachePath);
        [NativeName("Caching_GetCacheHandleAt")]
        [NativeThrows]
        [StaticAccessor("CachingManagerWrapper", StaticAccessorType.DoubleColon)]
        public static Cache GetCacheAt(int cacheIndex);
        [NativeName("Caching_GetCacheHandleByPath")]
        [NativeThrows]
        [StaticAccessor("CachingManagerWrapper", StaticAccessorType.DoubleColon)]
        public static Cache GetCacheByPath(string cachePath);
        public static void GetAllCachePaths(List<string> cachePaths);
        [NativeName("Caching_RemoveCacheByHandle")]
        [NativeThrows]
        [StaticAccessor("CachingManagerWrapper", StaticAccessorType.DoubleColon)]
        public static bool RemoveCache(Cache cache);
        [NativeName("Caching_MoveCacheBeforeByHandle")]
        [NativeThrows]
        [StaticAccessor("CachingManagerWrapper", StaticAccessorType.DoubleColon)]
        public static void MoveCacheBefore(Cache src, Cache dst);
        [NativeName("Caching_MoveCacheAfterByHandle")]
        [NativeThrows]
        [StaticAccessor("CachingManagerWrapper", StaticAccessorType.DoubleColon)]
        public static void MoveCacheAfter(Cache src, Cache dst);
        [Obsolete("This function is obsolete. Please use ClearCache.  (UnityUpgradable) -> ClearCache()")]
        public static bool CleanCache();
    }
}
