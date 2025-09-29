#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeParameterDeclarationExpression : CodeExpression
    {
        public CodeParameterDeclarationExpression();
        public CodeParameterDeclarationExpression(CodeTypeReference type, string name);
        public CodeParameterDeclarationExpression(string type, string name);
        public CodeParameterDeclarationExpression(Type type, string name);

        public CodeAttributeDeclarationCollection CustomAttributes { get; set; }
        public FieldDirection Direction { get; set; }
        public CodeTypeReference Type { get; set; }
        public string Name { get; set; }
    }
}
