#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEditor
{
    public enum iOSStatusBarStyle
    {
        Default = 0,
        LightContent = 1,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("BlackTranslucent has no effect, use LightContent instead (UnityUpgradable) -> LightContent", True)]
        BlackTranslucent = -1,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("BlackOpaque has no effect, use LightContent instead (UnityUpgradable) -> LightContent", True)]
        BlackOpaque = -1
    }
}
