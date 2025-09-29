#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public readonly struct TreeViewItemData<T>
    {
        public TreeViewItemData(int id, T data, List<TreeViewItemData<T>> children = null);

        public int id { get; }
        public T data { get; }
        public IEnumerable<TreeViewItemData<T>> children { get; }
        public bool hasChildren { get; }
    }
}
