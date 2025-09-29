#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEditor.SearchService
{
    public interface ISearchEngine<T> : ISearchEngineBase
    {

        IEnumerable<T> Search(ISearchContext context, string query, Action<IEnumerable<T>> asyncItemsReceived);
    }
}
