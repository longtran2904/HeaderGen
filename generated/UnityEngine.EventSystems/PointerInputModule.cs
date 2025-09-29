#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
    public abstract class PointerInputModule : BaseInputModule
    {

        protected Dictionary<int, PointerEventData> m_PointerData;
        public const int kMouseLeftId = -1;
        public const int kMouseRightId = -2;
        public const int kMouseMiddleId = -3;
        public const int kFakeTouchesId = -4;

        protected PointerInputModule();

        protected bool GetPointerData(int id, out PointerEventData data, bool create);
        protected void RemovePointerData(PointerEventData data);
        protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released);
        protected void CopyFromTo(PointerEventData from, PointerEventData to);
        protected PointerEventData.FramePressState StateForMouseButton(int buttonId);
        protected virtual MouseState GetMousePointerEventData();
        protected virtual MouseState GetMousePointerEventData(int id);
        protected PointerEventData GetLastPointerEventData(int id);
        protected virtual void ProcessMove(PointerEventData pointerEvent);
        protected virtual void ProcessDrag(PointerEventData pointerEvent);
        public override bool IsPointerOverGameObject(int pointerId);
        protected void ClearSelection();
        public override string ToString();
        protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent);
        protected class ButtonState
        {

            public ButtonState();

            public MouseButtonEventData eventData { get; set; }
            public PointerEventData.InputButton button { get; set; }
        }
        protected class MouseState
        {

            public MouseState();

            public bool AnyPressesThisFrame();
            public bool AnyReleasesThisFrame();
            public ButtonState GetButtonState(PointerEventData.InputButton button);
            public void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data);
        }
        public class MouseButtonEventData
        {

            public PointerEventData.FramePressState buttonState;
            public PointerEventData buttonData;

            public MouseButtonEventData();

            public bool PressedThisFrame();
            public bool ReleasedThisFrame();
        }
    }
}
