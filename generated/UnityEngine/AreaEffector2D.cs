#region UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics2D/AreaEffector2D.h")]
    public class AreaEffector2D : Effector2D
    {

        public AreaEffector2D();

        public float forceAngle { get; set; }
        public bool useGlobalAngle { get; set; }
        public float forceMagnitude { get; set; }
        public float forceVariation { get; set; }
        public float drag { get; set; }
        public float angularDrag { get; set; }
        public EffectorSelection2D forceTarget { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("AreaEffector2D.forceDirection has been deprecated. Use AreaEffector2D.forceAngle instead (UnityUpgradable) -> forceAngle", True)]
        public float forceDirection { get; set; }
    }
}
