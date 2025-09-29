#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;

namespace UnityEditor
{
    [ExcludeFromPreset]
    [NativeHeader("Modules/AssetPipelineEditor/Public/AndroidAssetPackImporter.h")]
    public class AndroidAssetPackImporter : AssetImporter
    {

        public AndroidAssetPackImporter();

        public static AndroidAssetPackImporter[] GetAllImporters();
    }
}
