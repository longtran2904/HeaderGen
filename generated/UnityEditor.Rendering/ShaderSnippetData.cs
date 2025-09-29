#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEditor.Rendering
{
    [UsedByNativeCode]
    public struct ShaderSnippetData
    {

        public ShaderType shaderType { get; }
        public PassType passType { get; }
        public string passName { get; }
        public PassIdentifier pass { get; }
    }
}
