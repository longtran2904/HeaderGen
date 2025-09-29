#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System.Collections.Generic;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.Profiling
{
    [NativeHeader("Modules/ProfilerEditor/ProfilerHistory/RawFrameDataView.h")]
    public class RawFrameDataView : FrameDataView
    {
        public const int invalidSampleIndex = -1;

        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public double GetSampleStartTimeMs(int sampleIndex);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public ulong GetSampleStartTimeNs(int sampleIndex);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public float GetSampleTimeMs(int sampleIndex);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public ulong GetSampleTimeNs(int sampleIndex);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public int GetSampleMarkerId(int sampleIndex);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public MarkerFlags GetSampleFlags(int sampleIndex);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public ushort GetSampleCategoryIndex(int sampleIndex);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public string GetSampleName(int sampleIndex);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public int GetSampleChildrenCount(int sampleIndex);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public int GetSampleChildrenCountRecursive(int sampleIndex);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public int GetSampleMetadataCount(int sampleIndex);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public string GetSampleMetadataAsString(int sampleIndex, int metadataIndex);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public int GetSampleMetadataAsInt(int sampleIndex, int metadataIndex);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public long GetSampleMetadataAsLong(int sampleIndex, int metadataIndex);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public float GetSampleMetadataAsFloat(int sampleIndex, int metadataIndex);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public double GetSampleMetadataAsDouble(int sampleIndex, int metadataIndex);
        public void GetSampleCallstack(int sampleIndex, List<ulong> outCallstack);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public void GetSampleFlowEvents(int sampleIndex, List<FlowEvent> outFlowEvents);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public void GetFlowEvents(List<FlowEvent> outFlowEvents);
        public override bool Equals(object obj);
        public override int GetHashCode();

        [RequiredByNativeCode]
        public struct FlowEvent
        {
            public int ParentSampleIndex;
            public uint FlowId;
            public ProfilerFlowEventType FlowEventType;
        }
    }
}
