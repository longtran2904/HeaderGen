#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor.Build.Reporting
{
    [NativeClass("BuildReporting::BuildReport")]
    [NativeHeader("Runtime/Utilities/DateTime.h")]
    [NativeType(Header = "Modules/BuildReportingEditor/Public/BuildReport.h")]
    public sealed class BuildReport : UnityEngine.Object
    {

        public BuildFile[] files { get; }
        [NativeName("BuildSteps")]
        public BuildStep[] steps { get; }
        public BuildSummary summary { get; }
        public StrippingInfo strippingInfo { get; }
        public PackedAssets[] packedAssets { get; }
        public ScenesUsingAssets[] scenesUsingAssets { get; }
    }
}
