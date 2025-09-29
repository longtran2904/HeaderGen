#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Diagnostics.Tracing
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class EventSourceAttribute : Attribute
    {

        public EventSourceAttribute();

        public string Name { get; set; }
        public string Guid { get; set; }
        public string LocalizationResources { get; set; }
    }
}
