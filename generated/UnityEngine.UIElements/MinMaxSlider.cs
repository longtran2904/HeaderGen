#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class MinMaxSlider : BaseField<Vector2>
    {
        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;
        public static readonly string trackerUssClassName;
        public static readonly string draggerUssClassName;
        public static readonly string minThumbUssClassName;
        public static readonly string maxThumbUssClassName;

        public MinMaxSlider();
        public MinMaxSlider(float minValue, float maxValue, float minLimit, float maxLimit);
        public MinMaxSlider(string label, float minValue = 0, float maxValue = 10, float minLimit = -3.4028235E+38, float maxLimit = 3.4028235E+38);

        public float minValue { get; set; }
        public float maxValue { get; set; }
        public override Vector2 value { get; set; }
        public float range { get; }
        public float lowLimit { get; set; }
        public float highLimit { get; set; }

        public override void SetValueWithoutNotify(Vector2 newValue);
        protected override void ExecuteDefaultAction(EventBase evt);
        protected override void UpdateMixedValueContent();

        public class UxmlFactory : UxmlFactory<MinMaxSlider, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : BaseField<Vector2>.UxmlTraits
        {
            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
