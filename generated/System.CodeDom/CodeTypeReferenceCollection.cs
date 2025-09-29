#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.Collections;
using System.Reflection;

namespace System.CodeDom
{
    [DefaultMember("Item")]
    public class CodeTypeReferenceCollection : CollectionBase
    {

        public CodeTypeReferenceCollection();
        public CodeTypeReferenceCollection(CodeTypeReferenceCollection value);
        public CodeTypeReferenceCollection(CodeTypeReference[] value);

        public CodeTypeReference this[int index] { get; set; }

        public int Add(CodeTypeReference value);
        public void Add(string value);
        public void Add(Type value);
        public void AddRange(CodeTypeReference[] value);
        public void AddRange(CodeTypeReferenceCollection value);
        public bool Contains(CodeTypeReference value);
        public void CopyTo(CodeTypeReference[] array, int index);
        public int IndexOf(CodeTypeReference value);
        public void Insert(int index, CodeTypeReference value);
        public void Remove(CodeTypeReference value);
    }
}
