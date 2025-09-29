#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;

namespace Mono.Cecil
{
    public sealed class InterfaceImplementation : ICustomAttributeProvider, IMetadataTokenProvider
    {

        public InterfaceImplementation(TypeReference interfaceType);

        public TypeReference InterfaceType { get; set; }
        public bool HasCustomAttributes { get; }
        public Collection<CustomAttribute> CustomAttributes { get; }
        public MetadataToken MetadataToken { get; set; }
    }
}
