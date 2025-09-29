#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Search
{
    [Flags]
    public enum SearchViewFlags
    {
        None = 0,
        Debug = 16,
        NoIndexing = 32,
        Packages = 256,
        OpenLeftSidePanel = 2048,
        OpenInspectorPreview = 4096,
        Centered = 8192,
        HideSearchBar = 16384,
        CompactView = 32768,
        ListView = 65536,
        GridView = 131072,
        TableView = 262144,
        EnableSearchQuery = 524288,
        DisableInspectorPreview = 1048576,
        DisableSavedSearchQuery = 2097152,
        OpenInBuilderMode = 4194304,
        OpenInTextMode = 8388608,
        DisableBuilderModeToggle = 16777216,
        Borderless = 33554432
    }
}
