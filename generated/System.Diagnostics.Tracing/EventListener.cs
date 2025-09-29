#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;

namespace System.Diagnostics.Tracing
{
    public abstract class EventListener : IDisposable
    {
        protected EventListener();

        public event EventHandler<EventSourceCreatedEventArgs> EventSourceCreated;
        public event EventHandler<EventWrittenEventArgs> EventWritten;

        public virtual void Dispose();
        public void EnableEvents(EventSource eventSource, EventLevel level);
        public void EnableEvents(EventSource eventSource, EventLevel level, EventKeywords matchAnyKeyword);
        public void EnableEvents(EventSource eventSource, EventLevel level, EventKeywords matchAnyKeyword, IDictionary<string, string> arguments);
        public void DisableEvents(EventSource eventSource);
        protected internal static int EventSourceIndex(EventSource eventSource);
        protected internal virtual void OnEventSourceCreated(EventSource eventSource);
        protected internal virtual void OnEventWritten(EventWrittenEventArgs eventData);
    }
}
