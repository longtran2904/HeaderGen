#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/Animation/AnimatorInfo.h")]
    [RequiredByNativeCode]
    public struct AnimatorStateInfo
    {

        public int fullPathHash { get; }
        [Obsolete("AnimatorStateInfo.nameHash has been deprecated. Use AnimatorStateInfo.fullPathHash instead.")]
        public int nameHash { get; }
        public int shortNameHash { get; }
        public float normalizedTime { get; }
        public float length { get; }
        public float speed { get; }
        public float speedMultiplier { get; }
        public int tagHash { get; }
        public bool loop { get; }

        public bool IsName(string name);
        public bool IsTag(string tag);
    }
}
