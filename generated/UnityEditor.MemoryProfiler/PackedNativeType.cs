#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor.MemoryProfiler
{
    public struct PackedNativeType
    {
        public PackedNativeType(string name, int nativeBaseTypeArrayIndex);

        public string name { get; }
        [Obsolete("PackedNativeType.baseClassId is obsolete. Use PackedNativeType.nativeBaseTypeArrayIndex instead (UnityUpgradable) -> nativeBaseTypeArrayIndex")]
        public int baseClassId { get; }
        public int nativeBaseTypeArrayIndex { get; }
    }
}
