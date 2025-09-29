#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.Collections;
using System.Reflection;

namespace System.CodeDom
{
    [DefaultMember("Item")]
    public class CodeNamespaceCollection : CollectionBase
    {
        public CodeNamespaceCollection();
        public CodeNamespaceCollection(CodeNamespaceCollection value);
        public CodeNamespaceCollection(CodeNamespace[] value);

        public CodeNamespace this[int index] { get; set; }

        public int Add(CodeNamespace value);
        public void AddRange(CodeNamespace[] value);
        public void AddRange(CodeNamespaceCollection value);
        public bool Contains(CodeNamespace value);
        public void CopyTo(CodeNamespace[] array, int index);
        public int IndexOf(CodeNamespace value);
        public void Insert(int index, CodeNamespace value);
        public void Remove(CodeNamespace value);
    }
}
