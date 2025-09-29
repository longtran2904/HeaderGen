#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityEditor.Search
{
    public static class SearchUtils
    {
        public static readonly char[] entrySeparators;

        public static string[] FindShiftLeftVariations(string word);
        public static string[] SplitCamelCase(string source);
        public static IEnumerable<string> SplitEntryComponents(string entry, char[] entrySeparators);
        public static IEnumerable<string> SplitFileEntryComponents(string path, in char[] entrySeparators);
        public static string GetTransformPath(Transform tform);
        public static string GetObjectPath(UnityEngine.Object obj);
        public static string GetHierarchyPath(GameObject gameObject, bool includeScene = True);
        public static string GetHierarchyAssetPath(GameObject gameObject, bool prefabOnly = False);
        public static void SelectMultipleItems(IEnumerable<SearchItem> items, bool focusProjectBrowser = False, bool pingSelection = True);
        public static bool MatchSearchGroups(SearchContext context, string content, bool ignoreCase = False);
        public static GameObject[] FetchGameObjects(Scene scene);
        public static IEnumerable<GameObject> FetchGameObjects();
        public static string GetAssetPath(in SearchItem item);
    }
}
