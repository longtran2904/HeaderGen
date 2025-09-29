#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.SceneManagement;

namespace UnityEditor
{
    public struct DestroyGameObjectHierarchyEventArgs
    {
        public DestroyGameObjectHierarchyEventArgs(int instanceId, Scene scene);
        public DestroyGameObjectHierarchyEventArgs(int instanceId, int parentInstanceId, Scene scene);

        public int instanceId { get; }
        public int parentInstanceId { get; }
        public Scene scene { get; }
    }
}
