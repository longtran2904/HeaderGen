#region Unity.Searcher.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Searcher.Editor.dll
#endregion

using JetBrains.Annotations;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Searcher
{
    [PublicAPI]
    public class SearcherItem
    {
        public SearcherItem(string name, string help = "", List<SearcherItem> children = null, object userData = null, Texture2D icon = null, bool collapseEmptyIcon = True);

        public int Id { get; }
        public virtual string Name { get; }
        public string Path { get; }
        public string Help { get; set; }
        public string[] Synonyms { get; set; }
        public int Depth { get; }
        public object UserData { get; set; }
        public Texture2D Icon { get; set; }
        public bool CollapseEmptyIcon { get; set; }
        public SearcherItem Parent { get; }
        public SearcherDatabaseBase Database { get; }
        public List<SearcherItem> Children { get; }
        public bool HasChildren { get; }

        public void AddChild(SearcherItem child);
        public override string ToString();
    }
}
