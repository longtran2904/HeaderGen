#region Unity.Timeline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.Timeline.dll
#endregion

using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
    public class ActivationControlPlayable : PlayableBehaviour
    {

        public GameObject gameObject;
        public PostPlaybackState postPlayback;

        public ActivationControlPlayable();

        public static ScriptPlayable<ActivationControlPlayable> Create(PlayableGraph graph, GameObject gameObject, PostPlaybackState postPlaybackState);
        public override void OnBehaviourPlay(Playable playable, FrameData info);
        public override void OnBehaviourPause(Playable playable, FrameData info);
        public override void ProcessFrame(Playable playable, FrameData info, object userData);
        public override void OnGraphStart(Playable playable);
        public override void OnPlayableDestroy(Playable playable);
        public enum PostPlaybackState
        {

            Active = 0,
            Inactive = 1,
            Revert = 2
        }
    }
}
