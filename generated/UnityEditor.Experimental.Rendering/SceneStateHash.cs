#region UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEditor.CoreModule.dll
#endregion

using System;
using UnityEngine;
using UnityEngine.Scripting;

namespace UnityEditor.Experimental.Rendering
{
    [RequiredByNativeCode]
    public struct SceneStateHash : IEquatable<SceneStateHash>
    {

        public SceneStateHash(Hash128 sceneObjectsHash, Hash128 skySettingsHash, Hash128 ambientProbeHash);

        public Hash128 sceneObjectsHash { get; }
        public Hash128 skySettingsHash { get; }
        public Hash128 ambientProbeHash { get; }

        public bool Equals(SceneStateHash other);
        public override bool Equals(object obj);
        public override int GetHashCode();
    }
}
