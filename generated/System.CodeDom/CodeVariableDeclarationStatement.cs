#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeVariableDeclarationStatement : CodeStatement
    {
        public CodeVariableDeclarationStatement();
        public CodeVariableDeclarationStatement(CodeTypeReference type, string name);
        public CodeVariableDeclarationStatement(string type, string name);
        public CodeVariableDeclarationStatement(Type type, string name);
        public CodeVariableDeclarationStatement(CodeTypeReference type, string name, CodeExpression initExpression);
        public CodeVariableDeclarationStatement(string type, string name, CodeExpression initExpression);
        public CodeVariableDeclarationStatement(Type type, string name, CodeExpression initExpression);

        public CodeExpression InitExpression { get; set; }
        public string Name { get; set; }
        public CodeTypeReference Type { get; set; }
    }
}
