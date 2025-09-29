#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;
using System;
using System.IO;

namespace Mono.Cecil
{
    public sealed class AssemblyDefinition : ICustomAttributeProvider, IDisposable, IMetadataTokenProvider, ISecurityDeclarationProvider
    {

        public AssemblyNameDefinition Name { get; set; }
        public string FullName { get; }
        public MetadataToken MetadataToken { get; set; }
        public Collection<ModuleDefinition> Modules { get; }
        public ModuleDefinition MainModule { get; }
        public MethodDefinition EntryPoint { get; set; }
        public bool HasCustomAttributes { get; }
        public Collection<CustomAttribute> CustomAttributes { get; }
        public bool HasSecurityDeclarations { get; }
        public Collection<SecurityDeclaration> SecurityDeclarations { get; }

        public void Dispose();
        public static AssemblyDefinition CreateAssembly(AssemblyNameDefinition assemblyName, string moduleName, ModuleKind kind);
        public static AssemblyDefinition CreateAssembly(AssemblyNameDefinition assemblyName, string moduleName, ModuleParameters parameters);
        public static AssemblyDefinition ReadAssembly(string fileName);
        public static AssemblyDefinition ReadAssembly(string fileName, ReaderParameters parameters);
        public static AssemblyDefinition ReadAssembly(Stream stream);
        public static AssemblyDefinition ReadAssembly(Stream stream, ReaderParameters parameters);
        public void Write(string fileName);
        public void Write(string fileName, WriterParameters parameters);
        public void Write();
        public void Write(WriterParameters parameters);
        public void Write(Stream stream);
        public void Write(Stream stream, WriterParameters parameters);
        public override string ToString();
    }
}
