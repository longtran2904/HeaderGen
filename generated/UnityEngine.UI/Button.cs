#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
    [AddComponentMenu("UI/Button", 30)]
    public class Button : Selectable, IPointerClickHandler, ISubmitHandler
    {
        protected Button();

        public ButtonClickedEvent onClick { get; set; }

        public virtual void OnPointerClick(PointerEventData eventData);
        public virtual void OnSubmit(BaseEventData eventData);

        public class ButtonClickedEvent : UnityEvent
        {
            public ButtonClickedEvent();
        }
    }
}
