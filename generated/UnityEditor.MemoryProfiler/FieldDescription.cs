#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.MemoryProfiler
{
    public struct FieldDescription
    {
        public FieldDescription(string name, int offset, int typeIndex, bool isStatic);

        public string name { get; }
        public int offset { get; }
        public int typeIndex { get; }
        public bool isStatic { get; }
    }
}
