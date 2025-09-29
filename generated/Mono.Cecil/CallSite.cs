#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;

namespace Mono.Cecil
{
    public sealed class CallSite : IMetadataTokenProvider, IMethodSignature
    {
        public CallSite(TypeReference returnType);

        public bool HasThis { get; set; }
        public bool ExplicitThis { get; set; }
        public MethodCallingConvention CallingConvention { get; set; }
        public bool HasParameters { get; }
        public Collection<ParameterDefinition> Parameters { get; }
        public TypeReference ReturnType { get; set; }
        public MethodReturnType MethodReturnType { get; }
        public string Name { get; set; }
        public string Namespace { get; set; }
        public ModuleDefinition Module { get; }
        public IMetadataScope Scope { get; }
        public MetadataToken MetadataToken { get; set; }
        public string FullName { get; }

        public override string ToString();
    }
}
