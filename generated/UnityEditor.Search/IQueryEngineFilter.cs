#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UnityEditor.Search
{
    public interface IQueryEngineFilter
    {
        string token { get; }
        Regex regexToken { get; }
        bool usesRegularExpressionToken { get; }
        IEnumerable<string> supportedOperators { get; }
        Type type { get; }
        bool usesParameter { get; }
        Type parameterType { get; }
        bool usesResolver { get; }
        StringComparison stringComparison { get; }
        bool overridesStringComparison { get; }
        IReadOnlyDictionary<string, QueryFilterOperator> operators { get; }
        IReadOnlyDictionary<string, string> metaInfo { get; }

        void SetNestedQueryTransformer<TNestedQueryData, TRhs>(Func<TNestedQueryData, TRhs> transformer);
        IQueryEngineFilter AddTypeParser<TFilterConstant>(Func<string, ParseResult<TFilterConstant>> parser);
        QueryFilterOperator AddOperator(string op);
        IQueryEngineFilter RemoveOperator(string op);
        IQueryEngineFilter AddOrUpdateMetaInfo(string key, string value);
        IQueryEngineFilter RemoveMetaInfo(string key);
        IQueryEngineFilter ClearMetaInfo();
    }
}
