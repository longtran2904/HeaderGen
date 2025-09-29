#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

namespace Mono.Cecil.Cil
{
    public sealed class Instruction
    {

        public int Offset { get; set; }
        public OpCode OpCode { get; set; }
        public object Operand { get; set; }
        public Instruction Previous { get; set; }
        public Instruction Next { get; set; }

        public int GetSize();
        public override string ToString();
        public static Instruction Create(OpCode opcode);
        public static Instruction Create(OpCode opcode, TypeReference type);
        public static Instruction Create(OpCode opcode, CallSite site);
        public static Instruction Create(OpCode opcode, MethodReference method);
        public static Instruction Create(OpCode opcode, FieldReference field);
        public static Instruction Create(OpCode opcode, string value);
        public static Instruction Create(OpCode opcode, sbyte value);
        public static Instruction Create(OpCode opcode, byte value);
        public static Instruction Create(OpCode opcode, int value);
        public static Instruction Create(OpCode opcode, long value);
        public static Instruction Create(OpCode opcode, float value);
        public static Instruction Create(OpCode opcode, double value);
        public static Instruction Create(OpCode opcode, Instruction target);
        public static Instruction Create(OpCode opcode, Instruction[] targets);
        public static Instruction Create(OpCode opcode, VariableDefinition variable);
        public static Instruction Create(OpCode opcode, ParameterDefinition parameter);
    }
}
