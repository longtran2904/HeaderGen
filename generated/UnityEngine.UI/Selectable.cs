#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
    [AddComponentMenu("UI/Selectable", 35)]
    [DisallowMultipleComponent]
    [ExecuteAlways]
    [SelectionBase]
    public class Selectable : UIBehaviour, IDeselectHandler, IEventSystemHandler, IMoveHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler, ISelectHandler
    {
        protected int m_CurrentIndex;
        protected static Selectable[] s_Selectables;
        protected static int s_SelectableCount;

        protected Selectable();

        public static Selectable[] allSelectablesArray { get; }
        public static int allSelectableCount { get; }
        [Obsolete("Replaced with allSelectablesArray to have better performance when disabling a element", False)]
        public static List<Selectable> allSelectables { get; }
        public Navigation navigation { get; set; }
        public Transition transition { get; set; }
        public ColorBlock colors { get; set; }
        public SpriteState spriteState { get; set; }
        public AnimationTriggers animationTriggers { get; set; }
        public Graphic targetGraphic { get; set; }
        public bool interactable { get; set; }
        public Image image { get; set; }
        public Animator animator { get; }
        protected SelectionState currentSelectionState { get; }

        public static int AllSelectablesNoAlloc(Selectable[] selectables);
        protected override void Awake();
        protected override void OnCanvasGroupChanged();
        public virtual bool IsInteractable();
        protected override void OnDidApplyAnimationProperties();
        protected override void OnEnable();
        protected override void OnTransformParentChanged();
        protected override void OnDisable();
        protected override void OnValidate();
        protected override void Reset();
        protected virtual void InstantClearState();
        protected virtual void DoStateTransition(SelectionState state, bool instant);
        public Selectable FindSelectable(Vector3 dir);
        public virtual Selectable FindSelectableOnLeft();
        public virtual Selectable FindSelectableOnRight();
        public virtual Selectable FindSelectableOnUp();
        public virtual Selectable FindSelectableOnDown();
        public virtual void OnMove(AxisEventData eventData);
        protected bool IsHighlighted();
        protected bool IsPressed();
        public virtual void OnPointerDown(PointerEventData eventData);
        public virtual void OnPointerUp(PointerEventData eventData);
        public virtual void OnPointerEnter(PointerEventData eventData);
        public virtual void OnPointerExit(PointerEventData eventData);
        public virtual void OnSelect(BaseEventData eventData);
        public virtual void OnDeselect(BaseEventData eventData);
        public virtual void Select();

        public enum Transition
        {
            None = 0,
            ColorTint = 1,
            SpriteSwap = 2,
            Animation = 3
        }
        protected enum SelectionState
        {
            Normal = 0,
            Highlighted = 1,
            Pressed = 2,
            Selected = 3,
            Disabled = 4
        }
    }
}
