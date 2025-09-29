#region Unity.Searcher.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Searcher.Editor.dll
#endregion

using JetBrains.Annotations;
using System;
using System.Collections.Generic;

namespace UnityEditor.Searcher
{
    [PublicAPI]
    public class Searcher
    {

        public Searcher(SearcherDatabaseBase database, string title);
        public Searcher(IEnumerable<SearcherDatabaseBase> databases, string title);
        public Searcher(SearcherDatabaseBase database, ISearcherAdapter adapter = null);
        public Searcher(IEnumerable<SearcherDatabaseBase> databases, ISearcherAdapter adapter = null);

        public ISearcherAdapter Adapter { get; }
        public Comparison<SearcherItem> SortComparison { get; set; }

        public void BuildIndices();
        public IEnumerable<SearcherItem> Search(string query);
        [PublicAPI]
        public class AnalyticsEvent
        {

            public readonly EventType eventType;
            public readonly string currentSearchFieldText;

            public AnalyticsEvent(EventType eventType, string currentSearchFieldText);
            [PublicAPI]
            public enum EventType
            {

                Pending = 0,
                Picked = 1,
                Cancelled = 2
            }
        }
    }
}
