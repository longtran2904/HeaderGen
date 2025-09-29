#region Unity.MemoryProfiler.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.MemoryProfiler.Editor.dll
#endregion

using System;
using System.Reflection;
using Unity.Collections;

namespace Unity.MemoryProfiler.Editor.Containers
{
    [DefaultMember("Item")]
    public struct DynamicArray<T> : IDisposable where T : unmanaged
    {
        public DynamicArray(Allocator label);
        public DynamicArray(long initialSize, Allocator label, bool memClear = False);

        public T this[long idx] { get; set; }
        public long Count { get; }
        public long Capacity { get; set; }
        public bool IsCreated { get; }

        public DynamicArray<U> Reinterpret<U>() where U : unmanaged;
        public DynamicArray<U> Reinterpret<U>(int expectedTypeSize) where U : unmanaged;
        public void CopyFrom(T[] arr);
        public void* GetUnsafePtr();
        public T Back();
        public void Resize(long newSize, bool memClear);
        public void Push(T value);
        public T Pop();
        public void Clear(bool stomp);
        public void ShrinkToFit();
        public void Dispose();
    }
}
