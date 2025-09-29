#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace Unity.Jobs.LowLevel.Unsafe
{
    public enum ScheduleMode
    {
        Run = 0,
        [Obsolete("Batched is obsolete, use Parallel or Single depending on job type. (UnityUpgradable) -> Parallel", False)]
        Batched = 1,
        Parallel = 1,
        Single = 2
    }
}
