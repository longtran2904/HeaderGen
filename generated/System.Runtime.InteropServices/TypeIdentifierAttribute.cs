#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Runtime.InteropServices
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = False, Inherited = False)]
    public sealed class TypeIdentifierAttribute : Attribute
    {
        public TypeIdentifierAttribute();
        public TypeIdentifierAttribute(string scope, string identifier);

        public string Scope { get; }
        public string Identifier { get; }
    }
}
