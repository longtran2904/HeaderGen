#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using UnityEngine.UIElements;

namespace UnityEditor.Overlays
{
    public abstract class IMGUIOverlay : Overlay
    {

        protected IMGUIOverlay();

        public sealed override VisualElement CreatePanelContent();
        public abstract void OnGUI();
    }
}
