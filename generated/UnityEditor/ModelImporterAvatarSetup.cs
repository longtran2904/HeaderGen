#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [NativeType(Header = "Modules/AssetPipelineEditor/Public/ModelImporting/ModelImporter.h")]
    public enum ModelImporterAvatarSetup
    {
        NoAvatar = 0,
        [Tooltip("Create an Avatar based on the model from this file.")]
        CreateFromThisModel = 1,
        [InspectorName("Copy From Other Avatar")]
        [Tooltip("Copy an Avatar from another file to import muscle clip. No avatar will be created.")]
        CopyFromOther = 2
    }
}
