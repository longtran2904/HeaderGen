#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.Collections;
using System.Reflection;

namespace System.CodeDom
{
    [DefaultMember("Item")]
    public class CodeDirectiveCollection : CollectionBase
    {
        public CodeDirectiveCollection();
        public CodeDirectiveCollection(CodeDirectiveCollection value);
        public CodeDirectiveCollection(CodeDirective[] value);

        public CodeDirective this[int index] { get; set; }

        public int Add(CodeDirective value);
        public void AddRange(CodeDirective[] value);
        public void AddRange(CodeDirectiveCollection value);
        public bool Contains(CodeDirective value);
        public void CopyTo(CodeDirective[] array, int index);
        public int IndexOf(CodeDirective value);
        public void Insert(int index, CodeDirective value);
        public void Remove(CodeDirective value);
    }
}
