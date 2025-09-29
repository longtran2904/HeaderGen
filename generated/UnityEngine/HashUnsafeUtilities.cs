#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine
{
    public static class HashUnsafeUtilities
    {

        public static void ComputeHash128(void* data, ulong dataSize, ulong* hash1, ulong* hash2);
        public static void ComputeHash128(void* data, ulong dataSize, Hash128* hash);
    }
}
