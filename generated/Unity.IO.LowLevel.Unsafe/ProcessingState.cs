#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace Unity.IO.LowLevel.Unsafe
{
    [NativeHeader("Runtime/File/AsyncReadManagerMetrics.h")]
    public enum ProcessingState
    {
        Unknown = 0,
        InQueue = 1,
        Reading = 2,
        Completed = 3,
        Failed = 4,
        Canceled = 5
    }
}
