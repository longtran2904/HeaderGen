#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Threading;

namespace System.Runtime
{
    public static class ControlledExecution
    {

        [Obsolete("ControlledExecution.Run method may corrupt the process and should not be used in production code.", DiagnosticId = "SYSLIB0046", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
        public static void Run(Action action, CancellationToken cancellationToken);
    }
}
