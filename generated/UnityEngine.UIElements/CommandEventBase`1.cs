#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public abstract class CommandEventBase<T> : EventBase<T>, ICommandEvent where T : CommandEventBase<T>, new()
    {
        protected CommandEventBase();

        public string commandName { get; protected set; }

        protected override void Init();
        public static T GetPooled(Event systemEvent);
        public static T GetPooled(string commandName);
    }
}
