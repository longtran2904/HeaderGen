#region UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Runtime/Interfaces/IRaycast.h")]
    [NativeHeader("PhysicsScriptingClasses.h")]
    [NativeHeader("Modules/Physics/RaycastHit.h")]
    [UsedByNativeCode]
    public struct RaycastHit
    {

        public Collider collider { get; }
        public int colliderInstanceID { get; }
        public Vector3 point { get; set; }
        public Vector3 normal { get; set; }
        public Vector3 barycentricCoordinate { get; set; }
        public float distance { get; set; }
        public int triangleIndex { get; }
        public Vector2 textureCoord { get; }
        public Vector2 textureCoord2 { get; }
        public Transform transform { get; }
        public Rigidbody rigidbody { get; }
        public ArticulationBody articulationBody { get; }
        public Vector2 lightmapCoord { get; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use textureCoord2 instead. (UnityUpgradable) -> textureCoord2")]
        public Vector2 textureCoord1 { get; }
    }
}
