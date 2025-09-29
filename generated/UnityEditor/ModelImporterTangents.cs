#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeType(Header = "Modules/AssetPipelineEditor/Public/ModelImporting/ImportMesh.h")]
    public enum ModelImporterTangents
    {

        Import = 0,
        CalculateLegacy = 1,
        CalculateLegacyWithSplitTangents = 4,
        [InspectorName("Calculate Mikktspace")]
        CalculateMikk = 3,
        None = 2
    }
}
