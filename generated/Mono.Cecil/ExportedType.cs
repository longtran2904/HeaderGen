#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

namespace Mono.Cecil
{
    public sealed class ExportedType : IMetadataTokenProvider
    {
        public ExportedType(string namespace, string name, ModuleDefinition module, IMetadataScope scope);

        public string Namespace { get; set; }
        public string Name { get; set; }
        public TypeAttributes Attributes { get; set; }
        public IMetadataScope Scope { get; set; }
        public ExportedType DeclaringType { get; set; }
        public MetadataToken MetadataToken { get; set; }
        public int Identifier { get; set; }
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
        public bool IsAnsiClass { get; set; }
        public bool IsUnicodeClass { get; set; }
        public bool IsAutoClass { get; set; }
        public bool IsBeforeFieldInit { get; set; }
        public bool IsRuntimeSpecialName { get; set; }
        public bool HasSecurity { get; set; }
        public bool IsForwarder { get; set; }
        public string FullName { get; }

        public override string ToString();
        public TypeDefinition Resolve();
    }
}
