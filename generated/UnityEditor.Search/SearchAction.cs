#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{
    public class SearchAction
    {
        public bool closeWindowAfterExecution;
        public Func<IReadOnlyCollection<SearchItem>, bool> enabled;
        public Action<SearchItem[]> execute;
        public Action<SearchItem> handler;

        public SearchAction(string providerId, string id, GUIContent content);
        public SearchAction(string providerId, string id, GUIContent content, Action<SearchItem[]> handler);
        public SearchAction(string providerId, string id, GUIContent content, Action<SearchItem> handler);
        public SearchAction(string providerId, string name, Texture2D icon, string tooltip, Action<SearchItem[]> handler);
        public SearchAction(string providerId, string name, Texture2D icon, string tooltip, Action<SearchItem> handler);
        public SearchAction(string providerId, string name, Texture2D icon = null, string tooltip = null);

        public string id { get; }
        public string displayName { get; }
    }
}
