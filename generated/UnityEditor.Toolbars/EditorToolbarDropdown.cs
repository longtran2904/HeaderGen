#region UnityEditor.UIServiceModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIServiceModule.dll
#endregion

using System;
using UnityEngine;

namespace UnityEditor.Toolbars
{
    public class EditorToolbarDropdown : EditorToolbarButton
    {
        public EditorToolbarDropdown();
        public EditorToolbarDropdown(Action clickEvent);
        public EditorToolbarDropdown(string text, Action clickEvent);
        public EditorToolbarDropdown(Texture2D icon, Action clickEvent);
        public EditorToolbarDropdown(string text, Texture2D icon, Action clickEvent);
    }
}
