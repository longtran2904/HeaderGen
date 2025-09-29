#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor.Analytics
{
    [NativeHeader("Modules/UnityConnect/PerformanceReporting/PerformanceReportingSettings.h")]
    [StaticAccessor("GetPerformanceReportingSettings()", StaticAccessorType.Dot)]
    public static class PerformanceReportingSettings
    {
        public static bool enabled { get; set; }
    }
}
