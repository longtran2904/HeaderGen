#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.SearchService
{
    [Obsolete("Project has been deprecated. Use ProjectSearch instead (UnityUpgradable) -> ProjectSearch", False)]
    public static class Project
    {

        public const SearchEngineScope EngineScope = 1;

        public static void RegisterEngine(IProjectSearchEngine engine);
        public static void UnregisterEngine(IProjectSearchEngine engine);
    }
}
