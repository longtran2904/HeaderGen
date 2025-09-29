#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeObjectCreateExpression : CodeExpression
    {
        public CodeObjectCreateExpression();
        public CodeObjectCreateExpression(CodeTypeReference createType, params CodeExpression[] parameters);
        public CodeObjectCreateExpression(string createType, params CodeExpression[] parameters);
        public CodeObjectCreateExpression(Type createType, params CodeExpression[] parameters);

        public CodeTypeReference CreateType { get; set; }
        public CodeExpressionCollection Parameters { get; }
    }
}
