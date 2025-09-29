#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.Search
{
    public struct SearchColumnEventArgs
    {
        public readonly SearchItem item;
        public readonly SearchContext context;
        public readonly SearchColumn column;
        public object value;
        public bool multiple;
        public Rect rect;
        public bool focused;
        public bool selected;

        public SearchColumnEventArgs(SearchItem item, SearchContext context, SearchColumn column);
    }
}
