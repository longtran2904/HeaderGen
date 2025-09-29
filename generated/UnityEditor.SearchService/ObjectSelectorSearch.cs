#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.SearchService
{
    [InitializeOnLoad]
    public static class ObjectSelectorSearch
    {
        public const SearchEngineScope EngineScope = 2;

        public static void RegisterEngine(IObjectSelectorEngine engine);
        public static void UnregisterEngine(IObjectSelectorEngine engine);
    }
}
