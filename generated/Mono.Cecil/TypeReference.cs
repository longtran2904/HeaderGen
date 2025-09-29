#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;

namespace Mono.Cecil
{
    public class TypeReference : MemberReference, IGenericContext, IGenericParameterProvider
    {

        protected Collection<GenericParameter> generic_parameters;

        protected TypeReference(string namespace, string name);
        public TypeReference(string namespace, string name, ModuleDefinition module, IMetadataScope scope);
        public TypeReference(string namespace, string name, ModuleDefinition module, IMetadataScope scope, bool valueType);

        public override string Name { get; set; }
        public virtual string Namespace { get; set; }
        public virtual bool IsValueType { get; set; }
        public override ModuleDefinition Module { get; }
        public virtual bool HasGenericParameters { get; }
        public virtual Collection<GenericParameter> GenericParameters { get; }
        public virtual IMetadataScope Scope { get; set; }
        public bool IsNested { get; }
        public override TypeReference DeclaringType { get; set; }
        public override string FullName { get; }
        public virtual bool IsByReference { get; }
        public virtual bool IsPointer { get; }
        public virtual bool IsSentinel { get; }
        public virtual bool IsArray { get; }
        public virtual bool IsGenericParameter { get; }
        public virtual bool IsGenericInstance { get; }
        public virtual bool IsRequiredModifier { get; }
        public virtual bool IsOptionalModifier { get; }
        public virtual bool IsPinned { get; }
        public virtual bool IsFunctionPointer { get; }
        public virtual bool IsPrimitive { get; }
        public virtual MetadataType MetadataType { get; }

        protected virtual void ClearFullName();
        public virtual TypeReference GetElementType();
        protected override IMemberDefinition ResolveDefinition();
        public virtual TypeDefinition Resolve();
    }
}
