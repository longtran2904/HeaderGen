#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.Pool
{
    public class CollectionPool<TCollection, TItem> where TCollection : ICollection<TItem>, class, new()
    {

        public CollectionPool();

        public static TCollection Get();
        public static PooledObject<TCollection> Get(out TCollection value);
        public static void Release(TCollection toRelease);
    }
}
