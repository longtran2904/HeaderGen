#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeBinaryOperatorExpression : CodeExpression
    {
        public CodeBinaryOperatorExpression();
        public CodeBinaryOperatorExpression(CodeExpression left, CodeBinaryOperatorType op, CodeExpression right);

        public CodeExpression Right { get; set; }
        public CodeExpression Left { get; set; }
        public CodeBinaryOperatorType Operator { get; set; }
    }
}
