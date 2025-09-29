#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.SearchService
{
    public interface ISelectorEngine : ISearchEngineBase
    {

        bool SelectObject(ISearchContext context, Action<UnityEngine.Object, bool> onObjectSelectorClosed, Action<UnityEngine.Object> onObjectSelectedUpdated);
        void SetSearchFilter(ISearchContext context, string searchFilter);
    }
}
