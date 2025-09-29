#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.SceneManagement;

namespace UnityEditor
{
    public struct ChangeGameObjectParentEventArgs
    {
        public ChangeGameObjectParentEventArgs(int instanceId, Scene previousScene, int previousParentInstanceId, Scene newScene, int newParentInstanceId);

        public int instanceId { get; }
        public int previousParentInstanceId { get; }
        public int newParentInstanceId { get; }
        public Scene previousScene { get; }
        public Scene newScene { get; }
    }
}
