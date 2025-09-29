#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Diagnostics.Tracing
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class EventAttribute : Attribute
    {

        public EventAttribute(int eventId);

        public int EventId { get; }
        public EventLevel Level { get; set; }
        public EventKeywords Keywords { get; set; }
        public EventOpcode Opcode { get; set; }
        public EventTask Task { get; set; }
        public EventChannel Channel { get; set; }
        public byte Version { get; set; }
        public string Message { get; set; }
        public EventTags Tags { get; set; }
        public EventActivityOptions ActivityOptions { get; set; }
    }
}
