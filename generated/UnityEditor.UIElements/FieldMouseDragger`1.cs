#region UnityEditor.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.UIElementsModule.dll
#endregion

using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    public class FieldMouseDragger<T> : BaseFieldMouseDragger
    {
        public FieldMouseDragger(IValueField<T> drivenField);

        public bool dragging { get; set; }
        public T startValue { get; set; }

        public sealed override void SetDragZone(VisualElement dragElement, Rect hotZone);
    }
}
