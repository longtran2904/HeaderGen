#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeType(Header = "Modules/AssetPipelineEditor/Public/ModelImporting/ModelImporter.h")]
    public enum ModelImporterMaterialLocation
    {

        [InspectorName("Use External Materials (Legacy)")]
        [Tooltip("Use external materials if found in the project.")]
        External = 0,
        [InspectorName("Use Embedded Materials")]
        [Tooltip("Embed the material inside the imported asset.")]
        InPrefab = 1
    }
}
