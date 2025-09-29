#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Diagnostics
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = True)]
    public sealed class DebuggerVisualizerAttribute : Attribute
    {

        public DebuggerVisualizerAttribute(string visualizerTypeName);
        public DebuggerVisualizerAttribute(string visualizerTypeName, string visualizerObjectSourceTypeName);
        public DebuggerVisualizerAttribute(string visualizerTypeName, Type visualizerObjectSource);
        public DebuggerVisualizerAttribute(Type visualizer);
        public DebuggerVisualizerAttribute(Type visualizer, Type visualizerObjectSource);
        public DebuggerVisualizerAttribute(Type visualizer, string visualizerObjectSourceTypeName);

        public string VisualizerObjectSourceTypeName { get; }
        public string VisualizerTypeName { get; }
        public string Description { get; set; }
        public Type Target { get; set; }
        public string TargetTypeName { get; set; }
    }
}
