#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public abstract class TextInputBaseField<TValueType> : BaseField<TValueType>
    {
        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;
        public static readonly string singleLineInputUssClassName;
        public static readonly string multilineInputUssClassName;
        public static readonly string textInputUssName;

        protected TextInputBaseField(int maxLength, char maskChar, TextInputBase textInputBase);
        protected TextInputBaseField(string label, int maxLength, char maskChar, TextInputBase textInputBase);

        protected internal TextInputBase textInputBase { get; }
        public string text { get; protected set; }
        public bool isReadOnly { get; set; }
        public bool isPasswordField { get; set; }
        public Color selectionColor { get; }
        public Color cursorColor { get; }
        public int cursorIndex { get; }
        public int selectIndex { get; }
        public int maxLength { get; set; }
        public bool doubleClickSelectsWord { get; set; }
        public bool tripleClickSelectsLine { get; set; }
        public bool isDelayed { get; set; }
        public char maskChar { get; set; }

        protected event Action<bool> onIsReadOnlyChanged;

        public Vector2 MeasureTextSize(string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode);
        protected virtual string ValueToString(TValueType value);
        protected virtual TValueType StringToValue(string str);
        public void SelectAll();
        protected override void ExecuteDefaultActionAtTarget(EventBase evt);
        protected override void UpdateMixedValueContent();

        public class UxmlTraits : BaseFieldTraits<string, UxmlStringAttributeDescription>
        {
            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
        protected internal abstract class TextInputBase : VisualElement, ITextElement, ITextInputField
        {
            public int cursorIndex { get; }
            public int selectIndex { get; }
            public bool isReadOnly { get; set; }
            public int maxLength { get; set; }
            public char maskChar { get; set; }
            public virtual bool isPasswordField { get; set; }
            public bool doubleClickSelectsWord { get; set; }
            public bool tripleClickSelectsLine { get; set; }
            public Color selectionColor { get; }
            public Color cursorColor { get; }
            public string text { get; set; }

            public void ResetValueAndText();
            public void SelectAll();
            protected virtual TValueType StringToValue(string str);
            protected virtual void BuildContextualMenu(ContextualMenuPopulateEvent evt);
            protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode);
            protected override void ExecuteDefaultActionAtTarget(EventBase evt);
            protected override void ExecuteDefaultAction(EventBase evt);
        }
    }
}
