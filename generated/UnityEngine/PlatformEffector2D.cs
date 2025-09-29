#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/PlatformEffector2D.h")]
    public class PlatformEffector2D : Effector2D
    {

        public PlatformEffector2D();

        public bool useOneWay { get; set; }
        public bool useOneWayGrouping { get; set; }
        public bool useSideFriction { get; set; }
        public bool useSideBounce { get; set; }
        public float surfaceArc { get; set; }
        public float sideArc { get; set; }
        public float rotationalOffset { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("PlatformEffector2D.oneWay has been deprecated. Use PlatformEffector2D.useOneWay instead (UnityUpgradable) -> useOneWay", True)]
        public bool oneWay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("PlatformEffector2D.sideFriction has been deprecated. Use PlatformEffector2D.useSideFriction instead (UnityUpgradable) -> useSideFriction", True)]
        public bool sideFriction { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("PlatformEffector2D.sideBounce has been deprecated. Use PlatformEffector2D.useSideBounce instead (UnityUpgradable) -> useSideBounce", True)]
        public bool sideBounce { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("PlatformEffector2D.sideAngleVariance has been deprecated. Use PlatformEffector2D.sideArc instead (UnityUpgradable) -> sideArc", True)]
        public float sideAngleVariance { get; set; }
    }
}
