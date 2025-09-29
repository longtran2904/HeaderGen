#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor.Profiling.Memory.Experimental
{
    public static class TypeFlagsExtensions
    {

        public static bool IsValueType(this TypeFlags flags);
        public static bool IsArray(this TypeFlags flags);
        public static int ArrayRank(this TypeFlags flags);
    }
}
