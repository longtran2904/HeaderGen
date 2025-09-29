#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.Versioning;

namespace System.Diagnostics.Tracing
{
    [UnsupportedOSPlatform("browser")]
    public class IncrementingPollingCounter : DiagnosticCounter
    {

        public IncrementingPollingCounter(string name, EventSource eventSource, Func<double> totalValueProvider);

        public TimeSpan DisplayRateTimeScale { get; set; }

        public override string ToString();
    }
}
