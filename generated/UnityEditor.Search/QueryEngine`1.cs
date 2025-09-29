#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UnityEditor.Search
{
    public class QueryEngine<TData>
    {
        public QueryEngine();
        public QueryEngine(bool validateFilters);
        public QueryEngine(QueryValidationOptions validationOptions);

        public bool validateFilters { get; set; }
        public bool skipUnknownFilters { get; set; }
        public bool skipIncompleteFilters { get; set; }
        public StringComparison globalStringComparison { get; }
        public StringComparison searchDataStringComparison { get; }
        public bool searchDataOverridesStringComparison { get; }
        public Func<TData, IEnumerable<string>> searchDataCallback { get; }
        public Func<string, bool, StringComparison, string, bool> searchWordMatcher { get; }

        public void AddFilter<TFilter>(string token, Func<TData, TFilter> getDataFunc, string[] supportedOperatorType = null);
        public void AddFilter<TFilter>(string token, Func<TData, TFilter> getDataFunc, StringComparison stringComparison, string[] supportedOperatorType = null);
        public void AddFilter<TParam, TFilter>(string token, Func<TData, TParam, TFilter> getDataFunc, string[] supportedOperatorType = null);
        public void AddFilter<TParam, TFilter>(string token, Func<TData, TParam, TFilter> getDataFunc, StringComparison stringComparison, string[] supportedOperatorType = null);
        public void AddFilter<TParam, TFilter>(string token, Func<TData, TParam, TFilter> getDataFunc, Func<string, TParam> parameterTransformer, string[] supportedOperatorType = null);
        public void AddFilter<TParam, TFilter>(string token, Func<TData, TParam, TFilter> getDataFunc, Func<string, TParam> parameterTransformer, StringComparison stringComparison, string[] supportedOperatorType = null);
        public void AddFilter<TFilter>(string token, Func<TData, string, TFilter, bool> filterResolver, string[] supportedOperatorType = null);
        public void AddFilter<TParam, TFilter>(string token, Func<TData, TParam, string, TFilter, bool> filterResolver, string[] supportedOperatorType = null);
        public void AddFilter<TParam, TFilter>(string token, Func<TData, TParam, string, TFilter, bool> filterResolver, Func<string, TParam> parameterTransformer, string[] supportedOperatorType = null);
        public IQueryEngineFilter AddFilter<TFilter>(Regex token, Func<TData, string, TFilter> getDataFunc, string[] supportedOperatorType = null);
        public IQueryEngineFilter AddFilter<TFilter>(Regex token, Func<TData, string, TFilter> getDataFunc, StringComparison stringComparison, string[] supportedOperatorType = null);
        public IQueryEngineFilter AddFilter<TParam, TFilter>(Regex token, Func<TData, string, TParam, TFilter> getDataFunc, string[] supportedOperatorType = null);
        public IQueryEngineFilter AddFilter<TParam, TFilter>(Regex token, Func<TData, string, TParam, TFilter> getDataFunc, StringComparison stringComparison, string[] supportedOperatorType = null);
        public IQueryEngineFilter AddFilter<TParam, TFilter>(Regex token, Func<TData, string, TParam, TFilter> getDataFunc, Func<string, TParam> parameterTransformer, string[] supportedOperatorType = null);
        public IQueryEngineFilter AddFilter<TParam, TFilter>(Regex token, Func<TData, string, TParam, TFilter> getDataFunc, Func<string, TParam> parameterTransformer, StringComparison stringComparison, string[] supportedOperatorType = null);
        public IQueryEngineFilter AddFilter<TFilter>(Regex token, Func<TData, string, string, TFilter, bool> filterResolver, string[] supportedOperatorType = null);
        public IQueryEngineFilter AddFilter<TParam, TFilter>(Regex token, Func<TData, string, TParam, string, TFilter, bool> filterResolver, string[] supportedOperatorType = null);
        public IQueryEngineFilter AddFilter<TParam, TFilter>(Regex token, Func<TData, string, TParam, string, TFilter, bool> filterResolver, Func<string, TParam> parameterTransformer, string[] supportedOperatorType = null);
        public void AddFiltersFromAttribute<TFilterAttribute, TTransformerAttribute>() where TFilterAttribute : QueryEngineFilterAttribute where TTransformerAttribute : QueryEngineParameterTransformerAttribute;
        public void RemoveFilter(string token);
        public void RemoveFilter(Regex token);
        public void RemoveFilter(IQueryEngineFilter filter);
        public void ClearFilters();
        public IEnumerable<IQueryEngineFilter> GetAllFilters();
        public bool TryGetFilter(string token, out IQueryEngineFilter filter);
        public bool TryGetFilter(Regex token, out IQueryEngineFilter filter);
        public void AddOperator(string op);
        public void RemoveOperator(string op);
        public QueryFilterOperator GetOperator(string op);
        public void AddOperatorHandler<TFilterVariable, TFilterConstant>(string op, Func<TFilterVariable, TFilterConstant, bool> handler);
        public void AddOperatorHandler<TFilterVariable, TFilterConstant>(string op, Func<TFilterVariable, TFilterConstant, StringComparison, bool> handler);
        public void AddTypeParser<TFilterConstant>(Func<string, ParseResult<TFilterConstant>> parser);
        public void SetDefaultFilter(Func<TData, string, string, string, bool> handler);
        public void SetDefaultParamFilter(Func<TData, string, string, string, string, bool> handler);
        public void SetSearchDataCallback(Func<TData, IEnumerable<string>> getSearchDataCallback);
        public void SetSearchDataCallback(Func<TData, IEnumerable<string>> getSearchDataCallback, StringComparison stringComparison);
        public void SetSearchDataCallback(Func<TData, IEnumerable<string>> getSearchDataCallback, Func<string, string> searchWordTransformerCallback, StringComparison stringComparison);
        public void SetSearchWordMatcher(Func<string, bool, StringComparison, string, bool> wordMatcher);
        public void SetGlobalStringComparisonOptions(StringComparison stringComparison);
        public Query<TData> Parse(string text, bool useFastYieldingQueryHandler = False);
        public Query<TData, TPayload> Parse<TQueryHandler, TPayload>(string text, IQueryHandlerFactory<TData, TQueryHandler, TPayload> queryHandlerFactory) where TQueryHandler : IQueryHandler<TData, TPayload> where TPayload : class;
        public void SetNestedQueryHandler<TNestedQueryData>(Func<string, string, IEnumerable<TNestedQueryData>> handler);
        public void SetFilterNestedQueryTransformer<TNestedQueryData, TRhs>(string filterToken, Func<TNestedQueryData, TRhs> transformer);
        public void AddNestedQueryAggregator<TNestedQueryData>(string token, Func<IEnumerable<TNestedQueryData>, IEnumerable<TNestedQueryData>> aggregator);
    }
}
