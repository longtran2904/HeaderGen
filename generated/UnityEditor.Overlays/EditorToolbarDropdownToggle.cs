#region UnityEditor.UIServiceModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIServiceModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.Overlays
{
    public class EditorToolbarDropdownToggle : BaseField<bool>
    {
        public EditorToolbarDropdownToggle();
        public EditorToolbarDropdownToggle(Action dropdownClickEvent);
        public EditorToolbarDropdownToggle(string text, Action dropdownClickEvent);
        public EditorToolbarDropdownToggle(Texture2D icon, Action dropdownClickEvent);
        public EditorToolbarDropdownToggle(string text, Texture2D icon, Action dropdownClickEvent);

        public Clickable dropdownClickable { get; }
        public Texture2D icon { get; set; }
        public string text { get; set; }

        public event Action dropdownClicked;

        public override void SetValueWithoutNotify(bool newValue);
    }
}
