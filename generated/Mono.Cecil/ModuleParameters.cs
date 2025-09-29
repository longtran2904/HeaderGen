#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

namespace Mono.Cecil
{
    public sealed class ModuleParameters
    {
        public ModuleParameters();

        public ModuleKind Kind { get; set; }
        public TargetRuntime Runtime { get; set; }
        public uint? Timestamp { get; set; }
        public TargetArchitecture Architecture { get; set; }
        public IAssemblyResolver AssemblyResolver { get; set; }
        public IMetadataResolver MetadataResolver { get; set; }
        public IMetadataImporterProvider MetadataImporterProvider { get; set; }
        public IReflectionImporterProvider ReflectionImporterProvider { get; set; }
    }
}
