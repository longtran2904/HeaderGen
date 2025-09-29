#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.Collections;
using System.Reflection;

namespace System.CodeDom
{
    [DefaultMember("Item")]
    public class CodeParameterDeclarationExpressionCollection : CollectionBase
    {
        public CodeParameterDeclarationExpressionCollection();
        public CodeParameterDeclarationExpressionCollection(CodeParameterDeclarationExpressionCollection value);
        public CodeParameterDeclarationExpressionCollection(CodeParameterDeclarationExpression[] value);

        public CodeParameterDeclarationExpression this[int index] { get; set; }

        public int Add(CodeParameterDeclarationExpression value);
        public void AddRange(CodeParameterDeclarationExpression[] value);
        public void AddRange(CodeParameterDeclarationExpressionCollection value);
        public bool Contains(CodeParameterDeclarationExpression value);
        public void CopyTo(CodeParameterDeclarationExpression[] array, int index);
        public int IndexOf(CodeParameterDeclarationExpression value);
        public void Insert(int index, CodeParameterDeclarationExpression value);
        public void Remove(CodeParameterDeclarationExpression value);
    }
}
