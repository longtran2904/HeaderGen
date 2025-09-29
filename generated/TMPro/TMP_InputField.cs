#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace TMPro
{
    [AddComponentMenu("UI/TextMeshPro - Input Field", 11)]
    public class TMP_InputField : Selectable, IBeginDragHandler, ICanvasElement, IDragHandler, IEndDragHandler, ILayoutElement, IPointerClickHandler, IScrollHandler, ISubmitHandler, IUpdateSelectedHandler
    {
        protected TouchScreenKeyboard m_SoftKeyboard;
        protected RectTransform m_RectTransform;
        [SerializeField]
        protected RectTransform m_TextViewport;
        protected RectMask2D m_TextComponentRectMask;
        protected RectMask2D m_TextViewportRectMask;
        [SerializeField]
        protected TMP_Text m_TextComponent;
        protected RectTransform m_TextComponentRectTransform;
        [SerializeField]
        protected Graphic m_Placeholder;
        [SerializeField]
        protected Scrollbar m_VerticalScrollbar;
        [SerializeField]
        protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler;
        [SerializeField]
        protected float m_ScrollSensitivity;
        [SerializeField]
        [TextArea(5, 10)]
        protected string m_Text;
        protected int m_StringPosition;
        protected int m_StringSelectPosition;
        protected int m_CaretPosition;
        protected int m_CaretSelectPosition;
        protected UIVertex[] m_CursorVerts;
        [NonSerialized]
        protected Mesh m_Mesh;
        protected bool m_CaretVisible;
        [SerializeField]
        protected TMP_FontAsset m_GlobalFontAsset;
        [SerializeField]
        protected bool m_OnFocusSelectAll;
        protected bool m_isSelectAll;
        [SerializeField]
        protected bool m_ResetOnDeActivation;
        [SerializeField]
        protected bool m_isRichTextEditingAllowed;
        [SerializeField]
        protected int m_LineLimit;
        [SerializeField]
        protected TMP_InputValidator m_InputValidator;

        protected TMP_InputField();

        protected Mesh mesh { get; }
        public bool shouldHideMobileInput { get; set; }
        public bool shouldHideSoftKeyboard { get; set; }
        public string text { get; set; }
        public bool isFocused { get; }
        public float caretBlinkRate { get; set; }
        public int caretWidth { get; set; }
        public RectTransform textViewport { get; set; }
        public TMP_Text textComponent { get; set; }
        public Graphic placeholder { get; set; }
        public Scrollbar verticalScrollbar { get; set; }
        public float scrollSensitivity { get; set; }
        public Color caretColor { get; set; }
        public bool customCaretColor { get; set; }
        public Color selectionColor { get; set; }
        public SubmitEvent onEndEdit { get; set; }
        public SubmitEvent onSubmit { get; set; }
        public SelectionEvent onSelect { get; set; }
        public SelectionEvent onDeselect { get; set; }
        public TextSelectionEvent onTextSelection { get; set; }
        public TextSelectionEvent onEndTextSelection { get; set; }
        public OnChangeEvent onValueChanged { get; set; }
        public TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged { get; set; }
        public OnValidateInput onValidateInput { get; set; }
        public int characterLimit { get; set; }
        public float pointSize { get; set; }
        public TMP_FontAsset fontAsset { get; set; }
        public bool onFocusSelectAll { get; set; }
        public bool resetOnDeActivation { get; set; }
        public bool restoreOriginalTextOnEscape { get; set; }
        public bool isRichTextEditingAllowed { get; set; }
        public ContentType contentType { get; set; }
        public LineType lineType { get; set; }
        public int lineLimit { get; set; }
        public InputType inputType { get; set; }
        public TouchScreenKeyboardType keyboardType { get; set; }
        public CharacterValidation characterValidation { get; set; }
        public TMP_InputValidator inputValidator { get; set; }
        public bool readOnly { get; set; }
        public bool richText { get; set; }
        public bool multiLine { get; }
        public char asteriskChar { get; set; }
        public bool wasCanceled { get; }
        protected int caretPositionInternal { get; set; }
        protected int stringPositionInternal { get; set; }
        protected int caretSelectPositionInternal { get; set; }
        protected int stringSelectPositionInternal { get; set; }
        public int caretPosition { get; set; }
        public int selectionAnchorPosition { get; set; }
        public int selectionFocusPosition { get; set; }
        public int stringPosition { get; set; }
        public int selectionStringAnchorPosition { get; set; }
        public int selectionStringFocusPosition { get; set; }
        public virtual float minWidth { get; }
        public virtual float preferredWidth { get; }
        public virtual float flexibleWidth { get; }
        public virtual float minHeight { get; }
        public virtual float preferredHeight { get; }
        public virtual float flexibleHeight { get; }
        public virtual int layoutPriority { get; }

        public void SetTextWithoutNotify(string input);
        protected void ClampStringPos(ref int pos);
        protected void ClampCaretPos(ref int pos);
        protected override void OnValidate();
        protected override void OnEnable();
        protected override void OnDisable();
        protected void OnFocus();
        protected void SelectAll();
        public void MoveTextEnd(bool shift);
        public void MoveTextStart(bool shift);
        public void MoveToEndOfLine(bool shift, bool ctrl);
        public void MoveToStartOfLine(bool shift, bool ctrl);
        protected virtual void LateUpdate();
        public virtual void OnBeginDrag(PointerEventData eventData);
        public virtual void OnDrag(PointerEventData eventData);
        public virtual void OnEndDrag(PointerEventData eventData);
        public override void OnPointerDown(PointerEventData eventData);
        protected EditState KeyPressed(Event evt);
        protected virtual bool IsValidChar(char c);
        public void ProcessEvent(Event e);
        public virtual void OnUpdateSelected(BaseEventData eventData);
        public virtual void OnScroll(PointerEventData eventData);
        protected virtual void Append(string input);
        protected virtual void Append(char input);
        protected void SendOnEndEdit();
        protected void SendOnSubmit();
        protected void SendOnFocus();
        protected void SendOnFocusLost();
        protected void SendOnTextSelection();
        protected void SendOnEndTextSelection();
        protected void SendTouchScreenKeyboardStatusChanged();
        protected void UpdateLabel();
        public void ForceLabelUpdate();
        public virtual void Rebuild(CanvasUpdate update);
        public virtual void LayoutComplete();
        public virtual void GraphicUpdateComplete();
        protected char Validate(string text, int pos, char ch);
        public void ActivateInputField();
        public override void OnSelect(BaseEventData eventData);
        public virtual void OnPointerClick(PointerEventData eventData);
        public void OnControlClick();
        public void ReleaseSelection();
        public void DeactivateInputField(bool clearSelection = False);
        public override void OnDeselect(BaseEventData eventData);
        public virtual void OnSubmit(BaseEventData eventData);
        protected override void DoStateTransition(SelectionState state, bool instant);
        public virtual void CalculateLayoutInputHorizontal();
        public virtual void CalculateLayoutInputVertical();
        public void SetGlobalPointSize(float pointSize);
        public void SetGlobalFontAsset(TMP_FontAsset fontAsset);

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
            Digit = 1,
            Integer = 2,
            Decimal = 3,
            Alphanumeric = 4,
            Name = 5,
            Regex = 6,
            EmailAddress = 7,
            CustomValidator = 8
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
        public class OnChangeEvent : UnityEvent<string>
        {
            public OnChangeEvent();
        }
        public class SelectionEvent : UnityEvent<string>
        {
            public SelectionEvent();
        }
        public class TextSelectionEvent : UnityEvent<string, int, int>
        {
            public TextSelectionEvent();
        }
        public class TouchScreenKeyboardEvent : UnityEvent<TouchScreenKeyboard.Status>
        {
            public TouchScreenKeyboardEvent();
        }
        protected enum EditState
        {
            Continue = 0,
            Finish = 1
        }
    }
}
