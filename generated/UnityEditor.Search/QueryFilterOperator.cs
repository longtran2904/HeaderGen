#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;

namespace UnityEditor.Search
{
    public readonly struct QueryFilterOperator
    {

        public string token { get; }
        public bool valid { get; }

        public QueryFilterOperator AddHandler<TFilterVariable, TFilterConstant>(Func<TFilterVariable, TFilterConstant, bool> handler);
        public QueryFilterOperator AddHandler<TFilterVariable, TFilterConstant>(Func<TFilterVariable, TFilterConstant, StringComparison, bool> handler);
    }
}
