#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Profiling
{
    [NativeHeader("Runtime/Profiler/ScriptBindings/ProfilerRecorder.bindings.h")]
    [UsedByNativeCode]
    public struct ProfilerRecorder : IDisposable
    {
        public ProfilerRecorder(string statName, int capacity = 1, ProfilerRecorderOptions options = ProfilerRecorderOptions.Default);
        public ProfilerRecorder(string categoryName, string statName, int capacity = 1, ProfilerRecorderOptions options = ProfilerRecorderOptions.Default);
        public ProfilerRecorder(ProfilerCategory category, string statName, int capacity = 1, ProfilerRecorderOptions options = ProfilerRecorderOptions.Default);
        public ProfilerRecorder(ProfilerCategory category, char* statName, int statNameLen, int capacity = 1, ProfilerRecorderOptions options = ProfilerRecorderOptions.Default);
        public ProfilerRecorder(ProfilerMarker marker, int capacity = 1, ProfilerRecorderOptions options = ProfilerRecorderOptions.Default);
        public ProfilerRecorder(ProfilerRecorderHandle statHandle, int capacity = 1, ProfilerRecorderOptions options = ProfilerRecorderOptions.Default);

        public bool Valid { get; }
        public ProfilerMarkerDataType DataType { get; }
        public ProfilerMarkerDataUnit UnitType { get; }
        public long CurrentValue { get; }
        public double CurrentValueAsDouble { get; }
        public long LastValue { get; }
        public double LastValueAsDouble { get; }
        public int Capacity { get; }
        public int Count { get; }
        public bool IsRunning { get; }
        public bool WrappedAround { get; }

        public static ProfilerRecorder StartNew(ProfilerCategory category, string statName, int capacity = 1, ProfilerRecorderOptions options = ProfilerRecorderOptions.Default);
        public static ProfilerRecorder StartNew(ProfilerMarker marker, int capacity = 1, ProfilerRecorderOptions options = ProfilerRecorderOptions.Default);
        public void Start();
        public void Stop();
        public void Reset();
        public ProfilerRecorderSample GetSample(int index);
        public void CopyTo(List<ProfilerRecorderSample> outSamples, bool reset = False);
        public int CopyTo(ProfilerRecorderSample* dest, int destSize, bool reset = False);
        public ProfilerRecorderSample[] ToArray();
        public void Dispose();
    }
}
