#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{
    public static class SearchService
    {

        public static List<SearchProvider> Providers { get; }
        public static IEnumerable<SearchProvider> OrderedProviders { get; }

        public static SearchProvider GetProvider(string providerId);
        public static SearchAction GetAction(SearchProvider provider, string actionId);
        public static void SetActive(string providerId, bool active = True);
        public static void Refresh();
        public static void RefreshWindows();
        public static SearchContext CreateContext(IEnumerable<string> providerIds, string searchText = "", SearchFlags flags = SearchFlags.Default);
        public static SearchContext CreateContext(IEnumerable<SearchProvider> providers, string searchText = "", SearchFlags flags = SearchFlags.Default);
        public static SearchContext CreateContext(SearchProvider provider, string searchText = "");
        public static SearchContext CreateContext(string providerId, string searchText = "", SearchFlags flags = SearchFlags.Default);
        public static SearchContext CreateContext(string searchText, SearchFlags flags);
        public static SearchContext CreateContext(string searchText);
        public static List<SearchItem> GetItems(SearchContext context, SearchFlags options = SearchFlags.Default);
        public static ISearchList Request(SearchContext context, SearchFlags options = SearchFlags.None);
        public static ISearchList Request(string searchText, SearchFlags options = SearchFlags.None);
        public static void Request(string searchText, Action<SearchContext, IList<SearchItem>> onSearchCompleted, SearchFlags options = SearchFlags.None);
        public static void Request(string searchText, Action<SearchContext, IEnumerable<SearchItem>> onIncomingItems, Action<SearchContext> onSearchCompleted, SearchFlags options = SearchFlags.None);
        public static void Request(SearchContext context, Action<SearchContext, IList<SearchItem>> onSearchCompleted, SearchFlags options = SearchFlags.None);
        public static void Request(SearchContext context, Action<SearchContext, IEnumerable<SearchItem>> onIncomingItems, Action<SearchContext> onSearchCompleted, SearchFlags options = SearchFlags.None);
        public static ISearchView ShowWindow(SearchContext context = null, string topic = "Unity", float defaultWidth = 850, float defaultHeight = 539, bool saveFilters = True, bool reuseExisting = False, bool multiselect = True, bool dockable = True);
        public static ISearchView ShowWindow(SearchViewState viewState);
        public static ISearchView ShowContextual(params string[] providerIds);
        public static ISearchView ShowObjectPicker(Action<UnityEngine.Object, bool> selectHandler, Action<UnityEngine.Object> trackingHandler, string searchText, string typeName, Type filterType, float defaultWidth = 850, float defaultHeight = 539, SearchFlags flags = SearchFlags.None);
        public static ISearchView ShowPicker(SearchContext context, Action<SearchItem, bool> selectHandler, Action<SearchItem> trackingHandler = null, Func<SearchItem, bool> filterHandler = null, IEnumerable<SearchItem> subset = null, string title = null, float itemSize = 64, float defaultWidth = 850, float defaultHeight = 539, SearchFlags flags = SearchFlags.None);
        public static ISearchView ShowPicker(SearchViewState viewState);
        public static void CreateIndex(in string name, in IndexingOptions options, IEnumerable<string> roots, IEnumerable<string> includes, IEnumerable<string> excludes, Action<string, string, Action> onIndexReady);
        public static bool IsIndexReady(string name);
    }
}
