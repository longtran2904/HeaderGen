#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    public enum iOSAppInBackgroundBehavior
    {
        Custom = -1,
        Suspend = 0,
        [Obsolete("UIApplicationExitsOnSuspend is no longer supported in iOS 13, use Custom or Suspend instead (UnityUpgradable) -> Custom", True)]
        Exit = 1
    }
}
