#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.Versioning;

namespace System.Diagnostics.Tracing
{
    [UnsupportedOSPlatform("browser")]
    public class IncrementingEventCounter : DiagnosticCounter
    {

        public IncrementingEventCounter(string name, EventSource eventSource);

        public TimeSpan DisplayRateTimeScale { get; set; }

        public void Increment(double increment = 1);
        public override string ToString();
    }
}
