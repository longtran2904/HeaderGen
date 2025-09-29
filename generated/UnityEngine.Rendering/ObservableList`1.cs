#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace UnityEngine.Rendering
{
    [DefaultMember("Item")]
    public class ObservableList<T> : ICollection<T>, IEnumerable, IEnumerable<T>, IList<T>
    {

        public ObservableList();
        public ObservableList(int capacity);
        public ObservableList(IEnumerable<T> collection);

        public T this[int index] { get; set; }
        public int Count { get; }
        public bool IsReadOnly { get; }

        public event ListChangedEventHandler<T> ItemAdded;
        public event ListChangedEventHandler<T> ItemRemoved;

        public bool Contains(T item);
        public int IndexOf(T item);
        public void Add(T item);
        public void Add(params T[] items);
        public void Insert(int index, T item);
        public bool Remove(T item);
        public int Remove(params T[] items);
        public void RemoveAt(int index);
        public void Clear();
        public void CopyTo(T[] array, int arrayIndex);
        public IEnumerator<T> GetEnumerator();
    }
}
