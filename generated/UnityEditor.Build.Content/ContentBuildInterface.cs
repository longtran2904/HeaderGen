#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEditor.Build.Player;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor.Build.Content
{
    [NativeHeader("Modules/BuildPipeline/Editor/Public/ContentBuildTypes.h")]
    [NativeHeader("Modules/BuildPipeline/Editor/Shared/ContentBuildInterface.bindings.h")]
    [NativeHeader("Modules/BuildPipeline/Editor/Public/BuildUtilities.h")]
    [NativeHeader("Modules/BuildPipeline/Editor/Public/ContentBuildInterfaceProfile.h")]
    [StaticAccessor("BuildPipeline", StaticAccessorType.DoubleColon)]
    public static class ContentBuildInterface
    {
        public static AssetBundleBuild[] GenerateAssetBundleBuilds();
        public static BuildUsageTagGlobal GetGlobalUsageFromGraphicsSettings();
        public static BuildUsageTagGlobal GetGlobalUsageFromActiveScene(BuildTarget target);
        public static bool ObjectIsSupportedInBuild(UnityEngine.Object targetObject);
        public static SceneDependencyInfo CalculatePlayerDependenciesForScene(string scenePath, BuildSettings settings, BuildUsageTagSet usageSet);
        public static SceneDependencyInfo CalculatePlayerDependenciesForScene(string scenePath, BuildSettings settings, BuildUsageTagSet usageSet, BuildUsageCache usageCache);
        public static SceneDependencyInfo CalculatePlayerDependenciesForScene(string scenePath, BuildSettings settings, BuildUsageTagSet usageSet, BuildUsageCache usageCache, DependencyType mode);
        public static GameManagerDependencyInfo CalculatePlayerDependenciesForGameManagers(BuildSettings settings, BuildUsageTagGlobal globalUsage, BuildUsageTagSet usageSet);
        public static GameManagerDependencyInfo CalculatePlayerDependenciesForGameManagers(BuildSettings settings, BuildUsageTagGlobal globalUsage, BuildUsageTagSet usageSet, BuildUsageCache usageCache);
        public static GameManagerDependencyInfo CalculatePlayerDependenciesForGameManagers(BuildSettings settings, BuildUsageTagGlobal globalUsage, BuildUsageTagSet usageSet, BuildUsageCache usageCache, DependencyType mode);
        public static ObjectIdentifier[] GetPlayerObjectIdentifiersInAsset(GUID asset, BuildTarget target);
        public static ObjectIdentifier[] GetPlayerObjectIdentifiersInSerializedFile(string filePath, BuildTarget target);
        public static ObjectIdentifier[] GetPlayerDependenciesForObject(ObjectIdentifier objectID, BuildTarget target, TypeDB typeDB);
        public static ObjectIdentifier[] GetPlayerDependenciesForObject(ObjectIdentifier objectID, BuildTarget target, TypeDB typeDB, DependencyType mode);
        public static ObjectIdentifier[] GetPlayerDependenciesForObject(UnityEngine.Object targetObject, BuildTarget target, TypeDB typeDB);
        public static ObjectIdentifier[] GetPlayerDependenciesForObject(UnityEngine.Object targetObject, BuildTarget target, TypeDB typeDB, DependencyType mode);
        public static ObjectIdentifier[] GetPlayerDependenciesForObjects(ObjectIdentifier[] objectIDs, BuildTarget target, TypeDB typeDB);
        public static ObjectIdentifier[] GetPlayerDependenciesForObjects(ObjectIdentifier[] objectIDs, BuildTarget target, TypeDB typeDB, DependencyType mode);
        public static ObjectIdentifier[] GetPlayerDependenciesForObjects(UnityEngine.Object[] objects, BuildTarget target, TypeDB typeDB);
        public static ObjectIdentifier[] GetPlayerDependenciesForObjects(UnityEngine.Object[] objects, BuildTarget target, TypeDB typeDB, DependencyType mode);
        public static ObjectIdentifier[] GetPlayerAssetRepresentations(GUID asset, BuildTarget target);
        public static void CalculateBuildUsageTags(ObjectIdentifier[] objectIDs, ObjectIdentifier[] dependentObjectIDs, BuildUsageTagGlobal globalUsage, BuildUsageTagSet usageSet);
        public static void CalculateBuildUsageTags(ObjectIdentifier[] objectIDs, ObjectIdentifier[] dependentObjectIDs, BuildUsageTagGlobal globalUsage, BuildUsageTagSet usageSet, BuildUsageCache usageCache);
        public static Type GetTypeForObject(ObjectIdentifier objectID);
        public static Type[] GetTypesForObject(ObjectIdentifier objectID);
        public static Type[] GetTypeForObjects(ObjectIdentifier[] objectIDs);
        public static WriteResult WriteSerializedFile(string outputFolder, WriteParameters parameters);
        public static WriteResult WriteSceneSerializedFile(string outputFolder, WriteSceneParameters parameters);
        public static WriteResult WriteGameManagersSerializedFile(string outputFolder, WriteManagerParameters parameters);
        public static uint ArchiveAndCompress(ResourceFile[] resourceFiles, string outputBundlePath, BuildCompression compression);
        [ThreadSafe]
        public static uint ArchiveAndCompress(ResourceFile[] resourceFiles, string outputBundlePath, BuildCompression compression, bool stripUnityVersion);
        [NativeThrows]
        public static void StartProfileCapture(ProfileCaptureOptions options);
        [NativeThrows]
        public static ContentBuildProfileEvent[] StopProfileCapture();
        public static Hash128 CalculatePlayerSerializationHashForType(Type type, TypeDB typeDB);
        [Obsolete("ContentBuildInterface.PrepareScene has been deprecated. Use ContentBuildInterface.CalculatePlayerDependenciesForScene instead")]
        public static SceneDependencyInfo PrepareScene(string scenePath, BuildSettings settings, BuildUsageTagSet usageSet, string outputFolder);
        [Obsolete("ContentBuildInterface.PrepareScene has been deprecated. Use ContentBuildInterface.CalculatePlayerDependenciesForScene instead")]
        public static SceneDependencyInfo PrepareScene(string scenePath, BuildSettings settings, BuildUsageTagSet usageSet, BuildUsageCache usageCache, string outputFolder);
        [Obsolete("ContentBuildInterface.WriteSerializedFile has been deprecated. Use ContentBuildInterface.WriteSerializedFile instead")]
        public static WriteResult WriteSerializedFile(string outputFolder, WriteCommand writeCommand, BuildSettings settings, BuildUsageTagGlobal globalUsage, BuildUsageTagSet usageSet, BuildReferenceMap referenceMap);
        [Obsolete("ContentBuildInterface.WriteSerializedFile has been deprecated. Use ContentBuildInterface.WriteSerializedFile instead")]
        public static WriteResult WriteSerializedFile(string outputFolder, WriteCommand writeCommand, BuildSettings settings, BuildUsageTagGlobal globalUsage, BuildUsageTagSet usageSet, BuildReferenceMap referenceMap, AssetBundleInfo bundleInfo);
        [Obsolete("ContentBuildInterface.WriteSceneSerializedFile has been deprecated. Use ContentBuildInterface.WriteSceneSerializedFile instead")]
        public static WriteResult WriteSceneSerializedFile(string outputFolder, string scenePath, string processedScene, WriteCommand writeCommand, BuildSettings settings, BuildUsageTagGlobal globalUsage, BuildUsageTagSet usageSet, BuildReferenceMap referenceMap);
        [Obsolete("ContentBuildInterface.WriteSceneSerializedFile has been deprecated. Use ContentBuildInterface.WriteSceneSerializedFile with WriteParameters instead")]
        public static WriteResult WriteSceneSerializedFile(string outputFolder, string scenePath, string processedScene, WriteCommand writeCommand, BuildSettings settings, BuildUsageTagGlobal globalUsage, BuildUsageTagSet usageSet, BuildReferenceMap referenceMap, PreloadInfo preloadInfo);
        [Obsolete("ContentBuildInterface.WriteSceneSerializedFile has been deprecated. Use ContentBuildInterface.WriteSceneSerializedFile with WriteSceneParameters instead")]
        public static WriteResult WriteSceneSerializedFile(string outputFolder, string scenePath, string processedScene, WriteCommand writeCommand, BuildSettings settings, BuildUsageTagGlobal globalUsage, BuildUsageTagSet usageSet, BuildReferenceMap referenceMap, PreloadInfo preloadInfo, SceneBundleInfo sceneBundleInfo);
    }
}
