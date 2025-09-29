#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System;

namespace UnityEngine.EventSystems
{
    [AddComponentMenu("Event/Standalone Input Module")]
    public class StandaloneInputModule : PointerInputModule
    {

        protected StandaloneInputModule();

        [Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", False)]
        public InputMode inputMode { get; }
        [Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
        public bool allowActivationOnMobileDevice { get; set; }
        [Obsolete("forceModuleActive has been deprecated. There is no need to force the module awake as StandaloneInputModule works for all platforms")]
        public bool forceModuleActive { get; set; }
        public float inputActionsPerSecond { get; set; }
        public float repeatDelay { get; set; }
        public string horizontalAxis { get; set; }
        public string verticalAxis { get; set; }
        public string submitButton { get; set; }
        public string cancelButton { get; set; }

        public override void UpdateModule();
        public override bool ShouldActivateModule();
        public override void ActivateModule();
        public override void DeactivateModule();
        public override void Process();
        protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released);
        protected bool SendSubmitEventToSelectedObject();
        protected bool SendMoveEventToSelectedObject();
        protected void ProcessMouseEvent();
        [Obsolete("This method is no longer checked, overriding it with return true does nothing!")]
        protected virtual bool ForceAutoSelect();
        protected void ProcessMouseEvent(int id);
        protected bool SendUpdateEventToSelectedObject();
        protected void ProcessMousePress(MouseButtonEventData data);
        protected GameObject GetCurrentFocusedGameObject();
        [Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", False)]
        public enum InputMode
        {

            Mouse = 0,
            Buttons = 1
        }
    }
}
