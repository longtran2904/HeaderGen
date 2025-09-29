#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    public enum JointProjectionMode
    {
        None = 0,
        PositionAndRotation = 1,
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("JointProjectionMode.PositionOnly is no longer supported", True)]
        PositionOnly = 2
    }
}
