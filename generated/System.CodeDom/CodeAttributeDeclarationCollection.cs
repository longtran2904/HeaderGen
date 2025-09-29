#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.Collections;
using System.Reflection;

namespace System.CodeDom
{
    [DefaultMember("Item")]
    public class CodeAttributeDeclarationCollection : CollectionBase
    {

        public CodeAttributeDeclarationCollection();
        public CodeAttributeDeclarationCollection(CodeAttributeDeclarationCollection value);
        public CodeAttributeDeclarationCollection(CodeAttributeDeclaration[] value);

        public CodeAttributeDeclaration this[int index] { get; set; }

        public int Add(CodeAttributeDeclaration value);
        public void AddRange(CodeAttributeDeclaration[] value);
        public void AddRange(CodeAttributeDeclarationCollection value);
        public bool Contains(CodeAttributeDeclaration value);
        public void CopyTo(CodeAttributeDeclaration[] array, int index);
        public int IndexOf(CodeAttributeDeclaration value);
        public void Insert(int index, CodeAttributeDeclaration value);
        public void Remove(CodeAttributeDeclaration value);
    }
}
