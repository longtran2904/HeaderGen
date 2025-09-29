#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;
using System.Collections.Generic;

namespace Mono.Cecil.Cil
{
    public sealed class MethodDebugInformation : DebugInformation
    {
        public MethodDefinition Method { get; }
        public bool HasSequencePoints { get; }
        public Collection<SequencePoint> SequencePoints { get; }
        public ScopeDebugInformation Scope { get; set; }
        public MethodDefinition StateMachineKickOffMethod { get; set; }

        public SequencePoint GetSequencePoint(Instruction instruction);
        public IDictionary<Instruction, SequencePoint> GetSequencePointMapping();
        public IEnumerable<ScopeDebugInformation> GetScopes();
        public bool TryGetName(VariableDefinition variable, out string name);
    }
}
