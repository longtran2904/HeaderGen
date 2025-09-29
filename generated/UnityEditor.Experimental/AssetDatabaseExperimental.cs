#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEditor.AssetImporters;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEditor.Experimental
{
    [NativeHeader("Modules/AssetDatabase/Editor/V2/AssetDatabaseCounters.h")]
    [NativeHeader("Modules/AssetDatabase/Editor/V2/AssetDatabaseInternal.h")]
    [NativeHeader("Modules/AssetDatabase/Editor/Public/AssetDatabaseExperimental.h")]
    public sealed class AssetDatabaseExperimental
    {

        public AssetDatabaseExperimental();

        public static AssetDatabaseCounters counters { get; }
        public static OnDemandMode ActiveOnDemandMode { get; set; }

        [Obsolete("AssetDatabaseExperimental.cacheServerConnectionChanged has been deprecated. Use AssetDatabase.cacheServerConnectionChanged instead (UnityUpgradable) -> UnityEditor.AssetDatabase.cacheServerConnectionChanged", False)]
        public static event Action<CacheServerConnectionChangedParameters> cacheServerConnectionChanged;

        [FreeFunction("AssetDatabase::ClearImporterOverride")]
        [Obsolete("AssetDatabaseExperimental.ClearImporterOverride() has been deprecated. Use AssetDatabase.ClearImporterOverride() instead (UnityUpgradable) -> UnityEditor.AssetDatabase.ClearImporterOverride(*)", False)]
        public static void ClearImporterOverride(string path);
        [FreeFunction("AssetDatabase::IsCacheServerEnabled")]
        [Obsolete("AssetDatabaseExperimental.IsCacheServerEnabled() has been deprecated. Use AssetDatabase.IsCacheServerEnabled() instead (UnityUpgradable) -> UnityEditor.AssetDatabase.IsCacheServerEnabled(*)", False)]
        public static bool IsCacheServerEnabled();
        [Obsolete("AssetDatabaseExperimental.SetImporterOverride<T>() has been deprecated. Use AssetDatabase.SetImporterOverride<T>() instead (UnityUpgradable) -> UnityEditor.AssetDatabase.SetImporterOverride<T>(*)", False)]
        public static void SetImporterOverride<T>(string path) where T : ScriptedImporter;
        [FreeFunction("AssetDatabase::GetImporterOverride")]
        [Obsolete("AssetDatabaseExperimental.GetImporterOverride() has been deprecated. Use AssetDatabase.GetImporterOverride() instead (UnityUpgradable) -> UnityEditor.AssetDatabase.GetImporterOverride(*)", False)]
        public static Type GetImporterOverride(string path);
        [FreeFunction("AssetDatabase::GetAvailableImporterTypes")]
        [Obsolete("AssetDatabaseExperimental.GetAvailableImporterTypes() has been deprecated. Use AssetDatabase.GetAvailableImporterTypes() instead (UnityUpgradable) -> UnityEditor.AssetDatabase.GetAvailableImporterTypes(*)", False)]
        public static Type[] GetAvailableImporterTypes(string path);
        [FreeFunction("AcceleratorClientCanConnectTo")]
        [Obsolete("AssetDatabaseExperimental.CanConnectToCacheServer() has been deprecated. Use AssetDatabase.CanConnectToCacheServer() instead (UnityUpgradable) -> UnityEditor.AssetDatabase.CanConnectToCacheServer(*)", False)]
        public static bool CanConnectToCacheServer(string ip, ushort port);
        [FreeFunction]
        [Obsolete("AssetDatabaseExperimental.RefreshSettings() has been deprecated. Use AssetDatabase.RefreshSettings() instead (UnityUpgradable) -> UnityEditor.AssetDatabase.RefreshSettings(*)", False)]
        public static void RefreshSettings();
        [FreeFunction("AcceleratorClientIsConnected")]
        [Obsolete("AssetDatabaseExperimental.IsConnectedToCacheServer() has been deprecated. Use AssetDatabase.IsConnectedToCacheServer() instead (UnityUpgradable) -> UnityEditor.AssetDatabase.IsConnectedToCacheServer(*)", False)]
        public static bool IsConnectedToCacheServer();
        [FreeFunction]
        [Obsolete("AssetDatabaseExperimental.GetCacheServerAddress() has been deprecated. Use AssetDatabase.GetCacheServerAddress() instead (UnityUpgradable) -> UnityEditor.AssetDatabase.GetCacheServerAddress(*)", False)]
        public static string GetCacheServerAddress();
        [FreeFunction]
        [Obsolete("AssetDatabaseExperimental.GetCacheServerPort() has been deprecated. Use AssetDatabase.GetCacheServerPort() instead (UnityUpgradable) -> UnityEditor.AssetDatabase.GetCacheServerPort(*)", False)]
        public static ushort GetCacheServerPort();
        [FreeFunction("AssetDatabase::GetCacheServerNamespacePrefix")]
        [Obsolete("AssetDatabaseExperimental.GetCacheServerNamespacePrefix() has been deprecated. Use AssetDatabase.GetCacheServerNamespacePrefix() instead (UnityUpgradable) -> UnityEditor.AssetDatabase.GetCacheServerNamespacePrefix(*)", False)]
        public static string GetCacheServerNamespacePrefix();
        [FreeFunction("AssetDatabase::GetCacheServerEnableDownload")]
        [Obsolete("AssetDatabaseExperimental.GetCacheServerEnableDownload() has been deprecated. Use AssetDatabase.GetCacheServerEnableDownload() instead (UnityUpgradable) -> UnityEditor.AssetDatabase.GetCacheServerEnableDownload(*)", False)]
        public static bool GetCacheServerEnableDownload();
        [FreeFunction("AssetDatabase::GetCacheServerEnableUpload")]
        [Obsolete("AssetDatabaseExperimental.GetCacheServerEnableUpload() has been deprecated. Use AssetDatabase.GetCacheServerEnableUpload() instead (UnityUpgradable) -> UnityEditor.AssetDatabase.GetCacheServerEnableUpload(*)", False)]
        public static bool GetCacheServerEnableUpload();
        [FreeFunction("AssetDatabase::IsDirectoryMonitoringEnabled")]
        [Obsolete("AssetDatabaseExperimental.IsDirectoryMonitoringEnabled() has been deprecated. Use AssetDatabase.IsDirectoryMonitoringEnabled() instead (UnityUpgradable) -> UnityEditor.AssetDatabase.IsDirectoryMonitoringEnabled(*)", False)]
        public static bool IsDirectoryMonitoringEnabled();
        [FreeFunction("AssetDatabaseExperimental::RegisterCustomDependency")]
        [Obsolete("AssetDatabaseExperimental.RegisterCustomDependency() has been deprecated. Use AssetDatabase.RegisterCustomDependency() instead (UnityUpgradable) -> UnityEditor.AssetDatabase.RegisterCustomDependency(*)", False)]
        [PreventExecutionInState(AssetDatabasePreventExecution.kPreventCustomDependencyChanges, PreventExecutionSeverity.PreventExecution_ManagedException, "Custom dependencies can only be removed when the assetdatabase is not importing.")]
        public static void RegisterCustomDependency(string dependency, Hash128 hashOfValue);
        [FreeFunction("AssetDatabaseExperimental::UnregisterCustomDependencyPrefixFilter")]
        [Obsolete("AssetDatabaseExperimental.UnregisterCustomDependencyPrefixFilter() has been deprecated. Use AssetDatabase.UnregisterCustomDependencyPrefixFilter() instead (UnityUpgradable) -> UnityEditor.AssetDatabase.UnregisterCustomDependencyPrefixFilter(*)", False)]
        [PreventExecutionInState(AssetDatabasePreventExecution.kPreventCustomDependencyChanges, PreventExecutionSeverity.PreventExecution_ManagedException, "Custom dependencies can only be removed when the assetdatabase is not importing.")]
        public static uint UnregisterCustomDependencyPrefixFilter(string prefixFilter);
        [FreeFunction("AssetDatabase::IsAssetImportProcess")]
        [Obsolete("AssetDatabaseExperimental.IsAssetImportWorkerProcess() has been deprecated. Use AssetDatabase.IsAssetImportWorkerProcess() instead (UnityUpgradable) -> UnityEditor.AssetDatabase.IsAssetImportWorkerProcess(*)", False)]
        public static bool IsAssetImportWorkerProcess();
        [Obsolete("Has been replaced by AssetDatabaseExperimental.RefreshSettings", True)]
        public static void ReconnectToCacheServer();
        public static ArtifactID LookupArtifact(ArtifactKey artifactKey);
        public static ArtifactID ProduceArtifact(ArtifactKey artifactKey);
        public static ArtifactID ProduceArtifactAsync(ArtifactKey artifactKey);
        public static ArtifactID[] ProduceArtifactsAsync(GUID[] artifactKey, [DefaultValue("null")] Type importerType = null);
        public static ArtifactID ForceProduceArtifact(ArtifactKey artifactKey);
        [ExcludeFromDocs]
        [Obsolete("GetArtifactHash() has been removed. Use LookupArtifact(), ProduceArtifact() or ForceProduceArtifact() instead.")]
        public static Hash128 GetArtifactHash(string guid, ImportSyncMode mode = ImportSyncMode.Block);
        [Obsolete("GetArtifactHash() has been removed. Use LookupArtifact(), ProduceArtifact() or ForceProduceArtifact() instead.")]
        public static Hash128 GetArtifactHash(string guid, [DefaultValue("null")] Type importerType, ImportSyncMode mode = ImportSyncMode.Block);
        public static bool GetArtifactPaths(ArtifactID hash, out string[] paths);
        [Obsolete("GetArtifactPaths(Hash128, out string[]) has been removed. Use GetArtifactPaths(ArtifactID, out string[]) instead.")]
        public static bool GetArtifactPaths(Hash128 hash, out string[] paths);
        [Obsolete("GetArtifactHashes() has been removed. Use LookupArtifact(), ProduceArtifact() or ForceProduceArtifact() instead.")]
        public static Hash128[] GetArtifactHashes(string[] guids, ImportSyncMode mode = ImportSyncMode.Block);
        public static OnDemandProgress GetOnDemandArtifactProgress(ArtifactKey artifactKey);
        [Obsolete("GetOnDemandArtifactProgress(string) has been removed. Use GetOnDemandArtifactProgress(ArtifactKey) instead.")]
        public static OnDemandProgress GetOnDemandArtifactProgress(string guid);
        [Obsolete("GetOnDemandArtifactProgress(string,Type) has been removed. Use GetOnDemandArtifactProgress(ArtifactKey) instead.")]
        public static OnDemandProgress GetOnDemandArtifactProgress(string guid, Type importerType);
        [Obsolete("AssetDatabaseExperimental.CacheServerConnectionChangedParameters has been deprecated. Use UnityEditor.CacheServerConnectionChangedParameters instead (UnityUpgradable) -> UnityEditor.CacheServerConnectionChangedParameters", False)]
        public struct CacheServerConnectionChangedParameters
        {
        }
        public enum OnDemandMode
        {

            Off = 0,
            Lazy = 1,
            Background = 2
        }
        [Obsolete("ImportSyncMode has been removed from the editor API", False)]
        public enum ImportSyncMode
        {

            Block = 0,
            Queue = 1,
            Poll = 2
        }
        public struct AssetDatabaseCounters
        {

            public CacheServerCounters cacheServer;
            public ImportCounters import;

            public void ResetDeltas();
            public struct Counter
            {

                public long total;
                public long delta;
            }
            public struct CacheServerCounters
            {

                public Counter metadataRequested;
                public Counter metadataDownloaded;
                public Counter metadataFailedToDownload;
                public Counter metadataUploaded;
                public Counter metadataFailedToUpload;
                public Counter metadataVersionsDownloaded;
                public Counter metadataMatched;
                public Counter artifactsDownloaded;
                public Counter artifactFilesDownloaded;
                public Counter artifactFilesFailedToDownload;
                public Counter artifactsUploaded;
                public Counter artifactFilesUploaded;
                public Counter artifactFilesFailedToUpload;
                public Counter connects;
                public Counter disconnects;
                public Counter batchesUsedForDownload;
            }
            public struct ImportCounters
            {

                public Counter imported;
                public Counter importedInProcess;
                public Counter importedOutOfProcess;
                public Counter refresh;
                public Counter domainReload;
            }
        }
    }
}
