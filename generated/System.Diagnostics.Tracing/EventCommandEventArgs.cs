#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;

namespace System.Diagnostics.Tracing
{
    public class EventCommandEventArgs : EventArgs
    {
        public EventCommand Command { get; }
        public IDictionary<string, string> Arguments { get; }

        public bool EnableEvent(int eventId);
        public bool DisableEvent(int eventId);
    }
}
