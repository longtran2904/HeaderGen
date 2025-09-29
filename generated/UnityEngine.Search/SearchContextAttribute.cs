#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Search
{
    [AttributeUsage(AttributeTargets.Field)]
    public class SearchContextAttribute : PropertyAttribute
    {
        public SearchContextAttribute(string query);
        public SearchContextAttribute(string query, SearchViewFlags flags);
        public SearchContextAttribute(string query, string providerIdsCommaSeparated);
        public SearchContextAttribute(string query, string providerIdsCommaSeparated, SearchViewFlags flags);
        public SearchContextAttribute(string query, params Type[] instantiableProviders);
        public SearchContextAttribute(string query, SearchViewFlags flags, params Type[] instantiableProviders);
        public SearchContextAttribute(string query, SearchViewFlags flags, string providerIdsCommaSeparated, params Type[] instantiableProviders);

        public string query { get; }
        public string[] providerIds { get; }
        public Type[] instantiableProviders { get; }
        public SearchViewFlags flags { get; }
    }
}
