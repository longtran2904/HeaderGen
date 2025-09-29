#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Physics/PhysicMaterial.h")]
    public class PhysicMaterial : Object
    {

        public PhysicMaterial();
        public PhysicMaterial(string name);

        public float bounciness { get; set; }
        public float dynamicFriction { get; set; }
        public float staticFriction { get; set; }
        public PhysicMaterialCombine frictionCombine { get; set; }
        public PhysicMaterialCombine bounceCombine { get; set; }
        [Obsolete("Use PhysicMaterial.bounciness instead (UnityUpgradable) -> bounciness")]
        public float bouncyness { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Anisotropic friction is no longer supported since Unity 5.0.", True)]
        public Vector3 frictionDirection2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Anisotropic friction is no longer supported since Unity 5.0.", True)]
        public float dynamicFriction2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Anisotropic friction is no longer supported since Unity 5.0.", True)]
        public float staticFriction2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Anisotropic friction is no longer supported since Unity 5.0.", True)]
        public Vector3 frictionDirection { get; set; }
    }
}
