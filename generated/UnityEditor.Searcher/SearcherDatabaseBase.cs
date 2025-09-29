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
    public abstract class SearcherDatabaseBase
    {

        [SerializeField]
        protected List<SearcherItem> m_ItemList;
        protected const string k_SerializedJsonFile = "/SerializedDatabase.json";

        protected SearcherDatabaseBase(string databaseDirectory);

        public string DatabaseDirectory { get; set; }
        public IList<SearcherItem> ItemList { get; }

        public virtual void BuildIndex();
        public abstract List<SearcherItem> Search(string query, out float localMaxScore);
        protected void LoadFromFile();
        protected void SerializeToFile();
        protected void AddItemToIndex(SearcherItem item, ref int lastId, Action<SearcherItem> action);
    }
}
