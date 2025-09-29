#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.Profiling.Memory.Experimental
{
    public class NativeMemoryRegionEntries
    {
        public ArrayEntries<string> memoryRegionName { get; }
        public ArrayEntries<int> parentIndex { get; }
        public ArrayEntries<ulong> addressBase { get; }
        public ArrayEntries<ulong> addressSize { get; }
        public ArrayEntries<int> firstAllocationIndex { get; }
        public ArrayEntries<int> numAllocations { get; }

        public uint GetNumEntries();
    }
}
