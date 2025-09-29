#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct EventDispatcherGate : IDisposable, IEquatable<EventDispatcherGate>
    {
        public EventDispatcherGate(EventDispatcher d);

        public void Dispose();
        public bool Equals(EventDispatcherGate other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(EventDispatcherGate left, EventDispatcherGate right);
        public static bool operator !=(EventDispatcherGate left, EventDispatcherGate right);
    }
}
