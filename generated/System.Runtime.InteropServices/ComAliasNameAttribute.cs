#region System.Runtime.InteropServices, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Runtime.InteropServices.dll
#endregion

namespace System.Runtime.InteropServices
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, Inherited = False)]
    public sealed class ComAliasNameAttribute : Attribute
    {

        public ComAliasNameAttribute(string alias);

        public string Value { get; }
    }
}
