#region Unity.MemoryProfiler.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.MemoryProfiler.Editor.dll
#endregion

using System;
using System.Reflection;

namespace Unity.MemoryProfiler.Editor.Containers
{
    [DefaultMember("Item")]
    public struct DynamicBlockArray<T> : IDisposable where T : struct
    {

        public const int k_InitialBlockSlots = 8;

        public DynamicBlockArray(int blockSize, int initialCapacity);

        public T this[long idx] { get; set; }
        public uint Count { get; }
        public uint Capacity { get; set; }

        public T Back();
        public void Push(T value);
        public T Pop();
        public void Clear(bool stomp);
        public void Dispose();
    }
}
