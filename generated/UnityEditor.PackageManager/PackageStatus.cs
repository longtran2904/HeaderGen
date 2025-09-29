#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.PackageManager
{
    [Obsolete("PackageStatus is deprecated and will be removed in a later version.", False)]
    public enum PackageStatus
    {
        Unknown = 0,
        Unavailable = 1,
        InProgress = 2,
        Error = 3,
        Available = 4
    }
}
