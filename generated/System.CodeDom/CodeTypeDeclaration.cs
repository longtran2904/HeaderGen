#region System.CodeDom, Version=7.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
// D:\Programs\2021.3.36f1\Editor\Data\Resources\Licensing\Client\System.CodeDom.dll
#endregion

using System.Reflection;

namespace System.CodeDom
{
    public class CodeTypeDeclaration : CodeTypeMember
    {
        public CodeTypeDeclaration();
        public CodeTypeDeclaration(string name);

        public TypeAttributes TypeAttributes { get; set; }
        public CodeTypeReferenceCollection BaseTypes { get; }
        public bool IsClass { get; set; }
        public bool IsStruct { get; set; }
        public bool IsEnum { get; set; }
        public bool IsInterface { get; set; }
        public bool IsPartial { get; set; }
        public CodeTypeMemberCollection Members { get; }
        public CodeTypeParameterCollection TypeParameters { get; }

        public event EventHandler PopulateBaseTypes;
        public event EventHandler PopulateMembers;
    }
}
