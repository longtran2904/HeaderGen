#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System;

namespace UnityEngine.EventSystems
{
    [AddComponentMenu("Event/Touch Input Module")]
    [Obsolete("TouchInputModule is no longer required as Touch input is now handled in StandaloneInputModule.")]
    public class TouchInputModule : PointerInputModule
    {
        protected TouchInputModule();

        [Obsolete("allowActivationOnStandalone has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
        public bool allowActivationOnStandalone { get; set; }
        public bool forceModuleActive { get; set; }

        public override void UpdateModule();
        public override bool IsModuleSupported();
        public override bool ShouldActivateModule();
        public override void Process();
        protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released);
        public override void DeactivateModule();
        public override string ToString();
    }
}
