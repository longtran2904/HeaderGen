#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public class GenericDropdownMenu : IGenericMenu
    {

        public static readonly string ussClassName;
        public static readonly string itemUssClassName;
        public static readonly string labelUssClassName;
        public static readonly string containerInnerUssClassName;
        public static readonly string containerOuterUssClassName;
        public static readonly string checkmarkUssClassName;
        public static readonly string separatorUssClassName;

        public GenericDropdownMenu();

        public VisualElement contentContainer { get; }

        public void AddItem(string itemName, bool isChecked, Action action);
        public void AddItem(string itemName, bool isChecked, Action<object> action, object data);
        public void AddDisabledItem(string itemName, bool isChecked);
        public void AddSeparator(string path);
        public void DropDown(Rect position, VisualElement targetElement = null, bool anchored = False);
    }
}
