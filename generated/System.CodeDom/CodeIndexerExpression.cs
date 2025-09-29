#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeIndexerExpression : CodeExpression
    {

        public CodeIndexerExpression();
        public CodeIndexerExpression(CodeExpression targetObject, params CodeExpression[] indices);

        public CodeExpression TargetObject { get; set; }
        public CodeExpressionCollection Indices { get; }
    }
}
