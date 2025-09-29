#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Events;
using UnityEngine.Internal;
using UnityEngine.SceneManagement;

namespace UnityEditor.SceneManagement
{
    [NativeHeader("Editor/Mono/EditorSceneManager.bindings.h")]
    [NativeHeader("Runtime/SceneManager/SceneManager.h")]
    [NativeHeader("Modules/AssetPipelineEditor/Public/DefaultImporter.h")]
    public sealed class EditorSceneManager : SceneManager
    {
        public const ulong DefaultSceneCullingMask = 16140901064495857664;

        public EditorSceneManager();

        public static int loadedSceneCount { get; }
        public static int loadedRootSceneCount { get; }
        public static int previewSceneCount { get; }
        public static bool preventCrossSceneReferences { get; set; }
        public static SceneAsset playModeStartScene { get; set; }

        public static event UnityAction<Scene, Scene> activeSceneChangedInEditMode;
        public static event NewSceneCreatedCallback newSceneCreated;
        public static event SceneOpeningCallback sceneOpening;
        public static event SceneOpenedCallback sceneOpened;
        public static event SceneClosingCallback sceneClosing;
        public static event SceneClosedCallback sceneClosed;
        public static event SceneSavingCallback sceneSaving;
        public static event SceneSavedCallback sceneSaved;
        public static event SceneDirtiedCallback sceneDirtied;

        [NativeMethod("IsReloading")]
        [StaticAccessor("GetSceneManager()", StaticAccessorType.Dot)]
        public static bool IsReloading(Scene scene);
        [NativeMethod("OpenScene")]
        [NativeThrows]
        [StaticAccessor("EditorSceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static Scene OpenScene(string scenePath, [DefaultValue("OpenSceneMode.Single")] OpenSceneMode mode);
        [NativeMethod("NewScene")]
        [NativeThrows]
        [StaticAccessor("EditorSceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static Scene NewScene(NewSceneSetup setup, [DefaultValue("NewSceneMode.Single")] NewSceneMode mode);
        public static Scene NewPreviewScene();
        [NativeMethod("CloseScene")]
        [NativeThrows]
        [StaticAccessor("EditorSceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static bool CloseScene(Scene scene, bool removeScene);
        [NativeMethod("ClosePreviewScene")]
        [NativeThrows]
        [StaticAccessor("EditorSceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static bool ClosePreviewScene(Scene scene);
        [NativeMethod("IsPreviewScene")]
        [StaticAccessor("EditorSceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static bool IsPreviewScene(Scene scene);
        [NativeMethod("IsPreviewSceneObject")]
        [StaticAccessor("EditorSceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static bool IsPreviewSceneObject(UnityEngine.Object obj);
        [NativeMethod("MoveSceneBefore")]
        [StaticAccessor("EditorSceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static void MoveSceneBefore(Scene src, Scene dst);
        [NativeMethod("MoveSceneAfter")]
        [StaticAccessor("EditorSceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static void MoveSceneAfter(Scene src, Scene dst);
        [NativeMethod("SaveOpenScenes")]
        [NativeThrows]
        [StaticAccessor("EditorSceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static bool SaveOpenScenes();
        [NativeMethod("SaveScenes")]
        [NativeThrows]
        [StaticAccessor("EditorSceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static bool SaveScenes([Unmarshalled] Scene[] scenes);
        [NativeMethod("SaveModifiedScenesIfUserWantsTo")]
        [NativeThrows]
        [StaticAccessor("EditorSceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static bool SaveModifiedScenesIfUserWantsTo([Unmarshalled] Scene[] scenes);
        [NativeMethod("EnsureUntitledSceneHasBeenSaved")]
        [StaticAccessor("GetSceneManager()", StaticAccessorType.Dot)]
        public static bool EnsureUntitledSceneHasBeenSaved(string dialogContent);
        [NativeMethod("MarkSceneDirty")]
        [NativeThrows]
        [StaticAccessor("EditorSceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static bool MarkSceneDirty(Scene scene);
        [NativeMethod("MarkAllScenesDirty")]
        [NativeThrows]
        [StaticAccessor("EditorSceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static void MarkAllScenesDirty();
        [NativeMethod("GetSceneManagerSetup")]
        [NativeThrows]
        [StaticAccessor("EditorSceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static SceneSetup[] GetSceneManagerSetup();
        [NativeMethod("RestoreSceneManagerSetup")]
        [NativeThrows]
        [StaticAccessor("EditorSceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static void RestoreSceneManagerSetup([Unmarshalled] SceneSetup[] value);
        [NativeMethod("DetectCrossSceneReferences")]
        [StaticAccessor("EditorSceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static bool DetectCrossSceneReferences(Scene scene);
        [StaticAccessor("EditorSceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static ulong GetSceneCullingMask(Scene scene);
        [StaticAccessor("EditorSceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static void SetSceneCullingMask(Scene scene, ulong sceneCullingMask);
        [StaticAccessor("GetSceneManager()", StaticAccessorType.Dot)]
        public static ulong CalculateAvailableSceneCullingMask();
        public static bool SaveCurrentModifiedScenesIfUserWantsTo();
        [ExcludeFromDocs]
        public static Scene OpenScene(string scenePath);
        [ExcludeFromDocs]
        public static Scene NewScene(NewSceneSetup setup);
        [ExcludeFromDocs]
        public static bool SaveScene(Scene scene, string dstScenePath);
        [ExcludeFromDocs]
        public static bool SaveScene(Scene scene);
        public static bool SaveScene(Scene scene, [DefaultValue("\"\"")] string dstScenePath, [DefaultValue("false")] bool saveAsCopy);
        public static Scene LoadSceneInPlayMode(string path, LoadSceneParameters parameters);
        public static AsyncOperation LoadSceneAsyncInPlayMode(string path, LoadSceneParameters parameters);

        public delegate void NewSceneCreatedCallback(Scene scene, NewSceneSetup setup, NewSceneMode mode);
        public delegate void SceneOpeningCallback(string path, OpenSceneMode mode);
        public delegate void SceneOpenedCallback(Scene scene, OpenSceneMode mode);
        public delegate void SceneClosingCallback(Scene scene, bool removingScene);
        public delegate void SceneClosedCallback(Scene scene);
        public delegate void SceneSavingCallback(Scene scene, string path);
        public delegate void SceneSavedCallback(Scene scene);
        public delegate void SceneDirtiedCallback(Scene scene);
    }
}
