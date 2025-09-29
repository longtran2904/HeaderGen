#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
    [NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
    public class PIX
    {
        public PIX();

        [FreeFunction("PIX::BeginGPUCapture")]
        public static void BeginGPUCapture();
        [FreeFunction("PIX::EndGPUCapture")]
        public static void EndGPUCapture();
        [FreeFunction("PIX::IsAttached")]
        public static bool IsAttached();
    }
}
