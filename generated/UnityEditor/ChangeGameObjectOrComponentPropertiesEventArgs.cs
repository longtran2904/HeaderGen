#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.SceneManagement;

namespace UnityEditor
{
    public struct ChangeGameObjectOrComponentPropertiesEventArgs
    {
        public ChangeGameObjectOrComponentPropertiesEventArgs(int instanceId, Scene scene);

        public int instanceId { get; }
        public Scene scene { get; }
    }
}
