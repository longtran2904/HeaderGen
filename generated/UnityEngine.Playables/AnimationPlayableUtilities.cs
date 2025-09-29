#region UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll
#endregion

using UnityEngine.Animations;

namespace UnityEngine.Playables
{
    public static class AnimationPlayableUtilities
    {

        public static void Play(Animator animator, Playable playable, PlayableGraph graph);
        public static AnimationClipPlayable PlayClip(Animator animator, AnimationClip clip, out PlayableGraph graph);
        public static AnimationMixerPlayable PlayMixer(Animator animator, int inputCount, out PlayableGraph graph);
        public static AnimationLayerMixerPlayable PlayLayerMixer(Animator animator, int inputCount, out PlayableGraph graph);
        public static AnimatorControllerPlayable PlayAnimatorController(Animator animator, RuntimeAnimatorController controller, out PlayableGraph graph);
    }
}
