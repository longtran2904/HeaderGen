#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeArrayCreateExpression : CodeExpression
    {

        public CodeArrayCreateExpression();
        public CodeArrayCreateExpression(CodeTypeReference createType, params CodeExpression[] initializers);
        public CodeArrayCreateExpression(string createType, params CodeExpression[] initializers);
        public CodeArrayCreateExpression(Type createType, params CodeExpression[] initializers);
        public CodeArrayCreateExpression(CodeTypeReference createType, int size);
        public CodeArrayCreateExpression(string createType, int size);
        public CodeArrayCreateExpression(Type createType, int size);
        public CodeArrayCreateExpression(CodeTypeReference createType, CodeExpression size);
        public CodeArrayCreateExpression(string createType, CodeExpression size);
        public CodeArrayCreateExpression(Type createType, CodeExpression size);

        public CodeTypeReference CreateType { get; set; }
        public CodeExpressionCollection Initializers { get; }
        public int Size { get; set; }
        public CodeExpression SizeExpression { get; set; }
    }
}
