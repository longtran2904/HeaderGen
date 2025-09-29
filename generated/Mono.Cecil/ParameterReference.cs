#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

namespace Mono.Cecil
{
    public abstract class ParameterReference : IMetadataTokenProvider
    {

        protected TypeReference parameter_type;

        public string Name { get; set; }
        public int Index { get; }
        public TypeReference ParameterType { get; set; }
        public MetadataToken MetadataToken { get; set; }

        public override string ToString();
        public abstract ParameterDefinition Resolve();
    }
}
