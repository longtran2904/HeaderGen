#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor.Build.Reporting
{
    [NativeClass("BuildReporting::ScenesUsingAssets")]
    [NativeType(Header = "Modules/BuildReportingEditor/Public/ScenesUsingAssets.h")]
    public sealed class ScenesUsingAssets : UnityEngine.Object
    {
        public ScenesUsingAssets();

        public ScenesUsingAsset[] list { get; }
    }
}
