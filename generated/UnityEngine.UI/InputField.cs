#region UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.UI.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
    [AddComponentMenu("UI/Legacy/Input Field", 103)]
    public class InputField : Selectable, IBeginDragHandler, ICanvasElement, IDragHandler, IEndDragHandler, ILayoutElement, IPointerClickHandler, ISubmitHandler, IUpdateSelectedHandler
    {
        protected TouchScreenKeyboard m_Keyboard;
        [FormerlySerializedAs("text")]
        [SerializeField]
        protected Text m_TextComponent;
        [SerializeField]
        protected Graphic m_Placeholder;
        [FormerlySerializedAs("mValue")]
        [Multiline]
        [SerializeField]
        protected string m_Text;
        protected int m_CaretPosition;
        protected int m_CaretSelectPosition;
        protected UIVertex[] m_CursorVerts;
        [NonSerialized]
        protected Mesh m_Mesh;
        protected bool m_CaretVisible;
        protected int m_DrawStart;
        protected int m_DrawEnd;

        protected InputField();

        protected Mesh mesh { get; }
        protected TextGenerator cachedInputTextGenerator { get; }
        public bool shouldHideMobileInput { get; set; }
        public virtual bool shouldActivateOnSelect { get; set; }
        public string text { get; set; }
        public bool isFocused { get; }
        public float caretBlinkRate { get; set; }
        public int caretWidth { get; set; }
        public Text textComponent { get; set; }
        public Graphic placeholder { get; set; }
        public Color caretColor { get; set; }
        public bool customCaretColor { get; set; }
        public Color selectionColor { get; set; }
        public EndEditEvent onEndEdit { get; set; }
        public SubmitEvent onSubmit { get; set; }
        [Obsolete("onValueChange has been renamed to onValueChanged")]
        public OnChangeEvent onValueChange { get; set; }
        public OnChangeEvent onValueChanged { get; set; }
        public OnValidateInput onValidateInput { get; set; }
        public int characterLimit { get; set; }
        public ContentType contentType { get; set; }
        public LineType lineType { get; set; }
        public InputType inputType { get; set; }
        public TouchScreenKeyboard touchScreenKeyboard { get; }
        public TouchScreenKeyboardType keyboardType { get; set; }
        public CharacterValidation characterValidation { get; set; }
        public bool readOnly { get; set; }
        public bool multiLine { get; }
        public char asteriskChar { get; set; }
        public bool wasCanceled { get; }
        protected int caretPositionInternal { get; set; }
        protected int caretSelectPositionInternal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("caretSelectPosition has been deprecated. Use selectionFocusPosition instead (UnityUpgradable) -> selectionFocusPosition", True)]
        public int caretSelectPosition { get; protected set; }
        public int caretPosition { get; set; }
        public int selectionAnchorPosition { get; set; }
        public int selectionFocusPosition { get; set; }
        public virtual float minWidth { get; }
        public virtual float preferredWidth { get; }
        public virtual float flexibleWidth { get; }
        public virtual float minHeight { get; }
        public virtual float preferredHeight { get; }
        public virtual float flexibleHeight { get; }
        public virtual int layoutPriority { get; }

        public void SetTextWithoutNotify(string input);
        protected void ClampPos(ref int pos);
        protected override void OnValidate();
        protected override void OnEnable();
        protected override void OnDisable();
        protected override void OnDestroy();
        protected void OnFocus();
        protected void SelectAll();
        public void MoveTextEnd(bool shift);
        public void MoveTextStart(bool shift);
        protected virtual void LateUpdate();
        [Obsolete("This function is no longer used. Please use RectTransformUtility.ScreenPointToLocalPointInRectangle() instead.")]
        public Vector2 ScreenToLocal(Vector2 screen);
        protected int GetCharacterIndexFromPosition(Vector2 pos);
        public virtual void OnBeginDrag(PointerEventData eventData);
        public virtual void OnDrag(PointerEventData eventData);
        public virtual void OnEndDrag(PointerEventData eventData);
        public override void OnPointerDown(PointerEventData eventData);
        protected EditState KeyPressed(Event evt);
        public void ProcessEvent(Event e);
        public virtual void OnUpdateSelected(BaseEventData eventData);
        protected void SendOnEndEdit();
        protected void SendOnSubmit();
        protected virtual void Append(string input);
        protected virtual void Append(char input);
        protected void UpdateLabel();
        public void ForceLabelUpdate();
        public virtual void Rebuild(CanvasUpdate update);
        public virtual void LayoutComplete();
        public virtual void GraphicUpdateComplete();
        protected char Validate(string text, int pos, char ch);
        public void ActivateInputField();
        public override void OnSelect(BaseEventData eventData);
        public virtual void OnPointerClick(PointerEventData eventData);
        public void DeactivateInputField();
        public override void OnDeselect(BaseEventData eventData);
        public virtual void OnSubmit(BaseEventData eventData);
        protected override void DoStateTransition(SelectionState state, bool instant);
        public virtual void CalculateLayoutInputHorizontal();
        public virtual void CalculateLayoutInputVertical();

        public enum ContentType
        {
            Standard = 0,
            Autocorrected = 1,
            IntegerNumber = 2,
            DecimalNumber = 3,
            Alphanumeric = 4,
            Name = 5,
            EmailAddress = 6,
            Password = 7,
            Pin = 8,
            Custom = 9
        }
        public enum InputType
        {
            Standard = 0,
            AutoCorrect = 1,
            Password = 2
        }
        public enum CharacterValidation
        {
            None = 0,
            Integer = 1,
            Decimal = 2,
            Alphanumeric = 3,
            Name = 4,
            EmailAddress = 5
        }
        public enum LineType
        {
            SingleLine = 0,
            MultiLineSubmit = 1,
            MultiLineNewline = 2
        }
        public delegate char OnValidateInput(string text, int charIndex, char addedChar);
        public class SubmitEvent : UnityEvent<string>
        {
            public SubmitEvent();
        }
        public class EndEditEvent : UnityEvent<string>
        {
            public EndEditEvent();
        }
        public class OnChangeEvent : UnityEvent<string>
        {
            public OnChangeEvent();
        }
        protected enum EditState
        {
            Continue = 0,
            Finish = 1
        }
    }
}
