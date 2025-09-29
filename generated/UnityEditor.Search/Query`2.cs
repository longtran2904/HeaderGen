#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEditor.Search
{
    public class Query<TData, TPayload> where TPayload : class
    {

        public string text { get; }
        public bool valid { get; }
        public ICollection<QueryError> errors { get; }
        public ICollection<string> tokens { get; }

        public virtual IEnumerable<TData> Apply(TPayload payload = null);
        public void Optimize(bool propagateNotToLeaves, bool swapNotToRightHandSide);
        public void Optimize(QueryGraphOptimizationOptions options);
        public IQueryNode GetNodeAtPosition(int position);
    }
}
