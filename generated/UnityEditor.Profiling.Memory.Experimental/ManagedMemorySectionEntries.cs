#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.Profiling.Memory.Experimental
{
    public class ManagedMemorySectionEntries
    {
        public ArrayEntries<byte[]> bytes { get; }
        public ArrayEntries<ulong> startAddress { get; }

        public uint GetNumEntries();
    }
}
