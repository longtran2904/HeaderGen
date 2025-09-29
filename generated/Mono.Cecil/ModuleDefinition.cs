#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Cecil.Cil;
using Mono.Collections.Generic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Mono.Cecil
{
    public sealed class ModuleDefinition : ModuleReference, ICustomAttributeProvider, ICustomDebugInformationProvider, IDisposable
    {
        public bool IsMain { get; }
        public ModuleKind Kind { get; set; }
        public MetadataKind MetadataKind { get; set; }
        public TargetRuntime Runtime { get; set; }
        public string RuntimeVersion { get; set; }
        public TargetArchitecture Architecture { get; set; }
        public ModuleAttributes Attributes { get; set; }
        public ModuleCharacteristics Characteristics { get; set; }
        [Obsolete("Use FileName")]
        public string FullyQualifiedName { get; }
        public string FileName { get; }
        public Guid Mvid { get; set; }
        public bool HasSymbols { get; }
        public ISymbolReader SymbolReader { get; }
        public override MetadataScopeType MetadataScopeType { get; }
        public AssemblyDefinition Assembly { get; }
        public IAssemblyResolver AssemblyResolver { get; }
        public IMetadataResolver MetadataResolver { get; }
        public TypeSystem TypeSystem { get; }
        public bool HasAssemblyReferences { get; }
        public Collection<AssemblyNameReference> AssemblyReferences { get; }
        public bool HasModuleReferences { get; }
        public Collection<ModuleReference> ModuleReferences { get; }
        public bool HasResources { get; }
        public Collection<Resource> Resources { get; }
        public bool HasCustomAttributes { get; }
        public Collection<CustomAttribute> CustomAttributes { get; }
        public bool HasTypes { get; }
        public Collection<TypeDefinition> Types { get; }
        public bool HasExportedTypes { get; }
        public Collection<ExportedType> ExportedTypes { get; }
        public MethodDefinition EntryPoint { get; set; }
        public bool HasCustomDebugInformations { get; }
        public Collection<CustomDebugInformation> CustomDebugInformations { get; }
        public bool HasDebugHeader { get; }

        public void Dispose();
        public bool HasTypeReference(string fullName);
        public bool HasTypeReference(string scope, string fullName);
        public bool TryGetTypeReference(string fullName, out TypeReference type);
        public bool TryGetTypeReference(string scope, string fullName, out TypeReference type);
        public IEnumerable<TypeReference> GetTypeReferences();
        public IEnumerable<MemberReference> GetMemberReferences();
        public IEnumerable<CustomAttribute> GetCustomAttributes();
        public TypeReference GetType(string fullName, bool runtimeName);
        public TypeDefinition GetType(string fullName);
        public TypeDefinition GetType(string namespace, string name);
        public IEnumerable<TypeDefinition> GetTypes();
        [Obsolete("Use ImportReference", False)]
        public TypeReference Import(Type type);
        public TypeReference ImportReference(Type type);
        [Obsolete("Use ImportReference", False)]
        public TypeReference Import(Type type, IGenericParameterProvider context);
        public TypeReference ImportReference(Type type, IGenericParameterProvider context);
        [Obsolete("Use ImportReference", False)]
        public FieldReference Import(FieldInfo field);
        [Obsolete("Use ImportReference", False)]
        public FieldReference Import(FieldInfo field, IGenericParameterProvider context);
        public FieldReference ImportReference(FieldInfo field);
        public FieldReference ImportReference(FieldInfo field, IGenericParameterProvider context);
        [Obsolete("Use ImportReference", False)]
        public MethodReference Import(MethodBase method);
        [Obsolete("Use ImportReference", False)]
        public MethodReference Import(MethodBase method, IGenericParameterProvider context);
        public MethodReference ImportReference(MethodBase method);
        public MethodReference ImportReference(MethodBase method, IGenericParameterProvider context);
        [Obsolete("Use ImportReference", False)]
        public TypeReference Import(TypeReference type);
        [Obsolete("Use ImportReference", False)]
        public TypeReference Import(TypeReference type, IGenericParameterProvider context);
        public TypeReference ImportReference(TypeReference type);
        public TypeReference ImportReference(TypeReference type, IGenericParameterProvider context);
        [Obsolete("Use ImportReference", False)]
        public FieldReference Import(FieldReference field);
        [Obsolete("Use ImportReference", False)]
        public FieldReference Import(FieldReference field, IGenericParameterProvider context);
        public FieldReference ImportReference(FieldReference field);
        public FieldReference ImportReference(FieldReference field, IGenericParameterProvider context);
        [Obsolete("Use ImportReference", False)]
        public MethodReference Import(MethodReference method);
        [Obsolete("Use ImportReference", False)]
        public MethodReference Import(MethodReference method, IGenericParameterProvider context);
        public MethodReference ImportReference(MethodReference method);
        public MethodReference ImportReference(MethodReference method, IGenericParameterProvider context);
        public IMetadataTokenProvider LookupToken(int token);
        public IMetadataTokenProvider LookupToken(MetadataToken token);
        public ImageDebugHeader GetDebugHeader();
        public static ModuleDefinition CreateModule(string name, ModuleKind kind);
        public static ModuleDefinition CreateModule(string name, ModuleParameters parameters);
        public void ReadSymbols();
        public void ReadSymbols(ISymbolReader reader);
        public static ModuleDefinition ReadModule(string fileName);
        public static ModuleDefinition ReadModule(string fileName, ReaderParameters parameters);
        public static ModuleDefinition ReadModule(Stream stream);
        public static ModuleDefinition ReadModule(Stream stream, ReaderParameters parameters);
        public void Write(string fileName);
        public void Write(string fileName, WriterParameters parameters);
        public void Write();
        public void Write(WriterParameters parameters);
        public void Write(Stream stream);
        public void Write(Stream stream, WriterParameters parameters);
    }
}
