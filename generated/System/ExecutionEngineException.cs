#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System
{
    [Obsolete("ExecutionEngineException previously indicated an unspecified fatal error in the runtime. The runtime no longer raises this exception so this type is obsolete.")]
    public sealed class ExecutionEngineException : SystemException
    {
        public ExecutionEngineException();
        public ExecutionEngineException(string message);
        public ExecutionEngineException(string message, Exception innerException);
    }
}
