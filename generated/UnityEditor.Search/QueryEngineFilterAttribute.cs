#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;

namespace UnityEditor.Search
{
    [AttributeUsage(AttributeTargets.Method)]
    public class QueryEngineFilterAttribute : Attribute
    {
        public string token;
        public StringComparison comparisonOptions;
        public bool overridesStringComparison;
        public string[] supportedOperators;
        public bool useParamTransformer;
        public string paramTransformerFunction;
        public bool useRegularExpressionToken;

        public QueryEngineFilterAttribute(string token, string[] supportedOperators = null);
        public QueryEngineFilterAttribute(string token, StringComparison options, string[] supportedOperators = null);
        public QueryEngineFilterAttribute(string token, string paramTransformerFunction, string[] supportedOperators = null);
        public QueryEngineFilterAttribute(string token, string paramTransformerFunction, StringComparison options, string[] supportedOperators = null);
        public QueryEngineFilterAttribute(string token, bool useRegularExpression, string[] supportedOperators = null);
        public QueryEngineFilterAttribute(string token, bool useRegularExpression, StringComparison options, string[] supportedOperators = null);
        public QueryEngineFilterAttribute(string token, bool useRegularExpression, string paramTransformerFunction, string[] supportedOperators = null);
        public QueryEngineFilterAttribute(string token, bool useRegularExpression, string paramTransformerFunction, StringComparison options, string[] supportedOperators = null);
    }
}
