#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.Profiling.Memory.Experimental
{
    public class TypeDescriptionEntries
    {
        public ArrayEntries<TypeFlags> flags { get; }
        public ArrayEntries<string> typeDescriptionName { get; }
        public ArrayEntries<string> assembly { get; }
        public ArrayEntries<int[]> fieldIndices { get; }
        public ArrayEntries<byte[]> staticFieldBytes { get; }
        public ArrayEntries<int> baseOrElementTypeIndex { get; }
        public ArrayEntries<int> size { get; }
        public ArrayEntries<ulong> typeInfoAddress { get; }
        public ArrayEntries<int> typeIndex { get; }

        public uint GetNumEntries();
    }
}
