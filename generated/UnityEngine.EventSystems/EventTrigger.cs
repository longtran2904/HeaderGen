#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.Events;

namespace UnityEngine.EventSystems
{
    [AddComponentMenu("Event/Event Trigger")]
    public class EventTrigger : MonoBehaviour, IBeginDragHandler, ICancelHandler, IDeselectHandler, IDragHandler, IDropHandler, IEndDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, IMoveHandler, IPointerClickHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler, IScrollHandler, ISelectHandler, ISubmitHandler, IUpdateSelectedHandler
    {
        protected EventTrigger();

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Please use triggers instead (UnityUpgradable) -> triggers", True)]
        public List<Entry> delegates { get; set; }
        public List<Entry> triggers { get; set; }

        public virtual void OnPointerEnter(PointerEventData eventData);
        public virtual void OnPointerExit(PointerEventData eventData);
        public virtual void OnDrag(PointerEventData eventData);
        public virtual void OnDrop(PointerEventData eventData);
        public virtual void OnPointerDown(PointerEventData eventData);
        public virtual void OnPointerUp(PointerEventData eventData);
        public virtual void OnPointerClick(PointerEventData eventData);
        public virtual void OnSelect(BaseEventData eventData);
        public virtual void OnDeselect(BaseEventData eventData);
        public virtual void OnScroll(PointerEventData eventData);
        public virtual void OnMove(AxisEventData eventData);
        public virtual void OnUpdateSelected(BaseEventData eventData);
        public virtual void OnInitializePotentialDrag(PointerEventData eventData);
        public virtual void OnBeginDrag(PointerEventData eventData);
        public virtual void OnEndDrag(PointerEventData eventData);
        public virtual void OnSubmit(BaseEventData eventData);
        public virtual void OnCancel(BaseEventData eventData);

        public class TriggerEvent : UnityEvent<BaseEventData>
        {
            public TriggerEvent();
        }
        public class Entry
        {
            public EventTriggerType eventID;
            public TriggerEvent callback;

            public Entry();
        }
    }
}
