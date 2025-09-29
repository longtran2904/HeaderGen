#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public abstract class BaseSlider<TValueType> : BaseField<TValueType> where TValueType : IComparable<TValueType>
    {
        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;
        public static readonly string horizontalVariantUssClassName;
        public static readonly string verticalVariantUssClassName;
        public static readonly string dragContainerUssClassName;
        public static readonly string trackerUssClassName;
        public static readonly string draggerUssClassName;
        public static readonly string draggerBorderUssClassName;
        public static readonly string textFieldClassName;

        public TValueType lowValue { get; set; }
        public TValueType highValue { get; set; }
        public TValueType range { get; }
        public virtual float pageSize { get; set; }
        public virtual bool showInputField { get; set; }
        public override TValueType value { get; set; }
        public SliderDirection direction { get; set; }
        public bool inverted { get; set; }

        public override void SetValueWithoutNotify(TValueType newValue);
        protected static float GetClosestPowerOfTen(float positiveNumber);
        protected static float RoundToMultipleOf(float value, float roundingValue);
        public void AdjustDragElement(float factor);
        protected override void ExecuteDefaultAction(EventBase evt);
        protected override void UpdateMixedValueContent();
    }
}
