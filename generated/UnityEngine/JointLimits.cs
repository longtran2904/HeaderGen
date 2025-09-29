#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
    public struct JointLimits
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("minBounce and maxBounce are replaced by a single JointLimits.bounciness for both limit ends.", True)]
        public float minBounce;
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("minBounce and maxBounce are replaced by a single JointLimits.bounciness for both limit ends.", True)]
        public float maxBounce;

        public float min { get; set; }
        public float max { get; set; }
        public float bounciness { get; set; }
        public float bounceMinVelocity { get; set; }
        public float contactDistance { get; set; }
    }
}
