#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEditor.Rendering
{
    [UsedByNativeCode]
    public struct ShaderCompilerData
    {
        public ShaderKeywordSet shaderKeywordSet;
        public PlatformKeywordSet platformKeywordSet;

        public ShaderRequirements shaderRequirements { get; }
        public GraphicsTier graphicsTier { get; }
        public ShaderCompilerPlatform shaderCompilerPlatform { get; }
        public BuildTarget buildTarget { get; }
    }
}
