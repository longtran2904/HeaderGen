#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;

namespace UnityEditor.Search
{
    [Flags]
    public enum RefreshFlags
    {

        None = 0,
        Default = 1,
        StructureChanged = 2,
        DisplayModeChanged = 4,
        ItemsChanged = 8,
        GroupChanged = 16
    }
}
