#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine.Pool
{
    public interface IObjectPool<T> where T : class
    {

        int CountInactive { get; }

        T Get();
        PooledObject<T> Get(out T v);
        void Release(T element);
        void Clear();
    }
}
