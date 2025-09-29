#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    [Obsolete("AssetStatus enum is not used anymore (Asset Server has been removed)")]
    public enum AssetStatus
    {
        Calculating = -1,
        ClientOnly = 0,
        ServerOnly = 1,
        Unchanged = 2,
        Conflict = 3,
        Same = 4,
        NewVersionAvailable = 5,
        NewLocalVersion = 6,
        RestoredFromTrash = 7,
        Ignored = 8,
        BadState = 9
    }
}
