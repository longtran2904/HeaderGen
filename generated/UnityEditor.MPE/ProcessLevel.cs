#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.MPE
{
    [MovedFrom("Unity.MPE")]
    public enum ProcessLevel
    {

        [Obsolete("... (UnityUpgradable) -> Undefined")]
        UMP_UNDEFINED = 0,
        Undefined = 0,
        [Obsolete("... (UnityUpgradable) -> Main")]
        UMP_MASTER = 1,
        Main = 1,
        [Obsolete("... (UnityUpgradable) -> Secondary")]
        UMP_SLAVE = 2,
        [Obsolete("... (UnityUpgradable) -> Secondary")]
        Slave = 2,
        Secondary = 2
    }
}
