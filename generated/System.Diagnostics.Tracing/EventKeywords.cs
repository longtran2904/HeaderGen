#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Diagnostics.Tracing
{
    [Flags]
    public enum EventKeywords
    {

        None = 0,
        All = -1,
        MicrosoftTelemetry = 562949953421312,
        WdiContext = 562949953421312,
        WdiDiagnostic = 1125899906842624,
        Sqm = 2251799813685248,
        AuditFailure = 4503599627370496,
        AuditSuccess = 9007199254740992,
        CorrelationHint = 4503599627370496,
        EventLogClassic = 36028797018963968
    }
}
