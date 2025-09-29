#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

namespace Mono.Cecil
{
    public abstract class TypeSpecification : TypeReference
    {
        public TypeReference ElementType { get; }
        public override string Name { get; set; }
        public override string Namespace { get; set; }
        public override IMetadataScope Scope { get; set; }
        public override ModuleDefinition Module { get; }
        public override string FullName { get; }
        public override bool ContainsGenericParameter { get; }
        public override MetadataType MetadataType { get; }

        public override TypeReference GetElementType();
    }
}
