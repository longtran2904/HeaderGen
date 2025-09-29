#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using Mono.Collections.Generic;
using System;

namespace Mono.Cecil.Cil
{
    public sealed class AsyncMethodBodyDebugInformation : CustomDebugInformation
    {

        public static Guid KindIdentifier;

        public AsyncMethodBodyDebugInformation(Instruction catchHandler);
        public AsyncMethodBodyDebugInformation();

        public InstructionOffset CatchHandler { get; set; }
        public Collection<InstructionOffset> Yields { get; }
        public Collection<InstructionOffset> Resumes { get; }
        public MethodDefinition MoveNextMethod { get; set; }
        public override CustomDebugInformationKind Kind { get; }
    }
}
