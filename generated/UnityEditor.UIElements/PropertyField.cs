#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class PropertyField : VisualElement, IBindable
    {
        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;

        public PropertyField();
        public PropertyField(SerializedProperty property);
        public PropertyField(SerializedProperty property, string label);

        public IBinding binding { get; set; }
        public string bindingPath { get; set; }
        public string label { get; set; }

        protected override void ExecuteDefaultActionAtTarget(EventBase evt);
        public void RegisterValueChangeCallback(EventCallback<SerializedPropertyChangeEvent> callback);

        public class UxmlFactory : UxmlFactory<PropertyField, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : VisualElement.UxmlTraits
        {
            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
