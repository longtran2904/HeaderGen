#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.VersionControl
{
    [Flags]
    [Obsolete("MergeMethod is no longer used.")]
    public enum MergeMethod
    {
        MergeNone = 0,
        MergeAll = 1,
        [Obsolete("This member is no longer supported (UnityUpgradable) -> MergeNone", True)]
        MergeNonConflicting = 2
    }
}
