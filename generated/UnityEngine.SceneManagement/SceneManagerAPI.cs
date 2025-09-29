#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine.SceneManagement
{
    public class SceneManagerAPI
    {

        protected internal SceneManagerAPI();

        public static SceneManagerAPI overrideAPI { get; set; }

        protected internal virtual int GetNumScenesInBuildSettings();
        protected internal virtual Scene GetSceneByBuildIndex(int buildIndex);
        protected internal virtual AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame);
        protected internal virtual AsyncOperation UnloadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess);
        protected internal virtual AsyncOperation LoadFirstScene(bool mustLoadAsync);
    }
}
