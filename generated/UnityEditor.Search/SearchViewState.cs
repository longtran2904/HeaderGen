#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using UnityEngine;
using UnityEngine.Search;

namespace UnityEditor.Search
{
    public class SearchViewState : ISerializationCallbackReceiver
    {
        public string title;
        public float itemSize;
        public Rect position;
        public SearchViewFlags flags;
        public string group;

        public SearchViewState(SearchContext context);
        public SearchViewState(SearchContext context, SearchViewFlags flags);

        public void OnBeforeSerialize();
        public void OnAfterDeserialize();
    }
}
