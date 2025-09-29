#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;

namespace Mono.Cecil
{
    public sealed class GenericParameter : TypeReference, ICustomAttributeProvider
    {

        public GenericParameter(IGenericParameterProvider owner);
        public GenericParameter(string name, IGenericParameterProvider owner);

        public GenericParameterAttributes Attributes { get; set; }
        public int Position { get; }
        public GenericParameterType Type { get; }
        public IGenericParameterProvider Owner { get; }
        public bool HasConstraints { get; }
        public Collection<GenericParameterConstraint> Constraints { get; }
        public bool HasCustomAttributes { get; }
        public Collection<CustomAttribute> CustomAttributes { get; }
        public override IMetadataScope Scope { get; set; }
        public override TypeReference DeclaringType { get; set; }
        public MethodReference DeclaringMethod { get; }
        public override ModuleDefinition Module { get; }
        public override string Name { get; }
        public override string Namespace { get; set; }
        public override string FullName { get; }
        public override bool IsGenericParameter { get; }
        public override bool ContainsGenericParameter { get; }
        public override MetadataType MetadataType { get; }
        public bool IsNonVariant { get; set; }
        public bool IsCovariant { get; set; }
        public bool IsContravariant { get; set; }
        public bool HasReferenceTypeConstraint { get; set; }
        public bool HasNotNullableValueTypeConstraint { get; set; }
        public bool HasDefaultConstructorConstraint { get; set; }

        public override TypeDefinition Resolve();
    }
}
