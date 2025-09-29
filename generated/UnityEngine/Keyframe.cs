#region UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [RequiredByNativeCode]
    public struct Keyframe
    {

        public Keyframe(float time, float value);
        public Keyframe(float time, float value, float inTangent, float outTangent);
        public Keyframe(float time, float value, float inTangent, float outTangent, float inWeight, float outWeight);

        public float time { get; set; }
        public float value { get; set; }
        public float inTangent { get; set; }
        public float outTangent { get; set; }
        public float inWeight { get; set; }
        public float outWeight { get; set; }
        public WeightedMode weightedMode { get; set; }
        [Obsolete("Use AnimationUtility.SetKeyLeftTangentMode, AnimationUtility.SetKeyRightTangentMode, AnimationUtility.GetKeyLeftTangentMode or AnimationUtility.GetKeyRightTangentMode instead.")]
        public int tangentMode { get; set; }
    }
}
