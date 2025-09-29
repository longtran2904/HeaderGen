#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEditor.Search
{
    public interface IQueryHandlerFactory<TData, TQueryHandler, TPayload> where TQueryHandler : IQueryHandler<TData, TPayload> where TPayload : class
    {

        TQueryHandler Create(QueryGraph graph, ICollection<QueryError> errors);
    }
}
