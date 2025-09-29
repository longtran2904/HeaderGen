#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using System;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class EnumField : BaseField<Enum>
    {
        public static readonly string ussClassName;
        public static readonly string textUssClassName;
        public static readonly string arrowUssClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;

        public EnumField();
        public EnumField(Enum defaultValue);
        public EnumField(string label, Enum defaultValue = null);

        public string text { get; }

        public void Init(Enum defaultValue);
        public void Init(Enum defaultValue, bool includeObsoleteValues);
        public override void SetValueWithoutNotify(Enum newValue);
        protected override void ExecuteDefaultActionAtTarget(EventBase evt);
        protected override void UpdateMixedValueContent();

        public class UxmlFactory : UxmlFactory<EnumField, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : BaseField<Enum>.UxmlTraits
        {
            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
