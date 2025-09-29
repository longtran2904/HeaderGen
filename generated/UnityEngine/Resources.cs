#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEngine
{
    [NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
    [NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
    public sealed class Resources
    {

        public Resources();

        public static Object[] FindObjectsOfTypeAll(Type type);
        public static T[] FindObjectsOfTypeAll<T>() where T : Object;
        public static Object Load(string path);
        public static T Load<T>(string path) where T : Object;
        public static Object Load(string path, Type systemTypeInstance);
        public static ResourceRequest LoadAsync(string path);
        public static ResourceRequest LoadAsync<T>(string path) where T : Object;
        public static ResourceRequest LoadAsync(string path, Type type);
        public static Object[] LoadAll(string path, Type systemTypeInstance);
        public static Object[] LoadAll(string path);
        public static T[] LoadAll<T>(string path) where T : Object;
        [FreeFunction("GetScriptingBuiltinResource", ThrowsException = True)]
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public static Object GetBuiltinResource([NotNull("ArgumentNullException")] Type type, string path);
        public static T GetBuiltinResource<T>(string path) where T : Object;
        public static void UnloadAsset(Object assetToUnload);
        [FreeFunction("Resources_Bindings::UnloadUnusedAssets")]
        public static AsyncOperation UnloadUnusedAssets();
        [FreeFunction("Resources_Bindings::InstanceIDToObject")]
        public static Object InstanceIDToObject(int instanceID);
        public static void InstanceIDToObjectList(NativeArray<int> instanceIDs, List<Object> objects);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use AssetDatabase.LoadAssetAtPath instead (UnityUpgradable) -> * [UnityEditor] UnityEditor.AssetDatabase.LoadAssetAtPath(*)", True)]
        [TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
        public static Object LoadAssetAtPath(string assetPath, Type type);
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use AssetDatabase.LoadAssetAtPath<T>() instead (UnityUpgradable) -> * [UnityEditor] UnityEditor.AssetDatabase.LoadAssetAtPath<T>(*)", True)]
        public static T LoadAssetAtPath<T>(string assetPath) where T : Object;
    }
}
