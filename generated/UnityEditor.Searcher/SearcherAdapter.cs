#region Unity.Searcher.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Searcher.Editor.dll
#endregion

using JetBrains.Annotations;
using System.Collections.Generic;
using UnityEngine.UIElements;

namespace UnityEditor.Searcher
{
    [PublicAPI]
    public class SearcherAdapter : ISearcherAdapter
    {

        public SearcherAdapter(string title);

        public virtual string Title { get; }
        public virtual bool HasDetailsPanel { get; }
        public virtual bool AddAllChildResults { get; }
        public virtual bool MultiSelectEnabled { get; }
        public virtual float InitialSplitterDetailRatio { get; }

        public virtual VisualElement MakeItem();
        public virtual VisualElement Bind(VisualElement element, SearcherItem item, ItemExpanderState expanderState, string query);
        public virtual void InitDetailsPanel(VisualElement detailsPanel);
        public virtual void OnSelectionChanged(IEnumerable<SearcherItem> items);
        public virtual SearcherItem OnSearchResultsFilter(IEnumerable<SearcherItem> searchResults, string searchQuery);
    }
}
