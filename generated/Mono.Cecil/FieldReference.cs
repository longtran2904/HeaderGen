#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

namespace Mono.Cecil
{
    public class FieldReference : MemberReference
    {
        public FieldReference(string name, TypeReference fieldType);
        public FieldReference(string name, TypeReference fieldType, TypeReference declaringType);

        public TypeReference FieldType { get; set; }
        public override string FullName { get; }
        public override bool ContainsGenericParameter { get; }

        protected override IMemberDefinition ResolveDefinition();
        public virtual FieldDefinition Resolve();
    }
}
