#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine
{
    public static class HashUtilities
    {
        public static void AppendHash(ref Hash128 inHash, ref Hash128 outHash);
        public static void QuantisedMatrixHash(ref Matrix4x4 value, ref Hash128 hash);
        public static void QuantisedVectorHash(ref Vector3 value, ref Hash128 hash);
        public static void ComputeHash128<T>(ref T value, ref Hash128 hash) where T : struct;
        public static void ComputeHash128(byte[] value, ref Hash128 hash);
    }
}
