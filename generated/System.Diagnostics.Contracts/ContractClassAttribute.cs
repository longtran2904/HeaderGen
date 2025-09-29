#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Diagnostics.Contracts
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = False, Inherited = False)]
    [Conditional("CONTRACTS_FULL")]
    [Conditional("DEBUG")]
    public sealed class ContractClassAttribute : Attribute
    {

        public ContractClassAttribute(Type typeContainingContracts);

        public Type TypeContainingContracts { get; }
    }
}
