#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

namespace UnityEditor.SceneManagement
{
    [NativeHeader("Editor/Src/SceneManager/StageUtility.bindings.h")]
    public static class StageUtility
    {
        public static bool IsGameObjectRenderedByCamera(GameObject gameObject, Camera camera);
        public static bool IsGameObjectRenderedByCameraAndPartOfEditableScene(GameObject gameObject, Camera camera);
        public static Stage GetCurrentStage();
        public static MainStage GetMainStage();
        public static Stage GetStage(GameObject gameObject);
        public static Stage GetStage(Scene scene);
        public static StageHandle GetCurrentStageHandle();
        public static StageHandle GetMainStageHandle();
        public static StageHandle GetStageHandle(GameObject gameObject);
        public static StageHandle GetStageHandle(Scene scene);
        [RequiredByNativeCode]
        public static void GoToMainStage();
        public static void GoBackToPreviousStage();
        public static void GoToStage(Stage stage, bool setAsFirstItemAfterMainStage);
        public static void PlaceGameObjectInCurrentStage(GameObject gameObject);
    }
}
