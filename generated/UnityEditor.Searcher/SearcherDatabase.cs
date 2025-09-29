#region Unity.Searcher.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Searcher.Editor.dll
#endregion

using JetBrains.Annotations;
using System;
using System.Collections.Generic;

namespace UnityEditor.Searcher
{
    [PublicAPI]
    public class SearcherDatabase : SearcherDatabaseBase
    {

        public SearcherDatabase(IReadOnlyCollection<SearcherItem> db);

        public Func<string, SearcherItem, bool> MatchFilter { get; set; }

        public static SearcherDatabase Create(List<SearcherItem> items, string databaseDirectory, bool serializeToFile = True);
        public static SearcherDatabase Load(string databaseDirectory);
        public override List<SearcherItem> Search(string query, out float localMaxScore);
        protected virtual bool Match(string query, IReadOnlyList<string> tokenizedQuery, SearcherItem item, out float score);
        public override void BuildIndex();
    }
}
