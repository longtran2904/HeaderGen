#region Unity.Searcher.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Searcher.Editor.dll
#endregion

using JetBrains.Annotations;
using System.Collections.Generic;
using UnityEngine.UIElements;

namespace UnityEditor.Searcher
{
    [PublicAPI]
    public interface ISearcherAdapter
    {
        string Title { get; }
        bool HasDetailsPanel { get; }
        bool AddAllChildResults { get; }
        bool MultiSelectEnabled { get; }
        float InitialSplitterDetailRatio { get; }

        VisualElement MakeItem();
        VisualElement Bind(VisualElement target, SearcherItem item, ItemExpanderState expanderState, string text);
        void OnSelectionChanged(IEnumerable<SearcherItem> items);
        SearcherItem OnSearchResultsFilter(IEnumerable<SearcherItem> searchResults, string searchQuery);
        void InitDetailsPanel(VisualElement detailsPanel);
    }
}
