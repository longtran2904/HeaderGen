#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using JetBrains.Annotations;
using System;
using System.Diagnostics;
using Unity.Profiling.LowLevel;
using UnityEngine;
using UnityEngine.Scripting;

namespace Unity.Profiling
{
    [UsedByNativeCode]
    public struct ProfilerMarker
    {
        public ProfilerMarker(string name);
        public ProfilerMarker(char* name, int nameLen);
        public ProfilerMarker(ProfilerCategory category, string name);
        public ProfilerMarker(ProfilerCategory category, char* name, int nameLen);
        public ProfilerMarker(ProfilerCategory category, string name, MarkerFlags flags);
        public ProfilerMarker(ProfilerCategory category, char* name, int nameLen, MarkerFlags flags);

        public nint Handle { get; }

        [Conditional("ENABLE_PROFILER")]
        [Pure]
        public void Begin();
        [Conditional("ENABLE_PROFILER")]
        public void Begin(UnityEngine.Object contextUnityObject);
        [Conditional("ENABLE_PROFILER")]
        [Pure]
        public void End();
        [Pure]
        public AutoScope Auto();

        [UsedByNativeCode]
        public struct AutoScope : IDisposable
        {
            public void Dispose();
        }
    }
}
