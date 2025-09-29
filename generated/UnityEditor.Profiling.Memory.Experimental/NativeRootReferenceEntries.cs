#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.Profiling.Memory.Experimental
{
    public class NativeRootReferenceEntries
    {

        public ArrayEntries<long> id { get; }
        public ArrayEntries<string> areaName { get; }
        public ArrayEntries<string> objectName { get; }
        public ArrayEntries<ulong> accumulatedSize { get; }

        public uint GetNumEntries();
    }
}
