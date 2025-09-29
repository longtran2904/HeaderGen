#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.Profiling.Memory.Experimental
{
    public class FieldDescriptionEntries
    {
        public ArrayEntries<string> fieldDescriptionName { get; }
        public ArrayEntries<int> offset { get; }
        public ArrayEntries<int> typeIndex { get; }
        public ArrayEntries<bool> isStatic { get; }

        public uint GetNumEntries();
    }
}
