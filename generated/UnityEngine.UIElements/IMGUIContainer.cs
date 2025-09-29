#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public class IMGUIContainer : VisualElement, IDisposable
    {
        public static readonly string ussClassName;

        public IMGUIContainer();
        public IMGUIContainer(Action onGUIHandler);

        public Action onGUIHandler { get; set; }
        public bool cullingEnabled { get; set; }
        public ContextType contextType { get; set; }
        public override bool canGrabFocus { get; }

        public void MarkDirtyLayout();
        public override void HandleEvent(EventBase evt);
        protected override void ExecuteDefaultAction(EventBase evt);
        protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode);
        public void Dispose();
        protected virtual void Dispose(bool disposeManaged);

        public class UxmlFactory : UxmlFactory<IMGUIContainer, UxmlTraits>
        {
            public UxmlFactory();
        }
        public class UxmlTraits : VisualElement.UxmlTraits
        {
            public UxmlTraits();

            public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription { get; }
        }
    }
}
