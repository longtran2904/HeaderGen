#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class BoundsField : BaseField<Bounds>
    {
        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;
        public static readonly string centerFieldUssClassName;
        public static readonly string extentsFieldUssClassName;

        public BoundsField();
        public BoundsField(string label);

        public override void SetValueWithoutNotify(Bounds newValue);
        protected override void UpdateMixedValueContent();

        public class UxmlFactory : UxmlFactory<BoundsField, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : BaseField<Bounds>.UxmlTraits
        {
            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
