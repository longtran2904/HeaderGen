#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

namespace UnityEngine.SceneManagement
{
    public struct LoadSceneParameters
    {

        public LoadSceneParameters(LoadSceneMode mode);
        public LoadSceneParameters(LoadSceneMode mode, LocalPhysicsMode physicsMode);

        public LoadSceneMode loadSceneMode { get; set; }
        public LocalPhysicsMode localPhysicsMode { get; set; }
    }
}
