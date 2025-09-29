#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using UnityEngine.EventSystems;

namespace UnityEngine.UIElements
{
    [AddComponentMenu("UI Toolkit/Panel Event Handler (UI Toolkit)")]
    public class PanelEventHandler : UIBehaviour, ICancelHandler, IDeselectHandler, IEventSystemHandler, IMoveHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler, IPointerMoveHandler, IPointerUpHandler, IRuntimePanelComponent, IScrollHandler, ISelectHandler, ISubmitHandler
    {

        public PanelEventHandler();

        public IPanel panel { get; set; }

        protected override void OnEnable();
        protected override void OnDisable();
        public void OnSelect(BaseEventData eventData);
        public void OnDeselect(BaseEventData eventData);
        public void OnPointerMove(PointerEventData eventData);
        public void OnPointerUp(PointerEventData eventData);
        public void OnPointerDown(PointerEventData eventData);
        public void OnPointerExit(PointerEventData eventData);
        public void OnPointerEnter(PointerEventData eventData);
        public void OnSubmit(BaseEventData eventData);
        public void OnCancel(BaseEventData eventData);
        public void OnMove(AxisEventData eventData);
        public void OnScroll(PointerEventData eventData);
    }
}
