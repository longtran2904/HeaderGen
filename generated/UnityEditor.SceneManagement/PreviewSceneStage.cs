#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.SceneManagement;

namespace UnityEditor.SceneManagement
{
    public abstract class PreviewSceneStage : Stage
    {

        protected PreviewSceneStage();

        public Scene scene { get; protected set; }
        public override StageHandle stageHandle { get; }

        protected internal override bool OnOpenStage();
        protected override void OnCloseStage();
    }
}
