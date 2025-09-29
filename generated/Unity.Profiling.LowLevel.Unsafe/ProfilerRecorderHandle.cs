#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Profiling.LowLevel.Unsafe
{
    [UsedByNativeCode]
    public readonly struct ProfilerRecorderHandle
    {

        public bool Valid { get; }

        public static ProfilerRecorderDescription GetDescription(ProfilerRecorderHandle handle);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public static void GetAvailable(List<ProfilerRecorderHandle> outRecorderHandleList);
    }
}
