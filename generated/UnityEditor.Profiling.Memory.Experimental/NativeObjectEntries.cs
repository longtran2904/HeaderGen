#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.Profiling.Memory.Experimental
{
    public class NativeObjectEntries
    {

        public ArrayEntries<string> objectName { get; }
        public ArrayEntries<int> instanceId { get; }
        public ArrayEntries<ulong> size { get; }
        public ArrayEntries<int> nativeTypeArrayIndex { get; }
        public ArrayEntries<HideFlags> hideFlags { get; }
        public ArrayEntries<ObjectFlags> flags { get; }
        public ArrayEntries<ulong> nativeObjectAddress { get; }
        public ArrayEntries<long> rootReferenceId { get; }
        public ArrayEntries<int> gcHandleIndex { get; }

        public uint GetNumEntries();
    }
}
