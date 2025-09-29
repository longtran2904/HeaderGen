#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public abstract class AbstractProgressBar : BindableElement, INotifyValueChanged<float>
    {

        public static readonly string ussClassName;
        public static readonly string containerUssClassName;
        public static readonly string titleUssClassName;
        public static readonly string titleContainerUssClassName;
        public static readonly string progressUssClassName;
        public static readonly string backgroundUssClassName;

        public AbstractProgressBar();

        public string title { get; set; }
        public float lowValue { get; set; }
        public float highValue { get; set; }
        public virtual float value { get; set; }

        public void SetValueWithoutNotify(float newValue);
        public class UxmlTraits : BindableElement.UxmlTraits
        {

            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
