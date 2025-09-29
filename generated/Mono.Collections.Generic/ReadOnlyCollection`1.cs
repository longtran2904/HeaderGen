#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

namespace Mono.Collections.Generic
{
    public sealed class ReadOnlyCollection<T> : Collection<T>
    {
        public ReadOnlyCollection(T[] array);
        public ReadOnlyCollection(Collection<T> collection);

        public static ReadOnlyCollection<T> Empty { get; }

        protected override void OnAdd(T item, int index);
        protected override void OnClear();
        protected override void OnInsert(T item, int index);
        protected override void OnRemove(T item, int index);
        protected override void OnSet(T item, int index);
    }
}
