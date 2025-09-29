#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using System;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class LayerField : PopupField<int>
    {

        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;

        public LayerField(string label);
        public LayerField();
        public LayerField(int defaultValue);
        public LayerField(string label, int defaultValue);

        public override int value { get; set; }
        public override Func<int, string> formatSelectedValueCallback { get; set; }
        public override Func<int, string> formatListItemCallback { get; set; }

        public override void SetValueWithoutNotify(int newValue);
        public class UxmlFactory : UxmlFactory<LayerField, UxmlTraits>
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
