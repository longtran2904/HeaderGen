#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;

namespace Mono.Cecil
{
    public sealed class ParameterDefinition : ParameterReference, IConstantProvider, ICustomAttributeProvider, IMarshalInfoProvider
    {
        public ParameterDefinition(TypeReference parameterType);
        public ParameterDefinition(string name, ParameterAttributes attributes, TypeReference parameterType);

        public ParameterAttributes Attributes { get; set; }
        public IMethodSignature Method { get; }
        public int Sequence { get; }
        public bool HasConstant { get; set; }
        public object Constant { get; set; }
        public bool HasCustomAttributes { get; }
        public Collection<CustomAttribute> CustomAttributes { get; }
        public bool HasMarshalInfo { get; }
        public MarshalInfo MarshalInfo { get; set; }
        public bool IsIn { get; set; }
        public bool IsOut { get; set; }
        public bool IsLcid { get; set; }
        public bool IsReturnValue { get; set; }
        public bool IsOptional { get; set; }
        public bool HasDefault { get; set; }
        public bool HasFieldMarshal { get; set; }

        public override ParameterDefinition Resolve();
    }
}
