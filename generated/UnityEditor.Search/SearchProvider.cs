#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{
    public class SearchProvider
    {
        public bool active;
        public string filterId;
        public bool isExplicitProvider;
        public bool showDetails;
        public ShowDetailsOptions showDetailsOptions;
        public Func<SearchItem, SearchContext, string> fetchLabel;
        public Func<SearchItem, SearchContext, string> fetchDescription;
        public Func<SearchItem, SearchContext, Texture2D> fetchThumbnail;
        public Func<SearchItem, SearchContext, Vector2, FetchPreviewOptions, Texture2D> fetchPreview;
        public Action<SearchItem, SearchContext> startDrag;
        public Action<SearchItem, SearchContext> trackSelection;
        public Func<SearchContext, List<SearchItem>, SearchProvider, object> fetchItems;
        public Func<SearchItem, Type, UnityEngine.Object> toObject;
        public Func<SearchContext, SearchPropositionOptions, IEnumerable<SearchProposition>> fetchPropositions;
        public Func<SearchContext, IEnumerable<SearchItem>, IEnumerable<SearchColumn>> fetchColumns;
        public Action onEnable;
        public Action onDisable;
        public int priority;
        public Func<bool> isEnabledForContextualSearch;

        public SearchProvider(string id);
        public SearchProvider(string id, string displayName);
        public SearchProvider(string id, Func<SearchContext, List<SearchItem>, SearchProvider, object> fetchItemsHandler);
        public SearchProvider(string id, Func<SearchContext, SearchProvider, object> fetchItemsHandler);
        public SearchProvider(string id, string displayName, Func<SearchContext, SearchProvider, object> fetchItemsHandler);
        public SearchProvider(string id, string displayName, Func<SearchContext, List<SearchItem>, SearchProvider, object> fetchItemsHandler);

        public string id { get; }
        public string name { get; }
        public List<SearchAction> actions { get; }

        public SearchItem CreateItem(SearchContext context, string id, int score, string label, string description, Texture2D thumbnail, object data);
        public SearchItem CreateItem(string id, int score, string label, string description, Texture2D thumbnail, object data);
        public SearchItem CreateItem(SearchContext context, string id);
        public SearchItem CreateItem(string id);
        public SearchItem CreateItem(string id, string label);
        public SearchItem CreateItem(string id, string label, string description, Texture2D thumbnail, object data);
        public SearchItem CreateItem(SearchContext context, string id, string label, string description, Texture2D thumbnail, object data);
        public override string ToString();
    }
}
