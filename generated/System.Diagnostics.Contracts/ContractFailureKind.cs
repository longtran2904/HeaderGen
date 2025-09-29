#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Diagnostics.Contracts
{
    public enum ContractFailureKind
    {
        Precondition = 0,
        Postcondition = 1,
        PostconditionOnException = 2,
        Invariant = 3,
        Assert = 4,
        Assume = 5
    }
}
