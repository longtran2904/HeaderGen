#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [Flags]
    public enum LightmapsMode
    {

        NonDirectional = 0,
        CombinedDirectional = 1,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Enum member LightmapsMode.SeparateDirectional has been removed. Use CombinedDirectional instead (UnityUpgradable) -> CombinedDirectional", True)]
        SeparateDirectional = 2,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Enum member LightmapsMode.Single has been removed. Use NonDirectional instead (UnityUpgradable) -> NonDirectional", True)]
        Single = 0,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Enum member LightmapsMode.Dual has been removed. Use CombinedDirectional instead (UnityUpgradable) -> CombinedDirectional", True)]
        Dual = 1,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Enum member LightmapsMode.Directional has been removed. Use CombinedDirectional instead (UnityUpgradable) -> CombinedDirectional", True)]
        Directional = 2
    }
}
