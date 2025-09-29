#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.Profiling
{
    [NativeHeader("Modules/ProfilerEditor/ProfilerHistory/FrameDataView.h")]
    public abstract class FrameDataView : IDisposable
    {

        protected nint m_Ptr;
        public const int invalidMarkerId = -1;
        public const int invalidThreadIndex = -1;
        public const ulong invalidThreadId = 0;

        protected FrameDataView();

        ~FrameDataView();

        public bool valid { get; }
        public int frameIndex { get; }
        public int threadIndex { get; }
        public string threadGroupName { get; }
        public string threadName { get; }
        public ulong threadId { get; }
        public double frameStartTimeMs { get; }
        public ulong frameStartTimeNs { get; }
        public float frameTimeMs { get; }
        public ulong frameTimeNs { get; }
        public float frameGpuTimeMs { get; }
        public ulong frameGpuTimeNs { get; }
        public float frameFps { get; }
        public int sampleCount { get; }
        public int maxDepth { get; }

        public void Dispose();
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public ushort GetMarkerCategoryIndex(int markerId);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public MarkerFlags GetMarkerFlags(int markerId);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public string GetMarkerName(int markerId);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public MarkerMetadataInfo[] GetMarkerMetadataInfo(int markerId);
        [NativeMethod(IsThreadSafe = True)]
        public int GetMarkerId(string markerName);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public void GetMarkers(List<MarkerInfo> markerInfoList);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public ProfilerCategoryInfo GetCategoryInfo(ushort id);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public void GetAllCategories(List<ProfilerCategoryInfo> categoryInfoList);
        public NativeArray<T> GetFrameMetaData<T>(Guid id, int tag) where T : struct;
        public NativeArray<T> GetFrameMetaData<T>(Guid id, int tag, int index) where T : struct;
        public int GetFrameMetaDataCount(Guid id, int tag);
        public NativeArray<T> GetSessionMetaData<T>(Guid id, int tag) where T : struct;
        public NativeArray<T> GetSessionMetaData<T>(Guid id, int tag, int index) where T : struct;
        public int GetSessionMetaDataCount(Guid id, int tag);
        public MethodInfo ResolveMethodInfo(ulong addr);
        [NativeMethod(IsThreadSafe = True)]
        public void* GetCounterValuePtr(int markerId);
        public bool HasCounterValue(int markerId);
        [NativeMethod(IsThreadSafe = True)]
        public int GetCounterValueAsInt(int markerId);
        [NativeMethod(IsThreadSafe = True)]
        public long GetCounterValueAsLong(int markerId);
        [NativeMethod(IsThreadSafe = True)]
        public float GetCounterValueAsFloat(int markerId);
        [NativeMethod(IsThreadSafe = True)]
        public double GetCounterValueAsDouble(int markerId);
        [RequiredByNativeCode]
        public struct MarkerMetadataInfo
        {

            public ProfilerMarkerDataType type;
            public ProfilerMarkerDataUnit unit;
            public string name;
        }
        [RequiredByNativeCode]
        public struct MarkerInfo
        {

            public int id;
            public ushort category;
            public MarkerFlags flags;
            public string name;
            public MarkerMetadataInfo[] metadataInfo;
        }
        [RequiredByNativeCode]
        public struct MethodInfo
        {

            public string methodName;
            public string sourceFileName;
            public uint sourceFileLine;
        }
    }
}
