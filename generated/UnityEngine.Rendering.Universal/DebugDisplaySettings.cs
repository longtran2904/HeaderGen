#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

namespace UnityEngine.Rendering.Universal
{
    public class DebugDisplaySettings : IDebugDisplaySettingsQuery
    {

        public static DebugDisplaySettings Instance { get; }
        public bool AreAnySettingsActive { get; }
        public bool IsLightingActive { get; }
        public bool IsPostProcessingAllowed { get; }

        public bool TryGetScreenClearColor(ref Color color);
    }
}
