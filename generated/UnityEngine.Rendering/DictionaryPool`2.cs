#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.Rendering
{
    public static class DictionaryPool<TKey, TValue>
    {

        public static Dictionary<TKey, TValue> Get();
        public static ObjectPool<Dictionary<TKey, TValue>>.PooledObject Get(out Dictionary<TKey, TValue> value);
        public static void Release(Dictionary<TKey, TValue> toRelease);
    }
}
