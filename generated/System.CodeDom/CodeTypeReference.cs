#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

namespace System.CodeDom
{
    public class CodeTypeReference : CodeObject
    {
        public CodeTypeReference();
        public CodeTypeReference(Type type);
        public CodeTypeReference(Type type, CodeTypeReferenceOptions codeTypeReferenceOption);
        public CodeTypeReference(string typeName, CodeTypeReferenceOptions codeTypeReferenceOption);
        public CodeTypeReference(string typeName);
        public CodeTypeReference(string typeName, params CodeTypeReference[] typeArguments);
        public CodeTypeReference(CodeTypeParameter typeParameter);
        public CodeTypeReference(string baseType, int rank);
        public CodeTypeReference(CodeTypeReference arrayType, int rank);

        public CodeTypeReference ArrayElementType { get; set; }
        public int ArrayRank { get; set; }
        public string BaseType { get; set; }
        public CodeTypeReferenceOptions Options { get; set; }
        public CodeTypeReferenceCollection TypeArguments { get; }
    }
}
