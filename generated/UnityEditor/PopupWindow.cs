#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor
{
    public class PopupWindow : EditorWindow
    {

        public static void Show(Rect activatorRect, PopupWindowContent windowContent);
        protected virtual void OnEnable();
        protected virtual void OnDisable();
    }
}
