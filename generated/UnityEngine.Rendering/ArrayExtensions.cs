#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using Unity.Collections;
using UnityEngine.Jobs;

namespace UnityEngine.Rendering
{
    public static class ArrayExtensions
    {

        public static void ResizeArray<T>(ref this NativeArray<T> array, int capacity) where T : struct;
        public static void ResizeArray(ref this TransformAccessArray array, int capacity);
        public static void ResizeArray<T>(ref T[] array, int capacity);
    }
}
