#region UnityEditor.UIServiceModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIServiceModule.dll
#endregion

using System;
using UnityEditor.UIElements;
using UnityEngine;

namespace UnityEditor.Toolbars
{
    public class EditorToolbarButton : ToolbarButton
    {
        public EditorToolbarButton();
        public EditorToolbarButton(Action clickEvent);
        public EditorToolbarButton(string text, Action clickEvent);
        public EditorToolbarButton(Texture2D icon, Action clickEvent);
        public EditorToolbarButton(string text, Texture2D icon, Action clickEvent);

        public string text { get; set; }
        public Texture2D icon { get; set; }
    }
}
