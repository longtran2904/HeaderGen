#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
    [MovedFrom("UnityEngine.Experimental.Animations")]
    [NativeHeader("Modules/Animation/Director/AnimationSceneHandles.h")]
    [NativeHeader("Modules/Animation/ScriptBindings/AnimationStreamHandles.bindings.h")]
    public struct TransformSceneHandle
    {

        public bool IsValid(AnimationStream stream);
        public Vector3 GetPosition(AnimationStream stream);
        [Obsolete("SceneHandle is now read-only; it was problematic with the engine multithreading and determinism", True)]
        public void SetPosition(AnimationStream stream, Vector3 position);
        public Vector3 GetLocalPosition(AnimationStream stream);
        [Obsolete("SceneHandle is now read-only; it was problematic with the engine multithreading and determinism", True)]
        public void SetLocalPosition(AnimationStream stream, Vector3 position);
        public Quaternion GetRotation(AnimationStream stream);
        [Obsolete("SceneHandle is now read-only; it was problematic with the engine multithreading and determinism", True)]
        public void SetRotation(AnimationStream stream, Quaternion rotation);
        public Quaternion GetLocalRotation(AnimationStream stream);
        [Obsolete("SceneHandle is now read-only; it was problematic with the engine multithreading and determinism", True)]
        public void SetLocalRotation(AnimationStream stream, Quaternion rotation);
        public Vector3 GetLocalScale(AnimationStream stream);
        public void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale);
        public void GetGlobalTR(AnimationStream stream, out Vector3 position, out Quaternion rotation);
        [Obsolete("SceneHandle is now read-only; it was problematic with the engine multithreading and determinism", True)]
        public void SetLocalScale(AnimationStream stream, Vector3 scale);
    }
}
