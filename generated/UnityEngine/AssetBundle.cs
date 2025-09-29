#region UnityEngine.AssetBundleModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AssetBundleModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEngine
{
    [ExcludeFromPreset]
    [NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromMemoryAsyncOperation.h")]
    [NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromManagedStreamAsyncOperation.h")]
    [NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
    [NativeHeader("Runtime/Scripting/ScriptingExportUtility.h")]
    [NativeHeader("Runtime/Scripting/ScriptingObjectWithIntPtrField.h")]
    [NativeHeader("Runtime/Scripting/ScriptingUtility.h")]
    [NativeHeader("AssetBundleScriptingClasses.h")]
    [NativeHeader("Modules/AssetBundle/Public/AssetBundleSaveAndLoadHelper.h")]
    [NativeHeader("Modules/AssetBundle/Public/AssetBundleUtility.h")]
    [NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetUtility.h")]
    [NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromFileAsyncOperation.h")]
    public class AssetBundle : Object
    {

        [Obsolete("mainAsset has been made obsolete. Please use the new AssetBundle build system introduced in 5.0 and check BuildAssetBundles documentation for details.")]
        public Object mainAsset { get; }
        public bool isStreamedSceneAssetBundle { get; }
        public static uint memoryBudgetKB { get; set; }

        [FreeFunction("UnloadAllAssetBundles")]
        public static void UnloadAllAssetBundles(bool unloadAllObjects);
        public static IEnumerable<AssetBundle> GetAllLoadedAssetBundles();
        public static AssetBundleCreateRequest LoadFromFileAsync(string path);
        public static AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc);
        public static AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc, ulong offset);
        public static AssetBundle LoadFromFile(string path);
        public static AssetBundle LoadFromFile(string path, uint crc);
        public static AssetBundle LoadFromFile(string path, uint crc, ulong offset);
        public static AssetBundleCreateRequest LoadFromMemoryAsync(byte[] binary);
        public static AssetBundleCreateRequest LoadFromMemoryAsync(byte[] binary, uint crc);
        public static AssetBundle LoadFromMemory(byte[] binary);
        public static AssetBundle LoadFromMemory(byte[] binary, uint crc);
        public static AssetBundleCreateRequest LoadFromStreamAsync(Stream stream, uint crc, uint managedReadBufferSize);
        public static AssetBundleCreateRequest LoadFromStreamAsync(Stream stream, uint crc);
        public static AssetBundleCreateRequest LoadFromStreamAsync(Stream stream);
        public static AssetBundle LoadFromStream(Stream stream, uint crc, uint managedReadBufferSize);
        public static AssetBundle LoadFromStream(Stream stream, uint crc);
        public static AssetBundle LoadFromStream(Stream stream);
        [NativeMethod("Contains")]
        public bool Contains(string name);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Method Load has been deprecated. Script updater cannot update it as the loading behaviour has changed. Please use LoadAsset instead and check the documentation for details.", True)]
        public Object Load(string name);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Method Load has been deprecated. Script updater cannot update it as the loading behaviour has changed. Please use LoadAsset instead and check the documentation for details.", True)]
        public Object Load<T>(string name);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Method LoadAll has been deprecated. Script updater cannot update it as the loading behaviour has changed. Please use LoadAllAssets instead and check the documentation for details.", True)]
        public Object[] LoadAll();
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Method LoadAll has been deprecated. Script updater cannot update it as the loading behaviour has changed. Please use LoadAllAssets instead and check the documentation for details.", True)]
        public T[] LoadAll<T>() where T : Object;
        public Object LoadAsset(string name);
        public T LoadAsset<T>(string name) where T : Object;
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
        public Object LoadAsset(string name, Type type);
        public AssetBundleRequest LoadAssetAsync(string name);
        public AssetBundleRequest LoadAssetAsync<T>(string name);
        public AssetBundleRequest LoadAssetAsync(string name, Type type);
        public Object[] LoadAssetWithSubAssets(string name);
        public T[] LoadAssetWithSubAssets<T>(string name) where T : Object;
        public Object[] LoadAssetWithSubAssets(string name, Type type);
        public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name);
        public AssetBundleRequest LoadAssetWithSubAssetsAsync<T>(string name);
        public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name, Type type);
        public Object[] LoadAllAssets();
        public T[] LoadAllAssets<T>() where T : Object;
        public Object[] LoadAllAssets(Type type);
        public AssetBundleRequest LoadAllAssetsAsync();
        public AssetBundleRequest LoadAllAssetsAsync<T>();
        public AssetBundleRequest LoadAllAssetsAsync(Type type);
        [Obsolete("This method is deprecated.Use GetAllAssetNames() instead.", False)]
        public string[] AllAssetNames();
        [NativeMethod("Unload")]
        [NativeThrows]
        public void Unload(bool unloadAllLoadedObjects);
        [NativeMethod("UnloadAsync")]
        [NativeThrows]
        public AsyncOperation UnloadAsync(bool unloadAllLoadedObjects);
        [NativeMethod("GetAllAssetNames")]
        public string[] GetAllAssetNames();
        [NativeMethod("GetAllScenePaths")]
        public string[] GetAllScenePaths();
        public static AssetBundleRecompressOperation RecompressAssetBundleAsync(string inputPath, string outputPath, BuildCompression method, uint expectedCRC = 0, ThreadPriority priority = ThreadPriority.Low);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Method CreateFromFile has been renamed to LoadFromFile (UnityUpgradable) -> LoadFromFile(*)", True)]
        public static AssetBundle CreateFromFile(string path);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Method CreateFromMemory has been renamed to LoadFromMemoryAsync (UnityUpgradable) -> LoadFromMemoryAsync(*)", True)]
        public static AssetBundleCreateRequest CreateFromMemory(byte[] binary);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Method CreateFromMemoryImmediate has been renamed to LoadFromMemory (UnityUpgradable) -> LoadFromMemory(*)", True)]
        public static AssetBundle CreateFromMemoryImmediate(byte[] binary);
    }
}
