#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public class Toggle : BaseBoolField
    {

        public static readonly string ussClassName;
        public static readonly string labelUssClassName;
        public static readonly string inputUssClassName;
        [Obsolete]
        public static readonly string noTextVariantUssClassName;
        public static readonly string checkmarkUssClassName;
        public static readonly string textUssClassName;

        public Toggle();
        public Toggle(string label);

        protected override void InitLabel();
        public class UxmlFactory : UxmlFactory<Toggle, UxmlTraits>
        {

            public UxmlFactory();
        }
        public class UxmlTraits : BaseFieldTraits<bool, UxmlBoolAttributeDescription>
        {

            public UxmlTraits();

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
        }
    }
}
