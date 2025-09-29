#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Bindings;

namespace UnityEngine
{
    [NativeHeader("Modules/Animation/HumanDescription.h")]
    [NativeHeader("Modules/Animation/ScriptBindings/AvatarBuilder.bindings.h")]
    public struct HumanDescription
    {
        [NativeName("m_Human")]
        public HumanBone[] human;
        [NativeName("m_Skeleton")]
        public SkeletonBone[] skeleton;

        public float upperArmTwist { get; set; }
        public float lowerArmTwist { get; set; }
        public float upperLegTwist { get; set; }
        public float lowerLegTwist { get; set; }
        public float armStretch { get; set; }
        public float legStretch { get; set; }
        public float feetSpacing { get; set; }
        public bool hasTranslationDoF { get; set; }
    }
}
