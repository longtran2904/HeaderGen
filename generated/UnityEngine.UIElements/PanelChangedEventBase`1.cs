#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public abstract class PanelChangedEventBase<T> : EventBase<T>, IPanelChangedEvent where T : PanelChangedEventBase<T>, new()
    {

        protected PanelChangedEventBase();

        public IPanel originPanel { get; }
        public IPanel destinationPanel { get; }

        protected override void Init();
        public static T GetPooled(IPanel originPanel, IPanel destinationPanel);
    }
}
