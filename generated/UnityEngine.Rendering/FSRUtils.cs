#region Unity.RenderPipelines.Core.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Core.Runtime.dll
#endregion

namespace UnityEngine.Rendering
{
    public static class FSRUtils
    {
        public const float kDefaultSharpnessStops = 0.2F;
        public const float kDefaultSharpnessLinear = 0.92F;

        public static void SetEasuConstants(CommandBuffer cmd, Vector2 inputViewportSizeInPixels, Vector2 inputImageSizeInPixels, Vector2 outputImageSizeInPixels);
        public static void SetRcasConstants(CommandBuffer cmd, float sharpnessStops = 0.2F);
        public static void SetRcasConstantsLinear(CommandBuffer cmd, float sharpnessLinear = 0.92F);
        public static bool IsSupported();
    }
}
