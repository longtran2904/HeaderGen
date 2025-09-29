#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class RadioButton : BaseBoolField, IGroupBoxOption
    {
        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;
        public static readonly string checkmarkBackgroundUssClassName;
        public static readonly string checkmarkUssClassName;
        public static readonly string textUssClassName;

        public RadioButton();
        public RadioButton(string label);

        public override bool value { get; set; }

        protected override void InitLabel();
        protected override void ToggleValue();
        public void SetSelected(bool selected);
        public override void SetValueWithoutNotify(bool newValue);
        protected override void UpdateMixedValueContent();

        public class UxmlFactory : UxmlFactory<RadioButton, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : BaseFieldTraits<bool, UxmlBoolAttributeDescription>
        {
            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
