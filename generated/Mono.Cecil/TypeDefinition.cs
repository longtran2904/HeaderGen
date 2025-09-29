#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;

namespace Mono.Cecil
{
    public sealed class TypeDefinition : TypeReference, ICustomAttributeProvider, IMemberDefinition, ISecurityDeclarationProvider
    {
        public TypeDefinition(string namespace, string name, TypeAttributes attributes);
        public TypeDefinition(string namespace, string name, TypeAttributes attributes, TypeReference baseType);

        public TypeAttributes Attributes { get; set; }
        public TypeReference BaseType { get; set; }
        public override string Name { get; set; }
        public bool HasLayoutInfo { get; }
        public short PackingSize { get; set; }
        public int ClassSize { get; set; }
        public bool HasInterfaces { get; }
        public Collection<InterfaceImplementation> Interfaces { get; }
        public bool HasNestedTypes { get; }
        public Collection<TypeDefinition> NestedTypes { get; }
        public bool HasMethods { get; }
        public Collection<MethodDefinition> Methods { get; }
        public bool HasFields { get; }
        public Collection<FieldDefinition> Fields { get; }
        public bool HasEvents { get; }
        public Collection<EventDefinition> Events { get; }
        public bool HasProperties { get; }
        public Collection<PropertyDefinition> Properties { get; }
        public bool HasSecurityDeclarations { get; }
        public Collection<SecurityDeclaration> SecurityDeclarations { get; }
        public bool HasCustomAttributes { get; }
        public Collection<CustomAttribute> CustomAttributes { get; }
        public override bool HasGenericParameters { get; }
        public override Collection<GenericParameter> GenericParameters { get; }
        public bool IsNotPublic { get; set; }
        public bool IsPublic { get; set; }
        public bool IsNestedPublic { get; set; }
        public bool IsNestedPrivate { get; set; }
        public bool IsNestedFamily { get; set; }
        public bool IsNestedAssembly { get; set; }
        public bool IsNestedFamilyAndAssembly { get; set; }
        public bool IsNestedFamilyOrAssembly { get; set; }
        public bool IsAutoLayout { get; set; }
        public bool IsSequentialLayout { get; set; }
        public bool IsExplicitLayout { get; set; }
        public bool IsClass { get; set; }
        public bool IsInterface { get; set; }
        public bool IsAbstract { get; set; }
        public bool IsSealed { get; set; }
        public bool IsSpecialName { get; set; }
        public bool IsImport { get; set; }
        public bool IsSerializable { get; set; }
        public bool IsWindowsRuntime { get; set; }
        public bool IsAnsiClass { get; set; }
        public bool IsUnicodeClass { get; set; }
        public bool IsAutoClass { get; set; }
        public bool IsBeforeFieldInit { get; set; }
        public bool IsRuntimeSpecialName { get; set; }
        public bool HasSecurity { get; set; }
        public bool IsEnum { get; }
        public override bool IsValueType { get; }
        public override bool IsPrimitive { get; }
        public override MetadataType MetadataType { get; }
        public override bool IsDefinition { get; }
        public TypeDefinition DeclaringType { get; set; }

        protected override void ClearFullName();
        public override TypeDefinition Resolve();
    }
}
