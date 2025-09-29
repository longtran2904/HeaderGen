#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.VersionControl
{
    [NativeHeader("Editor/Src/VersionControl/VCPlugin.h")]
    [UsedByNativeCode]
    public class Plugin
    {

        ~Plugin();

        public static Plugin[] availablePlugins { get; }
        public string name { get; }
        public ConfigField[] configFields { get; }

        public void Dispose();
    }
}
