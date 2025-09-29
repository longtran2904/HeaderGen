#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public class RadioButtonGroup : BaseField<int>, IGroupBox
    {

        public static readonly string ussClassName;

        public RadioButtonGroup();
        public RadioButtonGroup(string label, List<string> radioButtonChoices = null);

        public IEnumerable<string> choices { get; set; }

        public override void SetValueWithoutNotify(int newValue);
        public class UxmlFactory : UxmlFactory<RadioButtonGroup, UxmlTraits>
        {

            public UxmlFactory();
        }
        public class UxmlTraits : BaseFieldTraits<int, UxmlIntAttributeDescription>
        {

            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
