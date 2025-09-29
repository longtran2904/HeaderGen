#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
    [MovedFrom("UnityEngine.Experimental.Animations")]
    [NativeHeader("Modules/Animation/ScriptBindings/AnimationStreamHandles.bindings.h")]
    [NativeHeader("Modules/Animation/Director/AnimationStreamHandles.h")]
    public struct TransformStreamHandle
    {

        public bool IsValid(AnimationStream stream);
        public void Resolve(AnimationStream stream);
        public bool IsResolved(AnimationStream stream);
        public Vector3 GetPosition(AnimationStream stream);
        public void SetPosition(AnimationStream stream, Vector3 position);
        public Quaternion GetRotation(AnimationStream stream);
        public void SetRotation(AnimationStream stream, Quaternion rotation);
        public Vector3 GetLocalPosition(AnimationStream stream);
        public void SetLocalPosition(AnimationStream stream, Vector3 position);
        public Quaternion GetLocalRotation(AnimationStream stream);
        public void SetLocalRotation(AnimationStream stream, Quaternion rotation);
        public Vector3 GetLocalScale(AnimationStream stream);
        public void SetLocalScale(AnimationStream stream, Vector3 scale);
        public bool GetPositionReadMask(AnimationStream stream);
        public bool GetRotationReadMask(AnimationStream stream);
        public bool GetScaleReadMask(AnimationStream stream);
        public void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale);
        public void SetLocalTRS(AnimationStream stream, Vector3 position, Quaternion rotation, Vector3 scale, bool useMask);
        public void GetGlobalTR(AnimationStream stream, out Vector3 position, out Quaternion rotation);
        public void SetGlobalTR(AnimationStream stream, Vector3 position, Quaternion rotation, bool useMask);
    }
}
