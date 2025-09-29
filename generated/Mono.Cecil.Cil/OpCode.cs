#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using System;

namespace Mono.Cecil.Cil
{
    public struct OpCode : IEquatable<OpCode>
    {

        public string Name { get; }
        public int Size { get; }
        public byte Op1 { get; }
        public byte Op2 { get; }
        public short Value { get; }
        public Code Code { get; }
        public FlowControl FlowControl { get; }
        public OpCodeType OpCodeType { get; }
        public OperandType OperandType { get; }
        public StackBehaviour StackBehaviourPop { get; }
        public StackBehaviour StackBehaviourPush { get; }

        public override int GetHashCode();
        public override bool Equals(object obj);
        public bool Equals(OpCode opcode);
        public override string ToString();

        public static bool operator ==(OpCode one, OpCode other);
        public static bool operator !=(OpCode one, OpCode other);
    }
}
