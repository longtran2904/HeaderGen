#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/ScriptCompilation/ScriptCompilationPipeline.h")]
    [NativeHeader("Runtime/BaseClasses/TagManager.h")]
    [NativeHeader("Runtime/Camera/RenderSettings.h")]
    [NativeHeader("Runtime/Input/TimeManager.h")]
    [NativeHeader("Editor/Src/ProjectVersion.h")]
    [NativeHeader("Editor/Mono/EditorApplication.bindings.h")]
    [StaticAccessor("EditorApplicationBindings", StaticAccessorType.DoubleColon)]
    public sealed class EditorApplication
    {

        public static ProjectWindowItemCallback projectWindowItemOnGUI;
        public static HierarchyWindowItemCallback hierarchyWindowItemOnGUI;
        public static CallbackFunction update;
        public static CallbackFunction delayCall;
        [Obsolete("Use EditorApplication.hierarchyChanged")]
        public static CallbackFunction hierarchyWindowChanged;
        [Obsolete("Use EditorApplication.projectChanged")]
        public static CallbackFunction projectWindowChanged;
        public static CallbackFunction searchChanged;
        public static CallbackFunction modifierKeysChanged;
        [Obsolete("Use EditorApplication.playModeStateChanged and/or EditorApplication.pauseStateChanged")]
        public static CallbackFunction playmodeStateChanged;
        public static SerializedPropertyCallbackFunction contextualPropertyMenu;

        public EditorApplication();

        public static bool isPlaying { get; set; }
        [StaticAccessor("GetApplication()", StaticAccessorType.Dot)]
        public static bool isPlayingOrWillChangePlaymode { get; }
        [StaticAccessor("GetApplication().GetPlayerLoopController()", StaticAccessorType.Dot)]
        public static bool isPaused { get; set; }
        public static bool isCompiling { get; }
        public static bool isUpdating { get; }
        public static bool isRemoteConnected { get; }
        [Obsolete("ScriptingRuntimeVersion has been deprecated in 2019.3 due to the removal of legacy mono")]
        public static ScriptingRuntimeVersion scriptingRuntimeVersion { get; }
        public static string applicationContentsPath { get; }
        public static string applicationPath { get; }
        public static bool isTemporaryProject { get; }
        public static double timeSinceStartup { get; }
        [Obsolete("Use Scene.isDirty instead. Use EditorSceneManager.GetScene API to get each open scene")]
        public static bool isSceneDirty { get; }
        [Obsolete("Use EditorSceneManager to see which scenes are currently loaded")]
        public static string currentScene { get; set; }

        public static event Func<bool> wantsToQuit;
        public static event Action quitting;
        public static event Action hierarchyChanged;
        public static event Action projectChanged;
        public static event Action<PauseState> pauseStateChanged;
        public static event Action<PlayModeStateChange> playModeStateChanged;

        [Obsolete("Use EditorSceneManager.LoadSceneInPlayMode instead.")]
        public static void LoadLevelInPlayMode(string path);
        [Obsolete("Use EditorSceneManager.LoadSceneInPlayMode instead.")]
        public static void LoadLevelAdditiveInPlayMode(string path);
        [Obsolete("Use EditorSceneManager.LoadSceneAsyncInPlayMode instead.")]
        public static AsyncOperation LoadLevelAsyncInPlayMode(string path);
        [Obsolete("Use EditorSceneManager.LoadSceneAsyncInPlayMode instead.")]
        public static AsyncOperation LoadLevelAdditiveAsyncInPlayMode(string path);
        public static void OpenProject(string projectPath, params string[] args);
        [Obsolete("Use AssetDatabase.SaveAssets instead (UnityUpgradable) -> AssetDatabase.SaveAssets()", True)]
        public static void SaveAssets();
        public static void EnterPlaymode();
        public static void ExitPlaymode();
        [StaticAccessor("GetApplication().GetPlayerLoopController()", StaticAccessorType.Dot)]
        public static void Step();
        [StaticAccessor("GetApplication()", StaticAccessorType.Dot)]
        public static void LockReloadAssemblies();
        [StaticAccessor("GetApplication()", StaticAccessorType.Dot)]
        public static void UnlockReloadAssemblies();
        public static bool ExecuteMenuItem(string menuItemPath);
        [NativeThrows]
        public static void SetTemporaryProjectKeepPath(string path);
        public static void Exit(int returnValue);
        public static void QueuePlayerLoopUpdate();
        [FreeFunction("UnityBeep")]
        public static void Beep();
        public static void RepaintProjectWindow();
        public static void RepaintAnimationWindow();
        public static void RepaintHierarchyWindow();
        public static void DirtyHierarchyWindowSorting();
        [Obsolete("Use EditorSceneManager.NewScene (NewSceneSetup.DefaultGameObjects)")]
        public static void NewScene();
        [Obsolete("Use EditorSceneManager.NewScene (NewSceneSetup.EmptyScene)")]
        public static void NewEmptyScene();
        [Obsolete("Use EditorSceneManager.OpenScene")]
        public static bool OpenScene(string path);
        [Obsolete("Use EditorSceneManager.OpenScene")]
        public static void OpenSceneAdditive(string path);
        [Obsolete("Use EditorSceneManager.SaveScene")]
        public static bool SaveScene();
        [Obsolete("Use EditorSceneManager.SaveScene")]
        public static bool SaveScene(string path);
        [Obsolete("Use EditorSceneManager.SaveScene")]
        public static bool SaveScene(string path, bool saveAsCopy);
        [Obsolete("Use EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo")]
        public static bool SaveCurrentSceneIfUserWantsTo();
        [Obsolete("Use EditorSceneManager.MarkSceneDirty or EditorSceneManager.MarkAllScenesDirty")]
        public static void MarkSceneDirty();
        public delegate void ProjectWindowItemCallback(string guid, Rect selectionRect);
        public delegate void HierarchyWindowItemCallback(int instanceID, Rect selectionRect);
        public delegate void CallbackFunction();
        public delegate void SerializedPropertyCallbackFunction(GenericMenu menu, SerializedProperty property);
    }
}
