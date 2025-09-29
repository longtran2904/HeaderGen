#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.SceneManagement
{
    [NativeHeader("Runtime/Export/SceneManager/SceneUtility.bindings.h")]
    public static class SceneUtility
    {

        [StaticAccessor("SceneUtilityBindings", StaticAccessorType.DoubleColon)]
        public static string GetScenePathByBuildIndex(int buildIndex);
        [StaticAccessor("SceneUtilityBindings", StaticAccessorType.DoubleColon)]
        public static int GetBuildIndexByScenePath(string scenePath);
    }
}
