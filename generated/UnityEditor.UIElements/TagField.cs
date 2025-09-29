#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using System;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class TagField : PopupField<string>
    {
        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;

        public TagField();
        public TagField(string label, string defaultValue = null);

        public override string value { get; set; }
        public override Func<string, string> formatSelectedValueCallback { get; set; }
        public override Func<string, string> formatListItemCallback { get; set; }

        public override void SetValueWithoutNotify(string newValue);

        public class UxmlFactory : UxmlFactory<TagField, UxmlTraits>
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
