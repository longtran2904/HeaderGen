#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;

namespace Mono.Cecil
{
    public abstract class MethodSpecification : MethodReference
    {
        public MethodReference ElementMethod { get; }
        public override string Name { get; set; }
        public override MethodCallingConvention CallingConvention { get; set; }
        public override bool HasThis { get; set; }
        public override bool ExplicitThis { get; set; }
        public override MethodReturnType MethodReturnType { get; set; }
        public override TypeReference DeclaringType { get; set; }
        public override ModuleDefinition Module { get; }
        public override bool HasParameters { get; }
        public override Collection<ParameterDefinition> Parameters { get; }
        public override bool ContainsGenericParameter { get; }

        public sealed override MethodReference GetElementMethod();
    }
}
