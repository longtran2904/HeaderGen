#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.ObjectModel;

namespace System.Diagnostics.Tracing
{
    public class EventWrittenEventArgs : EventArgs
    {
        public string EventName { get; }
        public int EventId { get; }
        public Guid ActivityId { get; }
        public Guid RelatedActivityId { get; }
        public ReadOnlyCollection<object> Payload { get; }
        public ReadOnlyCollection<string> PayloadNames { get; }
        public EventSource EventSource { get; }
        public EventKeywords Keywords { get; }
        public EventOpcode Opcode { get; }
        public EventTask Task { get; }
        public EventTags Tags { get; }
        public string Message { get; }
        public EventChannel Channel { get; }
        public byte Version { get; }
        public EventLevel Level { get; }
        public long OSThreadId { get; }
        public DateTime TimeStamp { get; }
    }
}
