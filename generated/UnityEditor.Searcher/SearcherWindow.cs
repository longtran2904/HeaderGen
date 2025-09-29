#region Unity.Searcher.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Searcher.Editor.dll
#endregion

using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Searcher
{
    [PublicAPI]
    public class SearcherWindow : EditorWindow
    {

        public SearcherWindow();

        public static void Show(EditorWindow host, IList<SearcherItem> items, string title, Func<SearcherItem, bool> itemSelectedDelegate, Vector2 displayPosition, Alignment align = null);
        public static void Show(EditorWindow host, IList<SearcherItem> items, ISearcherAdapter adapter, Func<SearcherItem, bool> itemSelectedDelegate, Vector2 displayPosition, Action<Searcher.AnalyticsEvent> analyticsDataDelegate, Alignment align = null);
        public static void Show(EditorWindow host, IList<SearcherItem> items, string title, string directoryPath, Func<SearcherItem, bool> itemSelectedDelegate, Vector2 displayPosition, Alignment align = null);
        public static void Show(EditorWindow host, IEnumerable<SearcherItem> items, ISearcherAdapter adapter, string directoryPath, Func<SearcherItem, bool> itemSelectedDelegate, Vector2 displayPosition, Action<Searcher.AnalyticsEvent> analyticsDataDelegate, Alignment align = null);
        public static void Show(EditorWindow host, Searcher searcher, Func<SearcherItem, bool> itemSelectedDelegate, Vector2 displayPosition, Action<Searcher.AnalyticsEvent> analyticsDataDelegate, Alignment align = null);
        public static void Show(EditorWindow host, Searcher searcher, Func<SearcherItem, bool> itemSelectedDelegate, Action<Searcher.AnalyticsEvent> analyticsDataDelegate, Rect rect);
        public static Vector2 GetPositionWithAlignment(Vector2 pos, Vector2 size, Alignment align);
        [PublicAPI]
        public struct Alignment
        {

            public readonly Vertical vertical;
            public readonly Horizontal horizontal;

            public Alignment(Vertical v, Horizontal h);
            [PublicAPI]
            public enum Horizontal
            {

                Left = 0,
                Center = 1,
                Right = 2
            }
            [PublicAPI]
            public enum Vertical
            {

                Top = 0,
                Center = 1,
                Bottom = 2
            }
        }
    }
}
