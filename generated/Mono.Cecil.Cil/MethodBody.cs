#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;

namespace Mono.Cecil.Cil
{
    public sealed class MethodBody
    {

        public MethodBody(MethodDefinition method);

        public MethodDefinition Method { get; }
        public int MaxStackSize { get; set; }
        public int CodeSize { get; }
        public bool InitLocals { get; set; }
        public MetadataToken LocalVarToken { get; set; }
        public Collection<Instruction> Instructions { get; }
        public bool HasExceptionHandlers { get; }
        public Collection<ExceptionHandler> ExceptionHandlers { get; }
        public bool HasVariables { get; }
        public Collection<VariableDefinition> Variables { get; }
        public ScopeDebugInformation Scope { get; set; }
        public ParameterDefinition ThisParameter { get; }

        public ILProcessor GetILProcessor();
        public bool GetInstructionToken(Instruction instruction, out MetadataToken token);
    }
}
