#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using System;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class LayerMaskField : MaskField
    {
        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;

        public LayerMaskField(int defaultMask);
        public LayerMaskField(string label, int defaultMask);
        public LayerMaskField();
        public LayerMaskField(string label);

        public override Func<string, string> formatSelectedValueCallback { get; set; }
        public override Func<string, string> formatListItemCallback { get; set; }

        public class UxmlFactory : UxmlFactory<LayerMaskField, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : BaseField<int>.UxmlTraits
        {
            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
