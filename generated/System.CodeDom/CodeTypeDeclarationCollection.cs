#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.Collections;
using System.Reflection;

namespace System.CodeDom
{
    [DefaultMember("Item")]
    public class CodeTypeDeclarationCollection : CollectionBase
    {

        public CodeTypeDeclarationCollection();
        public CodeTypeDeclarationCollection(CodeTypeDeclarationCollection value);
        public CodeTypeDeclarationCollection(CodeTypeDeclaration[] value);

        public CodeTypeDeclaration this[int index] { get; set; }

        public int Add(CodeTypeDeclaration value);
        public void AddRange(CodeTypeDeclaration[] value);
        public void AddRange(CodeTypeDeclarationCollection value);
        public bool Contains(CodeTypeDeclaration value);
        public void CopyTo(CodeTypeDeclaration[] array, int index);
        public int IndexOf(CodeTypeDeclaration value);
        public void Insert(int index, CodeTypeDeclaration value);
        public void Remove(CodeTypeDeclaration value);
    }
}
