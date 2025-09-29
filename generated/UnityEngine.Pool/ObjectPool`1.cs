#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;

namespace UnityEngine.Pool
{
    public class ObjectPool<T> : IDisposable, IObjectPool<T> where T : class
    {

        public ObjectPool(Func<T> createFunc, Action<T> actionOnGet = null, Action<T> actionOnRelease = null, Action<T> actionOnDestroy = null, bool collectionCheck = True, int defaultCapacity = 10, int maxSize = 10000);

        public int CountAll { get; }
        public int CountActive { get; }
        public int CountInactive { get; }

        public T Get();
        public PooledObject<T> Get(out T v);
        public void Release(T element);
        public void Clear();
        public void Dispose();
    }
}
