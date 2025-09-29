#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEditor.VersionControl
{
    [NativeHeader("Editor/Src/VersionControl/VCManager.h")]
    [StaticAccessor("GetVCManager()")]
    public static class VersionControlManager
    {

        public static VersionControlDescriptor[] versionControlDescriptors { get; }
        public static VersionControlObject activeVersionControlObject { get; }

        public static bool SetVersionControl(string name);
    }
}
