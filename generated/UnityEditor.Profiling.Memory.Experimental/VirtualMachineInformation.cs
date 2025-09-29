#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.Profiling.Memory.Experimental
{
    public struct VirtualMachineInformation
    {

        public int pointerSize { get; }
        public int objectHeaderSize { get; }
        public int arrayHeaderSize { get; }
        public int arrayBoundsOffsetInHeader { get; }
        public int arraySizeOffsetInHeader { get; }
        public int allocationGranularity { get; }
    }
}
