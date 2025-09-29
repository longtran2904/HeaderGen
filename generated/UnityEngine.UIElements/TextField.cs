#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class TextField : TextInputBaseField<string>
    {

        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;

        public TextField();
        public TextField(int maxLength, bool multiline, bool isPasswordField, char maskChar);
        public TextField(string label);
        public TextField(string label, int maxLength, bool multiline, bool isPasswordField, char maskChar);

        public bool multiline { get; set; }
        public override string value { get; set; }

        public void SelectRange(int rangeCursorIndex, int selectionIndex);
        public override void SetValueWithoutNotify(string newValue);
        protected override string ValueToString(string value);
        protected override string StringToValue(string str);
        public class UxmlFactory : UxmlFactory<TextField, UxmlTraits>
        {

            public UxmlFactory();
        }
        public class UxmlTraits : TextInputBaseField<string>.UxmlTraits
        {

            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
