#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public abstract class BaseField<TValueType> : BindableElement, IMixedValueSupport, INotifyValueChanged<TValueType>, IPrefixLabel
    {
        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;
        public static readonly string noLabelVariantUssClassName;
        public static readonly string labelDraggerVariantUssClassName;
        public static readonly string mixedValueLabelUssClassName;
        public static readonly string alignedFieldUssClassName;
        protected internal static readonly string mixedValueString;
        protected internal static readonly PropertyName serializedPropertyCopyName;

        protected BaseField(string label, VisualElement visualInput);

        protected TValueType rawValue { get; set; }
        public virtual TValueType value { get; set; }
        public Label labelElement { get; }
        public string label { get; set; }
        public bool showMixedValue { get; set; }
        protected Label mixedValueLabel { get; }

        protected virtual void UpdateMixedValueContent();
        public virtual void SetValueWithoutNotify(TValueType newValue);

        public class UxmlTraits : BindableElement.UxmlTraits
        {
            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
