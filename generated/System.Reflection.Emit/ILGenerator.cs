#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
    public abstract class ILGenerator
    {
        protected ILGenerator();

        public abstract int ILOffset { get; }

        public abstract void Emit(OpCode opcode);
        public abstract void Emit(OpCode opcode, byte arg);
        public abstract void Emit(OpCode opcode, short arg);
        public abstract void Emit(OpCode opcode, long arg);
        public abstract void Emit(OpCode opcode, float arg);
        public abstract void Emit(OpCode opcode, double arg);
        public abstract void Emit(OpCode opcode, int arg);
        public abstract void Emit(OpCode opcode, MethodInfo meth);
        public abstract void EmitCalli(OpCode opcode, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Type[] optionalParameterTypes);
        public abstract void EmitCalli(OpCode opcode, CallingConvention unmanagedCallConv, Type returnType, Type[] parameterTypes);
        public abstract void EmitCall(OpCode opcode, MethodInfo methodInfo, Type[] optionalParameterTypes);
        public abstract void Emit(OpCode opcode, SignatureHelper signature);
        public abstract void Emit(OpCode opcode, ConstructorInfo con);
        public abstract void Emit(OpCode opcode, Type cls);
        public abstract void Emit(OpCode opcode, Label label);
        public abstract void Emit(OpCode opcode, Label[] labels);
        public abstract void Emit(OpCode opcode, FieldInfo field);
        public abstract void Emit(OpCode opcode, string str);
        public abstract void Emit(OpCode opcode, LocalBuilder local);
        public abstract Label BeginExceptionBlock();
        public abstract void EndExceptionBlock();
        public abstract void BeginExceptFilterBlock();
        public abstract void BeginCatchBlock(Type exceptionType);
        public abstract void BeginFaultBlock();
        public abstract void BeginFinallyBlock();
        public abstract Label DefineLabel();
        public abstract void MarkLabel(Label loc);
        public virtual void ThrowException(Type excType);
        public virtual void EmitWriteLine(string value);
        public virtual void EmitWriteLine(LocalBuilder localBuilder);
        public virtual void EmitWriteLine(FieldInfo fld);
        public virtual LocalBuilder DeclareLocal(Type localType);
        public abstract LocalBuilder DeclareLocal(Type localType, bool pinned);
        public abstract void UsingNamespace(string usingNamespace);
        public abstract void BeginScope();
        public abstract void EndScope();
        [CLSCompliant(False)]
        public void Emit(OpCode opcode, sbyte arg);
    }
}
