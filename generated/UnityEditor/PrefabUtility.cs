#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.SceneManagement;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/Prefabs/PrefabInstance.h")]
    [NativeHeader("Editor/Mono/Prefabs/PrefabUtility.bindings.h")]
    [NativeHeader("Editor/Src/Prefabs/PrefabConnection.h")]
    [NativeHeader("Editor/Src/Prefabs/Prefab.h")]
    [NativeHeader("Editor/Src/Prefabs/PrefabCreation.h")]
    public sealed class PrefabUtility
    {

        public static PrefabInstanceUpdated prefabInstanceUpdated;

        public PrefabUtility();

        [Obsolete("Use GetPrefabInstanceHandle for Prefab instances. Handles for Prefab Assets has been discontinued.")]
        [StaticAccessor("PrefabUtilityBindings", StaticAccessorType.DoubleColon)]
        public static UnityEngine.Object GetPrefabObject(UnityEngine.Object targetObject);
        [StaticAccessor("PrefabUtilityBindings", StaticAccessorType.DoubleColon)]
        public static UnityEngine.Object GetPrefabInstanceHandle(UnityEngine.Object instanceComponentOrGameObject);
        [NativeThrows]
        [StaticAccessor("PrefabUtilityBindings", StaticAccessorType.DoubleColon)]
        public static bool HasManagedReferencesWithMissingTypes(UnityEngine.Object assetComponentOrGameObject);
        [StaticAccessor("PrefabUtilityBindings", StaticAccessorType.DoubleColon)]
        public static PropertyModification[] GetPropertyModifications(UnityEngine.Object targetPrefab);
        [StaticAccessor("PrefabUtilityBindings", StaticAccessorType.DoubleColon)]
        public static void SetPropertyModifications(UnityEngine.Object targetPrefab, PropertyModification[] modifications);
        [FreeFunction]
        public static bool HasPrefabInstanceAnyOverrides(GameObject instanceRoot, bool includeDefaultOverrides);
        [Obsolete("InstantiateAttachedAsset is deprecated")]
        public static UnityEngine.Object InstantiateAttachedAsset(UnityEngine.Object targetObject);
        [FreeFunction]
        public static void RecordPrefabInstancePropertyModifications([NotNull("NullExceptionObject")] UnityEngine.Object targetObject);
        [NativeThrows]
        [Obsolete("MergeAllPrefabInstances is deprecated. Prefabs are merged automatically. There is no need to call this method.")]
        [StaticAccessor("PrefabUtilityBindings", StaticAccessorType.DoubleColon)]
        public static void MergeAllPrefabInstances(UnityEngine.Object targetObject);
        [NativeThrows]
        [StaticAccessor("PrefabUtilityBindings", StaticAccessorType.DoubleColon)]
        public static GameObject[] UnpackPrefabInstanceAndReturnNewOutermostRoots(GameObject instanceRoot, PrefabUnpackMode unpackMode);
        [NativeThrows]
        [StaticAccessor("PrefabUtilityBindings", StaticAccessorType.DoubleColon)]
        public static void LoadPrefabContentsIntoPreviewScene(string prefabPath, Scene scene);
        [NativeThrows]
        [Obsolete("Use RevertPrefabInstance. Prefabs instances can no longer be connected to Prefab Assets they are not an instance of to begin with.")]
        [StaticAccessor("PrefabUtilityBindings", StaticAccessorType.DoubleColon)]
        public static GameObject ConnectGameObjectToPrefab([NotNull("ArgumentNullException")] GameObject go, [NotNull("ArgumentNullException")] GameObject sourcePrefab);
        [FreeFunction]
        [Obsolete("FindRootGameObjectWithSameParentPrefab is deprecated, please use GetOutermostPrefabInstanceRoot instead.")]
        public static GameObject FindRootGameObjectWithSameParentPrefab([NotNull("NullExceptionObject")] GameObject target);
        [NativeMethod("FindInstanceRootGameObject", IsFreeFunction = True)]
        [Obsolete("FindValidUploadPrefabInstanceRoot is deprecated, please use GetOutermostPrefabInstanceRoot instead.")]
        public static GameObject FindValidUploadPrefabInstanceRoot([NotNull("NullExceptionObject")] GameObject target);
        [FreeFunction]
        [Obsolete("Use RevertPrefabInstance.")]
        public static bool ReconnectToLastPrefab([NotNull("NullExceptionObject")] GameObject go);
        [Obsolete("Use RevertObjectOverride.")]
        [StaticAccessor("PrefabUtilityBindings", StaticAccessorType.DoubleColon)]
        public static bool ResetToPrefabState(UnityEngine.Object obj);
        [FreeFunction]
        public static bool IsAddedComponentOverride([NotNull("ArgumentNullException")] UnityEngine.Object component);
        [FreeFunction]
        [Obsolete("Use the overload that takes an InteractionMode parameter.")]
        public static bool RevertPrefabInstance([NotNull("ArgumentNullException")] GameObject go);
        [FreeFunction]
        [Obsolete("Use GetOutermostPrefabInstanceRoot if source is a Prefab instance or source.transform.root.gameObject if source is a Prefab Asset object.")]
        public static GameObject FindPrefabRoot([NotNull("ArgumentNullException")] GameObject source);
        [FreeFunction]
        public static bool IsPartOfAnyPrefab([NotNull("ArgumentNullException")] UnityEngine.Object componentOrGameObject);
        [FreeFunction]
        public static bool IsPartOfPrefabAsset([NotNull("ArgumentNullException")] UnityEngine.Object componentOrGameObject);
        [FreeFunction]
        public static bool IsPartOfPrefabInstance([NotNull("ArgumentNullException")] UnityEngine.Object componentOrGameObject);
        [FreeFunction]
        public static bool IsPartOfNonAssetPrefabInstance([NotNull("ArgumentNullException")] UnityEngine.Object componentOrGameObject);
        [FreeFunction]
        public static bool IsPartOfRegularPrefab([NotNull("ArgumentNullException")] UnityEngine.Object componentOrGameObject);
        [FreeFunction]
        public static bool IsPartOfModelPrefab([NotNull("ArgumentNullException")] UnityEngine.Object componentOrGameObject);
        [FreeFunction]
        public static bool IsPartOfVariantPrefab([NotNull("ArgumentNullException")] UnityEngine.Object componentOrGameObject);
        [FreeFunction]
        public static bool IsPartOfImmutablePrefab([NotNull("ArgumentNullException")] UnityEngine.Object componentOrGameObject);
        [FreeFunction]
        public static bool IsPrefabAssetMissing([NotNull("ArgumentNullException")] UnityEngine.Object instanceComponentOrGameObject);
        [FreeFunction]
        public static GameObject GetOutermostPrefabInstanceRoot([NotNull("ArgumentNullException")] UnityEngine.Object componentOrGameObject);
        [FreeFunction]
        public static GameObject GetNearestPrefabInstanceRoot([NotNull("ArgumentNullException")] UnityEngine.Object componentOrGameObject);
        [NativeMethod("PrefabUtilityBindings::IsDefaultOverride", IsFreeFunction = True)]
        public static bool IsDefaultOverride(PropertyModification modification);
        public static GameObject[] FindAllInstancesOfPrefab(GameObject prefabRoot);
        public static GameObject[] FindAllInstancesOfPrefab(GameObject prefabRoot, Scene scene);
        public static void MergePrefabInstance(GameObject instanceRoot);
        public static void RevertPrefabInstance(GameObject instanceRoot, InteractionMode action);
        public static void ApplyPrefabInstance(GameObject instanceRoot, InteractionMode action);
        public static void ApplyPropertyOverride(SerializedProperty instanceProperty, string assetPath, InteractionMode action);
        public static void RevertPropertyOverride(SerializedProperty instanceProperty, InteractionMode action);
        public static void ApplyObjectOverride(UnityEngine.Object instanceComponentOrGameObject, string assetPath, InteractionMode action);
        public static void RevertObjectOverride(UnityEngine.Object instanceComponentOrGameObject, InteractionMode action);
        public static void ApplyAddedComponent(Component component, string assetPath, InteractionMode action);
        public static void RevertAddedComponent(Component component, InteractionMode action);
        public static void ApplyRemovedComponent(GameObject instanceGameObject, Component assetComponent, InteractionMode action);
        public static void RevertRemovedComponent(GameObject instanceGameObject, Component assetComponent, InteractionMode action);
        public static void ApplyAddedGameObject(GameObject gameObject, string assetPath, InteractionMode action);
        public static void ApplyAddedGameObjects(GameObject[] gameObjects, string assetPath, InteractionMode action);
        public static void RevertAddedGameObject(GameObject gameObject, InteractionMode action);
        public static List<ObjectOverride> GetObjectOverrides(GameObject prefabInstance, bool includeDefaultOverrides = False);
        public static List<AddedComponent> GetAddedComponents(GameObject prefabInstance);
        public static List<RemovedComponent> GetRemovedComponents(GameObject prefabInstance);
        public static List<AddedGameObject> GetAddedGameObjects(GameObject prefabInstance);
        public static bool IsAnyPrefabInstanceRoot(GameObject gameObject);
        public static bool IsOutermostPrefabInstanceRoot(GameObject gameObject);
        public static string GetPrefabAssetPathOfNearestInstanceRoot(UnityEngine.Object instanceComponentOrGameObject);
        [Obsolete("The concept of disconnecting Prefab instances has been deprecated. This method always returns False.")]
        public static bool IsDisconnectedFromPrefabAsset(UnityEngine.Object componentOrGameObject);
        [Obsolete("The concept of disconnecting Prefab instances has been deprecated. This method does nothing.")]
        public static void DisconnectPrefabInstance(UnityEngine.Object targetObject);
        public static Texture2D GetIconForGameObject(GameObject gameObject);
        [Obsolete("Use GetCorrespondingObjectFromSource.")]
        public static UnityEngine.Object GetPrefabParent(UnityEngine.Object obj);
        [Obsolete("The concept of creating a completely empty Prefab has been discontinued. You can however use SaveAsPrefabAsset with an empty GameObject.")]
        public static UnityEngine.Object CreateEmptyPrefab(string path);
        public static GameObject SavePrefabAsset(GameObject asset);
        public static GameObject SavePrefabAsset(GameObject asset, out bool savedSuccessfully);
        public static GameObject SaveAsPrefabAsset(GameObject instanceRoot, string assetPath, out bool success);
        public static GameObject SaveAsPrefabAsset(GameObject instanceRoot, string assetPath);
        public static GameObject SaveAsPrefabAssetAndConnect(GameObject instanceRoot, string assetPath, InteractionMode action);
        public static GameObject SaveAsPrefabAssetAndConnect(GameObject instanceRoot, string assetPath, InteractionMode action, out bool success);
        [Obsolete("Use SaveAsPrefabAsset instead.")]
        public static GameObject CreatePrefab(string path, GameObject go);
        [Obsolete("Use SaveAsPrefabAsset or SaveAsPrefabAssetAndConnect instead.")]
        public static GameObject CreatePrefab(string path, GameObject go, ReplacePrefabOptions options);
        public static UnityEngine.Object InstantiatePrefab(UnityEngine.Object assetComponentOrGameObject);
        public static UnityEngine.Object InstantiatePrefab(UnityEngine.Object assetComponentOrGameObject, Scene destinationScene);
        public static UnityEngine.Object InstantiatePrefab(UnityEngine.Object assetComponentOrGameObject, Transform parent);
        [Obsolete("Use SaveAsPrefabAsset with a path instead.")]
        public static GameObject ReplacePrefab(GameObject go, UnityEngine.Object targetPrefab);
        [Obsolete("Use SaveAsPrefabAsset or SaveAsPrefabAssetAndConnect with a path instead.")]
        public static GameObject ReplacePrefab(GameObject go, UnityEngine.Object targetPrefab, ReplacePrefabOptions replaceOptions);
        public static TObject GetCorrespondingObjectFromSource<TObject>(TObject componentOrGameObject) where TObject : UnityEngine.Object;
        public static TObject GetCorrespondingObjectFromOriginalSource<TObject>(TObject componentOrGameObject) where TObject : UnityEngine.Object;
        public static TObject GetCorrespondingObjectFromSourceAtPath<TObject>(TObject componentOrGameObject, string assetPath) where TObject : UnityEngine.Object;
        [Obsolete("Use GetPrefabAssetType and GetPrefabInstanceStatus to get the full picture about Prefab types.")]
        public static PrefabType GetPrefabType(UnityEngine.Object target);
        public static bool IsAddedGameObjectOverride(GameObject gameObject);
        public static void UnpackPrefabInstance(GameObject instanceRoot, PrefabUnpackMode unpackMode, InteractionMode action);
        public static void UnpackAllInstancesOfPrefab(GameObject prefabRoot, PrefabUnpackMode unpackMode, InteractionMode action);
        public static bool IsPartOfPrefabThatCanBeAppliedTo(UnityEngine.Object gameObjectOrComponent);
        public static PrefabInstanceStatus GetPrefabInstanceStatus(UnityEngine.Object componentOrGameObject);
        public static PrefabAssetType GetPrefabAssetType(UnityEngine.Object componentOrGameObject);
        public static GameObject LoadPrefabContents(string assetPath);
        public static void UnloadPrefabContents(GameObject contentsRoot);
        public delegate void PrefabInstanceUpdated(GameObject instance);
        public struct EditPrefabContentsScope : IDisposable
        {

            public readonly string assetPath;
            public readonly GameObject prefabContentsRoot;

            public EditPrefabContentsScope(string assetPath);

            public void Dispose();
        }
    }
}
