#region UnityEditor.UIServiceModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIServiceModule.dll
#endregion

using UnityEditor.UIElements;
using UnityEngine;

namespace UnityEditor.Toolbars
{
    public class EditorToolbarToggle : ToolbarToggle
    {

        public const string ussClassName = "unity-editor-toolbar-toggle";

        public EditorToolbarToggle();
        public EditorToolbarToggle(string text);
        public EditorToolbarToggle(Texture2D icon);
        public EditorToolbarToggle(Texture2D onIcon, Texture2D offIcon);
        public EditorToolbarToggle(string text, Texture2D onIcon, Texture2D offIcon);

        public string text { get; set; }
        public Texture2D icon { get; set; }
        public Texture2D onIcon { get; set; }
        public Texture2D offIcon { get; set; }

        public override void SetValueWithoutNotify(bool newValue);
    }
}
