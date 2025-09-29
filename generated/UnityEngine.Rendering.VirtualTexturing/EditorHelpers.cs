#region UnityEngine.VirtualTexturingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VirtualTexturingModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.VirtualTexturing
{
    [NativeConditional("UNITY_EDITOR")]
    [NativeHeader("Modules/VirtualTexturing/ScriptBindings/VirtualTexturing.bindings.h")]
    [StaticAccessor("VirtualTexturing::Editor", StaticAccessorType.DoubleColon)]
    public static class EditorHelpers
    {

        [NativeThrows]
        public static bool ValidateTextureStack([NotNull("ArgumentNullException")][Unmarshalled] Texture[] textures, out string errorMessage);
        [NativeConditional("UNITY_EDITOR", "{}")]
        [NativeThrows]
        public static GraphicsFormat[] QuerySupportedFormats();
    }
}
