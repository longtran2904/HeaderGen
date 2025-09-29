#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    public struct SoftJointLimit
    {
        public float limit { get; set; }
        public float bounciness { get; set; }
        public float contactDistance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Spring has been moved to SoftJointLimitSpring class in Unity 5", True)]
        public float spring { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Damper has been moved to SoftJointLimitSpring class in Unity 5", True)]
        public float damper { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use SoftJointLimit.bounciness instead", True)]
        public float bouncyness { get; set; }
    }
}
