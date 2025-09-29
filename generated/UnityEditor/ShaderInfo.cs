#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEditor
{
    [NativeHeader("Editor/Src/ShaderMenu.h")]
    [RequiredByNativeCode]
    public struct ShaderInfo
    {

        public string name { get; }
        public bool supported { get; }
        public bool hasErrors { get; }
        public bool hasWarnings { get; }
    }
}
