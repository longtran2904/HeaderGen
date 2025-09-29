#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeType(Header = "Editor/Src/EditorUserBuildSettings.h")]
    public enum PS4HardwareTarget
    {

        BaseOnly = 0,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Enum member PS4HardwareTarget.NeoAndBase has been deprecated. Use PS4HardwareTarget.ProAndBase instead (UnityUpgradable) -> ProAndBase", True)]
        NeoAndBase = 1,
        ProAndBase = 1
    }
}
