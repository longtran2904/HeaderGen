#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public abstract class ImmediateModeElement : VisualElement
    {
        public ImmediateModeElement();

        public bool cullingEnabled { get; set; }

        protected abstract void ImmediateRepaint();
    }
}
