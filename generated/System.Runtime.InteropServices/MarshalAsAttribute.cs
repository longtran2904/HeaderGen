#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, Inherited = False)]
    public sealed class MarshalAsAttribute : Attribute
    {

        public VarEnum SafeArraySubType;
        public Type SafeArrayUserDefinedSubType;
        public int IidParameterIndex;
        public UnmanagedType ArraySubType;
        public short SizeParamIndex;
        public int SizeConst;
        public string MarshalType;
        public Type MarshalTypeRef;
        public string MarshalCookie;

        public MarshalAsAttribute(UnmanagedType unmanagedType);
        public MarshalAsAttribute(short unmanagedType);

        public UnmanagedType Value { get; }
    }
}
