#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;

namespace UnityEditor.Search
{
    [Flags]
    public enum SearchFlags
    {
        None = 0,
        Synchronous = 1,
        Sorted = 2,
        FirstBatchAsync = 4,
        WantsMore = 8,
        Debug = 16,
        NoIndexing = 32,
        Expression = 64,
        QueryString = 128,
        Packages = 256,
        Default = 2,
        ShowErrorsWithResults = 16777216,
        SaveFilters = 33554432,
        ReuseExistingWindow = 67108864,
        Multiselect = 134217728,
        Dockable = 268435456,
        FocusContext = 536870912,
        HidePanels = 1073741824,
        OpenDefault = 436207616,
        OpenGlobal = 503316480,
        OpenContextual = 939524096,
        OpenPicker = 1610612736
    }
}
