#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEditor.SceneManagement
{
    [MovedFrom("UnityEditor.Experimental.SceneManagement")]
    public static class PrefabStageUtility
    {
        public static PrefabStage OpenPrefab(string prefabAssetPath);
        public static PrefabStage OpenPrefab(string prefabAssetPath, GameObject openedFromInstance);
        public static PrefabStage OpenPrefab(string prefabAssetPath, GameObject openedFromInstance, PrefabStage.Mode prefabStageMode);
        public static PrefabStage GetCurrentPrefabStage();
        public static PrefabStage GetPrefabStage(GameObject gameObject);
    }
}
