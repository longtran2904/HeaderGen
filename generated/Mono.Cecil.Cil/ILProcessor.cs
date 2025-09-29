#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

namespace Mono.Cecil.Cil
{
    public sealed class ILProcessor
    {
        public MethodBody Body { get; }

        public Instruction Create(OpCode opcode);
        public Instruction Create(OpCode opcode, TypeReference type);
        public Instruction Create(OpCode opcode, CallSite site);
        public Instruction Create(OpCode opcode, MethodReference method);
        public Instruction Create(OpCode opcode, FieldReference field);
        public Instruction Create(OpCode opcode, string value);
        public Instruction Create(OpCode opcode, sbyte value);
        public Instruction Create(OpCode opcode, byte value);
        public Instruction Create(OpCode opcode, int value);
        public Instruction Create(OpCode opcode, long value);
        public Instruction Create(OpCode opcode, float value);
        public Instruction Create(OpCode opcode, double value);
        public Instruction Create(OpCode opcode, Instruction target);
        public Instruction Create(OpCode opcode, Instruction[] targets);
        public Instruction Create(OpCode opcode, VariableDefinition variable);
        public Instruction Create(OpCode opcode, ParameterDefinition parameter);
        public void Emit(OpCode opcode);
        public void Emit(OpCode opcode, TypeReference type);
        public void Emit(OpCode opcode, MethodReference method);
        public void Emit(OpCode opcode, CallSite site);
        public void Emit(OpCode opcode, FieldReference field);
        public void Emit(OpCode opcode, string value);
        public void Emit(OpCode opcode, byte value);
        public void Emit(OpCode opcode, sbyte value);
        public void Emit(OpCode opcode, int value);
        public void Emit(OpCode opcode, long value);
        public void Emit(OpCode opcode, float value);
        public void Emit(OpCode opcode, double value);
        public void Emit(OpCode opcode, Instruction target);
        public void Emit(OpCode opcode, Instruction[] targets);
        public void Emit(OpCode opcode, VariableDefinition variable);
        public void Emit(OpCode opcode, ParameterDefinition parameter);
        public void InsertBefore(Instruction target, Instruction instruction);
        public void InsertAfter(Instruction target, Instruction instruction);
        public void InsertAfter(int index, Instruction instruction);
        public void Append(Instruction instruction);
        public void Replace(Instruction target, Instruction instruction);
        public void Replace(int index, Instruction instruction);
        public void Remove(Instruction instruction);
        public void RemoveAt(int index);
    }
}
