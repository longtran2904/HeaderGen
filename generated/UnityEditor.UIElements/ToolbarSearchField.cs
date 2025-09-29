#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class ToolbarSearchField : SearchFieldBase<TextField, string>
    {
        public static readonly string textUssClassName;
        public static readonly string searchButtonUssClassName;
        public static readonly string cancelButtonUssClassName;
        public static readonly string cancelButtonOffVariantUssClassName;
        public static readonly string popupVariantUssClassName;
        public static readonly string ussClassName;

        public ToolbarSearchField();

        protected Button searchButton { get; }
        public string value { get; set; }

        public override void SetValueWithoutNotify(string newValue);
        protected override void ClearTextField();
        protected override bool FieldIsEmpty(string fieldValue);

        public class UxmlFactory : UxmlFactory<ToolbarSearchField>
        {
            public UxmlFactory();
        }
    }
}
