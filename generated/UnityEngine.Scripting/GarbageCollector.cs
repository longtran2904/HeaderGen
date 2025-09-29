#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine.Scripting
{
    [NativeHeader("Runtime/Scripting/GarbageCollector.h")]
    public static class GarbageCollector
    {
        public static Mode GCMode { get; set; }
        public static bool isIncremental { get; }
        public static ulong incrementalTimeSliceNanoseconds { get; set; }

        public static event Action<Mode> GCModeChanged;

        [NativeMethod("CollectIncrementalWrapper")]
        [NativeThrows]
        public static bool CollectIncremental(ulong nanoseconds = 0);

        public enum Mode
        {
            Disabled = 0,
            Enabled = 1,
            Manual = 2
        }
    }
}
