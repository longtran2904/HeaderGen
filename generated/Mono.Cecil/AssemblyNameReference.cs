#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using System;

namespace Mono.Cecil
{
    public class AssemblyNameReference : IMetadataScope, IMetadataTokenProvider
    {
        public AssemblyNameReference(string name, Version version);

        public string Name { get; set; }
        public string Culture { get; set; }
        public Version Version { get; set; }
        public AssemblyAttributes Attributes { get; set; }
        public bool HasPublicKey { get; set; }
        public bool IsSideBySideCompatible { get; set; }
        public bool IsRetargetable { get; set; }
        public bool IsWindowsRuntime { get; set; }
        public byte[] PublicKey { get; set; }
        public byte[] PublicKeyToken { get; set; }
        public virtual MetadataScopeType MetadataScopeType { get; }
        public string FullName { get; }
        public AssemblyHashAlgorithm HashAlgorithm { get; set; }
        public virtual byte[] Hash { get; set; }
        public MetadataToken MetadataToken { get; set; }

        public static AssemblyNameReference Parse(string fullName);
        public override string ToString();
    }
}
