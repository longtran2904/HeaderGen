#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor
{
    public sealed class GenericMenu
    {
        public GenericMenu();

        public bool allowDuplicateNames { get; set; }

        public void AddItem(GUIContent content, bool on, MenuFunction func);
        public void AddItem(GUIContent content, bool on, MenuFunction2 func, object userData);
        public void AddDisabledItem(GUIContent content);
        public void AddDisabledItem(GUIContent content, bool on);
        public void AddSeparator(string path);
        public int GetItemCount();
        public void ShowAsContext();
        public void DropDown(Rect position);

        public delegate void MenuFunction();
        public delegate void MenuFunction2(object userData);
    }
}
