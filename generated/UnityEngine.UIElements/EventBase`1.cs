#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public abstract class EventBase<T> : EventBase where T : EventBase<T>, new()
    {

        protected EventBase();

        public override long eventTypeId { get; }

        public static long TypeId();
        protected override void Init();
        public static T GetPooled();
        public sealed override void Dispose();
    }
}
