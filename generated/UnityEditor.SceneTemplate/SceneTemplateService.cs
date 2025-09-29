#region UnityEditor.SceneTemplateModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.SceneTemplateModule.dll
#endregion

using UnityEngine.SceneManagement;

namespace UnityEditor.SceneTemplate
{
    public static class SceneTemplateService
    {

        public static event NewTemplateInstantiating newSceneTemplateInstantiating;
        public static event NewTemplateInstantiated newSceneTemplateInstantiated;

        public static InstantiationResult Instantiate(SceneTemplateAsset sceneTemplate, bool loadAdditively, string newSceneOutputPath = null);
        public static SceneTemplateAsset CreateSceneTemplate(string sceneTemplatePath);
        public static SceneTemplateAsset CreateTemplateFromScene(SceneAsset sourceSceneAsset, string sceneTemplatePath);
        public delegate void NewTemplateInstantiating(SceneTemplateAsset sceneTemplateAsset, string newSceneOutputPath, bool additiveLoad);
        public delegate void NewTemplateInstantiated(SceneTemplateAsset sceneTemplateAsset, Scene scene, SceneAsset sceneAsset, bool additiveLoad);
    }
}
