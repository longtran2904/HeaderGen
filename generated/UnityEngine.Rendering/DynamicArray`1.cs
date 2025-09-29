#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System;
using System.Reflection;

namespace UnityEngine.Rendering
{
    [DefaultMember("Item")]
    public class DynamicArray<T> where T : new()
    {
        public DynamicArray();
        public DynamicArray(int size);

        public ref T this[int index] { get; }
        public int size { get; }
        public int capacity { get; }

        public void Clear();
        public bool Contains(T item);
        public int Add(in T value);
        public void AddRange(DynamicArray<T> array);
        public bool Remove(T item);
        public void RemoveAt(int index);
        public void RemoveRange(int index, int count);
        public int FindIndex(int startIndex, int count, Predicate<T> match);
        public int IndexOf(T item, int index, int count);
        public int IndexOf(T item, int index);
        public int IndexOf(T item);
        public void Resize(int newSize, bool keepContent = False);
        public void Reserve(int newCapacity, bool keepContent = False);

        public static implicit operator T[](DynamicArray<T> array);
    }
}
