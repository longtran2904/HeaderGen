#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor.VersionControl
{
    [NativeHeader("Editor/Src/VersionControl/VCConfigField.h")]
    [NativeHeader("Editor/Src/VersionControl/VC_bindings.h")]
    [UsedByNativeCode]
    public class ConfigField
    {

        ~ConfigField();

        public string name { get; }
        public string label { get; }
        public string description { get; }
        public bool isRequired { get; }
        public bool isPassword { get; }

        public void Dispose();
    }
}
