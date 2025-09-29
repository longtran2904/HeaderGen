#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.MemoryProfiler
{
    public struct TypeDescription
    {

        public TypeDescription(string name, string assembly, FieldDescription[] fields, byte[] staticFieldBytes, int baseOrElementTypeIndes, int size, ulong typeInfoAddress, int typeIndex, TypeFlags flags);

        public bool isValueType { get; }
        public bool isArray { get; }
        public int arrayRank { get; }
        public string name { get; }
        public string assembly { get; }
        public FieldDescription[] fields { get; }
        public byte[] staticFieldBytes { get; }
        public int baseOrElementTypeIndex { get; }
        public int size { get; }
        public ulong typeInfoAddress { get; }
        public int typeIndex { get; }
        public enum TypeFlags
        {

            kNone = 0,
            kValueType = 1,
            kArray = 2,
            kArrayRankMask = -65536
        }
    }
}
