#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Animation/ScriptBindings/AnimationClip.bindings.h")]
    [NativeType("Modules/Animation/AnimationClip.h")]
    public sealed class AnimationClip : Motion
    {
        public AnimationClip();

        [NativeProperty("Length", False, TargetType.Function)]
        public float length { get; }
        [NativeProperty("SampleRate", False, TargetType.Function)]
        public float frameRate { get; set; }
        [NativeProperty("WrapMode", False, TargetType.Function)]
        public WrapMode wrapMode { get; set; }
        [NativeProperty("Bounds", False, TargetType.Function)]
        public Bounds localBounds { get; set; }
        public bool legacy { get; set; }
        public bool humanMotion { get; }
        public bool empty { get; }
        public bool hasGenericRootTransform { get; }
        public bool hasMotionFloatCurves { get; }
        public bool hasMotionCurves { get; }
        public bool hasRootCurves { get; }
        public AnimationEvent[] events { get; set; }

        public void SampleAnimation(GameObject go, float time);
        [FreeFunction("AnimationClipBindings::Internal_SetCurve", HasExplicitThis = True)]
        public void SetCurve([NotNull("ArgumentNullException")] string relativePath, [NotNull("ArgumentNullException")] Type type, [NotNull("ArgumentNullException")] string propertyName, AnimationCurve curve);
        public void EnsureQuaternionContinuity();
        public void ClearCurves();
        public void AddEvent(AnimationEvent evt);
    }
}
