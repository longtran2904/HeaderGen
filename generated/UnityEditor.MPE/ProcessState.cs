#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.MPE
{
    [MovedFrom("Unity.MPE")]
    public enum ProcessState
    {

        [Obsolete("... (UnityUpgradable) -> UnknownProcess")]
        UMP_UNKNOWN_PROCESS = 0,
        UnknownProcess = 0,
        [Obsolete("... (UnityUpgradable) -> FinishedSuccessfully")]
        UMP_FINISHED_SUCCESSFULLY = 1,
        FinishedSuccessfully = 1,
        [Obsolete("... (UnityUpgradable) -> FinishedWithError")]
        UMP_FINISHED_WITH_ERROR = 2,
        FinishedWithError = 2,
        [Obsolete("... (UnityUpgradable) -> Running")]
        UMP_RUNNING = 3,
        Running = 3
    }
}
