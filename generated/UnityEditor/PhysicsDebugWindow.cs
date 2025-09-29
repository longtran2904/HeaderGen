#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

namespace UnityEditor
{
    public class PhysicsDebugWindow : EditorWindow
    {
        public PhysicsDebugWindow();

        [MenuItem("Window/Analysis/Physics Debugger", False, 11)]
        public static PhysicsDebugWindow ShowWindow();
        public void OnEnable();
        public void OnDisable();
    }
}
