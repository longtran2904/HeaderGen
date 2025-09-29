#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeAttributeArgument
    {
        public CodeAttributeArgument();
        public CodeAttributeArgument(CodeExpression value);
        public CodeAttributeArgument(string name, CodeExpression value);

        public string Name { get; set; }
        public CodeExpression Value { get; set; }
    }
}
