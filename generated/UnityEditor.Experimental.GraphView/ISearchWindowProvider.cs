#region UnityEditor.GraphViewModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.GraphViewModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEditor.Experimental.GraphView
{
    public interface ISearchWindowProvider
    {

        List<SearchTreeEntry> CreateSearchTree(SearchWindowContext context);
        bool OnSelectEntry(SearchTreeEntry SearchTreeEntry, SearchWindowContext context);
    }
}
