#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection.Emit
{
    public sealed class SignatureHelper
    {
        public static SignatureHelper GetMethodSigHelper(Module mod, Type returnType, Type[] parameterTypes);
        public static SignatureHelper GetMethodSigHelper(Module mod, CallingConventions callingConvention, Type returnType);
        public static SignatureHelper GetLocalVarSigHelper();
        public static SignatureHelper GetMethodSigHelper(CallingConventions callingConvention, Type returnType);
        public static SignatureHelper GetLocalVarSigHelper(Module mod);
        public static SignatureHelper GetFieldSigHelper(Module mod);
        public static SignatureHelper GetPropertySigHelper(Module mod, Type returnType, Type[] parameterTypes);
        public static SignatureHelper GetPropertySigHelper(Module mod, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[][] requiredParameterTypeCustomModifiers, Type[][] optionalParameterTypeCustomModifiers);
        public static SignatureHelper GetPropertySigHelper(Module mod, CallingConventions callingConvention, Type returnType, Type[] requiredReturnTypeCustomModifiers, Type[] optionalReturnTypeCustomModifiers, Type[] parameterTypes, Type[][] requiredParameterTypeCustomModifiers, Type[][] optionalParameterTypeCustomModifiers);
        public void AddArgument(Type clsArgument);
        public void AddArgument(Type argument, bool pinned);
        public void AddArguments(Type[] arguments, Type[][] requiredCustomModifiers, Type[][] optionalCustomModifiers);
        public void AddArgument(Type argument, Type[] requiredCustomModifiers, Type[] optionalCustomModifiers);
        public void AddSentinel();
        public override bool Equals(object obj);
        public override int GetHashCode();
        public byte[] GetSignature();
        public override string ToString();
    }
}
