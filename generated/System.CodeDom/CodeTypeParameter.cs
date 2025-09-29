#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeTypeParameter : CodeObject
    {
        public CodeTypeParameter();
        public CodeTypeParameter(string name);

        public string Name { get; set; }
        public CodeTypeReferenceCollection Constraints { get; }
        public CodeAttributeDeclarationCollection CustomAttributes { get; }
        public bool HasConstructorConstraint { get; set; }
    }
}
