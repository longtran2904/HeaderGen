#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

namespace UnityEditor.Search
{
    public class QueryGraph
    {
        public QueryGraph(IQueryNode root);

        public IQueryNode root { get; }
        public bool empty { get; }

        public void Optimize(bool propagateNotToLeaves, bool swapNotToRightHandSide);
        public void Optimize(QueryGraphOptimizationOptions options);
    }
}
