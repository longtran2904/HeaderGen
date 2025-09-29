#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.Rendering
{
    public static class HashSetPool<T>
    {

        public static HashSet<T> Get();
        public static ObjectPool<HashSet<T>>.PooledObject Get(out HashSet<T> value);
        public static void Release(HashSet<T> toRelease);
    }
}
