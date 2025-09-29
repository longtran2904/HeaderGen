#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;

namespace UnityEditor
{
    [Obsolete("Use ModelImporterMaterialName, ModelImporter.materialName and ModelImporter.materialImportMode instead", True)]
    public enum ModelImporterGenerateMaterials
    {

        [Obsolete("Use ModelImporter.materialImportMode=None instead", True)]
        None = 0,
        [Obsolete("Use ModelImporter.materialImportMode=Import and ModelImporter.materialName=ModelImporterMaterialName.BasedOnTextureName instead", True)]
        PerTexture = 1,
        [Obsolete("Use ModelImporter.materialImportMode=Import and ModelImporter.materialName=ModelImporterMaterialName.BasedOnModelNameAndMaterialName instead", True)]
        PerSourceMaterial = 2
    }
}
