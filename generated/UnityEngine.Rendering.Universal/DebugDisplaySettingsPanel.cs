#region Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.RenderPipelines.Universal.Runtime.dll
#endregion

using System;

namespace UnityEngine.Rendering.Universal
{
    public abstract class DebugDisplaySettingsPanel : IDebugDisplaySettingsPanel, IDebugDisplaySettingsPanelDisposable, IDisposable
    {
        protected DebugDisplaySettingsPanel();

        public abstract string PanelName { get; }
        public DebugUI.Widget[] Widgets { get; }

        protected void AddWidget(DebugUI.Widget widget);
        public void Dispose();
    }
}
