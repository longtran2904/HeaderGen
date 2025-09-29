#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Diagnostics.Contracts
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = False, Inherited = False)]
    [Conditional("CONTRACTS_FULL")]
    public sealed class ContractClassForAttribute : Attribute
    {
        public ContractClassForAttribute(Type typeContractsAreFor);

        public Type TypeContractsAreFor { get; }
    }
}
