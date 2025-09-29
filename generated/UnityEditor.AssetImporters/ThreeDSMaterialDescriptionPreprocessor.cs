#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.AssetImporters
{
    [MovedFrom("UnityEditor.Experimental.AssetImporters")]
    public class ThreeDSMaterialDescriptionPreprocessor : AssetPostprocessor
    {

        public ThreeDSMaterialDescriptionPreprocessor();

        public override uint GetVersion();
        public override int GetPostprocessOrder();
        public void OnPreprocessMaterialDescription(MaterialDescription description, Material material, AnimationClip[] clips);
    }
}
