#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using System.IO;

namespace Mono.Cecil
{
    public sealed class EmbeddedResource : Resource
    {
        public EmbeddedResource(string name, ManifestResourceAttributes attributes, byte[] data);
        public EmbeddedResource(string name, ManifestResourceAttributes attributes, Stream stream);

        public override ResourceType ResourceType { get; }

        public Stream GetResourceStream();
        public byte[] GetResourceData();
    }
}
