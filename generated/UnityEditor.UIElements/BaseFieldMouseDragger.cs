#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public abstract class BaseFieldMouseDragger
    {

        protected BaseFieldMouseDragger();

        public void SetDragZone(VisualElement dragElement);
        public abstract void SetDragZone(VisualElement dragElement, Rect hotZone);
    }
}
