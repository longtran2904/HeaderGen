#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection.Emit
{
    public class DynamicILInfo
    {

        public DynamicMethod DynamicMethod { get; }

        public void SetCode(byte[] code, int maxStackSize);
        [CLSCompliant(False)]
        public void SetCode(byte* code, int codeSize, int maxStackSize);
        public void SetExceptions(byte[] exceptions);
        [CLSCompliant(False)]
        public void SetExceptions(byte* exceptions, int exceptionsSize);
        public void SetLocalSignature(byte[] localSignature);
        [CLSCompliant(False)]
        public void SetLocalSignature(byte* localSignature, int signatureSize);
        public int GetTokenFor(RuntimeMethodHandle method);
        public int GetTokenFor(DynamicMethod method);
        public int GetTokenFor(RuntimeMethodHandle method, RuntimeTypeHandle contextType);
        public int GetTokenFor(RuntimeFieldHandle field);
        public int GetTokenFor(RuntimeFieldHandle field, RuntimeTypeHandle contextType);
        public int GetTokenFor(RuntimeTypeHandle type);
        public int GetTokenFor(string literal);
        public int GetTokenFor(byte[] signature);
    }
}
