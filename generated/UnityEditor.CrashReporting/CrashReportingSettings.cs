#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor.CrashReporting
{
    [NativeHeader("Modules/UnityConnect/CrashReporting/CrashReportingSettings.h")]
    [StaticAccessor("GetCrashReportingSettings()")]
    public static class CrashReportingSettings
    {

        public static bool enabled { get; set; }
        public static bool captureEditorExceptions { get; set; }
        [NativeThrows]
        public static uint logBufferSize { get; set; }
    }
}
