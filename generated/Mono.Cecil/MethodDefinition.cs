#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Cecil.Cil;
using Mono.Collections.Generic;

namespace Mono.Cecil
{
    public sealed class MethodDefinition : MethodReference, ICustomAttributeProvider, ICustomDebugInformationProvider, IMemberDefinition, ISecurityDeclarationProvider
    {

        public MethodDefinition(string name, MethodAttributes attributes, TypeReference returnType);

        public override string Name { get; set; }
        public MethodAttributes Attributes { get; set; }
        public MethodImplAttributes ImplAttributes { get; set; }
        public MethodSemanticsAttributes SemanticsAttributes { get; set; }
        public bool HasSecurityDeclarations { get; }
        public Collection<SecurityDeclaration> SecurityDeclarations { get; }
        public bool HasCustomAttributes { get; }
        public Collection<CustomAttribute> CustomAttributes { get; }
        public int RVA { get; }
        public bool HasBody { get; }
        public MethodBody Body { get; set; }
        public MethodDebugInformation DebugInformation { get; }
        public bool HasPInvokeInfo { get; }
        public PInvokeInfo PInvokeInfo { get; set; }
        public bool HasOverrides { get; }
        public Collection<MethodReference> Overrides { get; }
        public override bool HasGenericParameters { get; }
        public override Collection<GenericParameter> GenericParameters { get; }
        public bool HasCustomDebugInformations { get; }
        public Collection<CustomDebugInformation> CustomDebugInformations { get; }
        public bool IsCompilerControlled { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsFamilyAndAssembly { get; set; }
        public bool IsAssembly { get; set; }
        public bool IsFamily { get; set; }
        public bool IsFamilyOrAssembly { get; set; }
        public bool IsPublic { get; set; }
        public bool IsStatic { get; set; }
        public bool IsFinal { get; set; }
        public bool IsVirtual { get; set; }
        public bool IsHideBySig { get; set; }
        public bool IsReuseSlot { get; set; }
        public bool IsNewSlot { get; set; }
        public bool IsCheckAccessOnOverride { get; set; }
        public bool IsAbstract { get; set; }
        public bool IsSpecialName { get; set; }
        public bool IsPInvokeImpl { get; set; }
        public bool IsUnmanagedExport { get; set; }
        public bool IsRuntimeSpecialName { get; set; }
        public bool HasSecurity { get; set; }
        public bool IsIL { get; set; }
        public bool IsNative { get; set; }
        public bool IsRuntime { get; set; }
        public bool IsUnmanaged { get; set; }
        public bool IsManaged { get; set; }
        public bool IsForwardRef { get; set; }
        public bool IsPreserveSig { get; set; }
        public bool IsInternalCall { get; set; }
        public bool IsSynchronized { get; set; }
        public bool NoInlining { get; set; }
        public bool NoOptimization { get; set; }
        public bool AggressiveInlining { get; set; }
        public bool IsSetter { get; set; }
        public bool IsGetter { get; set; }
        public bool IsOther { get; set; }
        public bool IsAddOn { get; set; }
        public bool IsRemoveOn { get; set; }
        public bool IsFire { get; set; }
        public TypeDefinition DeclaringType { get; set; }
        public bool IsConstructor { get; }
        public override bool IsDefinition { get; }

        public override MethodDefinition Resolve();
    }
}
