#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;

namespace Mono.Cecil.Cil
{
    public sealed class ScopeDebugInformation : DebugInformation
    {
        public ScopeDebugInformation(Instruction start, Instruction end);

        public InstructionOffset Start { get; set; }
        public InstructionOffset End { get; set; }
        public ImportDebugInformation Import { get; set; }
        public bool HasScopes { get; }
        public Collection<ScopeDebugInformation> Scopes { get; }
        public bool HasVariables { get; }
        public Collection<VariableDebugInformation> Variables { get; }
        public bool HasConstants { get; }
        public Collection<ConstantDebugInformation> Constants { get; }

        public bool TryGetName(VariableDefinition variable, out string name);
    }
}
