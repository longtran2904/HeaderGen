#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

namespace TMPro
{
    public struct TMP_TextProcessingStack<T>
    {

        public T[] itemStack;
        public int index;

        public TMP_TextProcessingStack(T[] stack);
        public TMP_TextProcessingStack(int capacity);
        public TMP_TextProcessingStack(int capacity, int rolloverSize);

        public int Count { get; }
        public T current { get; }
        public int rolloverSize { get; set; }

        public void Clear();
        public void SetDefault(T item);
        public void Add(T item);
        public T Remove();
        public void Push(T item);
        public T Pop();
        public T Peek();
        public T CurrentItem();
        public T PreviousItem();
    }
}
