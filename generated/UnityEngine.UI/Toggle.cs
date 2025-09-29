#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
    [AddComponentMenu("UI/Toggle", 30)]
    [RequireComponent(typeof(RectTransform))]
    public class Toggle : Selectable, ICanvasElement, IPointerClickHandler, ISubmitHandler
    {

        public ToggleTransition toggleTransition;
        public Graphic graphic;
        public ToggleEvent onValueChanged;

        protected Toggle();

        public ToggleGroup group { get; set; }
        public bool isOn { get; set; }

        protected override void OnValidate();
        public virtual void Rebuild(CanvasUpdate executing);
        public virtual void LayoutComplete();
        public virtual void GraphicUpdateComplete();
        protected override void OnDestroy();
        protected override void OnEnable();
        protected override void OnDisable();
        protected override void OnDidApplyAnimationProperties();
        public void SetIsOnWithoutNotify(bool value);
        protected override void Start();
        public virtual void OnPointerClick(PointerEventData eventData);
        public virtual void OnSubmit(BaseEventData eventData);
        public enum ToggleTransition
        {

            None = 0,
            Fade = 1
        }
        public class ToggleEvent : UnityEvent<bool>
        {

            public ToggleEvent();
        }
    }
}
