#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeTypeReferenceExpression : CodeExpression
    {

        public CodeTypeReferenceExpression();
        public CodeTypeReferenceExpression(CodeTypeReference type);
        public CodeTypeReferenceExpression(string type);
        public CodeTypeReferenceExpression(Type type);

        public CodeTypeReference Type { get; set; }
    }
}
