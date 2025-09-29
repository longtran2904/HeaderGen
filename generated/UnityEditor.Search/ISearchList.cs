#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEditor.Search
{
    public interface ISearchList : ICollection<SearchItem>, IDisposable, IEnumerable, IEnumerable<SearchItem>, IList<SearchItem>
    {

        bool pending { get; }
        SearchContext context { get; }

        IEnumerable<SearchItem> Fetch();
        void AddItems(IEnumerable<SearchItem> items);
        void InsertRange(int index, IEnumerable<SearchItem> items);
        IEnumerable<SearchItem> GetRange(int skipCount, int count);
        IEnumerable<TResult> Select<TResult>(Func<SearchItem, TResult> selector);
    }
}
