#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;

namespace UnityEditor.Search
{
    [Flags]
    public enum SearchItemOptions
    {
        None = 0,
        Ellipsis = 1,
        RightToLeft = 2,
        Highlight = 4,
        FuzzyHighlight = 8,
        Compacted = 16,
        AlwaysRefresh = 32,
        FullDescription = 64
    }
}
