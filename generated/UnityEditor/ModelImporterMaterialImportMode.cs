#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeType(Header = "Modules/AssetPipelineEditor/Public/ModelImporting/ModelImporter.h")]
    public enum ModelImporterMaterialImportMode
    {
        [Tooltip("Do not import materials")]
        None = 0,
        [InspectorName("Standard (Legacy)")]
        [Tooltip("Use the standard Material import method.")]
        ImportStandard = 1,
        [InspectorName("Import via MaterialDescription")]
        [Tooltip("Use AssetPostprocessor.OnPreprocessMaterialDescription.")]
        ImportViaMaterialDescription = 2,
        [Obsolete("Use ImportStandard (UnityUpgradable) -> ImportStandard")]
        LegacyImport = 1,
        [Obsolete("Use ImportViaMaterialDescription (UnityUpgradable) -> ImportViaMaterialDescription")]
        Import = 2
    }
}
