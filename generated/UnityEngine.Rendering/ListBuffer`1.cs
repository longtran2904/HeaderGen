#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System.Reflection;

namespace UnityEngine.Rendering
{
    [DefaultMember("Item")]
    public struct ListBuffer<T> where T : unmanaged
    {

        public ListBuffer(T* bufferPtr, int* countPtr, int capacity);

        public ref T this[in int index] { get; }
        public int Count { get; }
        public int Capacity { get; }

        public ref T GetUnchecked(in int index);
        public bool TryAdd(in T value);
        public void CopyTo(T* dstBuffer, int startDstIndex, int copyCount);
        public bool TryCopyTo(ListBuffer<T> other);
        public bool TryCopyFrom(T* srcPtr, int count);
    }
}
