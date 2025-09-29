#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System.Collections;
using System.Collections.Generic;

namespace UnityEditor.Search
{
    public class SearchSelection : IEnumerable, IEnumerable<SearchItem>, IReadOnlyCollection<SearchItem>
    {

        public SearchSelection(IList<int> selection, ISearchList filteredItems);
        public SearchSelection(IEnumerable<SearchItem> items);

        public int Count { get; }

        public int MinIndex();
        public int MaxIndex();
        public SearchItem First();
        public SearchItem Last();
        public IEnumerator<SearchItem> GetEnumerator();
        public bool Contains(SearchItem item);
    }
}
