#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices
{
    [AttributeUsage(AttributeTargets.Delegate, AllowMultiple = False, Inherited = False)]
    public sealed class UnmanagedFunctionPointerAttribute : Attribute
    {

        public bool BestFitMapping;
        public bool SetLastError;
        public bool ThrowOnUnmappableChar;
        public CharSet CharSet;

        public UnmanagedFunctionPointerAttribute(CallingConvention callingConvention);

        public CallingConvention CallingConvention { get; }
    }
}
