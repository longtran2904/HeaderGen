#region UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.XRModule.dll
#endregion

using System;

namespace UnityEngine.XR
{
    [Flags]
    public enum InputTrackingState
    {
        None = 0,
        Position = 1,
        Rotation = 2,
        Velocity = 4,
        AngularVelocity = 8,
        Acceleration = 16,
        AngularAcceleration = 32,
        All = 63
    }
}
