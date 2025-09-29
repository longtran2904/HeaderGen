#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal
{
    public static class CameraExtensions
    {
        public static UniversalAdditionalCameraData GetUniversalAdditionalCameraData(this Camera camera);
        public static VolumeFrameworkUpdateMode GetVolumeFrameworkUpdateMode(this Camera camera);
        public static void SetVolumeFrameworkUpdateMode(this Camera camera, VolumeFrameworkUpdateMode mode);
        public static void UpdateVolumeStack(this Camera camera);
        public static void UpdateVolumeStack(this Camera camera, UniversalAdditionalCameraData cameraData);
        public static void DestroyVolumeStack(this Camera camera);
        public static void DestroyVolumeStack(this Camera camera, UniversalAdditionalCameraData cameraData);
    }
}
