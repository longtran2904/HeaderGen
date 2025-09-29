#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    [Flags]
    [Obsolete("Use UnityEngine.iOS.SystemGestureDeferMode instead. (UnityUpgradable) -> [UnityEngine] UnityEngine.iOS.SystemGestureDeferMode", True)]
    public enum iOSSystemGestureDeferMode
    {
        None = 0,
        TopEdge = 1,
        LeftEdge = 2,
        BottomEdge = 4,
        RightEdge = 8,
        All = 15
    }
}
