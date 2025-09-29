#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEditor.Profiling.Memory.Experimental;

namespace UnityEditor.MemoryProfiler
{
    public class PackedMemorySnapshot
    {

        public PackedMemorySnapshot(UnityEditor.Profiling.Memory.Experimental.PackedMemorySnapshot snapshot);

        public PackedNativeType[] nativeTypes { get; }
        public PackedNativeUnityEngineObject[] nativeObjects { get; }
        public PackedGCHandle[] gcHandles { get; }
        public Connection[] connections { get; }
        public MemorySection[] managedHeapSections { get; }
        public TypeDescription[] typeDescriptions { get; }
        public VirtualMachineInformation virtualMachineInformation { get; }
    }
}
