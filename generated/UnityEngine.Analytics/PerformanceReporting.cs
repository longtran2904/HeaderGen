#region UnityEngine.PerformanceReportingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PerformanceReportingModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Analytics
{
    [NativeHeader("Modules/PerformanceReporting/PerformanceReportingManager.h")]
    [StaticAccessor("GetPerformanceReportingManager()", StaticAccessorType.Dot)]
    public static class PerformanceReporting
    {

        public static bool enabled { get; set; }
        public static long graphicsInitializationFinishTime { get; }
    }
}
