#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using System.Collections.Generic;
using Unity.Profiling.LowLevel;
using UnityEngine.Bindings;

namespace UnityEditor.Profiling
{
    [NativeHeader("Modules/ProfilerEditor/ProfilerHistory/HierarchyFrameDataView.h")]
    public class HierarchyFrameDataView : FrameDataView
    {

        public const int invalidSampleId = -1;
        public const int columnDontSort = -1;
        public const int columnName = 0;
        public const int columnTotalPercent = 1;
        public const int columnSelfPercent = 2;
        public const int columnCalls = 3;
        public const int columnGcMemory = 4;
        public const int columnTotalTime = 5;
        public const int columnSelfTime = 6;
        public const int columnWarningCount = 12;
        public const int columnObjectName = 13;
        public const int columnStartTime = 14;

        public ViewModes viewMode { get; }
        public int sortColumn { get; }
        public bool sortColumnAscending { get; }

        [ThreadSafe]
        public int GetRootItemID();
        [ThreadSafe]
        public int GetItemMarkerID(int id);
        [ThreadSafe]
        public MarkerFlags GetItemMarkerFlags(int id);
        [ThreadSafe]
        public ushort GetItemCategoryIndex(int id);
        [ThreadSafe]
        public int GetItemDepth(int id);
        public bool HasItemChildren(int id);
        [NativeThrows]
        public void GetItemChildren(int id, List<int> outChildren);
        [NativeThrows]
        public void GetItemAncestors(int id, List<int> outAncestors);
        [NativeThrows]
        public void GetItemDescendantsThatHaveChildren(int id, List<int> outChildren);
        [ThreadSafe]
        public string GetItemName(int id);
        [ThreadSafe]
        public int GetItemInstanceID(int id);
        [ThreadSafe]
        public string GetItemColumnData(int id, int column);
        public float GetItemColumnDataAsSingle(int id, int column);
        [ThreadSafe]
        public float GetItemColumnDataAsFloat(int id, int column);
        [ThreadSafe]
        public double GetItemColumnDataAsDouble(int id, int column);
        public int GetItemMetadataCount(int id);
        public string GetItemMetadata(int id, int index);
        public float GetItemMetadataAsFloat(int id, int index);
        public long GetItemMetadataAsLong(int id, int index);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public int GetItemMergedSamplesMetadataCount(int id, int sampleIndex);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public string GetItemMergedSamplesMetadata(int id, int sampleIndex, int metadataIndex);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public float GetItemMergedSamplesMetadataAsFloat(int id, int sampleIndex, int metadataIndex);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public long GetItemMergedSamplesMetadataAsLong(int id, int sampleIndex, int metadataIndex);
        public string ResolveItemCallstack(int id);
        public void GetItemCallstack(int id, List<ulong> outCallstack);
        [ThreadSafe]
        public int GetItemMergedSamplesCount(int id);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public void GetItemRawFrameDataViewIndices(int id, List<int> outSampleIndices);
        [NativeMethod(IsThreadSafe = True, ThrowsException = True)]
        public bool ItemContainsRawFrameDataViewIndex(int id, int sampleIndex);
        public void GetItemMergedSamplesColumnData(int id, int column, List<string> outStrings);
        public void GetItemMergedSamplesColumnDataAsFloats(int id, int column, List<float> outValues);
        public void GetItemMergedSamplesColumnDataAsDoubles(int id, int column, List<double> outValues);
        public void GetItemMergedSamplesInstanceID(int id, List<int> outInstanceIds);
        public void GetItemMergedSampleCallstack(int id, int sampleIndex, List<ulong> outCallstack);
        public string ResolveItemMergedSampleCallstack(int id, int sampleIndex);
        public void GetItemMarkerIDPath(int id, List<int> outFullIdPath);
        public string GetItemPath(int id);
        public void Sort(int sortColumn, bool sortAscending);
        public override bool Equals(object obj);
        public override int GetHashCode();
        [Flags]
        public enum ViewModes
        {

            Default = 0,
            MergeSamplesWithTheSameName = 1,
            HideEditorOnlySamples = 2
        }
    }
}
