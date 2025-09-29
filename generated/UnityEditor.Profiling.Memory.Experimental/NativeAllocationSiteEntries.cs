#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.Profiling.Memory.Experimental
{
    public class NativeAllocationSiteEntries
    {
        public ArrayEntries<long> id { get; }
        public ArrayEntries<int> memoryLabelIndex { get; }
        public ArrayEntries<ulong[]> callstackSymbols { get; }

        public uint GetNumEntries();
    }
}
