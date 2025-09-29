#region UnityEngine.CrashReportingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CrashReportingModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.CrashReportHandler
{
    [NativeHeader("Modules/CrashReporting/Public/CrashReporter.h")]
    [StaticAccessor("CrashReporting::CrashReporter::Get()", StaticAccessorType.Dot)]
    public class CrashReportHandler
    {

        [NativeProperty("Enabled")]
        public static bool enableCaptureExceptions { get; set; }
        [NativeThrows]
        public static uint logBufferSize { get; set; }

        [NativeThrows]
        public static string GetUserMetadata(string key);
        [NativeThrows]
        public static void SetUserMetadata(string key, string value);
    }
}
