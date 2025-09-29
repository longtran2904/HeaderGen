#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using System.Reflection;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [DefaultMember("Item")]
    [NativeHeader("Runtime/Math/AnimationCurve.bindings.h")]
    [RequiredByNativeCode]
    public class AnimationCurve : IEquatable<AnimationCurve>
    {
        public AnimationCurve(params Keyframe[] keys);
        [RequiredByNativeCode]
        public AnimationCurve();

        ~AnimationCurve();

        public Keyframe this[int index] { get; }
        public Keyframe[] keys { get; set; }
        public int length { get; }
        public WrapMode preWrapMode { get; set; }
        public WrapMode postWrapMode { get; set; }

        [ThreadSafe]
        public float Evaluate(float time);
        [FreeFunction("AnimationCurveBindings::AddKeySmoothTangents", IsThreadSafe = True, HasExplicitThis = True)]
        public int AddKey(float time, float value);
        public int AddKey(Keyframe key);
        [FreeFunction("AnimationCurveBindings::MoveKey", IsThreadSafe = True, HasExplicitThis = True)]
        [NativeThrows]
        public int MoveKey(int index, Keyframe key);
        [FreeFunction("AnimationCurveBindings::RemoveKey", IsThreadSafe = True, HasExplicitThis = True)]
        [NativeThrows]
        public void RemoveKey(int index);
        [FreeFunction("AnimationCurveBindings::SmoothTangents", IsThreadSafe = True, HasExplicitThis = True)]
        [NativeThrows]
        public void SmoothTangents(int index, float weight);
        public static AnimationCurve Constant(float timeStart, float timeEnd, float value);
        public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd);
        public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd);
        public override bool Equals(object o);
        public bool Equals(AnimationCurve other);
        public override int GetHashCode();
    }
}
