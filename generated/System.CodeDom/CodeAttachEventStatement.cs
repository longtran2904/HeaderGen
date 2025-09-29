#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeAttachEventStatement : CodeStatement
    {
        public CodeAttachEventStatement();
        public CodeAttachEventStatement(CodeEventReferenceExpression eventRef, CodeExpression listener);
        public CodeAttachEventStatement(CodeExpression targetObject, string eventName, CodeExpression listener);

        public CodeEventReferenceExpression Event { get; set; }
        public CodeExpression Listener { get; set; }
    }
}
