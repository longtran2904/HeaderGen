#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;
using UnityEngine.Events;

namespace UnityEngine.Rendering
{
    public class ObjectPool<T> where T : new()
    {

        public ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease, bool collectionCheck = True);

        public int countAll { get; }
        public int countActive { get; }
        public int countInactive { get; }

        public T Get();
        public PooledObject Get(out T v);
        public void Release(T element);
        public struct PooledObject : IDisposable
        {
        }
    }
}
