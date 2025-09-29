#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.SearchService
{
    [Obsolete("Scene has been deprecated. Use SceneSearch instead (UnityUpgradable) -> SceneSearch", False)]
    public static class Scene
    {
        public const SearchEngineScope EngineScope = 0;

        public static void RegisterEngine(ISceneSearchEngine engine);
        public static void UnregisterEngine(ISceneSearchEngine engine);
    }
}
