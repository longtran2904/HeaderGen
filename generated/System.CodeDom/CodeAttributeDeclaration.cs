#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeAttributeDeclaration
    {

        public CodeAttributeDeclaration();
        public CodeAttributeDeclaration(string name);
        public CodeAttributeDeclaration(string name, params CodeAttributeArgument[] arguments);
        public CodeAttributeDeclaration(CodeTypeReference attributeType);
        public CodeAttributeDeclaration(CodeTypeReference attributeType, params CodeAttributeArgument[] arguments);

        public string Name { get; set; }
        public CodeAttributeArgumentCollection Arguments { get; }
        public CodeTypeReference AttributeType { get; }
    }
}
