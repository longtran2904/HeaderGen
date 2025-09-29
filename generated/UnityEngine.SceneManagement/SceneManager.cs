#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Events;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.SceneManagement
{
    [NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
    [RequiredByNativeCode]
    public class SceneManager
    {

        public SceneManager();

        public static int sceneCount { get; }
        public static int sceneCountInBuildSettings { get; }

        public static event UnityAction<Scene, LoadSceneMode> sceneLoaded;
        public static event UnityAction<Scene> sceneUnloaded;
        public static event UnityAction<Scene, Scene> activeSceneChanged;

        [StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static Scene GetActiveScene();
        [NativeThrows]
        [StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static bool SetActiveScene(Scene scene);
        [StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static Scene GetSceneByPath(string scenePath);
        [StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static Scene GetSceneByName(string name);
        public static Scene GetSceneByBuildIndex(int buildIndex);
        [NativeThrows]
        [StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static Scene GetSceneAt(int index);
        [NativeThrows]
        [StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static Scene CreateScene([NotNull("ArgumentNullException")] string sceneName, CreateSceneParameters parameters);
        [NativeThrows]
        [StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static void MergeScenes(Scene sourceScene, Scene destinationScene);
        [NativeThrows]
        [StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
        public static void MoveGameObjectToScene([NotNull("ArgumentNullException")] GameObject go, Scene scene);
        [Obsolete("Use SceneManager.sceneCount and SceneManager.GetSceneAt(int index) to loop the all scenes instead.")]
        public static Scene[] GetAllScenes();
        public static Scene CreateScene(string sceneName);
        public static void LoadScene(string sceneName, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode);
        [ExcludeFromDocs]
        public static void LoadScene(string sceneName);
        public static Scene LoadScene(string sceneName, LoadSceneParameters parameters);
        public static void LoadScene(int sceneBuildIndex, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode);
        [ExcludeFromDocs]
        public static void LoadScene(int sceneBuildIndex);
        public static Scene LoadScene(int sceneBuildIndex, LoadSceneParameters parameters);
        public static AsyncOperation LoadSceneAsync(int sceneBuildIndex, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode);
        [ExcludeFromDocs]
        public static AsyncOperation LoadSceneAsync(int sceneBuildIndex);
        public static AsyncOperation LoadSceneAsync(int sceneBuildIndex, LoadSceneParameters parameters);
        public static AsyncOperation LoadSceneAsync(string sceneName, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode);
        [ExcludeFromDocs]
        public static AsyncOperation LoadSceneAsync(string sceneName);
        public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters);
        [Obsolete("Use SceneManager.UnloadSceneAsync. This function is not safe to use during triggers and under other circumstances. See Scripting reference for more details.")]
        public static bool UnloadScene(Scene scene);
        [Obsolete("Use SceneManager.UnloadSceneAsync. This function is not safe to use during triggers and under other circumstances. See Scripting reference for more details.")]
        public static bool UnloadScene(int sceneBuildIndex);
        [Obsolete("Use SceneManager.UnloadSceneAsync. This function is not safe to use during triggers and under other circumstances. See Scripting reference for more details.")]
        public static bool UnloadScene(string sceneName);
        public static AsyncOperation UnloadSceneAsync(int sceneBuildIndex);
        public static AsyncOperation UnloadSceneAsync(string sceneName);
        public static AsyncOperation UnloadSceneAsync(Scene scene);
        public static AsyncOperation UnloadSceneAsync(int sceneBuildIndex, UnloadSceneOptions options);
        public static AsyncOperation UnloadSceneAsync(string sceneName, UnloadSceneOptions options);
        public static AsyncOperation UnloadSceneAsync(Scene scene, UnloadSceneOptions options);
    }
}
