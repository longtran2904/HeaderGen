#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeType(Header = "Editor/Src/EditorUserBuildSettings.h")]
    public enum WSABuildAndRunDeployTarget
    {

        LocalMachine = 0,
        [Obsolete("UnityEditor.WSABuildAndRunDeployTarget.WindowsPhone is obsolete.", True)]
        WindowsPhone = 1,
        DevicePortal = 2
    }
}
