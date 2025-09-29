#region UnityEngine.ParticleSystemModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.ParticleSystemModule.dll
#endregion

using System;
using System.ComponentModel;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [RequiredByNativeCode(Optional = True)]
    public struct ParticleCollisionEvent
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("collider property is deprecated. Use colliderComponent instead, which supports Collider and Collider2D components (UnityUpgradable) -> colliderComponent", True)]
        public Component collider { get; }
        public Vector3 intersection { get; }
        public Vector3 normal { get; }
        public Vector3 velocity { get; }
        public Component colliderComponent { get; }
    }
}
