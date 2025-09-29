#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeRemoveEventStatement : CodeStatement
    {
        public CodeRemoveEventStatement();
        public CodeRemoveEventStatement(CodeEventReferenceExpression eventRef, CodeExpression listener);
        public CodeRemoveEventStatement(CodeExpression targetObject, string eventName, CodeExpression listener);

        public CodeEventReferenceExpression Event { get; set; }
        public CodeExpression Listener { get; set; }
    }
}
