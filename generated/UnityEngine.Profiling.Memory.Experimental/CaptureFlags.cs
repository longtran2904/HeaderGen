#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Profiling.Memory.Experimental
{
    [Flags]
    public enum CaptureFlags
    {

        ManagedObjects = 1,
        NativeObjects = 2,
        NativeAllocations = 4,
        NativeAllocationSites = 8,
        NativeStackTraces = 16
    }
}
