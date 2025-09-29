#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine;

namespace UnityEditor
{
    public abstract class PopupWindowContent
    {

        protected PopupWindowContent();

        public EditorWindow editorWindow { get; }

        public abstract void OnGUI(Rect rect);
        public virtual Vector2 GetWindowSize();
        public virtual void OnOpen();
        public virtual void OnClose();
    }
}
