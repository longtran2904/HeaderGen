#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.MPE
{
    [MovedFrom("Unity.MPE")]
    public enum ProcessEvent
    {
        [Obsolete("... (UnityUpgradable) -> Undefined")]
        UMP_EVENT_UNDEFINED = 0,
        Undefined = 0,
        [Obsolete("... (UnityUpgradable) -> Create")]
        UMP_EVENT_CREATE = 1,
        Create = 1,
        [Obsolete("... (UnityUpgradable) -> Initialize")]
        UMP_EVENT_INITIALIZE = 2,
        Initialize = 2,
        [Obsolete("... (UnityUpgradable) -> AfterDomainReload")]
        UMP_EVENT_AFTER_DOMAIN_RELOAD = 3,
        AfterDomainReload = 3,
        [Obsolete("... (UnityUpgradable) -> Shutdown")]
        UMP_EVENT_SHUTDOWN = 4,
        Shutdown = 4
    }
}
