#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Scripting;

namespace Unity.Profiling.LowLevel.Unsafe
{
    [UsedByNativeCode]
    public readonly struct ProfilerRecorderDescription
    {
        public ProfilerCategory Category { get; }
        public MarkerFlags Flags { get; }
        public ProfilerMarkerDataType DataType { get; }
        public ProfilerMarkerDataUnit UnitType { get; }
        public int NameUtf8Len { get; }
        public byte* NameUtf8 { get; }
        public string Name { get; }
    }
}
