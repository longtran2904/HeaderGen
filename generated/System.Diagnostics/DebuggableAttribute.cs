#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Diagnostics
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = False)]
    public sealed class DebuggableAttribute : Attribute
    {
        public DebuggableAttribute(bool isJITTrackingEnabled, bool isJITOptimizerDisabled);
        public DebuggableAttribute(DebuggingModes modes);

        public bool IsJITTrackingEnabled { get; }
        public bool IsJITOptimizerDisabled { get; }
        public DebuggingModes DebuggingFlags { get; }

        [Flags]
        public enum DebuggingModes
        {
            None = 0,
            Default = 1,
            DisableOptimizations = 256,
            IgnoreSymbolStoreSequencePoints = 2,
            EnableEditAndContinue = 4
        }
    }
}
