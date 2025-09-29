#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEditor.Search
{
    public class SearchContext : IDisposable
    {
        public SearchContext(IEnumerable<SearchProvider> providers, string searchText, SearchFlags options);
        public SearchContext(IEnumerable<SearchProvider> providers, string searchText);
        public SearchContext(IEnumerable<SearchProvider> providers);
        public SearchContext(SearchContext context);

        ~SearchContext();

        public int progressId { get; set; }
        public string searchQuery { get; }
        public int searchQueryOffset { get; }
        public string[] searchWords { get; }
        public string searchPhrase { get; }
        public string[] textFilters { get; }
        public EditorWindow focusedWindow { get; }
        public SearchFlags options { get; set; }
        public bool wantsMore { get; set; }
        public string searchText { get; set; }
        public IEnumerable<SearchProvider> providers { get; }
        public bool searchInProgress { get; }
        public SearchSelection selection { get; }
        public ISearchView searchView { get; }
        public string filterId { get; }

        public event Action<SearchContext, IEnumerable<SearchItem>> asyncItemReceived;
        public event Action<SearchContext> sessionStarted;
        public event Action<SearchContext> sessionEnded;

        [Obsolete("ResetFilter has been deprecated and there is no replacement.", True)]
        public void ResetFilter(bool enableAll);
        public void SetFilter(string providerId, bool isEnabled);
        public bool IsEnabled(string providerId);
        public void Dispose();
        protected virtual void Dispose(bool disposing);
        public override int GetHashCode();
        public void AddSearchQueryError(SearchQueryError error);
        public void AddSearchQueryErrors(IEnumerable<SearchQueryError> errors);
        public override string ToString();
    }
}
