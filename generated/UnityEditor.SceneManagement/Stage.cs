#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor.SceneManagement
{
    public abstract class Stage : ScriptableObject
    {

        protected Stage();

        public virtual string assetPath { get; }
        public virtual StageHandle stageHandle { get; }

        protected internal abstract bool OnOpenStage();
        protected abstract void OnCloseStage();
        protected internal virtual void OnReturnToStage();
        protected internal abstract GUIContent CreateHeaderContent();
        public virtual ulong GetCombinedSceneCullingMaskForCamera();
        protected internal virtual void OnFirstTimeOpenStageInSceneView(SceneView sceneView);
        protected internal virtual Hash128 GetHashForStateStorage();
        protected virtual void OnEnable();
        protected virtual void OnDisable();
        public T FindComponentOfType<T>() where T : Component;
        public T[] FindComponentsOfType<T>() where T : Component;
    }
}
