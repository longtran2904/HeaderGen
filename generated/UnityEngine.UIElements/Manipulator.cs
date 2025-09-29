#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public abstract class Manipulator : IManipulator
    {
        protected Manipulator();

        public VisualElement target { get; set; }

        protected abstract void RegisterCallbacksOnTarget();
        protected abstract void UnregisterCallbacksFromTarget();
    }
}
