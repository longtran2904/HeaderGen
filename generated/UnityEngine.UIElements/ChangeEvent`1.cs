#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class ChangeEvent<T> : EventBase<ChangeEvent<T>>, IChangeEvent
    {
        public ChangeEvent();

        public T previousValue { get; protected set; }
        public T newValue { get; protected set; }

        protected override void Init();
        public static ChangeEvent<T> GetPooled(T previousValue, T newValue);
    }
}
