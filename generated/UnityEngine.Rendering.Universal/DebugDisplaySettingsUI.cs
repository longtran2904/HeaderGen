#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering.Universal
{
    public class DebugDisplaySettingsUI : IDebugData
    {

        public DebugDisplaySettingsUI();

        public void RegisterDebug(DebugDisplaySettings settings);
        public void UnregisterDebug();
        public Action GetReset();
    }
}
