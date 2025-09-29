#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct ManipulatorActivationFilter : IEquatable<ManipulatorActivationFilter>
    {

        public MouseButton button { get; set; }
        public EventModifiers modifiers { get; set; }
        public int clickCount { get; set; }

        public override bool Equals(object obj);
        public bool Equals(ManipulatorActivationFilter other);
        public override int GetHashCode();
        public bool Matches(IMouseEvent e);
        public bool Matches(IPointerEvent e);

        public static bool operator ==(ManipulatorActivationFilter filter1, ManipulatorActivationFilter filter2);
        public static bool operator !=(ManipulatorActivationFilter filter1, ManipulatorActivationFilter filter2);
    }
}
