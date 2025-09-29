#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.SceneManagement
{
    [MovedFrom("UnityEditor.Experimental.SceneManagement")]
    public sealed class PrefabStage : PreviewSceneStage
    {

        public GameObject prefabContentsRoot { get; }
        public GameObject openedFromInstanceRoot { get; }
        public GameObject openedFromInstanceObject { get; }
        public Mode mode { get; }
        public override string assetPath { get; }
        [Obsolete("prefabAssetPath has been deprecated. Use assetPath instead.")]
        public string prefabAssetPath { get; }

        public static event Action<PrefabStage> prefabStageOpened;
        public static event Action<PrefabStage> prefabStageClosing;
        public static event Action<PrefabStage> prefabStageDirtied;
        public static event Action<GameObject> prefabSaving;
        public static event Action<GameObject> prefabSaved;

        protected override void OnEnable();
        protected override void OnDisable();
        public override ulong GetCombinedSceneCullingMaskForCamera();
        public bool IsPartOfPrefabContents(GameObject gameObject);
        protected internal override bool OnOpenStage();
        protected override void OnCloseStage();
        protected internal override void OnReturnToStage();
        protected internal override void OnFirstTimeOpenStageInSceneView(SceneView sceneView);
        protected internal override GUIContent CreateHeaderContent();
        public void ClearDirtiness();
        public enum Mode
        {

            InIsolation = 0,
            InContext = 1
        }
    }
}
