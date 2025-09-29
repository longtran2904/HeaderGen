#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.Collections;
using System.Reflection;

namespace System.CodeDom
{
    [DefaultMember("Item")]
    public class CodeCatchClauseCollection : CollectionBase
    {

        public CodeCatchClauseCollection();
        public CodeCatchClauseCollection(CodeCatchClauseCollection value);
        public CodeCatchClauseCollection(CodeCatchClause[] value);

        public CodeCatchClause this[int index] { get; set; }

        public int Add(CodeCatchClause value);
        public void AddRange(CodeCatchClause[] value);
        public void AddRange(CodeCatchClauseCollection value);
        public bool Contains(CodeCatchClause value);
        public void CopyTo(CodeCatchClause[] array, int index);
        public int IndexOf(CodeCatchClause value);
        public void Insert(int index, CodeCatchClause value);
        public void Remove(CodeCatchClause value);
    }
}
