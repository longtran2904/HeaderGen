#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.Collections;
using System.Reflection;

namespace System.CodeDom
{
    [DefaultMember("Item")]
    public class CodeExpressionCollection : CollectionBase
    {

        public CodeExpressionCollection();
        public CodeExpressionCollection(CodeExpressionCollection value);
        public CodeExpressionCollection(CodeExpression[] value);

        public CodeExpression this[int index] { get; set; }

        public int Add(CodeExpression value);
        public void AddRange(CodeExpression[] value);
        public void AddRange(CodeExpressionCollection value);
        public bool Contains(CodeExpression value);
        public void CopyTo(CodeExpression[] array, int index);
        public int IndexOf(CodeExpression value);
        public void Insert(int index, CodeExpression value);
        public void Remove(CodeExpression value);
    }
}
