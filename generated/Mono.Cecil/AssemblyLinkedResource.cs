#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

namespace Mono.Cecil
{
    public sealed class AssemblyLinkedResource : Resource
    {
        public AssemblyLinkedResource(string name, ManifestResourceAttributes flags);
        public AssemblyLinkedResource(string name, ManifestResourceAttributes flags, AssemblyNameReference reference);

        public AssemblyNameReference Assembly { get; set; }
        public override ResourceType ResourceType { get; }
    }
}
