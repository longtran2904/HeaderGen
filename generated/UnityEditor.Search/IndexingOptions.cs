#region UnityEditor.QuickSearchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.QuickSearchModule.dll
#endregion

using System;

namespace UnityEditor.Search
{
    [Flags]
    public enum IndexingOptions
    {

        None = 0,
        Types = 1,
        Properties = 2,
        Extended = 4,
        Dependencies = 8,
        Keep = 64,
        Temporary = 128,
        All = 15
    }
}
