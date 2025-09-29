#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using System;

namespace UnityEngine
{
    public struct JointDrive
    {
        public float positionSpring { get; set; }
        public float positionDamper { get; set; }
        public float maximumForce { get; set; }
        [Obsolete("JointDriveMode is obsolete")]
        public JointDriveMode mode { get; set; }
    }
}
