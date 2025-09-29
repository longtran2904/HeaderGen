#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;

namespace UnityEditor.Search
{
    [Flags]
    public enum SearchColumnFlags
    {

        None = 0,
        Hidden = 1,
        Sorted = 2,
        Volatile = 4,
        IgnoreSettings = 8,
        SortedDescending = 1024,
        TextAlignmentLeft = 32768,
        TextAlignmentCenter = 65536,
        TextAlignmentRight = 131072,
        CanHide = 1048576,
        CanSort = 2097152,
        Default = 3178496,
        TextAligmentMask = 229376
    }
}
