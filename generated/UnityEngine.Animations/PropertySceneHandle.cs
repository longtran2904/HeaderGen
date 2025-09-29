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
    public struct PropertySceneHandle
    {
        public bool IsValid(AnimationStream stream);
        public void Resolve(AnimationStream stream);
        public bool IsResolved(AnimationStream stream);
        public float GetFloat(AnimationStream stream);
        [Obsolete("SceneHandle is now read-only; it was problematic with the engine multithreading and determinism", True)]
        public void SetFloat(AnimationStream stream, float value);
        public int GetInt(AnimationStream stream);
        [Obsolete("SceneHandle is now read-only; it was problematic with the engine multithreading and determinism", True)]
        public void SetInt(AnimationStream stream, int value);
        public bool GetBool(AnimationStream stream);
        [Obsolete("SceneHandle is now read-only; it was problematic with the engine multithreading and determinism", True)]
        public void SetBool(AnimationStream stream, bool value);
    }
}
