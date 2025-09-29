#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
    [MovedFrom("UnityEngine.Experimental.Animations")]
    [NativeHeader("Modules/Animation/Director/AnimationStream.h")]
    [NativeHeader("Modules/Animation/ScriptBindings/AnimationStream.bindings.h")]
    [RequiredByNativeCode]
    public struct AnimationStream
    {

        public bool isValid { get; }
        public float deltaTime { get; }
        public Vector3 velocity { get; set; }
        public Vector3 angularVelocity { get; set; }
        public Vector3 rootMotionPosition { get; }
        public Quaternion rootMotionRotation { get; }
        public bool isHumanStream { get; }
        public int inputStreamCount { get; }

        public AnimationHumanStream AsHuman();
        public AnimationStream GetInputStream(int index);
        public float GetInputWeight(int index);
        public void CopyAnimationStreamMotion(AnimationStream animationStream);
    }
}
