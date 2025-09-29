#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;

namespace Mono.Cecil
{
    public interface IMethodSignature : IMetadataTokenProvider
    {

        bool HasThis { get; set; }
        bool ExplicitThis { get; set; }
        MethodCallingConvention CallingConvention { get; set; }
        bool HasParameters { get; }
        Collection<ParameterDefinition> Parameters { get; }
        TypeReference ReturnType { get; set; }
        MethodReturnType MethodReturnType { get; }
    }
}
