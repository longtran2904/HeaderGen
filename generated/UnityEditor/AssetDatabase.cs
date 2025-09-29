#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor.AssetImporters;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngineInternal;

namespace UnityEditor
{
    [NativeHeader("Modules/AssetDatabase/Editor/Public/AssetDatabase.h")]
    [NativeHeader("Editor/Src/Application/ApplicationFunctions.h")]
    [NativeHeader("Editor/Src/VersionControl/VC_bindings.h")]
    [NativeHeader("Editor/Src/PackageUtility.h")]
    [NativeHeader("Modules/AssetDatabase/Editor/Public/AssetDatabaseUtility.h")]
    [NativeHeader("Runtime/Core/PreventExecutionInState.h")]
    [NativeHeader("Modules/AssetDatabase/Editor/ScriptBindings/AssetDatabase.bindings.h")]
    [NativeHeader("Modules/AssetDatabase/Editor/Public/AssetDatabasePreventExecution.h")]
    [StaticAccessor("AssetDatabaseBindings", StaticAccessorType.DoubleColon)]
    public sealed class AssetDatabase
    {

        public static Action<string[]> onImportPackageItemsCompleted;

        public AssetDatabase();

        public static uint GlobalArtifactDependencyVersion { get; }
        public static uint GlobalArtifactProcessedVersion { get; }
        public static RefreshImportMode ActiveRefreshImportMode { get; set; }
        public static int DesiredWorkerCount { get; set; }

        public static event ImportPackageCallback importPackageStarted;
        public static event ImportPackageCallback importPackageCompleted;
        public static event ImportPackageCallback importPackageCancelled;
        public static event ImportPackageFailedCallback importPackageFailed;
        public static event Action<CacheServerConnectionChangedParameters> cacheServerConnectionChanged;

        public static void CanOpenForEdit(string[] assetOrMetaFilePaths, List<string> outNotEditablePaths, [DefaultValue("StatusQueryOptions.UseCachedIfPossible")] StatusQueryOptions statusQueryOptions = StatusQueryOptions.UseCachedIfPossible);
        public static void IsOpenForEdit(string[] assetOrMetaFilePaths, List<string> outNotEditablePaths, [DefaultValue("StatusQueryOptions.UseCachedIfPossible")] StatusQueryOptions statusQueryOptions = StatusQueryOptions.UseCachedIfPossible);
        public static bool MakeEditable(string path);
        public static bool MakeEditable(string[] paths, string prompt = null, List<string> outNotEditablePaths = null);
        [Obsolete("GetTextMetaDataPathFromAssetPath has been renamed to GetTextMetaFilePathFromAssetPath (UnityUpgradable) -> GetTextMetaFilePathFromAssetPath(*)")]
        public static string GetTextMetaDataPathFromAssetPath(string path);
        public static string[] FindAssets(string filter);
        public static string[] FindAssets(string filter, string[] searchInFolders);
        public static bool Contains(UnityEngine.Object obj);
        public static bool Contains(int instanceID);
        public static string CreateFolder(string parentFolder, string newFolderName);
        public static bool IsMainAsset(UnityEngine.Object obj);
        [FreeFunction("AssetDatabase::IsMainAsset")]
        public static bool IsMainAsset(int instanceID);
        public static bool IsSubAsset(UnityEngine.Object obj);
        [FreeFunction("AssetDatabase::IsSubAsset")]
        public static bool IsSubAsset(int instanceID);
        public static bool IsForeignAsset(UnityEngine.Object obj);
        public static bool IsForeignAsset(int instanceID);
        public static bool IsNativeAsset(UnityEngine.Object obj);
        public static bool IsNativeAsset(int instanceID);
        [FreeFunction]
        public static string GetCurrentCacheServerIp();
        public static string GenerateUniqueAssetPath(string path);
        [FreeFunction("AssetDatabase::StartAssetImporting")]
        public static void StartAssetEditing();
        [FreeFunction("AssetDatabase::StopAssetImporting")]
        public static void StopAssetEditing();
        [FreeFunction("AssetDatabase::UnloadAllFileStreams")]
        public static void ReleaseCachedFileHandles();
        public static string ValidateMoveAsset(string oldPath, string newPath);
        public static string MoveAsset(string oldPath, string newPath);
        [NativeThrows]
        public static string ExtractAsset(UnityEngine.Object asset, string newPath);
        public static string RenameAsset(string pathName, string newName);
        public static bool MoveAssetToTrash(string path);
        public static bool MoveAssetsToTrash(string[] paths, List<string> outFailedPaths);
        public static bool DeleteAsset(string path);
        public static bool DeleteAssets(string[] paths, List<string> outFailedPaths);
        [ExcludeFromDocs]
        public static void ImportAsset(string path);
        public static void ImportAsset(string path, [DefaultValue("ImportAssetOptions.Default")] ImportAssetOptions options);
        public static bool CopyAsset(string path, string newPath);
        public static bool WriteImportSettingsIfDirty(string path);
        [NativeThrows]
        public static string[] GetSubFolders([NotNull("ArgumentNullException")] string path);
        [FreeFunction("AssetDatabase::IsFolderAsset")]
        public static bool IsValidFolder(string path);
        [NativeThrows]
        [PreventExecutionInState(AssetDatabasePreventExecution.kGatheringDependenciesFromSourceFile, PreventExecutionSeverity.PreventExecution_ManagedException, "Assets may not be created during gathering of import dependencies")]
        public static void CreateAsset([NotNull("ArgumentNullException")] UnityEngine.Object asset, string path);
        [NativeThrows]
        public static void AddObjectToAsset([NotNull("ArgumentNullException")] UnityEngine.Object objectToAdd, string path);
        public static void AddObjectToAsset(UnityEngine.Object objectToAdd, UnityEngine.Object assetObject);
        [NativeThrows]
        public static void SetMainObject([NotNull("ArgumentNullException")] UnityEngine.Object mainObject, string assetPath);
        public static string GetAssetPath(UnityEngine.Object assetObject);
        public static string GetAssetPath(int instanceID);
        [FreeFunction("::GetAssetOrScenePath")]
        public static string GetAssetOrScenePath(UnityEngine.Object assetObject);
        [FreeFunction("AssetDatabase::TextMetaFilePathFromAssetPath")]
        public static string GetTextMetaFilePathFromAssetPath(string path);
        [FreeFunction("AssetDatabase::AssetPathFromTextMetaFilePath")]
        public static string GetAssetPathFromTextMetaFilePath(string path);
        [NativeThrows]
        [PreventExecutionInState(AssetDatabasePreventExecution.kGatheringDependenciesFromSourceFile, PreventExecutionSeverity.PreventExecution_ManagedException, "Assets may not be loaded while dependencies are being gathered, as these assets may not have been imported yet.")]
        [PreventExecutionInState(AssetDatabasePreventExecution.kDomainBackup, PreventExecutionSeverity.PreventExecution_ManagedException, "Assets may not be loaded while domain backup is running, as this will change the underlying state.")]
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
        public static UnityEngine.Object LoadAssetAtPath(string assetPath, Type type);
        public static T LoadAssetAtPath<T>(string assetPath) where T : UnityEngine.Object;
        [PreventExecutionInState(AssetDatabasePreventExecution.kGatheringDependenciesFromSourceFile, PreventExecutionSeverity.PreventExecution_ManagedException, "Assets may not be loaded while dependencies are being gathered, as these assets may not have been imported yet.")]
        public static UnityEngine.Object LoadMainAssetAtPath(string assetPath);
        public static Type GetMainAssetTypeAtPath(string assetPath);
        public static Type GetTypeFromPathAndFileID(string assetPath, long localIdentifierInFile);
        public static bool IsMainAssetAtPathLoaded(string assetPath);
        [PreventExecutionInState(AssetDatabasePreventExecution.kGatheringDependenciesFromSourceFile, PreventExecutionSeverity.PreventExecution_ManagedException, "Assets may not be loaded while dependencies are being gathered, as these assets may not have been imported yet.")]
        public static UnityEngine.Object[] LoadAllAssetRepresentationsAtPath(string assetPath);
        [PreventExecutionInState(AssetDatabasePreventExecution.kGatheringDependenciesFromSourceFile, PreventExecutionSeverity.PreventExecution_ManagedException, "Assets may not be loaded while dependencies are being gathered, as these assets may not have been imported yet.")]
        public static UnityEngine.Object[] LoadAllAssetsAtPath(string assetPath);
        public static string[] GetAllAssetPaths();
        [Obsolete("Please use AssetDatabase.Refresh instead", True)]
        public static void RefreshDelayed(ImportAssetOptions options);
        [Obsolete("Please use AssetDatabase.Refresh instead", True)]
        public static void RefreshDelayed();
        [ExcludeFromDocs]
        public static void Refresh();
        public static void Refresh([DefaultValue("ImportAssetOptions.Default")] ImportAssetOptions options);
        [FreeFunction("::CanOpenAssetInEditor")]
        public static bool CanOpenAssetInEditor(int instanceID);
        [ExcludeFromDocs]
        public static bool OpenAsset(int instanceID);
        public static bool OpenAsset(int instanceID, [DefaultValue("-1")] int lineNumber);
        [FreeFunction("::OpenAsset")]
        public static bool OpenAsset(int instanceID, int lineNumber, int columnNumber);
        [ExcludeFromDocs]
        public static bool OpenAsset(UnityEngine.Object target);
        public static bool OpenAsset(UnityEngine.Object target, [DefaultValue("-1")] int lineNumber);
        public static bool OpenAsset(UnityEngine.Object target, int lineNumber, int columnNumber);
        public static bool OpenAsset(UnityEngine.Object[] objects);
        public static string GUIDToAssetPath(string guid);
        public static string GUIDToAssetPath(GUID guid);
        public static GUID GUIDFromAssetPath(string path);
        public static string AssetPathToGUID(string path);
        public static string AssetPathToGUID(string path, [DefaultValue("AssetPathToGUIDOptions.IncludeRecentlyDeletedAssets")] AssetPathToGUIDOptions options);
        public static Hash128 GetAssetDependencyHash(GUID guid);
        public static Hash128 GetAssetDependencyHash(string path);
        [FreeFunction("AssetDatabase::SaveAssets")]
        public static void SaveAssets();
        [FreeFunction("AssetDatabase::SaveAssetIfDirty")]
        public static void SaveAssetIfDirty(GUID guid);
        public static void SaveAssetIfDirty(UnityEngine.Object obj);
        public static Texture GetCachedIcon(string path);
        public static void SetLabels(UnityEngine.Object obj, string[] labels);
        public static string[] GetLabels(GUID guid);
        public static string[] GetLabels(UnityEngine.Object obj);
        public static void ClearLabels(UnityEngine.Object obj);
        public static string[] GetAllAssetBundleNames();
        [Obsolete("Method GetAssetBundleNames has been deprecated. Use GetAllAssetBundleNames instead.")]
        public string[] GetAssetBundleNames();
        public static string[] GetUnusedAssetBundleNames();
        [FreeFunction("AssetDatabase::RemoveAssetBundleByName")]
        public static bool RemoveAssetBundleName(string assetBundleName, bool forceRemove);
        [FreeFunction("AssetDatabase::RemoveUnusedAssetBundleNames")]
        public static void RemoveUnusedAssetBundleNames();
        public static string[] GetAssetPathsFromAssetBundle(string assetBundleName);
        public static string[] GetAssetPathsFromAssetBundleAndAssetName(string assetBundleName, string assetName);
        [NativeThrows]
        public static string GetImplicitAssetBundleName(string assetPath);
        [NativeThrows]
        public static string GetImplicitAssetBundleVariantName(string assetPath);
        public static string[] GetAssetBundleDependencies(string assetBundleName, bool recursive);
        public static string[] GetDependencies(string pathName);
        public static string[] GetDependencies(string pathName, bool recursive);
        public static string[] GetDependencies(string[] pathNames);
        public static string[] GetDependencies(string[] pathNames, bool recursive);
        public static void ExportPackage(string assetPathName, string fileName);
        public static void ExportPackage(string assetPathName, string fileName, ExportPackageOptions flags);
        [ExcludeFromDocs]
        public static void ExportPackage(string[] assetPathNames, string fileName);
        [NativeThrows]
        public static void ExportPackage(string[] assetPathNames, string fileName, [DefaultValue("ExportPackageOptions.Default")] ExportPackageOptions flags);
        [ExcludeFromDocs]
        public static bool CanOpenForEdit(UnityEngine.Object assetObject);
        public static bool CanOpenForEdit(UnityEngine.Object assetObject, [DefaultValue("StatusQueryOptions.UseCachedIfPossible")] StatusQueryOptions statusOptions);
        [ExcludeFromDocs]
        public static bool CanOpenForEdit(string assetOrMetaFilePath);
        public static bool CanOpenForEdit(string assetOrMetaFilePath, [DefaultValue("StatusQueryOptions.UseCachedIfPossible")] StatusQueryOptions statusOptions);
        [ExcludeFromDocs]
        public static bool CanOpenForEdit(UnityEngine.Object assetObject, out string message);
        public static bool CanOpenForEdit(UnityEngine.Object assetObject, out string message, [DefaultValue("StatusQueryOptions.UseCachedIfPossible")] StatusQueryOptions statusOptions);
        [ExcludeFromDocs]
        public static bool CanOpenForEdit(string assetOrMetaFilePath, out string message);
        public static bool CanOpenForEdit(string assetOrMetaFilePath, out string message, [DefaultValue("StatusQueryOptions.UseCachedIfPossible")] StatusQueryOptions statusOptions);
        [ExcludeFromDocs]
        public static bool IsOpenForEdit(UnityEngine.Object assetObject);
        public static bool IsOpenForEdit(UnityEngine.Object assetObject, [DefaultValue("StatusQueryOptions.UseCachedIfPossible")] StatusQueryOptions statusOptions);
        [ExcludeFromDocs]
        public static bool IsOpenForEdit(string assetOrMetaFilePath);
        public static bool IsOpenForEdit(string assetOrMetaFilePath, [DefaultValue("StatusQueryOptions.UseCachedIfPossible")] StatusQueryOptions statusOptions);
        [ExcludeFromDocs]
        public static bool IsOpenForEdit(UnityEngine.Object assetObject, out string message);
        public static bool IsOpenForEdit(UnityEngine.Object assetObject, out string message, [DefaultValue("StatusQueryOptions.UseCachedIfPossible")] StatusQueryOptions statusOptions);
        [ExcludeFromDocs]
        public static bool IsOpenForEdit(string assetOrMetaFilePath, out string message);
        public static bool IsOpenForEdit(string assetOrMetaFilePath, out string message, [DefaultValue("StatusQueryOptions.UseCachedIfPossible")] StatusQueryOptions statusOptions);
        [ExcludeFromDocs]
        public static bool IsMetaFileOpenForEdit(UnityEngine.Object assetObject);
        public static bool IsMetaFileOpenForEdit(UnityEngine.Object assetObject, [DefaultValue("StatusQueryOptions.UseCachedIfPossible")] StatusQueryOptions statusOptions);
        [ExcludeFromDocs]
        public static bool IsMetaFileOpenForEdit(UnityEngine.Object assetObject, out string message);
        public static bool IsMetaFileOpenForEdit(UnityEngine.Object assetObject, out string message, [DefaultValue("StatusQueryOptions.UseCachedIfPossible")] StatusQueryOptions statusOptions);
        public static T GetBuiltinExtraResource<T>(string path) where T : UnityEngine.Object;
        [NativeThrows]
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public static UnityEngine.Object GetBuiltinExtraResource(Type type, string path);
        public static void ForceReserializeAssets(IEnumerable<string> assetPaths, ForceReserializeAssetsOptions options = ForceReserializeAssetsOptions.ReserializeAssetsAndMetadata);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Please use the overload of this function that uses a long data type for the localId parameter, because this version can return a localID that has overflowed. This can happen when called on objects that are part of a Prefab.", True)]
        public static bool TryGetGUIDAndLocalFileIdentifier(UnityEngine.Object obj, out string guid, out int localId);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Please use the overload of this function that uses a long data type for the localId parameter, because this version can return a localID that has overflowed. This can happen when called on objects that are part of a Prefab.", True)]
        public static bool TryGetGUIDAndLocalFileIdentifier(int instanceID, out string guid, out int localId);
        public static bool TryGetGUIDAndLocalFileIdentifier(UnityEngine.Object obj, out string guid, out long localId);
        public static bool TryGetGUIDAndLocalFileIdentifier(int instanceID, out string guid, out long localId);
        public static bool TryGetGUIDAndLocalFileIdentifier<T>(LazyLoadReference<T> assetRef, out string guid, out long localId) where T : UnityEngine.Object;
        public static void ForceReserializeAssets();
        [FreeFunction("AssetDatabase::RemoveObjectFromAsset")]
        public static void RemoveObjectFromAsset([NotNull("ArgumentNullException")] UnityEngine.Object objectToRemove);
        public static void ImportPackage(string packagePath, bool interactive);
        [FreeFunction("ApplicationDisallowAutoRefresh")]
        public static void DisallowAutoRefresh();
        [FreeFunction("ApplicationAllowAutoRefresh")]
        public static void AllowAutoRefresh();
        [FreeFunction("AssetDatabase::ClearImporterOverride")]
        public static void ClearImporterOverride(string path);
        [FreeFunction("AssetDatabase::IsCacheServerEnabled")]
        public static bool IsCacheServerEnabled();
        public static void SetImporterOverride<T>(string path) where T : ScriptedImporter;
        [FreeFunction("AssetDatabase::GetImporterOverride")]
        public static Type GetImporterOverride(string path);
        [FreeFunction("AssetDatabase::GetAvailableImporterTypes")]
        public static Type[] GetAvailableImporterTypes(string path);
        [FreeFunction("AcceleratorClientCanConnectTo")]
        public static bool CanConnectToCacheServer(string ip, ushort port);
        [FreeFunction]
        public static void RefreshSettings();
        [FreeFunction("AcceleratorClientIsConnected")]
        public static bool IsConnectedToCacheServer();
        [FreeFunction("AcceleratorClientResetReconnectTimer")]
        public static void ResetCacheServerReconnectTimer();
        [FreeFunction("AcceleratorClientCloseConnection")]
        public static void CloseCacheServerConnection();
        [FreeFunction]
        public static string GetCacheServerAddress();
        [FreeFunction]
        public static ushort GetCacheServerPort();
        [FreeFunction("AssetDatabase::GetCacheServerNamespacePrefix")]
        public static string GetCacheServerNamespacePrefix();
        [FreeFunction("AssetDatabase::GetCacheServerEnableDownload")]
        public static bool GetCacheServerEnableDownload();
        [FreeFunction("AssetDatabase::GetCacheServerEnableUpload")]
        public static bool GetCacheServerEnableUpload();
        [FreeFunction("AssetDatabase::IsDirectoryMonitoringEnabled")]
        public static bool IsDirectoryMonitoringEnabled();
        [FreeFunction("AssetDatabase::RegisterCustomDependency")]
        [PreventExecutionInState(AssetDatabasePreventExecution.kPreventCustomDependencyChanges, PreventExecutionSeverity.PreventExecution_ManagedException, "Custom dependencies can only be removed when the assetdatabase is not importing.")]
        public static void RegisterCustomDependency(string dependency, Hash128 hashOfValue);
        [FreeFunction("AssetDatabase::UnregisterCustomDependencyPrefixFilter")]
        [PreventExecutionInState(AssetDatabasePreventExecution.kPreventCustomDependencyChanges, PreventExecutionSeverity.PreventExecution_ManagedException, "Custom dependencies can only be removed when the assetdatabase is not importing.")]
        public static uint UnregisterCustomDependencyPrefixFilter(string prefixFilter);
        [FreeFunction("AssetDatabase::IsAssetImportProcess")]
        public static bool IsAssetImportWorkerProcess();
        [FreeFunction("AssetDatabase::ForceToDesiredWorkerCount")]
        public static void ForceToDesiredWorkerCount();
        public delegate void ImportPackageCallback(string packageName);
        public delegate void ImportPackageFailedCallback(string packageName, string errorMessage);
        public enum RefreshImportMode
        {

            InProcess = 0,
            OutOfProcessPerQueue = 1
        }
    }
}
