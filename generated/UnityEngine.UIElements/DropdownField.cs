#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public class DropdownField : BaseField<string>
    {
        public DropdownField();
        public DropdownField(string label);
        public DropdownField(List<string> choices, string defaultValue, Func<string, string> formatSelectedValueCallback = null, Func<string, string> formatListItemCallback = null);
        public DropdownField(string label, List<string> choices, string defaultValue, Func<string, string> formatSelectedValueCallback = null, Func<string, string> formatListItemCallback = null);
        public DropdownField(List<string> choices, int defaultIndex, Func<string, string> formatSelectedValueCallback = null, Func<string, string> formatListItemCallback = null);
        public DropdownField(string label, List<string> choices, int defaultIndex, Func<string, string> formatSelectedValueCallback = null, Func<string, string> formatListItemCallback = null);

        protected TextElement textElement { get; }
        public string text { get; }
        public int index { get; set; }
        public virtual List<string> choices { get; set; }
        public override string value { get; set; }

        public override void SetValueWithoutNotify(string newValue);
        protected override void ExecuteDefaultActionAtTarget(EventBase evt);
        protected override void UpdateMixedValueContent();

        public class UxmlFactory : UxmlFactory<DropdownField, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : BaseField<string>.UxmlTraits
        {
            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
