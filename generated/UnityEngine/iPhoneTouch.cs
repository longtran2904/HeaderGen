#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("iPhoneTouch struct is deprecated. Please use Touch instead (UnityUpgradable) -> Touch", True)]
    public struct iPhoneTouch
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("positionDelta property is deprecated. Please use Touch.deltaPosition instead (UnityUpgradable) -> Touch.deltaPosition", True)]
        public Vector2 positionDelta { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("timeDelta property is deprecated. Please use Touch.deltaTime instead (UnityUpgradable) -> Touch.deltaTime", True)]
        public float timeDelta { get; }
        public int fingerId { get; }
        public Vector2 position { get; }
        public Vector2 deltaPosition { get; }
        public float deltaTime { get; }
        public int tapCount { get; }
        public iPhoneTouchPhase phase { get; }
    }
}
