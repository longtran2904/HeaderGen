#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class InspectorElement : BindableElement
    {
        public static readonly string ussClassName;
        public static readonly string customInspectorUssClassName;
        public static readonly string iMGUIContainerUssClassName;
        public static readonly string iMGUIInspectorVariantUssClassName;
        public static readonly string uIEInspectorVariantUssClassName;
        public static readonly string noInspectorFoundVariantUssClassName;
        public static readonly string uIECustomVariantUssClassName;
        public static readonly string iMGUICustomVariantUssClassName;
        public static readonly string iMGUIDefaultVariantUssClassName;
        public static readonly string uIEDefaultVariantUssClassName;
        public static readonly string debugVariantUssClassName;
        public static readonly string debugInternalVariantUssClassName;

        public InspectorElement();
        public InspectorElement(UnityEngine.Object obj);
        public InspectorElement(SerializedObject obj);
        public InspectorElement(Editor editor);

        protected override void ExecuteDefaultActionAtTarget(EventBase evt);
        public static void FillDefaultInspector(VisualElement container, SerializedObject serializedObject, Editor editor);

        public class UxmlFactory : UxmlFactory<InspectorElement, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : BindableElement.UxmlTraits
        {
            public UxmlTraits();
        }
    }
}
