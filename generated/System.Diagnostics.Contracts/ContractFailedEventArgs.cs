#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Diagnostics.Contracts
{
    public sealed class ContractFailedEventArgs : EventArgs
    {
        public ContractFailedEventArgs(ContractFailureKind failureKind, string message, string condition, Exception originalException);

        public string Message { get; }
        public string Condition { get; }
        public ContractFailureKind FailureKind { get; }
        public Exception OriginalException { get; }
        public bool Handled { get; }
        public bool Unwind { get; }

        public void SetHandled();
        public void SetUnwind();
    }
}
