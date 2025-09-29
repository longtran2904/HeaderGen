#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEditor.Search
{
    public interface IQueryNode
    {
        IQueryNode parent { get; set; }
        QueryNodeType type { get; }
        List<IQueryNode> children { get; }
        bool leaf { get; }
        bool skipped { get; set; }
        string identifier { get; }
        QueryToken token { get; set; }

        int QueryHashCode();
    }
}
