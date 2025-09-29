#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Diagnostics.Contracts
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = True, Inherited = False)]
    [Conditional("CONTRACTS_FULL")]
    public sealed class ContractOptionAttribute : Attribute
    {
        public ContractOptionAttribute(string category, string setting, bool enabled);
        public ContractOptionAttribute(string category, string setting, string value);

        public string Category { get; }
        public string Setting { get; }
        public bool Enabled { get; }
        public string Value { get; }
    }
}
