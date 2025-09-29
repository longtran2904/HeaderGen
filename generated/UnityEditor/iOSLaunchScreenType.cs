#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    public enum iOSLaunchScreenType
    {
        Default = 0,
        ImageAndBackgroundRelative = 1,
        ImageAndBackgroundConstant = 4,
        CustomXib = 2,
        CustomStoryboard = 5,
        [Obsolete("Launch Images are no longer supported by Apple. (UnityUpgradable) -> Default", True)]
        None = 3
    }
}
