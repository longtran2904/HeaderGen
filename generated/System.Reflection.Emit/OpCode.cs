#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection.Emit
{
    public readonly struct OpCode : IEquatable<OpCode>
    {

        public OperandType OperandType { get; }
        public FlowControl FlowControl { get; }
        public OpCodeType OpCodeType { get; }
        public StackBehaviour StackBehaviourPop { get; }
        public StackBehaviour StackBehaviourPush { get; }
        public int Size { get; }
        public short Value { get; }
        public string Name { get; }

        public override bool Equals(object obj);
        public bool Equals(OpCode obj);
        public override int GetHashCode();
        public override string ToString();

        public static bool operator ==(OpCode a, OpCode b);
        public static bool operator !=(OpCode a, OpCode b);
    }
}
