#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.Search
{
    public interface ISearchView : IDisposable
    {
        SearchSelection selection { get; }
        ISearchList results { get; }
        SearchContext context { get; }
        float itemIconSize { get; set; }
        DisplayMode displayMode { get; }
        bool multiselect { get; set; }
        Rect position { get; }
        Action<SearchItem, bool> selectCallback { get; }
        Func<SearchItem, bool> filterCallback { get; }
        Action<SearchItem> trackingCallback { get; }

        void SetSelection(params int[] selection);
        void AddSelection(params int[] selection);
        void SetSearchText(string searchText, TextCursorPlacement moveCursor = TextCursorPlacement.MoveLineEnd);
        void SetSearchText(string searchText, TextCursorPlacement moveCursor, int cursorInsertPosition);
        void Focus();
        void Refresh(RefreshFlags reason = RefreshFlags.Default);
        void Repaint();
        void ExecuteAction(SearchAction action, SearchItem[] items, bool endSearch = True);
        void ExecuteSelection();
        void Close();
        void ShowItemContextualMenu(SearchItem item, Rect contextualActionPosition);
        void SelectSearch();
        void FocusSearch();
    }
}
