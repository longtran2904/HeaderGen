#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.Collections;
using System.Reflection;

namespace System.CodeDom
{
    [DefaultMember("Item")]
    public class CodeCommentStatementCollection : CollectionBase
    {
        public CodeCommentStatementCollection();
        public CodeCommentStatementCollection(CodeCommentStatementCollection value);
        public CodeCommentStatementCollection(CodeCommentStatement[] value);

        public CodeCommentStatement this[int index] { get; set; }

        public int Add(CodeCommentStatement value);
        public void AddRange(CodeCommentStatement[] value);
        public void AddRange(CodeCommentStatementCollection value);
        public bool Contains(CodeCommentStatement value);
        public void CopyTo(CodeCommentStatement[] array, int index);
        public int IndexOf(CodeCommentStatement value);
        public void Insert(int index, CodeCommentStatement value);
        public void Remove(CodeCommentStatement value);
    }
}
