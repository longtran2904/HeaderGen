#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

namespace UnityEditor.Search
{
    public readonly struct SearchColumnCompareArgs
    {
        public readonly SearchColumnEventArgs lhs;
        public readonly SearchColumnEventArgs rhs;
        public readonly bool sortAscending;

        public SearchColumnCompareArgs(SearchColumnEventArgs lhs, SearchColumnEventArgs rhs, bool sortAscending);
    }
}
