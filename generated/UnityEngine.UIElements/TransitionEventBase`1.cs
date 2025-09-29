#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

namespace UnityEngine.UIElements
{
    public abstract class TransitionEventBase<T> : EventBase<T>, ITransitionEvent where T : TransitionEventBase<T>, new()
    {

        protected TransitionEventBase();

        public StylePropertyNameCollection stylePropertyNames { get; }
        public double elapsedTime { get; protected set; }

        protected override void Init();
        public static T GetPooled(StylePropertyName stylePropertyName, double elapsedTime);
        public bool AffectsProperty(StylePropertyName stylePropertyName);
    }
}
