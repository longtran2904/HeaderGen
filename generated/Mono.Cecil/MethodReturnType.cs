#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;

namespace Mono.Cecil
{
    public sealed class MethodReturnType : IConstantProvider, ICustomAttributeProvider, IMarshalInfoProvider, IMetadataTokenProvider
    {
        public MethodReturnType(IMethodSignature method);

        public IMethodSignature Method { get; }
        public TypeReference ReturnType { get; set; }
        public MetadataToken MetadataToken { get; set; }
        public ParameterAttributes Attributes { get; set; }
        public string Name { get; set; }
        public bool HasCustomAttributes { get; }
        public Collection<CustomAttribute> CustomAttributes { get; }
        public bool HasDefault { get; set; }
        public bool HasConstant { get; set; }
        public object Constant { get; set; }
        public bool HasFieldMarshal { get; set; }
        public bool HasMarshalInfo { get; }
        public MarshalInfo MarshalInfo { get; set; }
    }
}
