#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeCastExpression : CodeExpression
    {
        public CodeCastExpression();
        public CodeCastExpression(CodeTypeReference targetType, CodeExpression expression);
        public CodeCastExpression(string targetType, CodeExpression expression);
        public CodeCastExpression(Type targetType, CodeExpression expression);

        public CodeTypeReference TargetType { get; set; }
        public CodeExpression Expression { get; set; }
    }
}
