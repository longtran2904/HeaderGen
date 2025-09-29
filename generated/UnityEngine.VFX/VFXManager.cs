#region UnityEngine.VFXModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.VFXModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine.VFX
{
    [NativeHeader("Modules/VFX/Public/VFXManager.h")]
    [RequiredByNativeCode]
    [StaticAccessor("GetVFXManager()", StaticAccessorType.Dot)]
    public static class VFXManager
    {

        public static float fixedTimeStep { get; set; }
        public static float maxDeltaTime { get; set; }

        public static VisualEffect[] GetComponents();
        public static void ProcessCamera(Camera cam);
        public static void PrepareCamera(Camera cam);
        public static void PrepareCamera([NotNull("NullExceptionObject")] Camera cam, VFXCameraXRSettings camXRSettings);
        public static void ProcessCameraCommand(Camera cam, CommandBuffer cmd);
        public static void ProcessCameraCommand([NotNull("NullExceptionObject")] Camera cam, CommandBuffer cmd, VFXCameraXRSettings camXRSettings);
        public static VFXCameraBufferTypes IsCameraBufferNeeded([NotNull("NullExceptionObject")] Camera cam);
        public static void SetCameraBuffer([NotNull("NullExceptionObject")] Camera cam, VFXCameraBufferTypes type, Texture buffer, int x, int y, int width, int height);
    }
}
