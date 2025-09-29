#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
    [NativeHeader("Editor/Src/Graphics/ShaderCompilerData.h")]
    [UsedByNativeCode]
    public struct ShaderKeywordSet
    {
        public bool IsEnabled(ShaderKeyword keyword);
        public bool IsEnabled(GlobalKeyword keyword);
        public bool IsEnabled(LocalKeyword keyword);
        public void Enable(ShaderKeyword keyword);
        public void Disable(ShaderKeyword keyword);
        public ShaderKeyword[] GetShaderKeywords();
    }
}
