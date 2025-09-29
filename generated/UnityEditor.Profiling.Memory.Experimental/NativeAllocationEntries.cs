#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.Profiling.Memory.Experimental
{
    public class NativeAllocationEntries
    {
        public ArrayEntries<int> memoryRegionIndex { get; }
        public ArrayEntries<long> rootReferenceId { get; }
        public ArrayEntries<long> allocationSiteId { get; }
        public ArrayEntries<ulong> address { get; }
        public ArrayEntries<ulong> size { get; }
        public ArrayEntries<int> overheadSize { get; }
        public ArrayEntries<int> paddingSize { get; }

        public uint GetNumEntries();
    }
}
