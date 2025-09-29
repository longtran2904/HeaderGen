#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.Collections;
using System.Reflection;

namespace System.CodeDom
{
    [DefaultMember("Item")]
    public class CodeStatementCollection : CollectionBase
    {
        public CodeStatementCollection();
        public CodeStatementCollection(CodeStatementCollection value);
        public CodeStatementCollection(CodeStatement[] value);

        public CodeStatement this[int index] { get; set; }

        public int Add(CodeStatement value);
        public int Add(CodeExpression value);
        public void AddRange(CodeStatement[] value);
        public void AddRange(CodeStatementCollection value);
        public bool Contains(CodeStatement value);
        public void CopyTo(CodeStatement[] array, int index);
        public int IndexOf(CodeStatement value);
        public void Insert(int index, CodeStatement value);
        public void Remove(CodeStatement value);
    }
}
