#region UnityEditor.SceneTemplateModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.SceneTemplateModule.dll
#endregion

using UnityEngine.SceneManagement;

namespace UnityEditor.SceneTemplate
{
    public interface ISceneTemplatePipeline
    {

        bool IsValidTemplateForInstantiation(SceneTemplateAsset sceneTemplateAsset);
        void BeforeTemplateInstantiation(SceneTemplateAsset sceneTemplateAsset, bool isAdditive, string sceneName);
        void AfterTemplateInstantiation(SceneTemplateAsset sceneTemplateAsset, Scene scene, bool isAdditive, string sceneName);
    }
}
