#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

namespace UnityEditor.Search
{
    public class SearchQueryError
    {

        public SearchQueryError(int index, int length, string reason, SearchContext context, SearchProvider provider, bool fromSearchQuery = True, SearchQueryErrorType type = SearchQueryErrorType.Error);
        public SearchQueryError(QueryError error, SearchContext context, SearchProvider provider, bool fromSearchQuery = True);

        public int index { get; }
        public int length { get; }
        public SearchQueryErrorType type { get; }
        public SearchContext context { get; }
        public SearchProvider provider { get; }
        public string reason { get; }

        public override int GetHashCode();
    }
}
