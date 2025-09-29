#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEditor.MemoryProfiler;
using UnityEngine.Profiling.Memory.Experimental;

namespace UnityEditor.Profiling.Memory.Experimental
{
    public class PackedMemorySnapshot : IDisposable
    {

        ~PackedMemorySnapshot();

        public ConnectionEntries connections { get; }
        public FieldDescriptionEntries fieldDescriptions { get; }
        public GCHandleEntries gcHandles { get; }
        public ManagedMemorySectionEntries managedHeapSections { get; }
        public ManagedMemorySectionEntries managedStacks { get; }
        public NativeAllocationEntries nativeAllocations { get; }
        public NativeAllocationSiteEntries nativeAllocationSites { get; }
        public NativeCallstackSymbolEntries nativeCallstackSymbols { get; }
        public NativeMemoryLabelEntries nativeMemoryLabels { get; }
        public NativeMemoryRegionEntries nativeMemoryRegions { get; }
        public NativeObjectEntries nativeObjects { get; }
        public NativeRootReferenceEntries nativeRootReferences { get; }
        public NativeTypeEntries nativeTypes { get; }
        public TypeDescriptionEntries typeDescriptions { get; }
        public uint version { get; }
        public MetaData metadata { get; }
        public string filePath { get; }
        public DateTime recordDate { get; }
        public CaptureFlags captureFlags { get; }
        public VirtualMachineInformation virtualMachineInformation { get; }

        public static PackedMemorySnapshot Load(string path);
        public static bool Convert(UnityEditor.MemoryProfiler.PackedMemorySnapshot snapshot, string writePath);
        public static void Save(PackedMemorySnapshot snapshot, string writePath);
        public void Dispose();
        protected virtual void Dispose(bool disposing);
    }
}
