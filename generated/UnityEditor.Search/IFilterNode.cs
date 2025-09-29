#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

namespace UnityEditor.Search
{
    public interface IFilterNode : IQueryNode
    {
        string filterId { get; }
        string paramValue { get; }
        string operatorId { get; }
        string filterValue { get; }
    }
}
