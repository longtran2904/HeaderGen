#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class BoundsIntField : BaseField<BoundsInt>
    {
        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;
        public static readonly string positionUssClassName;
        public static readonly string sizeUssClassName;

        public BoundsIntField();
        public BoundsIntField(string label);

        public override void SetValueWithoutNotify(BoundsInt newValue);
        protected override void UpdateMixedValueContent();

        public class UxmlFactory : UxmlFactory<BoundsIntField, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : BaseField<BoundsInt>.UxmlTraits
        {
            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
