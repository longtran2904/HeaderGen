#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public class InputEvent : EventBase<InputEvent>
    {
        public InputEvent();

        public string previousData { get; protected set; }
        public string newData { get; protected set; }

        protected override void Init();
        public static InputEvent GetPooled(string previousData, string newData);
    }
}
