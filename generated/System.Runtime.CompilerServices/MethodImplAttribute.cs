#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, Inherited = False)]
    public sealed class MethodImplAttribute : Attribute
    {

        public MethodCodeType MethodCodeType;

        public MethodImplAttribute(MethodImplOptions methodImplOptions);
        public MethodImplAttribute(short value);
        public MethodImplAttribute();

        public MethodImplOptions Value { get; }
    }
}
