#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.SceneManagement;

namespace UnityEditor.SceneManagement
{
    public static class SceneHierarchyHooks
    {

        public static Func<SubSceneInfo[]> provideSubScenes;
        public static Func<SubSceneInfo, string> provideSubSceneName;

        public static event Action<GenericMenu, GameObject> addItemsToGameObjectContextMenu;
        public static event Action<GenericMenu, Scene> addItemsToSceneHeaderContextMenu;
        public static event Action<GenericMenu, SubSceneInfo> addItemsToSubSceneHeaderContextMenu;
        public static event Action<GenericMenu> addItemsToCreateMenu;

        public static void ReloadAllSceneHierarchies();
        public static bool CanSetNewParent(Transform transform, Transform newParent);
        public static bool CanMoveTransformToScene(Transform transform, Scene scene);
        [NativeType(IntermediateScriptingStructName = "SceneHierarchyHooks_SubSceneInfo")]
        public struct SubSceneInfo
        {

            public Transform transform;
            public Scene scene;
            [Ignore]
            public SceneAsset sceneAsset;
            [Ignore]
            public string sceneName;
            [Ignore]
            public Color32 color;

            public bool isValid { get; }
        }
    }
}
