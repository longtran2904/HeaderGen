#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Experimental.Rendering
{
    [NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
    public static class ShaderWarmup
    {
        [FreeFunction(Name = "ShaderWarmupScripting::WarmupShader")]
        public static void WarmupShader(Shader shader, ShaderWarmupSetup setup);
        [FreeFunction(Name = "ShaderWarmupScripting::WarmupShaderFromCollection")]
        public static void WarmupShaderFromCollection(ShaderVariantCollection collection, Shader shader, ShaderWarmupSetup setup);
    }
}
