#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEditor.VersionControl
{
    [NativeHeader("Editor/Src/VersionControl/VCPlugin.h")]
    [NativeHeader("Editor/Src/VersionControl/VC_bindings.h")]
    [NativeHeader("Editor/Src/VersionControl/VCTask.h")]
    [NativeHeader("Editor/Src/VersionControl/VCProvider.h")]
    [NativeHeader("Editor/Src/VersionControl/VCCache.h")]
    public class Provider
    {
        public static PreSubmitCallback preSubmitCallback;
        public static PreCheckoutCallback preCheckoutCallback;

        public Provider();

        [StaticAccessor("GetVCProvider()", StaticAccessorType.Dot)]
        public static bool enabled { get; }
        [StaticAccessor("GetVCProvider()", StaticAccessorType.Dot)]
        public static bool isActive { get; }
        public static bool requiresNetwork { get; }
        public static bool hasChangelistSupport { get; }
        public static bool hasCheckoutSupport { get; }
        public static bool hasLockingSupport { get; }
        public static bool isVersioningFolders { get; }
        [StaticAccessor("GetVCProvider()", StaticAccessorType.Dot)]
        public static OnlineState onlineState { get; }
        [StaticAccessor("GetVCProvider()", StaticAccessorType.Dot)]
        public static string offlineReason { get; }
        public static Task activeTask { get; }

        [FreeFunction("VersionControlBindings::VCProvider::GetActivePlugin")]
        public static Plugin GetActivePlugin();
        [FreeFunction("VersionControlBindings::VCProvider::GetActiveConfigFields")]
        public static ConfigField[] GetActiveConfigFields();
        [FreeFunction("VersionControlBindings::VCProvider::ChangeSets")]
        public static Task ChangeSets();
        [FreeFunction("VersionControlBindings::VCProvider::Incoming")]
        public static Task Incoming();
        [FreeFunction("VersionControlBindings::VCProvider::UpdateSettings")]
        public static Task UpdateSettings();
        [FreeFunction("VersionControlBindings::VCProvider::GetAssetByPath")]
        public static Asset GetAssetByPath(string unityPath);
        [FreeFunction("VersionControlBindings::VCProvider::GetAssetByGUID")]
        public static Asset GetAssetByGUID(string guid);
        [FreeFunction("VersionControlBindings::VCProvider::IsOpenForEdit")]
        public static bool IsOpenForEdit([NotNull("ArgumentNullException")] Asset asset);
        [NativeMethod("Clear")]
        [StaticAccessor("GetVCCache()", StaticAccessorType.Dot)]
        public static void ClearCache();
        [FreeFunction("VersionControlBindings::VCProvider::Internal_CreateWarningTask")]
        public static Task Internal_WarningTask([NotNull("ArgumentNullException")] string message);
        [FreeFunction("VersionControlBindings::VCProvider::Internal_CreateErrorTask")]
        public static Task Internal_ErrorTask([NotNull("ArgumentNullException")] string message);
        public static Task Status(AssetList assets);
        public static Task Status(Asset asset);
        public static Task Status(AssetList assets, bool recursively);
        public static Task Status(Asset asset, bool recursively);
        public static Task Status(string[] assets);
        public static Task Status(string[] assets, bool recursively);
        public static Task Status(string asset);
        public static Task Status(string asset, bool recursively);
        public static Task Move(string from, string to);
        public static bool CheckoutIsValid(AssetList assets);
        public static bool CheckoutIsValid(AssetList assets, CheckoutMode mode);
        public static Task Checkout(AssetList assets, CheckoutMode mode);
        public static Task Checkout(AssetList assets, CheckoutMode mode, ChangeSet changeset);
        public static Task Checkout(string[] assets, CheckoutMode mode);
        public static Task Checkout(string[] assets, CheckoutMode mode, ChangeSet changeset);
        public static Task Checkout(UnityEngine.Object[] assets, CheckoutMode mode);
        public static Task Checkout(UnityEngine.Object[] assets, CheckoutMode mode, ChangeSet changeset);
        public static bool CheckoutIsValid(Asset asset);
        public static bool CheckoutIsValid(Asset asset, CheckoutMode mode);
        public static Task Checkout(Asset asset, CheckoutMode mode);
        public static Task Checkout(Asset asset, CheckoutMode mode, ChangeSet changeset);
        public static Task Checkout(string asset, CheckoutMode mode);
        public static Task Checkout(string asset, CheckoutMode mode, ChangeSet changeset);
        public static Task Checkout(UnityEngine.Object asset, CheckoutMode mode);
        public static Task Checkout(UnityEngine.Object asset, CheckoutMode mode, ChangeSet changeset);
        public static Task Delete(string assetProjectPath);
        public static Task Delete(AssetList assets);
        public static Task Delete(Asset asset);
        public static bool AddIsValid(AssetList assets);
        public static Task Add(AssetList assets, bool recursive);
        public static Task Add(Asset asset, bool recursive);
        public static bool DeleteChangeSetsIsValid(ChangeSets changesets);
        public static Task DeleteChangeSets(ChangeSets changesets);
        public static bool SubmitIsValid(ChangeSet changeset, AssetList assets);
        public static Task Submit(ChangeSet changeset, AssetList list, string description, bool saveOnly);
        public static bool DiffIsValid(AssetList assets);
        public static Task DiffHead(AssetList assets, bool includingMetaFiles);
        public static bool ResolveIsValid(AssetList assets);
        public static Task Resolve(AssetList assets, ResolveMethod resolveMethod);
        public static Task Merge(AssetList assets);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ExcludeFromDocs]
        [Obsolete("MergeMethod is no longer used.")]
        public static Task Merge(AssetList assets, MergeMethod method);
        public static bool LockIsValid(AssetList assets);
        public static bool LockIsValid(Asset asset);
        public static bool UnlockIsValid(AssetList assets);
        public static bool UnlockIsValid(Asset asset);
        public static Task Lock(AssetList assets, bool locked);
        public static Task Lock(Asset asset, bool locked);
        public static bool RevertIsValid(AssetList assets, RevertMode mode);
        public static Task Revert(AssetList assets, RevertMode mode);
        public static bool RevertIsValid(Asset asset, RevertMode mode);
        public static Task Revert(Asset asset, RevertMode mode);
        public static bool GetLatestIsValid(AssetList assets);
        public static bool GetLatestIsValid(Asset asset);
        public static Task GetLatest(AssetList assets);
        public static Task GetLatest(Asset asset);
        public static Task ChangeSetDescription(ChangeSet changeset);
        public static Task ChangeSetStatus(ChangeSet changeset);
        public static Task ChangeSetStatus(string changesetID);
        public static Task IncomingChangeSetAssets(ChangeSet changeset);
        public static Task IncomingChangeSetAssets(string changesetID);
        public static Task ChangeSetMove(AssetList assets, ChangeSet changeset);
        public static Task ChangeSetMove(Asset asset, ChangeSet changeset);
        public static Task ChangeSetMove(AssetList assets, string changesetID);
        public static Task ChangeSetMove(Asset asset, string changesetID);
        public static AssetList GetAssetListFromSelection();

        public delegate bool PreSubmitCallback(AssetList list, ref string changesetID, ref string changesetDescription);
        public delegate bool PreCheckoutCallback(AssetList list, ref string changesetID, ref string changesetDescription);
    }
}
