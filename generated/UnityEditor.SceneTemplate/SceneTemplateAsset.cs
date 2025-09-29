#region UnityEditor.SceneTemplateModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.SceneTemplateModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.SceneTemplate
{
    [AssetFileNameExtension("scenetemplate", new[] { })]
    [ExcludeFromPreset]
    [HelpURL("https://docs.unity3d.com/2021.3/Documentation/Manual/scene-templates.html")]
    public class SceneTemplateAsset : ScriptableObject
    {

        public SceneAsset templateScene;
        public string templateName;
        public string description;
        public Texture2D preview;
        public DependencyInfo[] dependencies;
        public MonoScript templatePipeline;
        public Texture2D badge;
        public bool addToDefaults;

        public SceneTemplateAsset();

        public bool isValid { get; }
    }
}
