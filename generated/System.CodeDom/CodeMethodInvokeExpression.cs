#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeMethodInvokeExpression : CodeExpression
    {
        public CodeMethodInvokeExpression();
        public CodeMethodInvokeExpression(CodeMethodReferenceExpression method, params CodeExpression[] parameters);
        public CodeMethodInvokeExpression(CodeExpression targetObject, string methodName, params CodeExpression[] parameters);

        public CodeMethodReferenceExpression Method { get; set; }
        public CodeExpressionCollection Parameters { get; }
    }
}
