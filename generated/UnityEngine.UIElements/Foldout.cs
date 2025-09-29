#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class Foldout : BindableElement, INotifyValueChanged<bool>
    {

        public static readonly string ussClassName;
        public static readonly string toggleUssClassName;
        public static readonly string contentUssClassName;
        public static readonly string inputUssClassName;
        public static readonly string checkmarkUssClassName;
        public static readonly string textUssClassName;

        public Foldout();

        public override VisualElement contentContainer { get; }
        public string text { get; set; }
        public bool value { get; set; }

        public void SetValueWithoutNotify(bool newValue);
        public class UxmlFactory : UxmlFactory<Foldout, UxmlTraits>
        {

            public UxmlFactory();
        }
        public class UxmlTraits : BindableElement.UxmlTraits
        {

            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
