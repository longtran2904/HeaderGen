#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

namespace Mono.Cecil
{
    public sealed class LinkedResource : Resource
    {
        public LinkedResource(string name, ManifestResourceAttributes flags);
        public LinkedResource(string name, ManifestResourceAttributes flags, string file);

        public byte[] Hash { get; }
        public string File { get; set; }
        public override ResourceType ResourceType { get; }
    }
}
