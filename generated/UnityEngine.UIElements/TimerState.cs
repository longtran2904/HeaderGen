#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;

namespace UnityEngine.UIElements
{
    public struct TimerState : IEquatable<TimerState>
    {

        public long start { get; set; }
        public long now { get; set; }
        public long deltaTime { get; }

        public override bool Equals(object obj);
        public bool Equals(TimerState other);
        public override int GetHashCode();

        public static bool operator ==(TimerState state1, TimerState state2);
        public static bool operator !=(TimerState state1, TimerState state2);
    }
}
