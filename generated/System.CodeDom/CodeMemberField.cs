#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeMemberField : CodeTypeMember
    {
        public CodeMemberField();
        public CodeMemberField(CodeTypeReference type, string name);
        public CodeMemberField(string type, string name);
        public CodeMemberField(Type type, string name);

        public CodeTypeReference Type { get; set; }
        public CodeExpression InitExpression { get; set; }
    }
}
