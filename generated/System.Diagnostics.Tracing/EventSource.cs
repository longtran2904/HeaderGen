#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

using System.Collections.Generic;

namespace System.Diagnostics.Tracing
{
    public class EventSource : IDisposable
    {

        protected EventSource();
        protected EventSource(bool throwOnEventWriteErrors);
        protected EventSource(EventSourceSettings settings);
        protected EventSource(EventSourceSettings settings, params string[] traits);
        public EventSource(string eventSourceName);
        public EventSource(string eventSourceName, EventSourceSettings config);
        public EventSource(string eventSourceName, EventSourceSettings config, params string[] traits);

        ~EventSource();

        public string Name { get; }
        public Guid Guid { get; }
        public EventSourceSettings Settings { get; }
        public Exception ConstructionException { get; }
        public static Guid CurrentThreadActivityId { get; }

        public event EventHandler<EventCommandEventArgs> EventCommandExecuted;

        public bool IsEnabled();
        public bool IsEnabled(EventLevel level, EventKeywords keywords);
        public bool IsEnabled(EventLevel level, EventKeywords keywords, EventChannel channel);
        public static Guid GetGuid(Type eventSourceType);
        public static string GetName(Type eventSourceType);
        public static string GenerateManifest(Type eventSourceType, string assemblyPathToIncludeInManifest);
        public static string GenerateManifest(Type eventSourceType, string assemblyPathToIncludeInManifest, EventManifestOptions flags);
        public static IEnumerable<EventSource> GetSources();
        public static void SendCommand(EventSource eventSource, EventCommand command, IDictionary<string, string> commandArguments);
        public string GetTrait(string key);
        public override string ToString();
        public static void SetCurrentThreadActivityId(Guid activityId);
        public static void SetCurrentThreadActivityId(Guid activityId, out Guid oldActivityThatWillContinue);
        protected virtual void OnEventCommand(EventCommandEventArgs command);
        protected void WriteEvent(int eventId);
        protected void WriteEvent(int eventId, int arg1);
        protected void WriteEvent(int eventId, int arg1, int arg2);
        protected void WriteEvent(int eventId, int arg1, int arg2, int arg3);
        protected void WriteEvent(int eventId, long arg1);
        protected void WriteEvent(int eventId, long arg1, long arg2);
        protected void WriteEvent(int eventId, long arg1, long arg2, long arg3);
        protected void WriteEvent(int eventId, string arg1);
        protected void WriteEvent(int eventId, string arg1, string arg2);
        protected void WriteEvent(int eventId, string arg1, string arg2, string arg3);
        protected void WriteEvent(int eventId, string arg1, int arg2);
        protected void WriteEvent(int eventId, string arg1, int arg2, int arg3);
        protected void WriteEvent(int eventId, string arg1, long arg2);
        protected void WriteEvent(int eventId, long arg1, string arg2);
        protected void WriteEvent(int eventId, int arg1, string arg2);
        protected void WriteEvent(int eventId, byte[] arg1);
        protected void WriteEvent(int eventId, long arg1, byte[] arg2);
        [CLSCompliant(False)]
        protected void WriteEventCore(int eventId, int eventDataCount, EventData* data);
        [CLSCompliant(False)]
        protected void WriteEventWithRelatedActivityIdCore(int eventId, Guid* relatedActivityId, int eventDataCount, EventData* data);
        protected void WriteEvent(int eventId, params EventSourcePrimitive[] args);
        protected void WriteEvent(int eventId, params object[] args);
        protected void WriteEventWithRelatedActivityId(int eventId, Guid relatedActivityId, params object[] args);
        public void Dispose();
        protected virtual void Dispose(bool disposing);
        public void Write(string eventName);
        public void Write(string eventName, EventSourceOptions options);
        public void Write<T>(string eventName, T data);
        public void Write<T>(string eventName, EventSourceOptions options, T data);
        public void Write<T>(string eventName, ref EventSourceOptions options, ref T data);
        public void Write<T>(string eventName, ref EventSourceOptions options, ref Guid activityId, ref Guid relatedActivityId, ref T data);
        public readonly struct EventSourcePrimitive
        {

            public static implicit operator EventSourcePrimitive(bool value);
            public static implicit operator EventSourcePrimitive(byte value);
            public static implicit operator EventSourcePrimitive(short value);
            public static implicit operator EventSourcePrimitive(int value);
            public static implicit operator EventSourcePrimitive(long value);
            [CLSCompliant(False)]
            public static implicit operator EventSourcePrimitive(sbyte value);
            [CLSCompliant(False)]
            public static implicit operator EventSourcePrimitive(ushort value);
            [CLSCompliant(False)]
            public static implicit operator EventSourcePrimitive(uint value);
            [CLSCompliant(False)]
            public static implicit operator EventSourcePrimitive(ulong value);
            [CLSCompliant(False)]
            public static implicit operator EventSourcePrimitive(nuint value);
            public static implicit operator EventSourcePrimitive(float value);
            public static implicit operator EventSourcePrimitive(double value);
            public static implicit operator EventSourcePrimitive(decimal value);
            public static implicit operator EventSourcePrimitive(string value);
            public static implicit operator EventSourcePrimitive(byte[] value);
            public static implicit operator EventSourcePrimitive(Guid value);
            public static implicit operator EventSourcePrimitive(DateTime value);
            public static implicit operator EventSourcePrimitive(nint value);
            public static implicit operator EventSourcePrimitive(char value);
            public static implicit operator EventSourcePrimitive(Enum value);
        }
        protected internal struct EventData
        {

            public nint DataPointer { get; set; }
            public int Size { get; set; }
        }
    }
}
