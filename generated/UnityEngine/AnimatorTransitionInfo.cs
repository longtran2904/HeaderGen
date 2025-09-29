#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [NativeHeader("Modules/Animation/AnimatorInfo.h")]
    [RequiredByNativeCode]
    public struct AnimatorTransitionInfo
    {

        public int fullPathHash { get; }
        public int nameHash { get; }
        public int userNameHash { get; }
        public DurationUnit durationUnit { get; }
        public float duration { get; }
        public float normalizedTime { get; }
        public bool anyState { get; }

        public bool IsName(string name);
        public bool IsUserName(string name);
    }
}
