#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public abstract class ContextualMenuManager
    {
        protected ContextualMenuManager();

        public abstract void DisplayMenuIfEventMatches(EventBase evt, IEventHandler eventHandler);
        public void DisplayMenu(EventBase triggerEvent, IEventHandler target);
        protected internal abstract void DoDisplayMenu(DropdownMenu menu, EventBase triggerEvent);
    }
}
