#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeType(Header = "Modules/AssetPipelineEditor/Public/ModelImporting/ImportMesh.h")]
    public enum ModelImporterNormalCalculationMode
    {
        [InspectorName("Unweighted (Legacy)")]
        Unweighted_Legacy = 0,
        Unweighted = 1,
        AreaWeighted = 2,
        AngleWeighted = 3,
        AreaAndAngleWeighted = 4
    }
}
