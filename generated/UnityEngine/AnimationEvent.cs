#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [RequiredByNativeCode]
    public sealed class AnimationEvent
    {
        public AnimationEvent();

        [Obsolete("Use stringParameter instead")]
        public string data { get; set; }
        public string stringParameter { get; set; }
        public float floatParameter { get; set; }
        public int intParameter { get; set; }
        public Object objectReferenceParameter { get; set; }
        public string functionName { get; set; }
        public float time { get; set; }
        public SendMessageOptions messageOptions { get; set; }
        public bool isFiredByLegacy { get; }
        public bool isFiredByAnimator { get; }
        public AnimationState animationState { get; }
        public AnimatorStateInfo animatorStateInfo { get; }
        public AnimatorClipInfo animatorClipInfo { get; }
    }
}
