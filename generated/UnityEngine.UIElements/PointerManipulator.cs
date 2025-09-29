#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public abstract class PointerManipulator : MouseManipulator
    {

        protected PointerManipulator();

        protected bool CanStartManipulation(IPointerEvent e);
        protected bool CanStopManipulation(IPointerEvent e);
    }
}
