#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering
{
    public static class GenericPool<T> where T : new()
    {

        public static T Get();
        public static ObjectPool<T>.PooledObject Get(out T value);
        public static void Release(T toRelease);
    }
}
