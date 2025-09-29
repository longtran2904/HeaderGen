#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeDelegateCreateExpression : CodeExpression
    {

        public CodeDelegateCreateExpression();
        public CodeDelegateCreateExpression(CodeTypeReference delegateType, CodeExpression targetObject, string methodName);

        public CodeTypeReference DelegateType { get; set; }
        public CodeExpression TargetObject { get; set; }
        public string MethodName { get; set; }
    }
}
