#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;

namespace Mono.Cecil
{
    public class MethodReference : MemberReference, IGenericContext, IGenericParameterProvider, IMethodSignature
    {
        public MethodReference(string name, TypeReference returnType);
        public MethodReference(string name, TypeReference returnType, TypeReference declaringType);

        public virtual bool HasThis { get; set; }
        public virtual bool ExplicitThis { get; set; }
        public virtual MethodCallingConvention CallingConvention { get; set; }
        public virtual bool HasParameters { get; }
        public virtual Collection<ParameterDefinition> Parameters { get; }
        public virtual bool HasGenericParameters { get; }
        public virtual Collection<GenericParameter> GenericParameters { get; }
        public TypeReference ReturnType { get; set; }
        public virtual MethodReturnType MethodReturnType { get; set; }
        public override string FullName { get; }
        public virtual bool IsGenericInstance { get; }
        public override bool ContainsGenericParameter { get; }

        public virtual MethodReference GetElementMethod();
        protected override IMemberDefinition ResolveDefinition();
        public virtual MethodDefinition Resolve();
    }
}
