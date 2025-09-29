#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.Collections;
using System.Reflection;

namespace System.CodeDom
{
    [DefaultMember("Item")]
    public class CodeNamespaceImportCollection : ICollection, IEnumerable, IList
    {
        public CodeNamespaceImportCollection();

        public CodeNamespaceImport this[int index] { get; set; }
        public int Count { get; }

        public void Add(CodeNamespaceImport value);
        public void AddRange(CodeNamespaceImport[] value);
        public void Clear();
        public IEnumerator GetEnumerator();
    }
}
