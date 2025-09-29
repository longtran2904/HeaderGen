#region Unity.ShaderGraph.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.ShaderGraph.Editor.dll
#endregion

using System.Collections.Generic;
using UnityEditor.Searcher;

namespace UnityEditor.ShaderGraph
{
    public class SearchWindowAdapter : SearcherAdapter
    {

        public SearchWindowAdapter(string title);

        public override bool HasDetailsPanel { get; }

        public override SearcherItem OnSearchResultsFilter(IEnumerable<SearcherItem> searchResults, string searchQuery);
    }
}
