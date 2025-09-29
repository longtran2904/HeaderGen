#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;

namespace Mono.Cecil
{
    public sealed class FunctionPointerType : TypeSpecification, IMethodSignature
    {

        public FunctionPointerType();

        public bool HasThis { get; set; }
        public bool ExplicitThis { get; set; }
        public MethodCallingConvention CallingConvention { get; set; }
        public bool HasParameters { get; }
        public Collection<ParameterDefinition> Parameters { get; }
        public TypeReference ReturnType { get; set; }
        public MethodReturnType MethodReturnType { get; }
        public override string Name { get; set; }
        public override string Namespace { get; set; }
        public override ModuleDefinition Module { get; }
        public override IMetadataScope Scope { get; set; }
        public override bool IsFunctionPointer { get; }
        public override bool ContainsGenericParameter { get; }
        public override string FullName { get; }

        public override TypeDefinition Resolve();
        public override TypeReference GetElementType();
    }
}
