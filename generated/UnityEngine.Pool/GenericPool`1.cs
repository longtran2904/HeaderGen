#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine.Pool
{
    public class GenericPool<T> where T : class, new()
    {
        public GenericPool();

        public static T Get();
        public static PooledObject<T> Get(out T value);
        public static void Release(T toRelease);
    }
}
