#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Runtime.Versioning;

namespace System.Diagnostics.Tracing
{
    [UnsupportedOSPlatform("browser")]
    public class EventCounter : DiagnosticCounter
    {
        public EventCounter(string name, EventSource eventSource);

        public void WriteMetric(float value);
        public void WriteMetric(double value);
        public override string ToString();
    }
}
