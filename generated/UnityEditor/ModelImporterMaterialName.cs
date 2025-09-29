#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeType(Header = "Modules/AssetPipelineEditor/Public/ModelImporting/ModelImporter.h")]
    public enum ModelImporterMaterialName
    {

        BasedOnTextureName = 0,
        BasedOnMaterialName = 1,
        BasedOnModelNameAndMaterialName = 2,
        [Obsolete("You should use ModelImporterMaterialName.BasedOnTextureName instead, because it it less complicated and behaves in more consistent way.")]
        BasedOnTextureName_Or_ModelNameAndMaterialName = 3
    }
}
